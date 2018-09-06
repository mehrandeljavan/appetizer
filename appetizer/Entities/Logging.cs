using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Logging
{
	private Int64 logID;
	private string logDescription;
	private string userName;
	private string userSysInfo;
	private string specificInfo;
	private string logSDate;
	private int? appID;
	private int? formID;
	private int? logTitleID;
	private DateTime? logDate;

	public Int64 LogID
	{
		get
		{
			return logID;
		}
		set
		{
			logID = value;
		}
	}

	public string LogDescription
	{
		get
		{
			return logDescription;
		}
		set
		{
			logDescription = value;
		}
	}

	public string UserName
	{
		get
		{
			return userName;
		}
		set
		{
			userName = value;
		}
	}

	public string UserSysInfo
	{
		get
		{
			return userSysInfo;
		}
		set
		{
			userSysInfo = value;
		}
	}

	public string SpecificInfo
	{
		get
		{
			return specificInfo;
		}
		set
		{
			specificInfo = value;
		}
	}

	public string LogSDate
	{
		get
		{
			return logSDate;
		}
		set
		{
			logSDate = value;
		}
	}

	public int? AppID
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

	public int? FormID
	{
		get
		{
			return formID;
		}
		set
		{
			formID = value;
		}
	}

	public int? LogTitleID
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

	public DateTime? LogDate
	{
		get
		{
			return logDate;
		}
		set
		{
			logDate = value;
		}
	}

}
}
