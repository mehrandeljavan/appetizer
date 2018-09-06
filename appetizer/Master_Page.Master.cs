using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appetizer
{
    public partial class Master_Page : System.Web.UI.MasterPage
    {




        public string get_site_title()
        {
            return "method says: " + PageTitle;
        }
        private String pageTitle = "P-Title";

        public String PageTitle
        {
            get { return pageTitle; }
            set { pageTitle = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

    }
}