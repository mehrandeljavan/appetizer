using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appetizer.Forms
{
    public partial class PrintPages :CommonPage// System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        public string get_multi_page_html()
        {
            System.Text.StringBuilder html = new System.Text.StringBuilder();
            html.AppendLine(@"<h1 style=""direction: rtl;"">عنوان اصلی!</h1>");
            Int32 page_count = 8;
            for (int i = 1; i <= page_count; i++)
            {
                html.AppendLine(String.Format(@"<h2 style=""direction: rtl;"">صفحه {0} از {1}</h2>",i,page_count));
                html.AppendLine(@"<div class=""page-break""></div>");
            }
            return html.ToString();
        }
    }
}