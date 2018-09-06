using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class ReportTypeHandler
{
	// Handle to the ReportType DBAccess class
	ReportTypeDBAccess reportTypeDb = null;

	public ReportTypeHandler()
	{
		reportTypeDb = new ReportTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reportTypes, we can put some logic here if needed 
	public List<ReportType> GetListAll()
	{
		return reportTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reportTypes, we can put some logic here if needed 
	public bool Update(ReportType reportType)
	{
		return reportTypeDb.Update(reportType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reportTypes, we can put some logic here if needed 
	public ReportType GetDetails(int reportTypeID)
	{
		return reportTypeDb.GetDetails(reportTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reportTypes, we can put some logic here if needed 
	public bool Delete(int reportTypeID)
	{
		return reportTypeDb.Delete(reportTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reportTypes, we can put some logic here if needed 
	public Int64 Insert(ReportType reportType)
	{
		return reportTypeDb.Insert(reportType);
	}

	public bool Exists(ReportType reportType)
	{
		return reportTypeDb.Exists(reportType);
	}

	public bool Exists(int reportTypeID)
	{
		return reportTypeDb.Exists(reportTypeID);
	}

	public List<Reports> GetListReports(int reportTypeID)
	{
		return reportTypeDb.GetListReports(reportTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reportTypes, we can put some logic here if needed 
	public List<ReportType> SearchLike(ReportType reportType)
	{
		return reportTypeDb.SearchLike(reportType);
	}

}
}
