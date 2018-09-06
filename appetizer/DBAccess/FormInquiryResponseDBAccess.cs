using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormInquiryResponseDBAccess
{


	public Int64 Insert(FormInquiryResponse formInquiryResponse)
	{
		SqlParameter[] parametersFormInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", (formInquiryResponse.RegisterInformationID > 0) ? formInquiryResponse.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@InquiryRegisterInformationID", (formInquiryResponse.InquiryRegisterInformationID != null) ? formInquiryResponse.InquiryRegisterInformationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("FormInquiryResponse_Insert", CommandType.StoredProcedure, parametersFormInquiryResponse);
	}

	public bool Update(FormInquiryResponse formInquiryResponse)
	{
		SqlParameter[] parametersFormInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", (formInquiryResponse.RegisterInformationID != null) ? formInquiryResponse.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@InquiryRegisterInformationID", (formInquiryResponse.InquiryRegisterInformationID != null) ? formInquiryResponse.InquiryRegisterInformationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryResponse_Update", CommandType.StoredProcedure, parametersFormInquiryResponse);
	}

	public bool Delete(Int64 registerInformationID)
	{
		SqlParameter[] parametersFormInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryResponse_Delete", CommandType.StoredProcedure, parametersFormInquiryResponse);
	}

	public FormInquiryResponse GetDetails(Int64 registerInformationID)
	{
		FormInquiryResponse formInquiryResponse = new FormInquiryResponse();

		SqlParameter[] parametersFormInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryResponse_GetDetails", CommandType.StoredProcedure, parametersFormInquiryResponse))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				formInquiryResponse.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
				formInquiryResponse.InquiryRegisterInformationID = (row["InquiryRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["InquiryRegisterInformationID"]) : 0 ;
			}
		}

		return formInquiryResponse;
	}

	public List<FormInquiryResponse> GetListAll()
	{
		List<FormInquiryResponse> listFormInquiryResponse = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormInquiryResponse_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormInquiryResponse = new List<FormInquiryResponse>();

				foreach (DataRow row in table.Rows)
				{
					FormInquiryResponse formInquiryResponse = new FormInquiryResponse();
					formInquiryResponse.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					formInquiryResponse.InquiryRegisterInformationID = (row["InquiryRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["InquiryRegisterInformationID"]) : 0 ;
					listFormInquiryResponse.Add(formInquiryResponse);
				}
			}
		}

		return listFormInquiryResponse;
	}

	public bool Exists(Int64 registerInformationID)
	{
		SqlParameter[] parametersFormInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryResponse_Exists", CommandType.StoredProcedure, parametersFormInquiryResponse)>0);
	}

	public bool Exists(FormInquiryResponse formInquiryResponse)
	{
		SqlParameter[] parametersFormInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", formInquiryResponse.RegisterInformationID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryResponse_Exists", CommandType.StoredProcedure, parametersFormInquiryResponse)>0);
	}

	public List<FormInquiryResponse> SearchLike(FormInquiryResponse formInquiryResponse)
	{
		List<FormInquiryResponse> listFormInquiryResponse = new List<FormInquiryResponse>();


		SqlParameter[] parametersFormInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", formInquiryResponse.RegisterInformationID),
			new SqlParameter("@InquiryRegisterInformationID", formInquiryResponse.InquiryRegisterInformationID),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryResponse_SearchLike", CommandType.StoredProcedure, parametersFormInquiryResponse))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormInquiryResponse tmpFormInquiryResponse = new FormInquiryResponse();
					tmpFormInquiryResponse.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					tmpFormInquiryResponse.InquiryRegisterInformationID = (row["InquiryRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["InquiryRegisterInformationID"]) : 0 ;

					listFormInquiryResponse.Add(tmpFormInquiryResponse);
				}
			}
		}

		return listFormInquiryResponse;
	}

}
}
