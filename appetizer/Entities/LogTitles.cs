using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class LogTitles
{
	private int logTitleID;
	private string logTitle;
	private List<Logging> loggingList;

	public int LogTitleID
	{
		get
		{
			return logTitleID;
		}
		set
		{
			logTitleID = value;
		}
	}

	public string LogTitle
	{
		get
		{
			return logTitle;
		}
		set
		{
			logTitle = value;
		}
	}

	public List<Logging> LoggingList
	{
		get
		{
			return loggingList;
		}
		set
		{
			loggingList = value;
		}
	}

	public List<Logging> GetListLogging()
	{
		LoggingList = new LogTitlesDBAccess().GetListLogging(this.LogTitleID);
		return LoggingList;
	}

	public bool AddLogging(Logging logging)
	{
		logging.LogTitleID = this.LogTitleID;
		LoggingDBAccess loggingDBAccess = new LoggingDBAccess();
		if (loggingDBAccess.Insert(logging)>0)
			return (true);
		return (false);
	}

}
}
