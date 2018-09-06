using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class BoolFieldsTitle
{
	private int boolFieldsTitleID;
	private string tableName;
	private string columnName;
	private string trueTitle;
	private string falseTitle;

	public int BoolFieldsTitleID
	{
		get
		{
			return boolFieldsTitleID;
		}
		set
		{
			boolFieldsTitleID = value;
		}
	}

	public string TableName
	{
		get
		{
			return tableName;
		}
		set
		{
			tableName = value;
		}
	}

	public string ColumnName
	{
		get
		{
			return columnName;
		}
		set
		{
			columnName = value;
		}
	}

	public string TrueTitle
	{
		get
		{
			return trueTitle;
		}
		set
		{
			trueTitle = value;
		}
	}

	public string FalseTitle
	{
		get
		{
			return falseTitle;
		}
		set
		{
			falseTitle = value;
		}
	}

}
}
