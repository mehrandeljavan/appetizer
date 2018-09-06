using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class ConvertLogDBAccess
{


	public Int64 Insert(ConvertLog convertLog)
	{
		SqlParameter[] parametersConvertLog = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", (convertLog.NationalCode != null) ? convertLog.NationalCode : (object)DBNull.Value),
			new SqlParameter("@DossierID", (convertLog.DossierID != null) ? convertLog.DossierID : (object)DBNull.Value),
			new SqlParameter("@TableName", (convertLog.TableName != null) ? convertLog.TableName : (object)DBNull.Value),
			new SqlParameter("@ConvertDate", (convertLog.ConvertDate != null) ? convertLog.ConvertDate : (object)DBNull.Value),
			new SqlParameter("@ConvertTime", (convertLog.ConvertTime != null) ? convertLog.ConvertTime : (object)DBNull.Value),
			new SqlParameter("@ErrorMessage", (convertLog.ErrorMessage != null) ? convertLog.ErrorMessage : (object)DBNull.Value),
			new SqlParameter("@TaxOfficeCode", (convertLog.TaxOfficeCode != null) ? convertLog.TaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@ErrorCode", (convertLog.ErrorCode != null) ? convertLog.ErrorCode : (object)DBNull.Value),
			new SqlParameter("@ConvertStatus", (convertLog.ConvertStatus != null) ? convertLog.ConvertStatus : (object)DBNull.Value)
		};
		convertLog.ConvertLogID = SqlDBHelper.ExecuteScalar("ConvertLog_Insert", CommandType.StoredProcedure, parametersConvertLog);
		return convertLog.ConvertLogID;
	}

	public bool Update(ConvertLog convertLog)
	{
		SqlParameter[] parametersConvertLog = new SqlParameter[]
		{
			new SqlParameter("@ConvertLogID", convertLog.ConvertLogID),
			new SqlParameter("@NationalCode", (convertLog.NationalCode != null) ? convertLog.NationalCode : (object)DBNull.Value),
			new SqlParameter("@DossierID", (convertLog.DossierID != null) ? convertLog.DossierID : (object)DBNull.Value),
			new SqlParameter("@TableName", (convertLog.TableName != null) ? convertLog.TableName : (object)DBNull.Value),
			new SqlParameter("@ConvertDate", (convertLog.ConvertDate != null) ? convertLog.ConvertDate : (object)DBNull.Value),
			new SqlParameter("@ConvertTime", (convertLog.ConvertTime != null) ? convertLog.ConvertTime : (object)DBNull.Value),
			new SqlParameter("@ErrorMessage", (convertLog.ErrorMessage != null) ? convertLog.ErrorMessage : (object)DBNull.Value),
			new SqlParameter("@TaxOfficeCode", (convertLog.TaxOfficeCode != null) ? convertLog.TaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@ErrorCode", (convertLog.ErrorCode != null) ? convertLog.ErrorCode : (object)DBNull.Value),
			new SqlParameter("@ConvertStatus", (convertLog.ConvertStatus != null) ? convertLog.ConvertStatus : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("ConvertLog_Update", CommandType.StoredProcedure, parametersConvertLog);
	}

	public bool Delete(Int64 convertLogID)
	{
		SqlParameter[] parametersConvertLog = new SqlParameter[]
		{
			new SqlParameter("@ConvertLogID", convertLogID)
		};
		return SqlDBHelper.ExecuteNonQuery("ConvertLog_Delete", CommandType.StoredProcedure, parametersConvertLog);
	}

	public bool Delete(Int64 nationalCode , int taxOfficeCode)
	{
		SqlParameter[] parametersConvertLog = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode),
			new SqlParameter("@TaxOfficeCode", taxOfficeCode)
		};
		return SqlDBHelper.ExecuteNonQuery("ConvertLog_DeleteBy_NationalCodeTaxOfficeCode", CommandType.StoredProcedure, parametersConvertLog);

	}

	public ConvertLog GetDetails(Int64 convertLogID)
	{
		ConvertLog convertLog = new ConvertLog();

		SqlParameter[] parametersConvertLog = new SqlParameter[]
		{
			new SqlParameter("@ConvertLogID", convertLogID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ConvertLog_GetDetails", CommandType.StoredProcedure, parametersConvertLog))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				convertLog.ConvertLogID = (row["ConvertLogID"] != DBNull.Value) ? Convert.ToInt64(row["ConvertLogID"]) : 0 ;
				convertLog.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
				convertLog.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
				convertLog.TableName = row["TableName"].ToString();
				convertLog.ConvertDate = row["ConvertDate"].ToString();
				convertLog.ConvertTime = row["ConvertTime"].ToString();
				convertLog.ErrorMessage = row["ErrorMessage"].ToString();
				convertLog.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
				convertLog.ErrorCode = (row["ErrorCode"] != DBNull.Value) ? Convert.ToInt32(row["ErrorCode"]) : 0 ;
				convertLog.ConvertStatus = (row["ConvertStatus"] != DBNull.Value) ? Convert.ToBoolean((row["ConvertStatus"].ToString() == "1" || row["ConvertStatus"].ToString().ToLower() == "true" ) ? true : false) : false ;
			}
		}

		return convertLog;
	}

	public ConvertLog GetDetails(Int64 nationalCode , int taxOfficeCode)
	{
		ConvertLog convertLog = new ConvertLog();

		SqlParameter[] parametersConvertLog = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode),
			new SqlParameter("@TaxOfficeCode", taxOfficeCode)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ConvertLog_GetDetailsBy_NationalCodeTaxOfficeCode", CommandType.StoredProcedure, parametersConvertLog))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				convertLog.ConvertLogID = (row["ConvertLogID"] != DBNull.Value) ? Convert.ToInt64(row["ConvertLogID"]) : 0 ;
				convertLog.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
				convertLog.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
				convertLog.TableName = row["TableName"].ToString();
				convertLog.ConvertDate = row["ConvertDate"].ToString();
				convertLog.ConvertTime = row["ConvertTime"].ToString();
				convertLog.ErrorMessage = row["ErrorMessage"].ToString();
				convertLog.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
				convertLog.ErrorCode = (row["ErrorCode"] != DBNull.Value) ? Convert.ToInt32(row["ErrorCode"]) : 0 ;
				convertLog.ConvertStatus = (row["ConvertStatus"] != DBNull.Value) ? Convert.ToBoolean((row["ConvertStatus"].ToString() == "1" || row["ConvertStatus"].ToString().ToLower() == "true" ) ? true : false) : false ;
			}
		}

		return convertLog;
	}

	public List<ConvertLog> GetListAll()
	{
		List<ConvertLog> listConvertLog = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("ConvertLog_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listConvertLog = new List<ConvertLog>();

				foreach (DataRow row in table.Rows)
				{
					ConvertLog convertLog = new ConvertLog();
					convertLog.ConvertLogID = (row["ConvertLogID"] != DBNull.Value) ? Convert.ToInt64(row["ConvertLogID"]) : 0 ;
					convertLog.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					convertLog.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					convertLog.TableName = row["TableName"].ToString();
					convertLog.ConvertDate = row["ConvertDate"].ToString();
					convertLog.ConvertTime = row["ConvertTime"].ToString();
					convertLog.ErrorMessage = row["ErrorMessage"].ToString();
					convertLog.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
					convertLog.ErrorCode = (row["ErrorCode"] != DBNull.Value) ? Convert.ToInt32(row["ErrorCode"]) : 0 ;
				convertLog.ConvertStatus = (row["ConvertStatus"] != DBNull.Value) ? Convert.ToBoolean((row["ConvertStatus"].ToString() == "1" || row["ConvertStatus"].ToString().ToLower() == "true" ) ? true : false) : false ;
					listConvertLog.Add(convertLog);
				}
			}
		}

		return listConvertLog;
	}

	public bool Exists(Int64 convertLogID)
	{
		SqlParameter[] parametersConvertLog = new SqlParameter[]
		{
			new SqlParameter("@ConvertLogID", convertLogID)
		};
		return (SqlDBHelper.ExecuteScalar("ConvertLog_Exists", CommandType.StoredProcedure, parametersConvertLog)>0);
	}

	public bool Exists(ConvertLog convertLog)
	{
		SqlParameter[] parametersConvertLog = new SqlParameter[]
		{
			new SqlParameter("@ConvertLogID", convertLog.ConvertLogID)
		};
		return (SqlDBHelper.ExecuteScalar("ConvertLog_Exists", CommandType.StoredProcedure, parametersConvertLog)>0);
	}

	public List<ConvertLog> GetListByConvertLogNationalCodeTaxOfficeCode(Int64 nationalCode,int taxOfficeCode)
	{
		List<ConvertLog> listConvertLog = new List<ConvertLog>();

		//Lets get the list of all ConvertLog records from database using NationalCode TaxOfficeCode
		SqlParameter[] parametersConvertLog = new SqlParameter[]
		{
			new SqlParameter("@nationalCode", nationalCode),
			new SqlParameter("@taxOfficeCode", taxOfficeCode)
		};
		//Lets get the list of ConvertLog records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ConvertLog_GetListByNationalCodeTaxOfficeCode", CommandType.StoredProcedure, parametersConvertLog))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of convertLog
				listConvertLog = new List<ConvertLog>();

				//Now lets populate the convertLog details into the list of convertLogs
				foreach (DataRow row in table.Rows)
				{
					ConvertLog convertLog = new ConvertLog();
					convertLog.ConvertLogID = (row["ConvertLogID"] != DBNull.Value) ? Convert.ToInt64(row["ConvertLogID"]) : 0 ;
					convertLog.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					convertLog.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					convertLog.TableName = row["TableName"].ToString();
					convertLog.ConvertDate = row["ConvertDate"].ToString();
					convertLog.ConvertTime = row["ConvertTime"].ToString();
					convertLog.ErrorMessage = row["ErrorMessage"].ToString();
					convertLog.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
					convertLog.ErrorCode = (row["ErrorCode"] != DBNull.Value) ? Convert.ToInt32(row["ErrorCode"]) : 0 ;
				convertLog.ConvertStatus = (row["ConvertStatus"] != DBNull.Value) ? Convert.ToBoolean((row["ConvertStatus"].ToString() == "1" || row["ConvertStatus"].ToString().ToLower() == "true" ) ? true : false) : false ;
					listConvertLog.Add(convertLog);
				}
			}
		}

		return listConvertLog;
	}

	public List<ConvertLog> SearchLike(ConvertLog convertLog)
	{
		List<ConvertLog> listConvertLog = new List<ConvertLog>();


		SqlParameter[] parametersConvertLog = new SqlParameter[]
		{
			new SqlParameter("@ConvertLogID", convertLog.ConvertLogID),
			new SqlParameter("@NationalCode", convertLog.NationalCode),
			new SqlParameter("@DossierID", convertLog.DossierID),
			new SqlParameter("@TableName", convertLog.TableName),
			new SqlParameter("@ConvertDate", convertLog.ConvertDate),
			new SqlParameter("@ConvertTime", convertLog.ConvertTime),
			new SqlParameter("@ErrorMessage", convertLog.ErrorMessage),
			new SqlParameter("@TaxOfficeCode", convertLog.TaxOfficeCode),
			new SqlParameter("@ErrorCode", convertLog.ErrorCode),
			new SqlParameter("@ConvertStatus", convertLog.ConvertStatus),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ConvertLog_SearchLike", CommandType.StoredProcedure, parametersConvertLog))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					ConvertLog tmpConvertLog = new ConvertLog();
					tmpConvertLog.ConvertLogID = (row["ConvertLogID"] != DBNull.Value) ? Convert.ToInt64(row["ConvertLogID"]) : 0 ;
					tmpConvertLog.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					tmpConvertLog.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					tmpConvertLog.TableName = row["TableName"].ToString();
					tmpConvertLog.ConvertDate = row["ConvertDate"].ToString();
					tmpConvertLog.ConvertTime = row["ConvertTime"].ToString();
					tmpConvertLog.ErrorMessage = row["ErrorMessage"].ToString();
					tmpConvertLog.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
					tmpConvertLog.ErrorCode = (row["ErrorCode"] != DBNull.Value) ? Convert.ToInt32(row["ErrorCode"]) : 0 ;
					tmpConvertLog.ConvertStatus = (row["ConvertStatus"] != DBNull.Value) ? Convert.ToBoolean((row["ConvertStatus"].ToString() == "1" || row["ConvertStatus"].ToString().ToLower() == "true" ) ? true : false) : false ;

					listConvertLog.Add(tmpConvertLog);
				}
			}
		}

		return listConvertLog;
	}

}
}
