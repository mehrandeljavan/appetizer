using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appetizer
{
    public partial class Index : CommonPage// System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string msg = @"Hi this is message";
            Response.Write(String.Format(@"<script type=""text/javascript"">
        alert(""{0}"");
    </script>",msg));
        }
    }
}