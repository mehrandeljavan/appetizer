using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormHeritagesDescriptionsDBAccess
{


	public Int64 Insert(FormHeritagesDescriptions formHeritagesDescriptions)
	{
		SqlParameter[] parametersFormHeritagesDescriptions = new SqlParameter[]
		{
			new SqlParameter("@FormHeritagesDescriptionsDeclarationID", (formHeritagesDescriptions.FormHeritagesDescriptionsDeclarationID > 0) ? formHeritagesDescriptions.FormHeritagesDescriptionsDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormHeritagesDescriptionsRegisterarUserNationalCode", (formHeritagesDescriptions.FormHeritagesDescriptionsRegisterarUserNationalCode > 0) ? formHeritagesDescriptions.FormHeritagesDescriptionsRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritagesDescriptionsDescription", (formHeritagesDescriptions.FormHeritagesDescriptionsDescription != null) ? formHeritagesDescriptions.FormHeritagesDescriptionsDescription : (object)DBNull.Value)
		};
		formHeritagesDescriptions.FormHeritagesDescriptionsID = SqlDBHelper.ExecuteScalar("FormHeritagesDescriptions_Insert", CommandType.StoredProcedure, parametersFormHeritagesDescriptions);
		return formHeritagesDescriptions.FormHeritagesDescriptionsID;
	}

	public bool Update(FormHeritagesDescriptions formHeritagesDescriptions)
	{
		SqlParameter[] parametersFormHeritagesDescriptions = new SqlParameter[]
		{
			new SqlParameter("@FormHeritagesDescriptionsID", formHeritagesDescriptions.FormHeritagesDescriptionsID),
			new SqlParameter("@FormHeritagesDescriptionsDeclarationID", (formHeritagesDescriptions.FormHeritagesDescriptionsDeclarationID != null && formHeritagesDescriptions.FormHeritagesDescriptionsDeclarationID >0 ) ? formHeritagesDescriptions.FormHeritagesDescriptionsDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormHeritagesDescriptionsRegisterarUserNationalCode", (formHeritagesDescriptions.FormHeritagesDescriptionsRegisterarUserNationalCode != null && formHeritagesDescriptions.FormHeritagesDescriptionsRegisterarUserNationalCode >0 ) ? formHeritagesDescriptions.FormHeritagesDescriptionsRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritagesDescriptionsDescription", (formHeritagesDescriptions.FormHeritagesDescriptionsDescription != null) ? formHeritagesDescriptions.FormHeritagesDescriptionsDescription : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormHeritagesDescriptions_Update", CommandType.StoredProcedure, parametersFormHeritagesDescriptions);
	}

	public bool Delete(Int64 formHeritagesDescriptionsID)
	{
		SqlParameter[] parametersFormHeritagesDescriptions = new SqlParameter[]
		{
			new SqlParameter("@FormHeritagesDescriptionsID", formHeritagesDescriptionsID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormHeritagesDescriptions_Delete", CommandType.StoredProcedure, parametersFormHeritagesDescriptions);
	}

	public FormHeritagesDescriptions GetDetails(Int64 formHeritagesDescriptionsID)
	{
		FormHeritagesDescriptions formHeritagesDescriptions = new FormHeritagesDescriptions();

		SqlParameter[] parametersFormHeritagesDescriptions = new SqlParameter[]
		{
			new SqlParameter("@FormHeritagesDescriptionsID", formHeritagesDescriptionsID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritagesDescriptions_GetDetails", CommandType.StoredProcedure, parametersFormHeritagesDescriptions))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				formHeritagesDescriptions.FormHeritagesDescriptionsID = (row["FormHeritagesDescriptionsID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritagesDescriptionsID"]) : 0 ;
				formHeritagesDescriptions.FormHeritagesDescriptionsDeclarationID = (row["FormHeritagesDescriptionsDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritagesDescriptionsDeclarationID"]) : 0 ;
				formHeritagesDescriptions.FormHeritagesDescriptionsRegisterarUserNationalCode = (row["FormHeritagesDescriptionsRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritagesDescriptionsRegisterarUserNationalCode"]) : 0 ;
				formHeritagesDescriptions.FormHeritagesDescriptionsDescription = row["FormHeritagesDescriptionsDescription"].ToString();
			}
		}

		return formHeritagesDescriptions;
	}

	public List<FormHeritagesDescriptions> GetListAll()
	{
		List<FormHeritagesDescriptions> listFormHeritagesDescriptions = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormHeritagesDescriptions_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormHeritagesDescriptions = new List<FormHeritagesDescriptions>();

				foreach (DataRow row in table.Rows)
				{
					FormHeritagesDescriptions formHeritagesDescriptions = new FormHeritagesDescriptions();
					formHeritagesDescriptions.FormHeritagesDescriptionsID = (row["FormHeritagesDescriptionsID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritagesDescriptionsID"]) : 0 ;
					formHeritagesDescriptions.FormHeritagesDescriptionsDeclarationID = (row["FormHeritagesDescriptionsDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritagesDescriptionsDeclarationID"]) : 0 ;
					formHeritagesDescriptions.FormHeritagesDescriptionsRegisterarUserNationalCode = (row["FormHeritagesDescriptionsRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritagesDescriptionsRegisterarUserNationalCode"]) : 0 ;
					formHeritagesDescriptions.FormHeritagesDescriptionsDescription = row["FormHeritagesDescriptionsDescription"].ToString();
					listFormHeritagesDescriptions.Add(formHeritagesDescriptions);
				}
			}
		}

		return listFormHeritagesDescriptions;
	}

	public bool Exists(Int64 formHeritagesDescriptionsID)
	{
		SqlParameter[] parametersFormHeritagesDescriptions = new SqlParameter[]
		{
			new SqlParameter("@FormHeritagesDescriptionsID", formHeritagesDescriptionsID)
		};
		return (SqlDBHelper.ExecuteScalar("FormHeritagesDescriptions_Exists", CommandType.StoredProcedure, parametersFormHeritagesDescriptions)>0);
	}

	public bool Exists(FormHeritagesDescriptions formHeritagesDescriptions)
	{
		SqlParameter[] parametersFormHeritagesDescriptions = new SqlParameter[]
		{
			new SqlParameter("@FormHeritagesDescriptionsID", formHeritagesDescriptions.FormHeritagesDescriptionsID)
		};
		return (SqlDBHelper.ExecuteScalar("FormHeritagesDescriptions_Exists", CommandType.StoredProcedure, parametersFormHeritagesDescriptions)>0);
	}

	public List<FormHeritagesDescriptions> SearchLike(FormHeritagesDescriptions formHeritagesDescriptions)
	{
		List<FormHeritagesDescriptions> listFormHeritagesDescriptions = new List<FormHeritagesDescriptions>();


		SqlParameter[] parametersFormHeritagesDescriptions = new SqlParameter[]
		{
			new SqlParameter("@FormHeritagesDescriptionsID", formHeritagesDescriptions.FormHeritagesDescriptionsID),
			new SqlParameter("@FormHeritagesDescriptionsDeclarationID", formHeritagesDescriptions.FormHeritagesDescriptionsDeclarationID),
			new SqlParameter("@FormHeritagesDescriptionsRegisterarUserNationalCode", formHeritagesDescriptions.FormHeritagesDescriptionsRegisterarUserNationalCode),
			new SqlParameter("@FormHeritagesDescriptionsDescription", formHeritagesDescriptions.FormHeritagesDescriptionsDescription),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritagesDescriptions_SearchLike", CommandType.StoredProcedure, parametersFormHeritagesDescriptions))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormHeritagesDescriptions tmpFormHeritagesDescriptions = new FormHeritagesDescriptions();
					tmpFormHeritagesDescriptions.FormHeritagesDescriptionsID = (row["FormHeritagesDescriptionsID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritagesDescriptionsID"]) : 0 ;
					tmpFormHeritagesDescriptions.FormHeritagesDescriptionsDeclarationID = (row["FormHeritagesDescriptionsDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritagesDescriptionsDeclarationID"]) : 0 ;
					tmpFormHeritagesDescriptions.FormHeritagesDescriptionsRegisterarUserNationalCode = (row["FormHeritagesDescriptionsRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritagesDescriptionsRegisterarUserNationalCode"]) : 0 ;
					tmpFormHeritagesDescriptions.FormHeritagesDescriptionsDescription = row["FormHeritagesDescriptionsDescription"].ToString();

					listFormHeritagesDescriptions.Add(tmpFormHeritagesDescriptions);
				}
			}
		}

		return listFormHeritagesDescriptions;
	}

}
}
