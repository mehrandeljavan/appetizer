using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class ReportsDBAccess
{


	public Int64 Insert(Reports reports)
	{
		SqlParameter[] parametersReports = new SqlParameter[]
		{
			new SqlParameter("@ReportTypeID", (reports.ReportTypeID > 0) ? reports.ReportTypeID : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (reports.RegisterInformationID > 0) ? reports.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@DossierID", (reports.DossierID > 0) ? reports.DossierID : (object)DBNull.Value),
			new SqlParameter("@ReportDate", (reports.ReportDate != null) ? reports.ReportDate : (object)DBNull.Value),
			new SqlParameter("@Body", (reports.Body != null) ? reports.Body : (object)DBNull.Value)
		};
		reports.ReportsID = SqlDBHelper.ExecuteScalar("Reports_Insert", CommandType.StoredProcedure, parametersReports);
		return reports.ReportsID;
	}

	public bool Update(Reports reports)
	{
		SqlParameter[] parametersReports = new SqlParameter[]
		{
			new SqlParameter("@ReportsID", reports.ReportsID),
			new SqlParameter("@ReportTypeID", (reports.ReportTypeID != null && reports.ReportTypeID >0 ) ? reports.ReportTypeID : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", reports.RegisterInformationID),
			new SqlParameter("@DossierID", (reports.DossierID != null && reports.DossierID >0 ) ? reports.DossierID : (object)DBNull.Value),
			new SqlParameter("@ReportDate", (reports.ReportDate != null) ? reports.ReportDate : (object)DBNull.Value),
			new SqlParameter("@Body", (reports.Body != null) ? reports.Body : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Reports_Update", CommandType.StoredProcedure, parametersReports);
	}

	public bool Delete(Int64 reportsID)
	{
		SqlParameter[] parametersReports = new SqlParameter[]
		{
			new SqlParameter("@ReportsID", reportsID)
		};
		return SqlDBHelper.ExecuteNonQuery("Reports_Delete", CommandType.StoredProcedure, parametersReports);
	}

	public Reports GetDetails(Int64 reportsID)
	{
		Reports reports = new Reports();

		SqlParameter[] parametersReports = new SqlParameter[]
		{
			new SqlParameter("@ReportsID", reportsID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Reports_GetDetails", CommandType.StoredProcedure, parametersReports))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				reports.ReportsID = (row["ReportsID"] != DBNull.Value) ? Convert.ToInt64(row["ReportsID"]) : 0 ;
				reports.ReportTypeIDTitle = row["ReportTypeIDTitle"].ToString();
				reports.OldRegisterDate = row["OldRegisterDate"].ToString();
				reports.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
				reports.ReportTypeID = (row["ReportTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ReportTypeID"]) : 0 ;
				reports.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
				reports.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
				reports.ReportDate = row["ReportDate"].ToString();
				reports.Body = row["Body"].ToString();
			}
		}

		return reports;
	}

	public List<Reports> GetListAll()
	{
		List<Reports> listReports = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Reports_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listReports = new List<Reports>();

				foreach (DataRow row in table.Rows)
				{
					Reports reports = new Reports();
					reports.ReportsID = (row["ReportsID"] != DBNull.Value) ? Convert.ToInt64(row["ReportsID"]) : 0 ;
					reports.ReportTypeIDTitle = row["ReportTypeIDTitle"].ToString();
					reports.OldRegisterDate = row["OldRegisterDate"].ToString();
					reports.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					reports.ReportTypeID = (row["ReportTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ReportTypeID"]) : 0 ;
					reports.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					reports.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					reports.ReportDate = row["ReportDate"].ToString();
					reports.Body = row["Body"].ToString();
					listReports.Add(reports);
				}
			}
		}

		return listReports;
	}

	public bool Exists(Int64 reportsID)
	{
		SqlParameter[] parametersReports = new SqlParameter[]
		{
			new SqlParameter("@ReportsID", reportsID)
		};
		return (SqlDBHelper.ExecuteScalar("Reports_Exists", CommandType.StoredProcedure, parametersReports)>0);
	}

	public bool Exists(Reports reports)
	{
		SqlParameter[] parametersReports = new SqlParameter[]
		{
			new SqlParameter("@ReportsID", reports.ReportsID)
		};
		return (SqlDBHelper.ExecuteScalar("Reports_Exists", CommandType.StoredProcedure, parametersReports)>0);
	}

	public List<Reports> SearchLike(Reports reports)
	{
		List<Reports> listReports = new List<Reports>();


		SqlParameter[] parametersReports = new SqlParameter[]
		{
			new SqlParameter("@ReportsID", reports.ReportsID),
			new SqlParameter("@ReportTypeIDTitle", reports.ReportTypeIDTitle),
			new SqlParameter("@OldRegisterDate", reports.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", reports.OldRegisterInformationID),
			new SqlParameter("@ReportTypeID", reports.ReportTypeID),
			new SqlParameter("@RegisterInformationID", reports.RegisterInformationID),
			new SqlParameter("@DossierID", reports.DossierID),
			new SqlParameter("@ReportDate", reports.ReportDate),
			new SqlParameter("@Body", reports.Body),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Reports_SearchLike", CommandType.StoredProcedure, parametersReports))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Reports tmpReports = new Reports();
					tmpReports.ReportsID = (row["ReportsID"] != DBNull.Value) ? Convert.ToInt64(row["ReportsID"]) : 0 ;
					tmpReports.ReportTypeIDTitle = row["ReportTypeIDTitle"].ToString();
					tmpReports.OldRegisterDate = row["OldRegisterDate"].ToString();
					tmpReports.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					tmpReports.ReportTypeID = (row["ReportTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ReportTypeID"]) : 0 ;
					tmpReports.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					tmpReports.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					tmpReports.ReportDate = row["ReportDate"].ToString();
					tmpReports.Body = row["Body"].ToString();

					listReports.Add(tmpReports);
				}
			}
		}

		return listReports;
	}

}
}
