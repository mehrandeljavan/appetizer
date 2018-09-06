using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taxer.Models;

namespace appetizer.Forms
{
    public partial class DossierUserAssignment :CommonPage// System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["DossierUserAssignmentNationalCode"] = null;
                Session["DossierUserAssignmentName"] = null;
                Session["DossierUserAssignmentFamily"] = null;

                Session["DossierUserAssignmentDossier"] = null;
               
                List<User> users = new UserHandler().GetListAll();
                DataBindCombo(UserList, users, "FullName", "NationalCode");

            }

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Int64 dossierID = Int64.Parse(e.CommandArgument.ToString());
            Dossier dossier = new DossierHandler().GetDetails(dossierID);
            Session["DossierUserAssignmentDossier"] = dossier;
            ObjectDataSourceDossierUsers.DataBind();
            GridView2.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Session["DossierUserAssignmentNationalCode"] = null;
            Session["DossierUserAssignmentName"] = null;
            Session["DossierUserAssignmentFamily"] = null;
            if (String.IsNullOrEmpty(txtNationalCode.Text))
            {
                if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtFamily.Text))
                {
                    ShowMessage("خطا", "لطفا کد ملی یا نام و نام خانوادگی را وارد کنید");
                }
                else
                {
                    Session["DossierUserAssignmentName"] = txtName.Text;
                    Session["DossierUserAssignmentFamily"] = txtFamily.Text;
                }
            }
            else
            {
                try
                {
                    Int64 nationalCode = Int64.Parse(txtNationalCode.Text);
                    Session["DossierUserAssignmentNationalCode"] = nationalCode;
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
            if (Session["DossierUserAssignmentNationalCode"] == null)
            {
                if (Session["DossierUserAssignmentName"] != null || Session["DossierUserAssignmentFamily"] != null)
                {
                    String name = Session["DossierUserAssignmentName"].ToString();
                    String family = Session["DossierUserAssignmentFamily"].ToString();
                    Dead dead = new Dead() { Name = name, Family = family };
                    deads = new DeadHandler().SearchLike(dead);
                }
            }
            else
            {
                Int64 nationalCode = (Int64)Session["DossierUserAssignmentNationalCode"];
                Dead dead = new DeadHandler().GetDetails(nationalCode);
                deads.Add(dead);

            }
            return deads;
        }
        public List<UserDossier> GetDossierUsers()
        {
            List<UserDossier> dossier_users = new List<UserDossier>();
            if (Session["DossierUserAssignmentDossier"] != null)
            {
                Dossier dossier = (Dossier)Session["DossierUserAssignmentDossier"];
               dossier_users = dossier.GetListUserDossier();
            }
            return dossier_users;
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            Int64 nationalCode = Int64.Parse(UserList.SelectedValue);
            Dossier dossier = (Dossier)Session["DossierUserAssignmentDossier"];
            if (nationalCode > -1 && dossier != null)
            {
                if (!new UserDossierHandler().Exists(nationalCode, dossier.DossierID))
                {
                    User user = new Taxer.Models.UserHandler().GetDetails(nationalCode);
                    UserDossier userDossier = new UserDossier()
                    {
                        UserFullName = user.FullName,
                        UserNationalCode = user.NationalCode,
                        DossierID = dossier.DossierID
                    };
                    new UserDossierHandler().Insert(userDossier);
                    this.ObjectDataSourceDossierUsers.DataBind();
                    this.GridView2.DataBind();
                }
                else
                {
                    ShowMessage("oops!", "User ALready Exists in Dossier!");

                }
            }
            else
            {
                ShowMessage("oops!", "Please Select a Dossier Then USER!");
            }
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteUser")
            {
                Int64 nationalCode = Int64.Parse(e.CommandArgument.ToString());
                Dossier dossier = (Dossier)Session["DossierUserAssignmentDossier"];
                new UserDossierHandler().Delete(nationalCode, dossier.DossierID);
                this.ObjectDataSourceDossierUsers.DataBind();
                this.GridView2.DataBind();
            }
        }

        
    }
}