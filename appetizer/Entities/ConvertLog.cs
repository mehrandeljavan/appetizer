using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class ConvertLog
{
	private Int64 convertLogID;
	private Int64? nationalCode;
	private Int64? dossierID;
	private string tableName;
	private string convertDate;
	private string convertTime;
	private string errorMessage;
	private int? taxOfficeCode;
	private int? errorCode;
	private bool? convertStatus;

	public Int64 ConvertLogID
	{
		get
		{
			return convertLogID;
		}
		set
		{
			convertLogID = value;
		}
	}

	public Int64? NationalCode
	{
		get
		{
			return nationalCode;
		}
		set
		{
			nationalCode = value;
		}
	}

	public Int64? DossierID
	{
		get
		{
			return dossierID;
		}
		set
		{
			dossierID = value;
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

	public string ConvertDate
	{
		get
		{
			return convertDate;
		}
		set
		{
			convertDate = value;
		}
	}

	public string ConvertTime
	{
		get
		{
			return convertTime;
		}
		set
		{
			convertTime = value;
		}
	}

	public string ErrorMessage
	{
		get
		{
			return errorMessage;
		}
		set
		{
			errorMessage = value;
		}
	}

	public int? TaxOfficeCode
	{
		get
		{
			return taxOfficeCode;
		}
		set
		{
			taxOfficeCode = value;
		}
	}

	public int? ErrorCode
	{
		get
		{
			return errorCode;
		}
		set
		{
			errorCode = value;
		}
	}

	public bool? ConvertStatus
	{
		get
		{
			return convertStatus;
		}
		set
		{
			convertStatus = value;
		}
	}

}
}
