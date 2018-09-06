using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class UserDossier
{
	private Int64 userNationalCode;
	private Int64 dossierID;
	private string userFullName;
	private Int64? referrerUserNationalCode;
	private string startDate;
	private string endDate;
	private string referenceDate;

	public Int64 UserNationalCode
	{
		get
		{
			return userNationalCode;
		}
		set
		{
			userNationalCode = value;
		}
	}

	public Int64 DossierID
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

	public string UserFullName
	{
		get
		{
			return userFullName;
		}
		set
		{
			userFullName = value;
		}
	}

	public Int64? ReferrerUserNationalCode
	{
		get
		{
			return referrerUserNationalCode;
		}
		set
		{
			referrerUserNationalCode = value;
		}
	}

	public string StartDate
	{
		get
		{
			return startDate;
		}
		set
		{
			startDate = value;
		}
	}

	public string EndDate
	{
		get
		{
			return endDate;
		}
		set
		{
			endDate = value;
		}
	}

	public string ReferenceDate
	{
		get
		{
			return referenceDate;
		}
		set
		{
			referenceDate = value;
		}
	}

}
}
