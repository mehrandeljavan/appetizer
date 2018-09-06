using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taxer.Models;

namespace appetizer.Forms
{
    public partial class BankAccounts : CommonPage// System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // this.ObjectDataSource1.
            if (!IsPostBack)
            {
                Session.Remove("BankAccounts.SelectedHeritageID");
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                Int64 val = Int64.Parse(e.CommandArgument.ToString());
                Session["BankAccounts.SelectedHeritageID"] = val;
                FormView.DataBind();
            }
        }
        public List<Taxer.Models.BankDeposit> GetSelectedBankDeposit()
        {
            List<Taxer.Models.BankDeposit> Data = new List<Taxer.Models.BankDeposit>();
            if (Session["BankAccounts.SelectedHeritageID"] !=null)
            {
                Int64 val = (Int64)Session["BankAccounts.SelectedHeritageID"];
                Taxer.Models.BankDeposit Item = new Taxer.Models.BankDepositHandler().GetDetails(val);
                Data.Add(Item);

            }
            return Data;
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            FormView.ChangeMode(FormViewMode.Insert);
            ((Button)sender).Visible = false;
        }

        protected void Insert_Command(object sender, CommandEventArgs e)
        {
            this.AddButton.Visible = true;
        }

        protected void ObjectDataSource2_Inserting(object sender, ObjectDataSourceMethodEventArgs e)
        {

        }

        protected void FormView_ItemInserting(object sender, FormViewInsertEventArgs e)
        {
            var Values = e.Values;
            BankDeposit O = (BankDeposit)CreateObjectByCollection(Values, typeof(BankDeposit));
            BankDepositHandler ObjectHandler = new BankDepositHandler();
            O.DeclarationID = GetCurrentDeclaration().DeclarationID;
            ObjectHandler.Insert(O);
            e.Cancel = true;
        }


    }
}