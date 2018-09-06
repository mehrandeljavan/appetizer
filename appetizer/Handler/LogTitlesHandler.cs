using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class LogTitlesHandler
{
	// Handle to the LogTitles DBAccess class
	LogTitlesDBAccess logTitlesDb = null;

	public LogTitlesHandler()
	{
		logTitlesDb = new LogTitlesDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of logTitless, we can put some logic here if needed 
	public List<LogTitles> GetListAll()
	{
		return logTitlesDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of logTitless, we can put some logic here if needed 
	public bool Update(LogTitles logTitles)
	{
		return logTitlesDb.Update(logTitles);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of logTitless, we can put some logic here if needed 
	public LogTitles GetDetails(int logTitleID)
	{
		return logTitlesDb.GetDetails(logTitleID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of logTitless, we can put some logic here if needed 
	public bool Delete(int logTitleID)
	{
		return logTitlesDb.Delete(logTitleID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of logTitless, we can put some logic here if needed 
	public Int64 Insert(LogTitles logTitles)
	{
		return logTitlesDb.Insert(logTitles);
	}

	public bool Exists(LogTitles logTitles)
	{
		return logTitlesDb.Exists(logTitles);
	}

	public bool Exists(int logTitleID)
	{
		return logTitlesDb.Exists(logTitleID);
	}

	public List<Logging> GetListLogging(int logTitleID)
	{
		return logTitlesDb.GetListLogging(logTitleID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of logTitless, we can put some logic here if needed 
	public List<LogTitles> SearchLike(LogTitles logTitles)
	{
		return logTitlesDb.SearchLike(logTitles);
	}

}
}
