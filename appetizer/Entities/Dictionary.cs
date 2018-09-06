using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Dictionary
{
	private string tableName;
	private string columnName;
	private string persianDisplayName;

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

	public string PersianDisplayName
	{
		get
		{
			return persianDisplayName;
		}
		set
		{
			persianDisplayName = value;
		}
	}

}
}
