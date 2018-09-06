using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Reports
{
	private Int64 reportsID;
	private string reportTypeIDTitle;
	private string oldRegisterDate;
	private string oldRegisterInformationID;
	private int? reportTypeID;
	private Int64 registerInformationID;
	private Int64? dossierID;
	private string reportDate;
	private string body;

	public Int64 ReportsID
	{
		get
		{
			return reportsID;
		}
		set
		{
			reportsID = value;
		}
	}

	public string ReportTypeIDTitle
	{
		get
		{
			return reportTypeIDTitle;
		}
		set
		{
			reportTypeIDTitle = value;
		}
	}

	public string OldRegisterDate
	{
		get
		{
			return oldRegisterDate;
		}
		set
		{
			oldRegisterDate = value;
		}
	}

	public string OldRegisterInformationID
	{
		get
		{
			return oldRegisterInformationID;
		}
		set
		{
			oldRegisterInformationID = value;
		}
	}

	public int? ReportTypeID
	{
		get
		{
			return reportTypeID;
		}
		set
		{
			reportTypeID = value;
		}
	}

	public Int64 RegisterInformationID
	{
		get
		{
			return registerInformationID;
		}
		set
		{
			registerInformationID = value;
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

	public string ReportDate
	{
		get
		{
			return reportDate;
		}
		set
		{
			reportDate = value;
		}
	}

	public string Body
	{
		get
		{
			return body;
		}
		set
		{
			body = value;
		}
	}

}
}
