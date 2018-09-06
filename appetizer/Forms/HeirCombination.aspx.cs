using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taxer.Models;

namespace appetizer.Forms
{
    public partial class HeirCombination :CommonPage// System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataBindTreeView();
                
                List<Gender> Data = new Taxer.Models.GenderHandler().GetListAll();
                DataBindCombo(HeirGender, Data, "Title", "GenderID");

                List<Marriage> MariageData = new MarriageHandler().GetListAll();
                DataBindCombo(HeirMarriage, MariageData, "Title", "MarriageID");

                List<PhysicalState> PhysicalStateData = new PhysicalStateHandler().GetListAll();
                DataBindCombo(HeirPhysicalState, PhysicalStateData, "Title", "PhysicalStateID");

                List<EducationState> EducationStateData = new EducationStateHandler().GetListAll();
                DataBindCombo(HeirEducationState, EducationStateData, "Title", "EducationStateID");
            }
        }

        protected void tvControl_SelectedNodeChanged(object sender, EventArgs e)
        {
            if (tvControl.SelectedValue != "0")
            {
                Heir heir = new HeirHandler().GetDetails(Int64.Parse(tvControl.SelectedNode.Value));
                this.HeirName.Text = heir.Name;
                this.HeirFamily.Text = heir.Family;
                this.HeirNationalCode.Text = heir.NationalCode.ToString();
                this.HeirGender.SelectedValue = heir.GenderID.ToString();
                this.HeirRelation.SelectedValue = heir.RelationID.ToString();
                this.HeirPhysicalState.SelectedValue = heir.PhysicalStateID.ToString();
                this.HeirMarriage.SelectedValue = heir.MarriageID.ToString();
                this.HeirEducationState.SelectedValue = heir.EducationStateID.ToString();
            }
        }

        public String GetHeirNodesCaption()
        {
            return "لیست وراث";
        }
        void DataBindTreeView()
        {
            DataSet dataSet = new DataSet();

            dataSet.Tables.Add("Table");
            dataSet.Tables[0].Columns.Add("HeirID", typeof(int));
            dataSet.Tables[0].Columns.Add("ParentHeirID", typeof(int));
            dataSet.Tables[0].Columns.Add("FullName", typeof(string));

            DataRow row = null;
            row = dataSet.Tables[0].NewRow();
            row["HeirID"] = 0;
            row["FullName"] = "متوفی";
            //row["ParentHeirID"] = "0";
            dataSet.Tables[0].Rows.Add(row);
            Declaration declaration = GetCurrentDeclaration();
            List<Heir> heir_list = declaration.GetListHeir();
            foreach (Heir heir in heir_list)
            {
                if (declaration.Stage == heir.Stage)
                {

                    row = dataSet.Tables[0].NewRow();
                    row["HeirID"] = heir.HeirID;
                    row["FullName"] = heir.FullName;
                    dataSet.Tables[0].Rows.Add(row);

                    row["ParentHeirID"] = heir.ParentHeirID;
                }

            }

            tvControl.DataSource = new HierarchicalDataSet(dataSet, "HeirID", "ParentHeirID");
            tvControl.DataBind();
            tvControl.Nodes[0].Select();
        }

        protected void btnAddHeir_Click(object sender, EventArgs e)
        {
            Declaration declaration = GetCurrentDeclaration();

            Int64 nationalCode = Int64.Parse(HeirNationalCode.Text);
            Int32 relationID = Int32.Parse(HeirRelation.SelectedValue);
            String name = HeirName.Text;
            String family = HeirFamily.Text;
            Int32 parentHeirID = tvControl.SelectedValue!=null ? Int32.Parse(tvControl.SelectedValue):0;

            Int32 genderID = Int32.Parse(HeirGender.SelectedValue);
            Int32 physicalStateID = Int32.Parse(HeirPhysicalState.SelectedValue);
            Int32 educationStateID = Int32.Parse(HeirEducationState.SelectedValue);
            Int32 marriageID = Int32.Parse(HeirMarriage.SelectedValue);
            
            Heir heir = new Heir()
            {
                NationalCode = nationalCode,
                Name = name,
                Family = family,
                RelationID = relationID,
                GenderID = genderID,
                ParentHeirID=parentHeirID,

                RegisterInformationID = declaration.RegisterInformationID,
                Stage = declaration.Stage,
                PhysicalStateID = physicalStateID,
                MarriageID=marriageID,
                EducationStateID = educationStateID
                //,
                //AdjustmentIncomeRegisterInformationID = declaration.RegisterInformationID,
                //CommissionAdjustmentIncomeRegisterInformationID = declaration.RegisterInformationID,
                //CommissionAdjustmentTaxRegisterInformationID = declaration.RegisterInformationID,
                //AdjustmentTaxRegisterInformationID = declaration.RegisterInformationID

            };
            declaration.AddHeir(heir);

            DataBindTreeView();
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Relation> Data=new RelationHandler().SearchLike(new Relation(){RelationLevel=Int32.Parse(RadioButtonList1.SelectedValue)});
            DataBindCombo(HeirRelation, Data, "Title", "RelationID");
        }

        protected void btnDeleteHeir_Click(object sender, EventArgs e)
        {
            if (tvControl.SelectedValue != "0" && Int32.Parse(tvControl.SelectedValue) > 0)
            {
                Heir heir = new HeirHandler().GetDetails(Int64.Parse(tvControl.SelectedNode.Value));
                new HeirHandler().Delete(heir.HeirID);
                DataBindTreeView();

            }
        }
    }
}