using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class ReportType
{
	private int reportTypeID;
	private string title;
	private List<Reports> reportsList;

	public int ReportTypeID
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

	public string Title
	{
		get
		{
			return title;
		}
		set
		{
			title = value;
		}
	}

	public List<Reports> ReportsList
	{
		get
		{
			return reportsList;
		}
		set
		{
			reportsList = value;
		}
	}

	public List<Reports> GetListReports()
	{
		ReportsList = new ReportTypeDBAccess().GetListReports(this.ReportTypeID);
		return ReportsList;
	}

	public bool AddReports(Reports reports)
	{
		reports.ReportTypeID = this.ReportTypeID;
		ReportsDBAccess reportsDBAccess = new ReportsDBAccess();
		if (reportsDBAccess.Insert(reports)>0)
			return (true);
		return (false);
	}

}
}
