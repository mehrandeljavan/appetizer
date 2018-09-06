using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taxer.Models;

namespace appetizer.Forms
{
    public partial class SelectCurrentDossier :CommonPage // System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["SelectCurrentDossierNationalCode"] = null;
                Session["SelectCurrentDossierName"] = null;
                Session["SelectCurrentDossierFamily"] = null;

            }

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Int64 dossierID =Int64.Parse(e.CommandArgument.ToString());
            Dossier dossier = new DossierHandler().GetDetails(dossierID);
            Session["CurrentDossier"] = dossier;
            SetCurrentDeclaration(null);
            List<Declaration> declarations = dossier.GetListDeclaration();
            DataBindCombo(DeclarationList, declarations, "StageTitle", "DeclarationID");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Session["SelectCurrentDossierNationalCode"] = null;
            Session["SelectCurrentDossierName"] = null;
            Session["SelectCurrentDossierFamily"] = null;
            if (String.IsNullOrEmpty(txtNationalCode.Text))
            {
                if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtFamily.Text))
                {
                    ShowMessage("خطا", "لطفا کد ملی یا نام و نام خانوادگی را وارد کنید");
                }
                else
                {
                    Session["SelectCurrentDossierName"] = txtName.Text;
                    Session["SelectCurrentDossierFamily"] = txtFamily.Text;
                }
            }
            else
            {
                try
                {
                    Int64 nationalCode = Int64.Parse(txtNationalCode.Text);
                    Session["SelectCurrentDossierNationalCode"] = nationalCode;
                }
                catch (Exception ex)
                {

                    ShowMessage("Error", "<span style=\"background-color:red;\">" + ex.Message + "</span>");
                }

            }
            ObjectDataSource1.DataBind();            
            GridView1.DataBind();
        }

        public List<Dead> SearchDossier()
        {
            List<Dead> deads = new List<Dead>();
            if (Session["SelectCurrentDossierNationalCode"] == null)
            {
                if (Session["SelectCurrentDossierName"] != null || Session["SelectCurrentDossierFamily"] != null)
                {
                    String name = Session["SelectCurrentDossierName"].ToString();
                    String family = Session["SelectCurrentDossierFamily"].ToString();
                    Dead dead = new Dead() { Name = name, Family = family };
                    deads = new DeadHandler().SearchLike(dead);
                }
            }
            else
            {
                Int64 nationalCode = (Int64)Session["SelectCurrentDossierNationalCode"];
                Dead dead = new DeadHandler().GetDetails(nationalCode);
                deads.Add(dead);

            }
            return deads;
        }

        protected void btnSelectDeclaration_Click(object sender, EventArgs e)
        {
            Int32 declarationID = int.Parse(DeclarationList.SelectedValue);
            if (declarationID > -1)
            {
                Session["CurrentDeclaration"] = new Taxer.Models.DeclarationHandler().GetDetails(declarationID);
                 ShowMessage("توجه", "اظهارنامه جاری انتخاب گردید");
               
            }
            else
            {
                ShowMessage("", "Please Select a Declaration");
            }
        }


    }
}