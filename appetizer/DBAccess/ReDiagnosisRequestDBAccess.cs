using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class ReDiagnosisRequestDBAccess
{


	public Int64 Insert(ReDiagnosisRequest reDiagnosisRequest)
	{
		SqlParameter[] parametersReDiagnosisRequest = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", (reDiagnosisRequest.DeclarationID > 0) ? reDiagnosisRequest.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (reDiagnosisRequest.RegisterInformationID > 0) ? reDiagnosisRequest.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@RequestDate", (reDiagnosisRequest.RequestDate != null) ? reDiagnosisRequest.RequestDate : (object)DBNull.Value)
		};
		reDiagnosisRequest.ReDiagnosisRequestID = SqlDBHelper.ExecuteScalar("ReDiagnosisRequest_Insert", CommandType.StoredProcedure, parametersReDiagnosisRequest);
		return reDiagnosisRequest.ReDiagnosisRequestID;
	}

	public bool Update(ReDiagnosisRequest reDiagnosisRequest)
	{
		SqlParameter[] parametersReDiagnosisRequest = new SqlParameter[]
		{
			new SqlParameter("@ReDiagnosisRequestID", reDiagnosisRequest.ReDiagnosisRequestID),
			new SqlParameter("@DeclarationID", reDiagnosisRequest.DeclarationID),
			new SqlParameter("@RegisterInformationID", reDiagnosisRequest.RegisterInformationID),
			new SqlParameter("@RequestDate", (reDiagnosisRequest.RequestDate != null) ? reDiagnosisRequest.RequestDate : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("ReDiagnosisRequest_Update", CommandType.StoredProcedure, parametersReDiagnosisRequest);
	}

	public bool Delete(Int64 reDiagnosisRequestID)
	{
		SqlParameter[] parametersReDiagnosisRequest = new SqlParameter[]
		{
			new SqlParameter("@ReDiagnosisRequestID", reDiagnosisRequestID)
		};
		return SqlDBHelper.ExecuteNonQuery("ReDiagnosisRequest_Delete", CommandType.StoredProcedure, parametersReDiagnosisRequest);
	}

	public ReDiagnosisRequest GetDetails(Int64 reDiagnosisRequestID)
	{
		ReDiagnosisRequest reDiagnosisRequest = new ReDiagnosisRequest();

		SqlParameter[] parametersReDiagnosisRequest = new SqlParameter[]
		{
			new SqlParameter("@ReDiagnosisRequestID", reDiagnosisRequestID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ReDiagnosisRequest_GetDetails", CommandType.StoredProcedure, parametersReDiagnosisRequest))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				reDiagnosisRequest.ReDiagnosisRequestID = (row["ReDiagnosisRequestID"] != DBNull.Value) ? Convert.ToInt64(row["ReDiagnosisRequestID"]) : 0 ;
				reDiagnosisRequest.PrintRegisterDate = row["PrintRegisterDate"].ToString();
				reDiagnosisRequest.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				reDiagnosisRequest.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
				reDiagnosisRequest.RequestDate = row["RequestDate"].ToString();
			}
		}

		return reDiagnosisRequest;
	}

	public List<ReDiagnosisRequest> GetListAll()
	{
		List<ReDiagnosisRequest> listReDiagnosisRequest = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("ReDiagnosisRequest_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listReDiagnosisRequest = new List<ReDiagnosisRequest>();

				foreach (DataRow row in table.Rows)
				{
					ReDiagnosisRequest reDiagnosisRequest = new ReDiagnosisRequest();
					reDiagnosisRequest.ReDiagnosisRequestID = (row["ReDiagnosisRequestID"] != DBNull.Value) ? Convert.ToInt64(row["ReDiagnosisRequestID"]) : 0 ;
					reDiagnosisRequest.PrintRegisterDate = row["PrintRegisterDate"].ToString();
					reDiagnosisRequest.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					reDiagnosisRequest.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					reDiagnosisRequest.RequestDate = row["RequestDate"].ToString();
					listReDiagnosisRequest.Add(reDiagnosisRequest);
				}
			}
		}

		return listReDiagnosisRequest;
	}

	public bool Exists(Int64 reDiagnosisRequestID)
	{
		SqlParameter[] parametersReDiagnosisRequest = new SqlParameter[]
		{
			new SqlParameter("@ReDiagnosisRequestID", reDiagnosisRequestID)
		};
		return (SqlDBHelper.ExecuteScalar("ReDiagnosisRequest_Exists", CommandType.StoredProcedure, parametersReDiagnosisRequest)>0);
	}

	public bool Exists(ReDiagnosisRequest reDiagnosisRequest)
	{
		SqlParameter[] parametersReDiagnosisRequest = new SqlParameter[]
		{
			new SqlParameter("@ReDiagnosisRequestID", reDiagnosisRequest.ReDiagnosisRequestID)
		};
		return (SqlDBHelper.ExecuteScalar("ReDiagnosisRequest_Exists", CommandType.StoredProcedure, parametersReDiagnosisRequest)>0);
	}

	public List<ReDiagnosisRequest> SearchLike(ReDiagnosisRequest reDiagnosisRequest)
	{
		List<ReDiagnosisRequest> listReDiagnosisRequest = new List<ReDiagnosisRequest>();


		SqlParameter[] parametersReDiagnosisRequest = new SqlParameter[]
		{
			new SqlParameter("@ReDiagnosisRequestID", reDiagnosisRequest.ReDiagnosisRequestID),
			new SqlParameter("@PrintRegisterDate", reDiagnosisRequest.PrintRegisterDate),
			new SqlParameter("@DeclarationID", reDiagnosisRequest.DeclarationID),
			new SqlParameter("@RegisterInformationID", reDiagnosisRequest.RegisterInformationID),
			new SqlParameter("@RequestDate", reDiagnosisRequest.RequestDate),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ReDiagnosisRequest_SearchLike", CommandType.StoredProcedure, parametersReDiagnosisRequest))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					ReDiagnosisRequest tmpReDiagnosisRequest = new ReDiagnosisRequest();
					tmpReDiagnosisRequest.ReDiagnosisRequestID = (row["ReDiagnosisRequestID"] != DBNull.Value) ? Convert.ToInt64(row["ReDiagnosisRequestID"]) : 0 ;
					tmpReDiagnosisRequest.PrintRegisterDate = row["PrintRegisterDate"].ToString();
					tmpReDiagnosisRequest.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpReDiagnosisRequest.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					tmpReDiagnosisRequest.RequestDate = row["RequestDate"].ToString();

					listReDiagnosisRequest.Add(tmpReDiagnosisRequest);
				}
			}
		}

		return listReDiagnosisRequest;
	}

}
}
