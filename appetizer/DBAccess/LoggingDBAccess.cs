using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class LoggingDBAccess
{


	public Int64 Insert(Logging logging)
	{
		SqlParameter[] parametersLogging = new SqlParameter[]
		{
			new SqlParameter("@LogDescription", (logging.LogDescription != null) ? logging.LogDescription : (object)DBNull.Value),
			new SqlParameter("@UserName", (logging.UserName != null) ? logging.UserName : (object)DBNull.Value),
			new SqlParameter("@UserSysInfo", (logging.UserSysInfo != null) ? logging.UserSysInfo : (object)DBNull.Value),
			new SqlParameter("@SpecificInfo", (logging.SpecificInfo != null) ? logging.SpecificInfo : (object)DBNull.Value),
			new SqlParameter("@LogSDate", (logging.LogSDate != null) ? logging.LogSDate : (object)DBNull.Value),
			new SqlParameter("@AppID", (logging.AppID > 0) ? logging.AppID : (object)DBNull.Value),
			new SqlParameter("@FormID", (logging.FormID != null) ? logging.FormID : (object)DBNull.Value),
			new SqlParameter("@LogTitleID", (logging.LogTitleID > 0) ? logging.LogTitleID : (object)DBNull.Value),
			new SqlParameter("@LogDate", (logging.LogDate != null) ? logging.LogDate : (object)DBNull.Value)
		};
		logging.LogID = SqlDBHelper.ExecuteScalar("Logging_Insert", CommandType.StoredProcedure, parametersLogging);
		return logging.LogID;
	}

	public bool Update(Logging logging)
	{
		SqlParameter[] parametersLogging = new SqlParameter[]
		{
			new SqlParameter("@LogID", logging.LogID),
			new SqlParameter("@LogDescription", (logging.LogDescription != null) ? logging.LogDescription : (object)DBNull.Value),
			new SqlParameter("@UserName", (logging.UserName != null) ? logging.UserName : (object)DBNull.Value),
			new SqlParameter("@UserSysInfo", (logging.UserSysInfo != null) ? logging.UserSysInfo : (object)DBNull.Value),
			new SqlParameter("@SpecificInfo", (logging.SpecificInfo != null) ? logging.SpecificInfo : (object)DBNull.Value),
			new SqlParameter("@LogSDate", (logging.LogSDate != null) ? logging.LogSDate : (object)DBNull.Value),
			new SqlParameter("@AppID", (logging.AppID != null && logging.AppID >0 ) ? logging.AppID : (object)DBNull.Value),
			new SqlParameter("@FormID", (logging.FormID != null) ? logging.FormID : (object)DBNull.Value),
			new SqlParameter("@LogTitleID", (logging.LogTitleID != null && logging.LogTitleID >0 ) ? logging.LogTitleID : (object)DBNull.Value),
			new SqlParameter("@LogDate", (logging.LogDate != null) ? logging.LogDate : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Logging_Update", CommandType.StoredProcedure, parametersLogging);
	}

	public bool Delete(Int64 logID)
	{
		SqlParameter[] parametersLogging = new SqlParameter[]
		{
			new SqlParameter("@LogID", logID)
		};
		return SqlDBHelper.ExecuteNonQuery("Logging_Delete", CommandType.StoredProcedure, parametersLogging);
	}

	public Logging GetDetails(Int64 logID)
	{
		Logging logging = new Logging();

		SqlParameter[] parametersLogging = new SqlParameter[]
		{
			new SqlParameter("@LogID", logID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Logging_GetDetails", CommandType.StoredProcedure, parametersLogging))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				logging.LogID = (row["LogID"] != DBNull.Value) ? Convert.ToInt64(row["LogID"]) : 0 ;
				logging.LogDescription = row["LogDescription"].ToString();
				logging.UserName = row["UserName"].ToString();
				logging.UserSysInfo = row["UserSysInfo"].ToString();
				logging.SpecificInfo = row["SpecificInfo"].ToString();
				logging.LogSDate = row["LogSDate"].ToString();
				logging.AppID = (row["AppID"] != DBNull.Value) ? Convert.ToInt32(row["AppID"]) : 0 ;
				logging.FormID = (row["FormID"] != DBNull.Value) ? Convert.ToInt32(row["FormID"]) : 0 ;
				logging.LogTitleID = (row["LogTitleID"] != DBNull.Value) ? Convert.ToInt32(row["LogTitleID"]) : 0 ;
			}
		}

		return logging;
	}

	public List<Logging> GetListAll()
	{
		List<Logging> listLogging = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Logging_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listLogging = new List<Logging>();

				foreach (DataRow row in table.Rows)
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
					listLogging.Add(logging);
				}
			}
		}

		return listLogging;
	}

	public bool Exists(Int64 logID)
	{
		SqlParameter[] parametersLogging = new SqlParameter[]
		{
			new SqlParameter("@LogID", logID)
		};
		return (SqlDBHelper.ExecuteScalar("Logging_Exists", CommandType.StoredProcedure, parametersLogging)>0);
	}

	public bool Exists(Logging logging)
	{
		SqlParameter[] parametersLogging = new SqlParameter[]
		{
			new SqlParameter("@LogID", logging.LogID)
		};
		return (SqlDBHelper.ExecuteScalar("Logging_Exists", CommandType.StoredProcedure, parametersLogging)>0);
	}

	public List<Logging> SearchLike(Logging logging)
	{
		List<Logging> listLogging = new List<Logging>();


		SqlParameter[] parametersLogging = new SqlParameter[]
		{
			new SqlParameter("@LogID", logging.LogID),
			new SqlParameter("@LogDescription", logging.LogDescription),
			new SqlParameter("@UserName", logging.UserName),
			new SqlParameter("@UserSysInfo", logging.UserSysInfo),
			new SqlParameter("@SpecificInfo", logging.SpecificInfo),
			new SqlParameter("@LogSDate", logging.LogSDate),
			new SqlParameter("@AppID", logging.AppID),
			new SqlParameter("@FormID", logging.FormID),
			new SqlParameter("@LogTitleID", logging.LogTitleID),
			new SqlParameter("@LogDate", logging.LogDate),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Logging_SearchLike", CommandType.StoredProcedure, parametersLogging))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Logging tmpLogging = new Logging();
					tmpLogging.LogID = (row["LogID"] != DBNull.Value) ? Convert.ToInt64(row["LogID"]) : 0 ;
					tmpLogging.LogDescription = row["LogDescription"].ToString();
					tmpLogging.UserName = row["UserName"].ToString();
					tmpLogging.UserSysInfo = row["UserSysInfo"].ToString();
					tmpLogging.SpecificInfo = row["SpecificInfo"].ToString();
					tmpLogging.LogSDate = row["LogSDate"].ToString();
					tmpLogging.AppID = (row["AppID"] != DBNull.Value) ? Convert.ToInt32(row["AppID"]) : 0 ;
					tmpLogging.FormID = (row["FormID"] != DBNull.Value) ? Convert.ToInt32(row["FormID"]) : 0 ;
					tmpLogging.LogTitleID = (row["LogTitleID"] != DBNull.Value) ? Convert.ToInt32(row["LogTitleID"]) : 0 ;

					listLogging.Add(tmpLogging);
				}
			}
		}

		return listLogging;
	}

}
}
