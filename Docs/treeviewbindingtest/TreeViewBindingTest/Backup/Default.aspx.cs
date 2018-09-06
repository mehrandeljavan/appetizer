using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace TreeViewBindingTest
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();

            dataSet.Tables.Add("Table");
            dataSet.Tables[0].Columns.Add("ID", typeof(int));
            dataSet.Tables[0].Columns.Add("ParentID", typeof(int));
            dataSet.Tables[0].Columns.Add("Text", typeof(string));

            DataRow row = dataSet.Tables[0].NewRow();
            row["ID"] = 1;
            row["Text"] = "Parent 1";
            dataSet.Tables[0].Rows.Add(row);

            row = dataSet.Tables[0].NewRow();
            row["ID"] = 2;
            row["Text"] = "Parent 2";
            dataSet.Tables[0].Rows.Add(row);

            row = dataSet.Tables[0].NewRow();
            row["ID"] = 3;
            row["ParentID"] = 1;
            row["Text"] = "Child 1";
            dataSet.Tables[0].Rows.Add(row);

            row = dataSet.Tables[0].NewRow();
            row["ID"] = 4;
            row["ParentID"] = 1;
            row["Text"] = "Child 2";
            dataSet.Tables[0].Rows.Add(row);

            row = dataSet.Tables[0].NewRow();
            row["ID"] = 5;
            row["ParentID"] = 2;
            row["Text"] = "Child 3";
            dataSet.Tables[0].Rows.Add(row);

            row = dataSet.Tables[0].NewRow();
            row["ID"] = 6;
            row["ParentID"] = 2;
            row["Text"] = "Child 4";
            dataSet.Tables[0].Rows.Add(row);

            TreeView1.DataSource = new HierarchicalDataSet(dataSet, "ID", "ParentID");
            TreeView1.DataBind();
        }
    }
}


