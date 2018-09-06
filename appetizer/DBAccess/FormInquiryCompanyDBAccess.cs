using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormInquiryCompanyDBAccess
{


	public Int64 Insert(FormInquiryCompany formInquiryCompany)
	{
		SqlParameter[] parametersFormInquiryCompany = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryCompanyRuleComment1", (formInquiryCompany.FormInquiryCompanyRuleComment1 != null) ? formInquiryCompany.FormInquiryCompanyRuleComment1 : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyRuleComment2", (formInquiryCompany.FormInquiryCompanyRuleComment2 != null) ? formInquiryCompany.FormInquiryCompanyRuleComment2 : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyRegisterInformationDate", (formInquiryCompany.FormInquiryCompanyRegisterInformationDate != null) ? formInquiryCompany.FormInquiryCompanyRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyDossierClasses", (formInquiryCompany.FormInquiryCompanyDossierClasses != null) ? formInquiryCompany.FormInquiryCompanyDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyDeadDeathDate", (formInquiryCompany.FormInquiryCompanyDeadDeathDate != null) ? formInquiryCompany.FormInquiryCompanyDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyRegisterInformationID", (formInquiryCompany.FormInquiryCompanyRegisterInformationID != null) ? formInquiryCompany.FormInquiryCompanyRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyRegisterarUserNationalCode", (formInquiryCompany.FormInquiryCompanyRegisterarUserNationalCode > 0) ? formInquiryCompany.FormInquiryCompanyRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyDeclarationID", (formInquiryCompany.FormInquiryCompanyDeclarationID > 0) ? formInquiryCompany.FormInquiryCompanyDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyFormInquiryResponseID", (formInquiryCompany.FormInquiryCompanyFormInquiryResponseID > 0) ? formInquiryCompany.FormInquiryCompanyFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyReciver", (formInquiryCompany.FormInquiryCompanyReciver != null) ? formInquiryCompany.FormInquiryCompanyReciver : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyNumber", (formInquiryCompany.FormInquiryCompanyNumber != null) ? formInquiryCompany.FormInquiryCompanyNumber : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyUser1FullName", (formInquiryCompany.FormInquiryCompanyUser1FullName != null) ? formInquiryCompany.FormInquiryCompanyUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyUser2FullName", (formInquiryCompany.FormInquiryCompanyUser2FullName != null) ? formInquiryCompany.FormInquiryCompanyUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyUser1TaxUnitCode", (formInquiryCompany.FormInquiryCompanyUser1TaxUnitCode != null) ? formInquiryCompany.FormInquiryCompanyUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyUser2TaxGroupCode", (formInquiryCompany.FormInquiryCompanyUser2TaxGroupCode != null) ? formInquiryCompany.FormInquiryCompanyUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyDeadFullName", (formInquiryCompany.FormInquiryCompanyDeadFullName != null) ? formInquiryCompany.FormInquiryCompanyDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyName", (formInquiryCompany.FormInquiryCompanyName != null) ? formInquiryCompany.FormInquiryCompanyName : (object)DBNull.Value)
		};
		formInquiryCompany.FormInquiryCompanyID = SqlDBHelper.ExecuteScalar("FormInquiryCompany_Insert", CommandType.StoredProcedure, parametersFormInquiryCompany);
		return formInquiryCompany.FormInquiryCompanyID;
	}

	public bool Update(FormInquiryCompany formInquiryCompany)
	{
		SqlParameter[] parametersFormInquiryCompany = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryCompanyID", formInquiryCompany.FormInquiryCompanyID),
			new SqlParameter("@FormInquiryCompanyRuleComment1", (formInquiryCompany.FormInquiryCompanyRuleComment1 != null) ? formInquiryCompany.FormInquiryCompanyRuleComment1 : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyRuleComment2", (formInquiryCompany.FormInquiryCompanyRuleComment2 != null) ? formInquiryCompany.FormInquiryCompanyRuleComment2 : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyRegisterInformationDate", (formInquiryCompany.FormInquiryCompanyRegisterInformationDate != null) ? formInquiryCompany.FormInquiryCompanyRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyDossierClasses", (formInquiryCompany.FormInquiryCompanyDossierClasses != null) ? formInquiryCompany.FormInquiryCompanyDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyDeadDeathDate", (formInquiryCompany.FormInquiryCompanyDeadDeathDate != null) ? formInquiryCompany.FormInquiryCompanyDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyRegisterInformationID", (formInquiryCompany.FormInquiryCompanyRegisterInformationID != null) ? formInquiryCompany.FormInquiryCompanyRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyRegisterarUserNationalCode", (formInquiryCompany.FormInquiryCompanyRegisterarUserNationalCode != null && formInquiryCompany.FormInquiryCompanyRegisterarUserNationalCode >0 ) ? formInquiryCompany.FormInquiryCompanyRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyDeclarationID", formInquiryCompany.FormInquiryCompanyDeclarationID),
			new SqlParameter("@FormInquiryCompanyFormInquiryResponseID", (formInquiryCompany.FormInquiryCompanyFormInquiryResponseID != null && formInquiryCompany.FormInquiryCompanyFormInquiryResponseID >0 ) ? formInquiryCompany.FormInquiryCompanyFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyReciver", (formInquiryCompany.FormInquiryCompanyReciver != null) ? formInquiryCompany.FormInquiryCompanyReciver : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyNumber", (formInquiryCompany.FormInquiryCompanyNumber != null) ? formInquiryCompany.FormInquiryCompanyNumber : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyUser1FullName", (formInquiryCompany.FormInquiryCompanyUser1FullName != null) ? formInquiryCompany.FormInquiryCompanyUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyUser2FullName", (formInquiryCompany.FormInquiryCompanyUser2FullName != null) ? formInquiryCompany.FormInquiryCompanyUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyUser1TaxUnitCode", (formInquiryCompany.FormInquiryCompanyUser1TaxUnitCode != null) ? formInquiryCompany.FormInquiryCompanyUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyUser2TaxGroupCode", (formInquiryCompany.FormInquiryCompanyUser2TaxGroupCode != null) ? formInquiryCompany.FormInquiryCompanyUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyDeadFullName", (formInquiryCompany.FormInquiryCompanyDeadFullName != null) ? formInquiryCompany.FormInquiryCompanyDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryCompanyName", (formInquiryCompany.FormInquiryCompanyName != null) ? formInquiryCompany.FormInquiryCompanyName : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryCompany_Update", CommandType.StoredProcedure, parametersFormInquiryCompany);
	}

	public bool Delete(Int64 formInquiryCompanyID)
	{
		SqlParameter[] parametersFormInquiryCompany = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryCompanyID", formInquiryCompanyID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryCompany_Delete", CommandType.StoredProcedure, parametersFormInquiryCompany);
	}

	public FormInquiryCompany GetDetails(Int64 formInquiryCompanyID)
	{
		FormInquiryCompany formInquiryCompany = new FormInquiryCompany();

		SqlParameter[] parametersFormInquiryCompany = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryCompanyID", formInquiryCompanyID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryCompany_GetDetails", CommandType.StoredProcedure, parametersFormInquiryCompany))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				formInquiryCompany.FormInquiryCompanyID = (row["FormInquiryCompanyID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyID"]) : 0 ;
				formInquiryCompany.FormInquiryCompanyPrintRegisterInformationID = row["FormInquiryCompanyPrintRegisterInformationID"].ToString();
				formInquiryCompany.FormInquiryCompanyPrintRegisterDate = row["FormInquiryCompanyPrintRegisterDate"].ToString();
				formInquiryCompany.FormInquiryCompanyRuleComment1 = row["FormInquiryCompanyRuleComment1"].ToString();
				formInquiryCompany.FormInquiryCompanyRuleComment2 = row["FormInquiryCompanyRuleComment2"].ToString();
				formInquiryCompany.FormInquiryCompanyRegisterInformationDate = row["FormInquiryCompanyRegisterInformationDate"].ToString();
				formInquiryCompany.FormInquiryCompanyDossierClasses = row["FormInquiryCompanyDossierClasses"].ToString();
				formInquiryCompany.FormInquiryCompanyDeadDeathDate = row["FormInquiryCompanyDeadDeathDate"].ToString();
				formInquiryCompany.FormInquiryCompanyRegisterInformationID = (row["FormInquiryCompanyRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyRegisterInformationID"]) : 0 ;
				formInquiryCompany.FormInquiryCompanyRegisterarUserNationalCode = (row["FormInquiryCompanyRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyRegisterarUserNationalCode"]) : 0 ;
				formInquiryCompany.FormInquiryCompanyDeclarationID = (row["FormInquiryCompanyDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyDeclarationID"]) : 0 ;
				formInquiryCompany.FormInquiryCompanyFormInquiryResponseID = (row["FormInquiryCompanyFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyFormInquiryResponseID"]) : 0 ;
				formInquiryCompany.FormInquiryCompanyReciver = row["FormInquiryCompanyReciver"].ToString();
				formInquiryCompany.FormInquiryCompanyNumber = row["FormInquiryCompanyNumber"].ToString();
				formInquiryCompany.FormInquiryCompanyUser1FullName = row["FormInquiryCompanyUser1FullName"].ToString();
				formInquiryCompany.FormInquiryCompanyUser2FullName = row["FormInquiryCompanyUser2FullName"].ToString();
				formInquiryCompany.FormInquiryCompanyUser1TaxUnitCode = row["FormInquiryCompanyUser1TaxUnitCode"].ToString();
				formInquiryCompany.FormInquiryCompanyUser2TaxGroupCode = row["FormInquiryCompanyUser2TaxGroupCode"].ToString();
				formInquiryCompany.FormInquiryCompanyDeadFullName = row["FormInquiryCompanyDeadFullName"].ToString();
				formInquiryCompany.FormInquiryCompanyName = row["FormInquiryCompanyName"].ToString();
			}
		}

		return formInquiryCompany;
	}

	public List<FormInquiryCompany> GetListAll()
	{
		List<FormInquiryCompany> listFormInquiryCompany = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormInquiryCompany_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormInquiryCompany = new List<FormInquiryCompany>();

				foreach (DataRow row in table.Rows)
				{
					FormInquiryCompany formInquiryCompany = new FormInquiryCompany();
					formInquiryCompany.FormInquiryCompanyID = (row["FormInquiryCompanyID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyID"]) : 0 ;
					formInquiryCompany.FormInquiryCompanyPrintRegisterInformationID = row["FormInquiryCompanyPrintRegisterInformationID"].ToString();
					formInquiryCompany.FormInquiryCompanyPrintRegisterDate = row["FormInquiryCompanyPrintRegisterDate"].ToString();
					formInquiryCompany.FormInquiryCompanyRuleComment1 = row["FormInquiryCompanyRuleComment1"].ToString();
					formInquiryCompany.FormInquiryCompanyRuleComment2 = row["FormInquiryCompanyRuleComment2"].ToString();
					formInquiryCompany.FormInquiryCompanyRegisterInformationDate = row["FormInquiryCompanyRegisterInformationDate"].ToString();
					formInquiryCompany.FormInquiryCompanyDossierClasses = row["FormInquiryCompanyDossierClasses"].ToString();
					formInquiryCompany.FormInquiryCompanyDeadDeathDate = row["FormInquiryCompanyDeadDeathDate"].ToString();
					formInquiryCompany.FormInquiryCompanyRegisterInformationID = (row["FormInquiryCompanyRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyRegisterInformationID"]) : 0 ;
					formInquiryCompany.FormInquiryCompanyRegisterarUserNationalCode = (row["FormInquiryCompanyRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyRegisterarUserNationalCode"]) : 0 ;
					formInquiryCompany.FormInquiryCompanyDeclarationID = (row["FormInquiryCompanyDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyDeclarationID"]) : 0 ;
					formInquiryCompany.FormInquiryCompanyFormInquiryResponseID = (row["FormInquiryCompanyFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyFormInquiryResponseID"]) : 0 ;
					formInquiryCompany.FormInquiryCompanyReciver = row["FormInquiryCompanyReciver"].ToString();
					formInquiryCompany.FormInquiryCompanyNumber = row["FormInquiryCompanyNumber"].ToString();
					formInquiryCompany.FormInquiryCompanyUser1FullName = row["FormInquiryCompanyUser1FullName"].ToString();
					formInquiryCompany.FormInquiryCompanyUser2FullName = row["FormInquiryCompanyUser2FullName"].ToString();
					formInquiryCompany.FormInquiryCompanyUser1TaxUnitCode = row["FormInquiryCompanyUser1TaxUnitCode"].ToString();
					formInquiryCompany.FormInquiryCompanyUser2TaxGroupCode = row["FormInquiryCompanyUser2TaxGroupCode"].ToString();
					formInquiryCompany.FormInquiryCompanyDeadFullName = row["FormInquiryCompanyDeadFullName"].ToString();
					formInquiryCompany.FormInquiryCompanyName = row["FormInquiryCompanyName"].ToString();
					listFormInquiryCompany.Add(formInquiryCompany);
				}
			}
		}

		return listFormInquiryCompany;
	}

	public bool Exists(Int64 formInquiryCompanyID)
	{
		SqlParameter[] parametersFormInquiryCompany = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryCompanyID", formInquiryCompanyID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryCompany_Exists", CommandType.StoredProcedure, parametersFormInquiryCompany)>0);
	}

	public bool Exists(FormInquiryCompany formInquiryCompany)
	{
		SqlParameter[] parametersFormInquiryCompany = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryCompanyID", formInquiryCompany.FormInquiryCompanyID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryCompany_Exists", CommandType.StoredProcedure, parametersFormInquiryCompany)>0);
	}

	public List<FormInquiryCompany> SearchLike(FormInquiryCompany formInquiryCompany)
	{
		List<FormInquiryCompany> listFormInquiryCompany = new List<FormInquiryCompany>();


		SqlParameter[] parametersFormInquiryCompany = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryCompanyID", formInquiryCompany.FormInquiryCompanyID),
			new SqlParameter("@FormInquiryCompanyPrintRegisterInformationID", formInquiryCompany.FormInquiryCompanyPrintRegisterInformationID),
			new SqlParameter("@FormInquiryCompanyPrintRegisterDate", formInquiryCompany.FormInquiryCompanyPrintRegisterDate),
			new SqlParameter("@FormInquiryCompanyRuleComment1", formInquiryCompany.FormInquiryCompanyRuleComment1),
			new SqlParameter("@FormInquiryCompanyRuleComment2", formInquiryCompany.FormInquiryCompanyRuleComment2),
			new SqlParameter("@FormInquiryCompanyRegisterInformationDate", formInquiryCompany.FormInquiryCompanyRegisterInformationDate),
			new SqlParameter("@FormInquiryCompanyDossierClasses", formInquiryCompany.FormInquiryCompanyDossierClasses),
			new SqlParameter("@FormInquiryCompanyDeadDeathDate", formInquiryCompany.FormInquiryCompanyDeadDeathDate),
			new SqlParameter("@FormInquiryCompanyRegisterInformationID", formInquiryCompany.FormInquiryCompanyRegisterInformationID),
			new SqlParameter("@FormInquiryCompanyRegisterarUserNationalCode", formInquiryCompany.FormInquiryCompanyRegisterarUserNationalCode),
			new SqlParameter("@FormInquiryCompanyDeclarationID", formInquiryCompany.FormInquiryCompanyDeclarationID),
			new SqlParameter("@FormInquiryCompanyFormInquiryResponseID", formInquiryCompany.FormInquiryCompanyFormInquiryResponseID),
			new SqlParameter("@FormInquiryCompanyReciver", formInquiryCompany.FormInquiryCompanyReciver),
			new SqlParameter("@FormInquiryCompanyNumber", formInquiryCompany.FormInquiryCompanyNumber),
			new SqlParameter("@FormInquiryCompanyUser1FullName", formInquiryCompany.FormInquiryCompanyUser1FullName),
			new SqlParameter("@FormInquiryCompanyUser2FullName", formInquiryCompany.FormInquiryCompanyUser2FullName),
			new SqlParameter("@FormInquiryCompanyUser1TaxUnitCode", formInquiryCompany.FormInquiryCompanyUser1TaxUnitCode),
			new SqlParameter("@FormInquiryCompanyUser2TaxGroupCode", formInquiryCompany.FormInquiryCompanyUser2TaxGroupCode),
			new SqlParameter("@FormInquiryCompanyDeadFullName", formInquiryCompany.FormInquiryCompanyDeadFullName),
			new SqlParameter("@FormInquiryCompanyName", formInquiryCompany.FormInquiryCompanyName),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryCompany_SearchLike", CommandType.StoredProcedure, parametersFormInquiryCompany))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormInquiryCompany tmpFormInquiryCompany = new FormInquiryCompany();
					tmpFormInquiryCompany.FormInquiryCompanyID = (row["FormInquiryCompanyID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyID"]) : 0 ;
					tmpFormInquiryCompany.FormInquiryCompanyPrintRegisterInformationID = row["FormInquiryCompanyPrintRegisterInformationID"].ToString();
					tmpFormInquiryCompany.FormInquiryCompanyPrintRegisterDate = row["FormInquiryCompanyPrintRegisterDate"].ToString();
					tmpFormInquiryCompany.FormInquiryCompanyRuleComment1 = row["FormInquiryCompanyRuleComment1"].ToString();
					tmpFormInquiryCompany.FormInquiryCompanyRuleComment2 = row["FormInquiryCompanyRuleComment2"].ToString();
					tmpFormInquiryCompany.FormInquiryCompanyRegisterInformationDate = row["FormInquiryCompanyRegisterInformationDate"].ToString();
					tmpFormInquiryCompany.FormInquiryCompanyDossierClasses = row["FormInquiryCompanyDossierClasses"].ToString();
					tmpFormInquiryCompany.FormInquiryCompanyDeadDeathDate = row["FormInquiryCompanyDeadDeathDate"].ToString();
					tmpFormInquiryCompany.FormInquiryCompanyRegisterInformationID = (row["FormInquiryCompanyRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyRegisterInformationID"]) : 0 ;
					tmpFormInquiryCompany.FormInquiryCompanyRegisterarUserNationalCode = (row["FormInquiryCompanyRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyRegisterarUserNationalCode"]) : 0 ;
					tmpFormInquiryCompany.FormInquiryCompanyDeclarationID = (row["FormInquiryCompanyDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyDeclarationID"]) : 0 ;
					tmpFormInquiryCompany.FormInquiryCompanyFormInquiryResponseID = (row["FormInquiryCompanyFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyFormInquiryResponseID"]) : 0 ;
					tmpFormInquiryCompany.FormInquiryCompanyReciver = row["FormInquiryCompanyReciver"].ToString();
					tmpFormInquiryCompany.FormInquiryCompanyNumber = row["FormInquiryCompanyNumber"].ToString();
					tmpFormInquiryCompany.FormInquiryCompanyUser1FullName = row["FormInquiryCompanyUser1FullName"].ToString();
					tmpFormInquiryCompany.FormInquiryCompanyUser2FullName = row["FormInquiryCompanyUser2FullName"].ToString();
					tmpFormInquiryCompany.FormInquiryCompanyUser1TaxUnitCode = row["FormInquiryCompanyUser1TaxUnitCode"].ToString();
					tmpFormInquiryCompany.FormInquiryCompanyUser2TaxGroupCode = row["FormInquiryCompanyUser2TaxGroupCode"].ToString();
					tmpFormInquiryCompany.FormInquiryCompanyDeadFullName = row["FormInquiryCompanyDeadFullName"].ToString();
					tmpFormInquiryCompany.FormInquiryCompanyName = row["FormInquiryCompanyName"].ToString();

					listFormInquiryCompany.Add(tmpFormInquiryCompany);
				}
			}
		}

		return listFormInquiryCompany;
	}

}
}
