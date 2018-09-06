using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class RequestDBAccess
{


	public Int64 Insert(Request request)
	{
		SqlParameter[] parametersRequest = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", (request.DeclarationID > 0) ? request.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@RequestDate", (request.RequestDate != null) ? request.RequestDate : (object)DBNull.Value),
			new SqlParameter("@RequestResource", (request.RequestResource != null) ? request.RequestResource : (object)DBNull.Value),
			new SqlParameter("@RequestNumber", (request.RequestNumber != null) ? request.RequestNumber : (object)DBNull.Value)
		};
		request.RequestID = SqlDBHelper.ExecuteScalar("Request_Insert", CommandType.StoredProcedure, parametersRequest);
		return request.RequestID;
	}

	public bool Update(Request request)
	{
		SqlParameter[] parametersRequest = new SqlParameter[]
		{
			new SqlParameter("@RequestID", request.RequestID),
			new SqlParameter("@DeclarationID", (request.DeclarationID != null && request.DeclarationID >0 ) ? request.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@RequestDate", (request.RequestDate != null) ? request.RequestDate : (object)DBNull.Value),
			new SqlParameter("@RequestResource", (request.RequestResource != null) ? request.RequestResource : (object)DBNull.Value),
			new SqlParameter("@RequestNumber", (request.RequestNumber != null) ? request.RequestNumber : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Request_Update", CommandType.StoredProcedure, parametersRequest);
	}

	public bool Delete(Int64 requestID)
	{
		SqlParameter[] parametersRequest = new SqlParameter[]
		{
			new SqlParameter("@RequestID", requestID)
		};
		return SqlDBHelper.ExecuteNonQuery("Request_Delete", CommandType.StoredProcedure, parametersRequest);
	}

	public Request GetDetails(Int64 requestID)
	{
		Request request = new Request();

		SqlParameter[] parametersRequest = new SqlParameter[]
		{
			new SqlParameter("@RequestID", requestID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Request_GetDetails", CommandType.StoredProcedure, parametersRequest))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				request.RequestID = (row["RequestID"] != DBNull.Value) ? Convert.ToInt64(row["RequestID"]) : 0 ;
				request.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				request.RequestDate = row["RequestDate"].ToString();
				request.RequestResource = row["RequestResource"].ToString();
				request.RequestNumber = row["RequestNumber"].ToString();
			}
		}

		return request;
	}

	public List<Request> GetListAll()
	{
		List<Request> listRequest = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Request_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listRequest = new List<Request>();

				foreach (DataRow row in table.Rows)
				{
					Request request = new Request();
					request.RequestID = (row["RequestID"] != DBNull.Value) ? Convert.ToInt64(row["RequestID"]) : 0 ;
					request.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					request.RequestDate = row["RequestDate"].ToString();
					request.RequestResource = row["RequestResource"].ToString();
					request.RequestNumber = row["RequestNumber"].ToString();
					listRequest.Add(request);
				}
			}
		}

		return listRequest;
	}

	public bool Exists(Int64 requestID)
	{
		SqlParameter[] parametersRequest = new SqlParameter[]
		{
			new SqlParameter("@RequestID", requestID)
		};
		return (SqlDBHelper.ExecuteScalar("Request_Exists", CommandType.StoredProcedure, parametersRequest)>0);
	}

	public bool Exists(Request request)
	{
		SqlParameter[] parametersRequest = new SqlParameter[]
		{
			new SqlParameter("@RequestID", request.RequestID)
		};
		return (SqlDBHelper.ExecuteScalar("Request_Exists", CommandType.StoredProcedure, parametersRequest)>0);
	}

	public List<Request> SearchLike(Request request)
	{
		List<Request> listRequest = new List<Request>();


		SqlParameter[] parametersRequest = new SqlParameter[]
		{
			new SqlParameter("@RequestID", request.RequestID),
			new SqlParameter("@DeclarationID", request.DeclarationID),
			new SqlParameter("@RequestDate", request.RequestDate),
			new SqlParameter("@RequestResource", request.RequestResource),
			new SqlParameter("@RequestNumber", request.RequestNumber),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Request_SearchLike", CommandType.StoredProcedure, parametersRequest))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Request tmpRequest = new Request();
					tmpRequest.RequestID = (row["RequestID"] != DBNull.Value) ? Convert.ToInt64(row["RequestID"]) : 0 ;
					tmpRequest.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpRequest.RequestDate = row["RequestDate"].ToString();
					tmpRequest.RequestResource = row["RequestResource"].ToString();
					tmpRequest.RequestNumber = row["RequestNumber"].ToString();

					listRequest.Add(tmpRequest);
				}
			}
		}

		return listRequest;
	}

}
}
