using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class ReportsHandler
{
	// Handle to the Reports DBAccess class
	ReportsDBAccess reportsDb = null;

	public ReportsHandler()
	{
		reportsDb = new ReportsDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reportss, we can put some logic here if needed 
	public List<Reports> GetListAll()
	{
		return reportsDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reportss, we can put some logic here if needed 
	public bool Update(Reports reports)
	{
		return reportsDb.Update(reports);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reportss, we can put some logic here if needed 
	public Reports GetDetails(Int64 reportsID)
	{
		return reportsDb.GetDetails(reportsID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reportss, we can put some logic here if needed 
	public bool Delete(Int64 reportsID)
	{
		return reportsDb.Delete(reportsID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reportss, we can put some logic here if needed 
	public Int64 Insert(Reports reports)
	{
		return reportsDb.Insert(reports);
	}

	public bool Exists(Reports reports)
	{
		return reportsDb.Exists(reports);
	}

	public bool Exists(Int64 reportsID)
	{
		return reportsDb.Exists(reportsID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reportss, we can put some logic here if needed 
	public List<Reports> SearchLike(Reports reports)
	{
		return reportsDb.SearchLike(reports);
	}

}
}
