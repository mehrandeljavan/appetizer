using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class LogTitlesDBAccess
{

	LoggingDBAccess loggingDBAccess = new LoggingDBAccess();

	public List<Logging> GetListLogging(int logTitleID)
	{
		List<Logging> listLogging = new List<Logging>() { };
		SqlParameter[] parametersLogTitles = new SqlParameter[]
		{
			new SqlParameter("@LogTitleID", logTitleID)
		};

		//Lets get the list of Logging records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Logging_GetList_UseInLogTitles", CommandType.StoredProcedure, parametersLogTitles))
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
	public Int64 Insert(LogTitles logTitles)
	{
		SqlParameter[] parametersLogTitles = new SqlParameter[]
		{
			new SqlParameter("@LogTitle", (logTitles.LogTitle != null) ? logTitles.LogTitle : (object)DBNull.Value)
		};
		logTitles.LogTitleID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("LogTitles_Insert", CommandType.StoredProcedure, parametersLogTitles));
		return logTitles.LogTitleID;
	}

	public bool Update(LogTitles logTitles)
	{
		SqlParameter[] parametersLogTitles = new SqlParameter[]
		{
			new SqlParameter("@LogTitleID", logTitles.LogTitleID),
			new SqlParameter("@LogTitle", (logTitles.LogTitle != null) ? logTitles.LogTitle : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("LogTitles_Update", CommandType.StoredProcedure, parametersLogTitles);
	}

	public bool Delete(int logTitleID)
	{
		SqlParameter[] parametersLogTitles = new SqlParameter[]
		{
			new SqlParameter("@LogTitleID", logTitleID)
		};
		return SqlDBHelper.ExecuteNonQuery("LogTitles_Delete", CommandType.StoredProcedure, parametersLogTitles);
	}

	public LogTitles GetDetails(int logTitleID)
	{
		LogTitles logTitles = new LogTitles();

		SqlParameter[] parametersLogTitles = new SqlParameter[]
		{
			new SqlParameter("@LogTitleID", logTitleID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("LogTitles_GetDetails", CommandType.StoredProcedure, parametersLogTitles))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				logTitles.LogTitleID = (row["LogTitleID"] != DBNull.Value) ? Convert.ToInt32(row["LogTitleID"]) : 0 ;
				logTitles.LogTitle = row["LogTitle"].ToString();
			}
		}

		return logTitles;
	}

	public List<LogTitles> GetListAll()
	{
		List<LogTitles> listLogTitles = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("LogTitles_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listLogTitles = new List<LogTitles>();

				foreach (DataRow row in table.Rows)
				{
					LogTitles logTitles = new LogTitles();
					logTitles.LogTitleID = (row["LogTitleID"] != DBNull.Value) ? Convert.ToInt32(row["LogTitleID"]) : 0 ;
					logTitles.LogTitle = row["LogTitle"].ToString();
					listLogTitles.Add(logTitles);
				}
			}
		}

		return listLogTitles;
	}

	public bool Exists(int logTitleID)
	{
		SqlParameter[] parametersLogTitles = new SqlParameter[]
		{
			new SqlParameter("@LogTitleID", logTitleID)
		};
		return (SqlDBHelper.ExecuteScalar("LogTitles_Exists", CommandType.StoredProcedure, parametersLogTitles)>0);
	}

	public bool Exists(LogTitles logTitles)
	{
		SqlParameter[] parametersLogTitles = new SqlParameter[]
		{
			new SqlParameter("@LogTitleID", logTitles.LogTitleID)
		};
		return (SqlDBHelper.ExecuteScalar("LogTitles_Exists", CommandType.StoredProcedure, parametersLogTitles)>0);
	}

	public List<LogTitles> SearchLike(LogTitles logTitles)
	{
		List<LogTitles> listLogTitles = new List<LogTitles>();


		SqlParameter[] parametersLogTitles = new SqlParameter[]
		{
			new SqlParameter("@LogTitleID", logTitles.LogTitleID),
			new SqlParameter("@LogTitle", logTitles.LogTitle),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("LogTitles_SearchLike", CommandType.StoredProcedure, parametersLogTitles))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					LogTitles tmpLogTitles = new LogTitles();
					tmpLogTitles.LogTitleID = (row["LogTitleID"] != DBNull.Value) ? Convert.ToInt32(row["LogTitleID"]) : 0 ;
					tmpLogTitles.LogTitle = row["LogTitle"].ToString();

					listLogTitles.Add(tmpLogTitles);
				}
			}
		}

		return listLogTitles;
	}

}
}
