using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Applications
{
	private int appID;
	private bool? appStatus;
	private string background;
	private string appName;
	private string appStartMessage;
	private string appVersion;
	private string appStatusMessage;
	private List<Logging> loggingList;

	public int AppID
	{
		get
		{
			return appID;
		}
		set
		{
			appID = value;
		}
	}

	public bool? AppStatus
	{
		get
		{
			return appStatus;
		}
		set
		{
			appStatus = value;
		}
	}

	public string Background
	{
		get
		{
			return background;
		}
		set
		{
			background = value;
		}
	}

	public string AppName
	{
		get
		{
			return appName;
		}
		set
		{
			appName = value;
		}
	}

	public string AppStartMessage
	{
		get
		{
			return appStartMessage;
		}
		set
		{
			appStartMessage = value;
		}
	}

	public string AppVersion
	{
		get
		{
			return appVersion;
		}
		set
		{
			appVersion = value;
		}
	}

	public string AppStatusMessage
	{
		get
		{
			return appStatusMessage;
		}
		set
		{
			appStatusMessage = value;
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
		LoggingList = new ApplicationsDBAccess().GetListLogging(this.AppID);
		return LoggingList;
	}

	public bool AddLogging(Logging logging)
	{
		logging.AppID = this.AppID;
		LoggingDBAccess loggingDBAccess = new LoggingDBAccess();
		if (loggingDBAccess.Insert(logging)>0)
			return (true);
		return (false);
	}

}
}
