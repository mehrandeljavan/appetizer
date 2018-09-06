using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Web;
using Taxer.Models;

namespace appetizer
{
    
    public class CommonPage : System.Web.UI.Page
    {

        public String home_page ="~/Index.aspx";
        public CommonPage()
        {
            
            if (PublicPages.Count==0)
            {
                PublicPages.AddRange(new string[] { "~/login.aspx", "~/Index.aspx" });
            }
            base.Load += new EventHandler(CommonPage_Load);
            base.Unload += new EventHandler(CommonPage_Unload);
        }
        public List<String> PublicPages = new List<string>();
        public List<Taxer.Models.Dictionary> CaptionsDictiobnary
        {
            get
            {
                return Session["CaptionsDictiobnary"] == null ? new List<Taxer.Models.Dictionary>() : (List<Taxer.Models.Dictionary>)(Session["CaptionsDictiobnary"]);
            }
            set { Session["CaptionsDictiobnary"] = value; }
        }

        //public Taxer.Models.Declaration CurrentDeclaration
        //{
        //    get
        //    {
        //        return Session["CurrentDeclaration"] == null ? new Taxer.Models.Declaration() : (Taxer.Models.Declaration)(Session["CurrentDeclaration"]);
        //    }
        //    set { Session["CurrentDeclaration"] = value; }
        //}
        public Taxer.Models.Declaration GetCurrentDeclaration()
        {
            //if (GetCurrentDeclaration().DeclarationID == 0)
            //return    new DeclarationHandler().GetDetails(17);
             return Page.Session["CurrentDeclaration"] == null ? new Taxer.Models.Declaration() : (Taxer.Models.Declaration)(Session["CurrentDeclaration"]);
        }
        public Taxer.Models.Dossier GetCurrentDossier()
        {
            return Page.Session["CurrentDossier"] == null ? new Taxer.Models.Dossier() : (Taxer.Models.Dossier)(Session["CurrentDossier"]);
        }
        public List<Taxer.Models.BankDeposit> GetBankDeposits(Taxer.Models.Declaration Declaration)
        {
            //if (GetCurrentDeclaration().DeclarationID == 0)
           // return new DeclarationHandler().GetDetails(17).GetListBankDeposit();
           return GetCurrentDeclaration().GetListBankDeposit();
        }

        public Boolean UpdateBankDeposit(BankDeposit BankDeposit)
        {
            //var original = new BankDepositHandler().GetDetails(BankDeposit.HeritageID);
            //foreach (var item in BankDeposit.GetType().GetProperties())
            //{
               
            //}
            return new BankDepositHandler().Update(BankDeposit);
        }
        public Int64 InsertBankDeposit(BankDeposit BankDeposit)
        {
            //var original = new BankDepositHandler().GetDetails(BankDeposit.HeritageID);
            //foreach (var item in BankDeposit.GetType().GetProperties())
            //{
               
            //}
            return new BankDepositHandler().Insert(BankDeposit);
        }
        public void SetCurrentDeclaration(Taxer.Models.Declaration dec)
        {
             Session["CurrentDeclaration"] = dec;
        
        }
        public bool get_visible(String EntityName, String FieldName)
        {
            return false;
        }
        public string get_caption(String EntityName, String FieldName)
        {
            string caption = String.Join(" ", new string[] { EntityName, FieldName });
            if (CaptionsDictiobnary==null || CaptionsDictiobnary.Count == 0)
            {
                CaptionsDictiobnary = new Taxer.Models.DictionaryHandler().GetListAll();
            }
            foreach (Taxer.Models.Dictionary dic in CaptionsDictiobnary)
            {
                if (dic.TableName.Trim() == EntityName && dic.ColumnName.Trim() == FieldName)
                {
                    caption = dic.PersianDisplayName;
                    break;
                }
            }

            return caption;
        }

