using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taxer.Models;

namespace appetizer
{
    public partial class app_menu : System.Web.UI.UserControl
    {
        public string GetDossierInfo()
        {
            string ret = String.Empty;
            if (Page.Session["CurrentDossier"] != null)
            {
                Dossier dossier = (Dossier)Page.Session["CurrentDossier"];
                List<Dead> deads = dossier.GetListDead();
                Dead dead = deads.Count > 0 ? deads[0] : new Dead();
                Declaration declaration = (Declaration)Page.Session["CurrentDeclaration"];
                ret = String.Format(@"
<div style=""z-index:10000;direction:rtl;color:red;background-color:yellow;float:right;padding:5px; position: absolute;right: 20px;"" class=""navbar-header""> 
<span>نام متوفی:{0} - </span>
<span>کلاسه:</span><span  dir=""ltr"">{1}</span>
<span style=""direction:rtl;"">{2}</span>
</div>

        ", dead.FullName,dossier.Classes,((declaration!=null)
         ?" - اظهارنامه:"+ declaration.StageTitle
                : " - اظهارنامه انتخاب نشده است")
                );
            }
            return ret;

        }

        public string get_dynamic_menu()
        {
            return @"
        <li><a href=""/Forms/PrintPages.aspx"">چاپ چند صفحه ای</a></li>
        <li><a href=""/Forms/BankAccounts.aspx"">ثبت حساب بانکی</a></li>
        <li><a href=""/Forms/DossierUserAssignment.aspx"">انتصاب پرونده به کاربران</a></li>
        <li><a href=""/Forms/HeirCombination.aspx"">ثبت ترکیب وراث</a></li>
        <li><a href=""/Forms/SelectCurrentDossier.aspx"">انتخاب پرونده جاری</a></li>
";
        }

        public string get_search_bar_menu()
        {
            return @"
        <li><a href=""/Forms/PrintPages.aspx"">چاپ چند صفحه ای</a></li>
        <li><a href=""/Forms/BankAccounts.aspx"">ثبت حساب بانکی</a></li>
        <li><a href=""/Forms/DossierUserAssignment.aspx"">انتصاب پرونده به کاربران</a></li>
        <li><a href=""/Forms/HeirCombination.aspx"">ثبت ترکیب وراث</a></li>
        <li><a href=""/Forms/SelectCurrentDossier.aspx"">انتخاب پرونده جاری</a></li>
";
        }

        public string get_login_name()
        {
            String UserName = String.Empty;
            if (Session["CurrentUser"] != null)
            {
                UserName = ((Taxer.Models.User)Session["CurrentUser"]).FullName;
            }
            return UserName;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHeaderSearchDossierByClasse_Click(object sender, EventArgs e)
        {
            List<Dossier> dossier = new DossierHandler().SearchLike(new Dossier() {Classes=txtClasse.Text});
            if (dossier.Count>0)
            {
                Session["CurrentDossier"] = dossier[0];
                Session["CurrentDeclaration"] = null;
                List<Declaration> declarations = dossier[0].GetListDeclaration();
              CommonPage.DataBindCombo(this.HeaderDeclarationList, declarations, "StageTitle", "DeclarationID");
            }
            else
            {
                CommonPage.DataBindCombo(this.HeaderDeclarationList, new List<Declaration>(), "StageTitle", "DeclarationID");
                ShowMessage("Error", "Could not find anything!.");
            }
        }

        public void ShowMessage(string msg_title, string message)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + msg_title + "','" + message + "');", true);
        }

        protected void btnHeaderSelectDeclaration_Click(object sender, EventArgs e)
        {
            Int32 declarationID = int.Parse(HeaderDeclarationList.SelectedValue);
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