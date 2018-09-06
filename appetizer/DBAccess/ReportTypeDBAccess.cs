using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class ReportTypeDBAccess
{

	ReportsDBAccess reportsDBAccess = new ReportsDBAccess();

	public List<Reports> GetListReports(int reportTypeID)
	{
		List<Reports> listReports = new List<Reports>() { };
		SqlParameter[] parametersReportType = new SqlParameter[]
		{
			new SqlParameter("@ReportTypeID", reportTypeID)
		};

		//Lets get the list of Reports records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Reports_GetList_UseInReportType", CommandType.StoredProcedure, parametersReportType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of reports
				listReports = new List<Reports>();

				//Now lets populate the Reports details into the list of reportss
				foreach (DataRow row in table.Rows)
				{
					Reports reports = ConvertRowToReports(row);
					listReports.Add(reports);
				}
			}
		}

		return listReports;
	}

	private Reports ConvertRowToReports(DataRow row)
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
		return reports;
	}
	public Int64 Insert(ReportType reportType)
	{
		SqlParameter[] parametersReportType = new SqlParameter[]
		{
			new SqlParameter("@Title", reportType.Title)
		};
		reportType.ReportTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("ReportType_Insert", CommandType.StoredProcedure, parametersReportType));
		return reportType.ReportTypeID;
	}

	public bool Update(ReportType reportType)
	{
		SqlParameter[] parametersReportType = new SqlParameter[]
		{
			new SqlParameter("@ReportTypeID", reportType.ReportTypeID),
			new SqlParameter("@Title", reportType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("ReportType_Update", CommandType.StoredProcedure, parametersReportType);
	}

	public bool Delete(int reportTypeID)
	{
		SqlParameter[] parametersReportType = new SqlParameter[]
		{
			new SqlParameter("@ReportTypeID", reportTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("ReportType_Delete", CommandType.StoredProcedure, parametersReportType);
	}

	public ReportType GetDetails(int reportTypeID)
	{
		ReportType reportType = new ReportType();

		SqlParameter[] parametersReportType = new SqlParameter[]
		{
			new SqlParameter("@ReportTypeID", reportTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ReportType_GetDetails", CommandType.StoredProcedure, parametersReportType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				reportType.ReportTypeID = (row["ReportTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ReportTypeID"]) : 0 ;
				reportType.Title = row["Title"].ToString();
			}
		}

		return reportType;
	}

	public List<ReportType> GetListAll()
	{
		List<ReportType> listReportType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("ReportType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listReportType = new List<ReportType>();

				foreach (DataRow row in table.Rows)
				{
					ReportType reportType = new ReportType();
					reportType.ReportTypeID = (row["ReportTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ReportTypeID"]) : 0 ;
					reportType.Title = row["Title"].ToString();
					listReportType.Add(reportType);
				}
			}
		}

		return listReportType;
	}

	public bool Exists(int reportTypeID)
	{
		SqlParameter[] parametersReportType = new SqlParameter[]
		{
			new SqlParameter("@ReportTypeID", reportTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("ReportType_Exists", CommandType.StoredProcedure, parametersReportType)>0);
	}

	public bool Exists(ReportType reportType)
	{
		SqlParameter[] parametersReportType = new SqlParameter[]
		{
			new SqlParameter("@ReportTypeID", reportType.ReportTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("ReportType_Exists", CommandType.StoredProcedure, parametersReportType)>0);
	}

	public List<ReportType> SearchLike(ReportType reportType)
	{
		List<ReportType> listReportType = new List<ReportType>();


		SqlParameter[] parametersReportType = new SqlParameter[]
		{
			new SqlParameter("@ReportTypeID", reportType.ReportTypeID),
			new SqlParameter("@Title", reportType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ReportType_SearchLike", CommandType.StoredProcedure, parametersReportType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					ReportType tmpReportType = new ReportType();
					tmpReportType.ReportTypeID = (row["ReportTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ReportTypeID"]) : 0 ;
					tmpReportType.Title = row["Title"].ToString();

					listReportType.Add(tmpReportType);
				}
			}
		}

		return listReportType;
	}

}
}