        private void CommonPage_Load(object sender, EventArgs e)
        {
            if (page_is_public(Request.AppRelativeCurrentExecutionFilePath))
            {
                return;  
            }
            AccessCheck();
        }
        Boolean page_is_public(String PageName)
        {
            bool result = false;
            foreach (String page_name in PublicPages)
            {
                if (page_name.ToLower() == PageName.ToLower())
                {
                    result = true;
                }
            }
            return result;
        }
        private void CommonPage_Unload(object sender, EventArgs e)
        {
            // clean up
        }

        public User CurrentUser
        {
            get
            {
                User usr = (User)Session["CurrentUser"];
                if (usr == null)
                {
                    usr = new User();
                    Session.Add("CurrentUser", usr);
                }
                return usr;
            }
        }
        public void logout_user()
        {
            Session.Clear();
            Response.Redirect(home_page);
        }
        private void AccessCheck()
        {
            bool can_view_this_page = false;
            can_view_this_page = !String.IsNullOrEmpty(CurrentUser.Name);
            {
                if (!can_view_this_page)
                {
                    Response.Redirect("~/Login.aspx?requested_page=" + Request.RawUrl);
                }
            }
        }

        public void ShowMessage(string msg_title, string message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + msg_title + "','" + message + "');", true);
        }
        public static void DataBindCombo(System.Web.UI.WebControls.DropDownList Combo, Object Data, String DisplayField, String ValueField)
        {
            Combo.DataSource = Data;
            Combo.DataTextField = DisplayField;
            Combo.DataValueField = ValueField;
            Combo.DataBind();
            Combo.SelectedValue = null;
            //Combo.SelectedIndex = -1;
        }

        public static Object CreateObjectByCollection(IOrderedDictionary C, Type T)
        {
            // create an instance of that type
            object O = Activator.CreateInstance(T);
            foreach (PropertyInfo p in T.GetProperties())
            {
                //D.Add(((System.Reflection.MemberInfo)(p)).Name, GetNameByType(p) + ((System.Reflection.MemberInfo)(p)).Name);

                string property = p.Name;
                object value = null;
                try
                {
                    string KeyName = null;
                    //////Linq expression is equal to below code
                    foreach (String Key in C.Keys)
                    {
                        if (Key ==  ((System.Reflection.MemberInfo)(p)).Name)
                        {
                            KeyName = Key;
                            break;
                        }
                    }

                    //???????????????????????????????????????????????????????????????????????????????????/////
                    //Correct Nullable Values
                    String propertyName = String.Empty;
                    if (p.PropertyType.IsGenericType)
                    {
                        if (p.PropertyType.Name == "List`1")
                        {
                            propertyName = p.PropertyType.Name;
                        }
                        else
                        {
                            propertyName = p.PropertyType.GetGenericArguments()[0].Name;
                        }
                    }
                    else
                    {
                        propertyName = p.PropertyType.Name;
                    }
                    //???????????????????????????????????????????????????????????????????????????????????/////

                    if (propertyName == "Int32")
                        value = Convert.ToInt32(C[KeyName]);
                    else if (propertyName == "Int64")
                        value = Convert.ToInt64(C[KeyName]);
                    else if (propertyName == "Single")
                        value = Convert.ToSingle(C[KeyName]);
                    else if (propertyName == "Boolean")
                        value = Convert.ToBoolean(C[KeyName]);
                    else
                        value = C[KeyName];


                    //switch (propertyName)
                    //{
                    //    case "Int32":
                    //    case "Int64":
                    //    case "Single":
                    //        if (Convert.ToInt64(value) == 0)
                    //            if (FieldIsforeignKey(T.Name, p.Name))
                    //                value = null;
                    //        break;
                    //    default:
                    //        break;
                    //}
                }
                catch (Exception)
                {
                    //TODO: Important! be sure to log exceptions here dear ali
                    continue;
                }

                // Get the type contained in the name string
                //Type type = Type.GetType(name, true);

                // Get a property on the type that is stored in the 
                // property string
                PropertyInfo prop = T.GetProperty(property);

                // Set the value of the given property on the given instance
                if (value != null && !String.IsNullOrEmpty(value.ToString())) prop.SetValue(O, value, null);

                // at this stage instance.Bar will equal to the value
            }
            return O;

        }

    }
}