using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class ApplicationsDBAccess
{

	LoggingDBAccess loggingDBAccess = new LoggingDBAccess();

	public List<Logging> GetListLogging(int appID)
	{
		List<Logging> listLogging = new List<Logging>() { };
		SqlParameter[] parametersApplications = new SqlParameter[]
		{
			new SqlParameter("@AppID", appID)
		};

		//Lets get the list of Logging records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Logging_GetList_UseInApplications", CommandType.StoredProcedure, parametersApplications))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of logging
				listLogging = new List<Logging>();

				//Now lets populate the Logging details into the list of loggings
				foreach (DataRow row in table.Rows)
				{
					Logging logging = ConvertRowToLogging(row);
					listLogging.Add(logging);
				}
			}
		}

		return listLogging;
	}

	private Logging ConvertRowToLogging(DataRow row)
	{
		Logging logging = new Logging();
		logging.LogID = (row["LogID"] != DBNull.Value) ? Convert.ToInt64(row["LogID"]) : 0 ;
		logging.LogDescription = row["LogDescription"].ToString();
		logging.UserName = row["UserName"].ToString();
		logging.UserSysInfo = row["UserSysInfo"].ToString();
		logging.SpecificInfo = row["SpecificInfo"].ToString();
		logging.LogSDate = row["LogSDate"].ToString();
		logging.AppID = (row["AppID"] != DBNull.Value) ? Convert.ToInt32(row["AppID"]) : 0 ;
		logging.FormID = (row["FormID"] != DBNull.Value) ? Convert.ToInt32(row["FormID"]) : 0 ;
		logging.LogTitleID = (row["LogTitleID"] != DBNull.Value) ? Convert.ToInt32(row["LogTitleID"]) : 0 ;
		return logging;
	}
	public Int64 Insert(Applications applications)
	{
		SqlParameter[] parametersApplications = new SqlParameter[]
		{
			new SqlParameter("@AppID", applications.AppID),
			new SqlParameter("@AppStatus", (applications.AppStatus != null) ? applications.AppStatus : (object)DBNull.Value),
			new SqlParameter("@Background", (applications.Background != null) ? applications.Background : (object)DBNull.Value),
			new SqlParameter("@AppName", applications.AppName),
			new SqlParameter("@AppStartMessage", (applications.AppStartMessage != null) ? applications.AppStartMessage : (object)DBNull.Value),
			new SqlParameter("@AppVersion", (applications.AppVersion != null) ? applications.AppVersion : (object)DBNull.Value),
			new SqlParameter("@AppStatusMessage", (applications.AppStatusMessage != null) ? applications.AppStatusMessage : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Applications_Insert", CommandType.StoredProcedure, parametersApplications);
	}

	public bool Update(Applications applications)
	{
		SqlParameter[] parametersApplications = new SqlParameter[]
		{
			new SqlParameter("@AppID", applications.AppID),
			new SqlParameter("@AppStatus", (applications.AppStatus != null) ? applications.AppStatus : (object)DBNull.Value),
			new SqlParameter("@Background", (applications.Background != null) ? applications.Background : (object)DBNull.Value),
			new SqlParameter("@AppName", applications.AppName),
			new SqlParameter("@AppStartMessage", (applications.AppStartMessage != null) ? applications.AppStartMessage : (object)DBNull.Value),
			new SqlParameter("@AppVersion", (applications.AppVersion != null) ? applications.AppVersion : (object)DBNull.Value),
			new SqlParameter("@AppStatusMessage", (applications.AppStatusMessage != null) ? applications.AppStatusMessage : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Applications_Update", CommandType.StoredProcedure, parametersApplications);
	}

	public bool Delete(int appID)
	{
		SqlParameter[] parametersApplications = new SqlParameter[]
		{
			new SqlParameter("@AppID", appID)
		};
		return SqlDBHelper.ExecuteNonQuery("Applications_Delete", CommandType.StoredProcedure, parametersApplications);
	}

	public Applications GetDetails(int appID)
	{
		Applications applications = new Applications();

		SqlParameter[] parametersApplications = new SqlParameter[]
		{
			new SqlParameter("@AppID", appID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Applications_GetDetails", CommandType.StoredProcedure, parametersApplications))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				applications.AppID = (row["AppID"] != DBNull.Value) ? Convert.ToInt32(row["AppID"]) : 0 ;
				applications.AppStatus = (row["AppStatus"] != DBNull.Value) ? Convert.ToBoolean((row["AppStatus"].ToString() == "1" || row["AppStatus"].ToString().ToLower() == "true" ) ? true : false) : false ;
				applications.Background = row["Background"].ToString();
				applications.AppName = row["AppName"].ToString();
				applications.AppStartMessage = row["AppStartMessage"].ToString();
				applications.AppVersion = row["AppVersion"].ToString();
				applications.AppStatusMessage = row["AppStatusMessage"].ToString();
			}
		}

		return applications;
	}

	public List<Applications> GetListAll()
	{
		List<Applications> listApplications = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Applications_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listApplications = new List<Applications>();

				foreach (DataRow row in table.Rows)
				{
					Applications applications = new Applications();
					applications.AppID = (row["AppID"] != DBNull.Value) ? Convert.ToInt32(row["AppID"]) : 0 ;
				applications.AppStatus = (row["AppStatus"] != DBNull.Value) ? Convert.ToBoolean((row["AppStatus"].ToString() == "1" || row["AppStatus"].ToString().ToLower() == "true" ) ? true : false) : false ;
					applications.Background = row["Background"].ToString();
					applications.AppName = row["AppName"].ToString();
					applications.AppStartMessage = row["AppStartMessage"].ToString();
					applications.AppVersion = row["AppVersion"].ToString();
					applications.AppStatusMessage = row["AppStatusMessage"].ToString();
					listApplications.Add(applications);
				}
			}
		}

		return listApplications;
	}

	public bool Exists(int appID)
	{
		SqlParameter[] parametersApplications = new SqlParameter[]
		{
			new SqlParameter("@AppID", appID)
		};
		return (SqlDBHelper.ExecuteScalar("Applications_Exists", CommandType.StoredProcedure, parametersApplications)>0);
	}

	public bool Exists(Applications applications)
	{
		SqlParameter[] parametersApplications = new SqlParameter[]
		{
			new SqlParameter("@AppID", applications.AppID)
		};
		return (SqlDBHelper.ExecuteScalar("Applications_Exists", CommandType.StoredProcedure, parametersApplications)>0);
	}

	public List<Applications> SearchLike(Applications applications)
	{
		List<Applications> listApplications = new List<Applications>();


		SqlParameter[] parametersApplications = new SqlParameter[]
		{
			new SqlParameter("@AppID", applications.AppID),
			new SqlParameter("@AppStatus", applications.AppStatus),
			new SqlParameter("@Background", applications.Background),
			new SqlParameter("@AppName", applications.AppName),
			new SqlParameter("@AppStartMessage", applications.AppStartMessage),
			new SqlParameter("@AppVersion", applications.AppVersion),
			new SqlParameter("@AppStatusMessage", applications.AppStatusMessage),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Applications_SearchLike", CommandType.StoredProcedure, parametersApplications))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Applications tmpApplications = new Applications();
					tmpApplications.AppID = (row["AppID"] != DBNull.Value) ? Convert.ToInt32(row["AppID"]) : 0 ;
					tmpApplications.AppStatus = (row["AppStatus"] != DBNull.Value) ? Convert.ToBoolean((row["AppStatus"].ToString() == "1" || row["AppStatus"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpApplications.Background = row["Background"].ToString();
					tmpApplications.AppName = row["AppName"].ToString();
					tmpApplications.AppStartMessage = row["AppStartMessage"].ToString();
					tmpApplications.AppVersion = row["AppVersion"].ToString();
					tmpApplications.AppStatusMessage = row["AppStatusMessage"].ToString();

					listApplications.Add(tmpApplications);
				}
			}
		}

		return listApplications;
	}

}
}
