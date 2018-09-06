using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormHeritageListDBAccess
{


	public Int64 Insert(FormHeritageList formHeritageList)
	{
		SqlParameter[] parametersFormHeritageList = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageListDeclarationID", (formHeritageList.FormHeritageListDeclarationID > 0) ? formHeritageList.FormHeritageListDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListRegisterarUserNationalCode", (formHeritageList.FormHeritageListRegisterarUserNationalCode > 0) ? formHeritageList.FormHeritageListRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListIssuanceDate", (formHeritageList.FormHeritageListIssuanceDate != null) ? formHeritageList.FormHeritageListIssuanceDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListDeathDate", (formHeritageList.FormHeritageListDeathDate != null) ? formHeritageList.FormHeritageListDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListRegisterInformationDate", (formHeritageList.FormHeritageListRegisterInformationDate != null) ? formHeritageList.FormHeritageListRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListType", (formHeritageList.FormHeritageListType != null) ? formHeritageList.FormHeritageListType : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListDeadFullName", (formHeritageList.FormHeritageListDeadFullName != null) ? formHeritageList.FormHeritageListDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListTaxOfficeTitle", (formHeritageList.FormHeritageListTaxOfficeTitle != null) ? formHeritageList.FormHeritageListTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListDescriptions", (formHeritageList.FormHeritageListDescriptions != null) ? formHeritageList.FormHeritageListDescriptions : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListDossierClasses", (formHeritageList.FormHeritageListDossierClasses != null) ? formHeritageList.FormHeritageListDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListItemCount", (formHeritageList.FormHeritageListItemCount != null) ? formHeritageList.FormHeritageListItemCount : (object)DBNull.Value)
		};
		formHeritageList.FormHeritageListID = SqlDBHelper.ExecuteScalar("FormHeritageList_Insert", CommandType.StoredProcedure, parametersFormHeritageList);
		return formHeritageList.FormHeritageListID;
	}

	public bool Update(FormHeritageList formHeritageList)
	{
		SqlParameter[] parametersFormHeritageList = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageListID", formHeritageList.FormHeritageListID),
			new SqlParameter("@FormHeritageListDeclarationID", formHeritageList.FormHeritageListDeclarationID),
			new SqlParameter("@FormHeritageListRegisterarUserNationalCode", (formHeritageList.FormHeritageListRegisterarUserNationalCode != null && formHeritageList.FormHeritageListRegisterarUserNationalCode >0 ) ? formHeritageList.FormHeritageListRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListIssuanceDate", (formHeritageList.FormHeritageListIssuanceDate != null) ? formHeritageList.FormHeritageListIssuanceDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListDeathDate", (formHeritageList.FormHeritageListDeathDate != null) ? formHeritageList.FormHeritageListDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListRegisterInformationDate", (formHeritageList.FormHeritageListRegisterInformationDate != null) ? formHeritageList.FormHeritageListRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListType", (formHeritageList.FormHeritageListType != null) ? formHeritageList.FormHeritageListType : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListDeadFullName", (formHeritageList.FormHeritageListDeadFullName != null) ? formHeritageList.FormHeritageListDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListTaxOfficeTitle", (formHeritageList.FormHeritageListTaxOfficeTitle != null) ? formHeritageList.FormHeritageListTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListDescriptions", (formHeritageList.FormHeritageListDescriptions != null) ? formHeritageList.FormHeritageListDescriptions : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListDossierClasses", (formHeritageList.FormHeritageListDossierClasses != null) ? formHeritageList.FormHeritageListDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormHeritageListItemCount", (formHeritageList.FormHeritageListItemCount != null) ? formHeritageList.FormHeritageListItemCount : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormHeritageList_Update", CommandType.StoredProcedure, parametersFormHeritageList);
	}

	public bool Delete(Int64 formHeritageListID)
	{
		SqlParameter[] parametersFormHeritageList = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageListID", formHeritageListID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormHeritageList_Delete", CommandType.StoredProcedure, parametersFormHeritageList);
	}

	public FormHeritageList GetDetails(Int64 formHeritageListID)
	{
		FormHeritageList formHeritageList = new FormHeritageList();

		SqlParameter[] parametersFormHeritageList = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageListID", formHeritageListID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritageList_GetDetails", CommandType.StoredProcedure, parametersFormHeritageList))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				formHeritageList.FormHeritageListID = (row["FormHeritageListID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageListID"]) : 0 ;
				formHeritageList.FormHeritageListDeclarationID = (row["FormHeritageListDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageListDeclarationID"]) : 0 ;
				formHeritageList.FormHeritageListRegisterarUserNationalCode = (row["FormHeritageListRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageListRegisterarUserNationalCode"]) : 0 ;
				formHeritageList.FormHeritageListIssuanceDate = row["FormHeritageListIssuanceDate"].ToString();
				formHeritageList.FormHeritageListDeathDate = row["FormHeritageListDeathDate"].ToString();
				formHeritageList.FormHeritageListRegisterInformationDate = row["FormHeritageListRegisterInformationDate"].ToString();
				formHeritageList.FormHeritageListType = row["FormHeritageListType"].ToString();
				formHeritageList.FormHeritageListDeadFullName = row["FormHeritageListDeadFullName"].ToString();
				formHeritageList.FormHeritageListTaxOfficeTitle = row["FormHeritageListTaxOfficeTitle"].ToString();
				formHeritageList.FormHeritageListDescriptions = row["FormHeritageListDescriptions"].ToString();
				formHeritageList.FormHeritageListDossierClasses = row["FormHeritageListDossierClasses"].ToString();
				formHeritageList.FormHeritageListItemCount = (row["FormHeritageListItemCount"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageListItemCount"]) : 0 ;
			}
		}

		return formHeritageList;
	}

	public List<FormHeritageList> GetListAll()
	{
		List<FormHeritageList> listFormHeritageList = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormHeritageList_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormHeritageList = new List<FormHeritageList>();

				foreach (DataRow row in table.Rows)
				{
					FormHeritageList formHeritageList = new FormHeritageList();
					formHeritageList.FormHeritageListID = (row["FormHeritageListID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageListID"]) : 0 ;
					formHeritageList.FormHeritageListDeclarationID = (row["FormHeritageListDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageListDeclarationID"]) : 0 ;
					formHeritageList.FormHeritageListRegisterarUserNationalCode = (row["FormHeritageListRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageListRegisterarUserNationalCode"]) : 0 ;
					formHeritageList.FormHeritageListIssuanceDate = row["FormHeritageListIssuanceDate"].ToString();
					formHeritageList.FormHeritageListDeathDate = row["FormHeritageListDeathDate"].ToString();
					formHeritageList.FormHeritageListRegisterInformationDate = row["FormHeritageListRegisterInformationDate"].ToString();
					formHeritageList.FormHeritageListType = row["FormHeritageListType"].ToString();
					formHeritageList.FormHeritageListDeadFullName = row["FormHeritageListDeadFullName"].ToString();
					formHeritageList.FormHeritageListTaxOfficeTitle = row["FormHeritageListTaxOfficeTitle"].ToString();
					formHeritageList.FormHeritageListDescriptions = row["FormHeritageListDescriptions"].ToString();
					formHeritageList.FormHeritageListDossierClasses = row["FormHeritageListDossierClasses"].ToString();
					formHeritageList.FormHeritageListItemCount = (row["FormHeritageListItemCount"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageListItemCount"]) : 0 ;
					listFormHeritageList.Add(formHeritageList);
				}
			}
		}

		return listFormHeritageList;
	}

	public bool Exists(Int64 formHeritageListID)
	{
		SqlParameter[] parametersFormHeritageList = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageListID", formHeritageListID)
		};
		return (SqlDBHelper.ExecuteScalar("FormHeritageList_Exists", CommandType.StoredProcedure, parametersFormHeritageList)>0);
	}

	public bool Exists(FormHeritageList formHeritageList)
	{
		SqlParameter[] parametersFormHeritageList = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageListID", formHeritageList.FormHeritageListID)
		};
		return (SqlDBHelper.ExecuteScalar("FormHeritageList_Exists", CommandType.StoredProcedure, parametersFormHeritageList)>0);
	}

	public List<FormHeritageList> SearchLike(FormHeritageList formHeritageList)
	{
		List<FormHeritageList> listFormHeritageList = new List<FormHeritageList>();


		SqlParameter[] parametersFormHeritageList = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageListID", formHeritageList.FormHeritageListID),
			new SqlParameter("@FormHeritageListDeclarationID", formHeritageList.FormHeritageListDeclarationID),
			new SqlParameter("@FormHeritageListRegisterarUserNationalCode", formHeritageList.FormHeritageListRegisterarUserNationalCode),
			new SqlParameter("@FormHeritageListIssuanceDate", formHeritageList.FormHeritageListIssuanceDate),
			new SqlParameter("@FormHeritageListDeathDate", formHeritageList.FormHeritageListDeathDate),
			new SqlParameter("@FormHeritageListRegisterInformationDate", formHeritageList.FormHeritageListRegisterInformationDate),
			new SqlParameter("@FormHeritageListType", formHeritageList.FormHeritageListType),
			new SqlParameter("@FormHeritageListDeadFullName", formHeritageList.FormHeritageListDeadFullName),
			new SqlParameter("@FormHeritageListTaxOfficeTitle", formHeritageList.FormHeritageListTaxOfficeTitle),
			new SqlParameter("@FormHeritageListDescriptions", formHeritageList.FormHeritageListDescriptions),
			new SqlParameter("@FormHeritageListDossierClasses", formHeritageList.FormHeritageListDossierClasses),
			new SqlParameter("@FormHeritageListItemCount", formHeritageList.FormHeritageListItemCount),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritageList_SearchLike", CommandType.StoredProcedure, parametersFormHeritageList))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormHeritageList tmpFormHeritageList = new FormHeritageList();
					tmpFormHeritageList.FormHeritageListID = (row["FormHeritageListID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageListID"]) : 0 ;
					tmpFormHeritageList.FormHeritageListDeclarationID = (row["FormHeritageListDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageListDeclarationID"]) : 0 ;
					tmpFormHeritageList.FormHeritageListRegisterarUserNationalCode = (row["FormHeritageListRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageListRegisterarUserNationalCode"]) : 0 ;
					tmpFormHeritageList.FormHeritageListIssuanceDate = row["FormHeritageListIssuanceDate"].ToString();
					tmpFormHeritageList.FormHeritageListDeathDate = row["FormHeritageListDeathDate"].ToString();
					tmpFormHeritageList.FormHeritageListRegisterInformationDate = row["FormHeritageListRegisterInformationDate"].ToString();
					tmpFormHeritageList.FormHeritageListType = row["FormHeritageListType"].ToString();
					tmpFormHeritageList.FormHeritageListDeadFullName = row["FormHeritageListDeadFullName"].ToString();
					tmpFormHeritageList.FormHeritageListTaxOfficeTitle = row["FormHeritageListTaxOfficeTitle"].ToString();
					tmpFormHeritageList.FormHeritageListDescriptions = row["FormHeritageListDescriptions"].ToString();
					tmpFormHeritageList.FormHeritageListDossierClasses = row["FormHeritageListDossierClasses"].ToString();
					tmpFormHeritageList.FormHeritageListItemCount = (row["FormHeritageListItemCount"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageListItemCount"]) : 0 ;

					listFormHeritageList.Add(tmpFormHeritageList);
				}
			}
		}

		return listFormHeritageList;
	}

}
}
