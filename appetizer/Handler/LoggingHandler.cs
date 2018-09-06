using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class LoggingHandler
{
	// Handle to the Logging DBAccess class
	LoggingDBAccess loggingDb = null;

	public LoggingHandler()
	{
		loggingDb = new LoggingDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of loggings, we can put some logic here if needed 
	public List<Logging> GetListAll()
	{
		return loggingDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of loggings, we can put some logic here if needed 
	public bool Update(Logging logging)
	{
		return loggingDb.Update(logging);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of loggings, we can put some logic here if needed 
	public Logging GetDetails(Int64 logID)
	{
		return loggingDb.GetDetails(logID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of loggings, we can put some logic here if needed 
	public bool Delete(Int64 logID)
	{
		return loggingDb.Delete(logID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of loggings, we can put some logic here if needed 
	public Int64 Insert(Logging logging)
	{
		return loggingDb.Insert(logging);
	}

	public bool Exists(Logging logging)
	{
		return loggingDb.Exists(logging);
	}

	public bool Exists(Int64 logID)
	{
		return loggingDb.Exists(logID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of loggings, we can put some logic here if needed 
	public List<Logging> SearchLike(Logging logging)
	{
		return loggingDb.SearchLike(logging);
	}

}
}
