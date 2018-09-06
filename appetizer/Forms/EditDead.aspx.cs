using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taxer.Models;

namespace appetizer.Forms
{
    public partial class EditDead : appetizer.CommonPage // System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (GetCurrentDossier() != null && GetCurrentDossier().DossierID > 0)
                {
                    Dead CurrentDead = GetCurrentDossier().GetListDead()[0];
                    txtDeadNationalCode.Text = CurrentDead.NationalCode.ToString();
                    txtDeadName.Text = CurrentDead.Name.ToString();
                    if (cboDeadGender.DataSource == null)
                    {
                        cboDeadGender.DataSource = new Taxer.Models.GenderHandler().GetListAll();
                        cboDeadGender.DataTextField = "Title";
                        cboDeadGender.DataValueField = "GenderID";
                        cboDeadGender.DataBind();
                    }
                    cboDeadGender.SelectedValue = CurrentDead.GenderID.Value.ToString();

                }
                else
                {
                    ShowMessage("توجه", "لطفا پرونده جاری را انتخاب کنید");
                }
            }
        }

        protected void btnSaveDead_Click(object sender, EventArgs e)
        {
            Int64 NationslCode  = 0;
            if (Int64.TryParse(txtDeadNationalCode.Text, out NationslCode))
            {
                Dead CurrentDossierDead = GetCurrentDossier().GetListDead()[0];
                if (NationslCode == CurrentDossierDead.NationalCode)
                {
                    Dead CurrentDead = new Taxer.Models.DeadHandler().GetDetails(NationslCode);
                    CurrentDead.GenderID = Int32.Parse(cboDeadGender.SelectedValue);
                    CurrentDead.Name = txtDeadName.Text;
                    new Taxer.Models.DeadHandler().Update(CurrentDead);
                    ShowMessage("پیام", "اطلاعات متوفی با موفقیت ذخیره گردید");
                }

            }
        }
    }
}