using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormInquiryEstateDBAccess
{


	public Int64 Insert(FormInquiryEstate formInquiryEstate)
	{
		SqlParameter[] parametersFormInquiryEstate = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryEstateRuleComment1", (formInquiryEstate.FormInquiryEstateRuleComment1 != null) ? formInquiryEstate.FormInquiryEstateRuleComment1 : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateRuleComment2", (formInquiryEstate.FormInquiryEstateRuleComment2 != null) ? formInquiryEstate.FormInquiryEstateRuleComment2 : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateRegisterInformationDate", (formInquiryEstate.FormInquiryEstateRegisterInformationDate != null) ? formInquiryEstate.FormInquiryEstateRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateDossierClasses", (formInquiryEstate.FormInquiryEstateDossierClasses != null) ? formInquiryEstate.FormInquiryEstateDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateDeadDeathDate", (formInquiryEstate.FormInquiryEstateDeadDeathDate != null) ? formInquiryEstate.FormInquiryEstateDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateTaxUnitCode1", (formInquiryEstate.FormInquiryEstateTaxUnitCode1 != null) ? formInquiryEstate.FormInquiryEstateTaxUnitCode1 : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateUser1TaxUnitCode", (formInquiryEstate.FormInquiryEstateUser1TaxUnitCode != null) ? formInquiryEstate.FormInquiryEstateUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateUser2TaxGroupCode", (formInquiryEstate.FormInquiryEstateUser2TaxGroupCode != null) ? formInquiryEstate.FormInquiryEstateUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateTaxUnitCode2", (formInquiryEstate.FormInquiryEstateTaxUnitCode2 != null) ? formInquiryEstate.FormInquiryEstateTaxUnitCode2 : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateDeclarationID", (formInquiryEstate.FormInquiryEstateDeclarationID > 0) ? formInquiryEstate.FormInquiryEstateDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateRegisterarUserNationalCode", (formInquiryEstate.FormInquiryEstateRegisterarUserNationalCode > 0) ? formInquiryEstate.FormInquiryEstateRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateFormInquiryResponseID", (formInquiryEstate.FormInquiryEstateFormInquiryResponseID > 0) ? formInquiryEstate.FormInquiryEstateFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateDeadFullName", (formInquiryEstate.FormInquiryEstateDeadFullName != null) ? formInquiryEstate.FormInquiryEstateDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateUser1FullName", (formInquiryEstate.FormInquiryEstateUser1FullName != null) ? formInquiryEstate.FormInquiryEstateUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateUser2FullName", (formInquiryEstate.FormInquiryEstateUser2FullName != null) ? formInquiryEstate.FormInquiryEstateUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateReciver", (formInquiryEstate.FormInquiryEstateReciver != null) ? formInquiryEstate.FormInquiryEstateReciver : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateReciverRole", (formInquiryEstate.FormInquiryEstateReciverRole != null) ? formInquiryEstate.FormInquiryEstateReciverRole : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateReciverHeritageDescription", (formInquiryEstate.FormInquiryEstateReciverHeritageDescription != null) ? formInquiryEstate.FormInquiryEstateReciverHeritageDescription : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateRegisterInformationID", formInquiryEstate.FormInquiryEstateRegisterInformationID)
		};
		formInquiryEstate.FormInquiryEstateID = SqlDBHelper.ExecuteScalar("FormInquiryEstate_Insert", CommandType.StoredProcedure, parametersFormInquiryEstate);
		return formInquiryEstate.FormInquiryEstateID;
	}

	public bool Update(FormInquiryEstate formInquiryEstate)
	{
		SqlParameter[] parametersFormInquiryEstate = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryEstateID", formInquiryEstate.FormInquiryEstateID),
			new SqlParameter("@FormInquiryEstateRuleComment1", (formInquiryEstate.FormInquiryEstateRuleComment1 != null) ? formInquiryEstate.FormInquiryEstateRuleComment1 : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateRuleComment2", (formInquiryEstate.FormInquiryEstateRuleComment2 != null) ? formInquiryEstate.FormInquiryEstateRuleComment2 : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateRegisterInformationDate", (formInquiryEstate.FormInquiryEstateRegisterInformationDate != null) ? formInquiryEstate.FormInquiryEstateRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateDossierClasses", (formInquiryEstate.FormInquiryEstateDossierClasses != null) ? formInquiryEstate.FormInquiryEstateDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateDeadDeathDate", (formInquiryEstate.FormInquiryEstateDeadDeathDate != null) ? formInquiryEstate.FormInquiryEstateDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateTaxUnitCode1", (formInquiryEstate.FormInquiryEstateTaxUnitCode1 != null) ? formInquiryEstate.FormInquiryEstateTaxUnitCode1 : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateUser1TaxUnitCode", (formInquiryEstate.FormInquiryEstateUser1TaxUnitCode != null) ? formInquiryEstate.FormInquiryEstateUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateUser2TaxGroupCode", (formInquiryEstate.FormInquiryEstateUser2TaxGroupCode != null) ? formInquiryEstate.FormInquiryEstateUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateTaxUnitCode2", (formInquiryEstate.FormInquiryEstateTaxUnitCode2 != null) ? formInquiryEstate.FormInquiryEstateTaxUnitCode2 : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateDeclarationID", formInquiryEstate.FormInquiryEstateDeclarationID),
			new SqlParameter("@FormInquiryEstateRegisterarUserNationalCode", (formInquiryEstate.FormInquiryEstateRegisterarUserNationalCode != null && formInquiryEstate.FormInquiryEstateRegisterarUserNationalCode >0 ) ? formInquiryEstate.FormInquiryEstateRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateFormInquiryResponseID", (formInquiryEstate.FormInquiryEstateFormInquiryResponseID != null && formInquiryEstate.FormInquiryEstateFormInquiryResponseID >0 ) ? formInquiryEstate.FormInquiryEstateFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateDeadFullName", (formInquiryEstate.FormInquiryEstateDeadFullName != null) ? formInquiryEstate.FormInquiryEstateDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateUser1FullName", (formInquiryEstate.FormInquiryEstateUser1FullName != null) ? formInquiryEstate.FormInquiryEstateUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateUser2FullName", (formInquiryEstate.FormInquiryEstateUser2FullName != null) ? formInquiryEstate.FormInquiryEstateUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateReciver", (formInquiryEstate.FormInquiryEstateReciver != null) ? formInquiryEstate.FormInquiryEstateReciver : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateReciverRole", (formInquiryEstate.FormInquiryEstateReciverRole != null) ? formInquiryEstate.FormInquiryEstateReciverRole : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateReciverHeritageDescription", (formInquiryEstate.FormInquiryEstateReciverHeritageDescription != null) ? formInquiryEstate.FormInquiryEstateReciverHeritageDescription : (object)DBNull.Value),
			new SqlParameter("@FormInquiryEstateRegisterInformationID", formInquiryEstate.FormInquiryEstateRegisterInformationID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryEstate_Update", CommandType.StoredProcedure, parametersFormInquiryEstate);
	}

	public bool Delete(Int64 formInquiryEstateID)
	{
		SqlParameter[] parametersFormInquiryEstate = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryEstateID", formInquiryEstateID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryEstate_Delete", CommandType.StoredProcedure, parametersFormInquiryEstate);
	}

	public FormInquiryEstate GetDetails(Int64 formInquiryEstateID)
	{
		FormInquiryEstate formInquiryEstate = new FormInquiryEstate();

		SqlParameter[] parametersFormInquiryEstate = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryEstateID", formInquiryEstateID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryEstate_GetDetails", CommandType.StoredProcedure, parametersFormInquiryEstate))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				formInquiryEstate.FormInquiryEstateID = (row["FormInquiryEstateID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateID"]) : 0 ;
				formInquiryEstate.FormInquiryEstatePrintRegisterInformationID = row["FormInquiryEstatePrintRegisterInformationID"].ToString();
				formInquiryEstate.FormInquiryEstatePrintRegisterDate = row["FormInquiryEstatePrintRegisterDate"].ToString();
				formInquiryEstate.FormInquiryEstateRuleComment1 = row["FormInquiryEstateRuleComment1"].ToString();
				formInquiryEstate.FormInquiryEstateRuleComment2 = row["FormInquiryEstateRuleComment2"].ToString();
				formInquiryEstate.FormInquiryEstateRegisterInformationDate = row["FormInquiryEstateRegisterInformationDate"].ToString();
				formInquiryEstate.FormInquiryEstateDossierClasses = row["FormInquiryEstateDossierClasses"].ToString();
				formInquiryEstate.FormInquiryEstateDeadDeathDate = row["FormInquiryEstateDeadDeathDate"].ToString();
				formInquiryEstate.FormInquiryEstateTaxUnitCode1 = row["FormInquiryEstateTaxUnitCode1"].ToString();
				formInquiryEstate.FormInquiryEstateUser1TaxUnitCode = row["FormInquiryEstateUser1TaxUnitCode"].ToString();
				formInquiryEstate.FormInquiryEstateUser2TaxGroupCode = row["FormInquiryEstateUser2TaxGroupCode"].ToString();
				formInquiryEstate.FormInquiryEstateTaxUnitCode2 = row["FormInquiryEstateTaxUnitCode2"].ToString();
				formInquiryEstate.FormInquiryEstateDeclarationID = (row["FormInquiryEstateDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateDeclarationID"]) : 0 ;
				formInquiryEstate.FormInquiryEstateRegisterarUserNationalCode = (row["FormInquiryEstateRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateRegisterarUserNationalCode"]) : 0 ;
				formInquiryEstate.FormInquiryEstateFormInquiryResponseID = (row["FormInquiryEstateFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateFormInquiryResponseID"]) : 0 ;
				formInquiryEstate.FormInquiryEstateDeadFullName = row["FormInquiryEstateDeadFullName"].ToString();
				formInquiryEstate.FormInquiryEstateUser1FullName = row["FormInquiryEstateUser1FullName"].ToString();
				formInquiryEstate.FormInquiryEstateUser2FullName = row["FormInquiryEstateUser2FullName"].ToString();
				formInquiryEstate.FormInquiryEstateReciver = row["FormInquiryEstateReciver"].ToString();
				formInquiryEstate.FormInquiryEstateReciverRole = row["FormInquiryEstateReciverRole"].ToString();
				formInquiryEstate.FormInquiryEstateReciverHeritageDescription = row["FormInquiryEstateReciverHeritageDescription"].ToString();
				formInquiryEstate.FormInquiryEstateRegisterInformationID = (row["FormInquiryEstateRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateRegisterInformationID"]) : 0 ;
			}
		}

		return formInquiryEstate;
	}

	public List<FormInquiryEstate> GetListAll()
	{
		List<FormInquiryEstate> listFormInquiryEstate = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormInquiryEstate_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormInquiryEstate = new List<FormInquiryEstate>();

				foreach (DataRow row in table.Rows)
				{
					FormInquiryEstate formInquiryEstate = new FormInquiryEstate();
					formInquiryEstate.FormInquiryEstateID = (row["FormInquiryEstateID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateID"]) : 0 ;
					formInquiryEstate.FormInquiryEstatePrintRegisterInformationID = row["FormInquiryEstatePrintRegisterInformationID"].ToString();
					formInquiryEstate.FormInquiryEstatePrintRegisterDate = row["FormInquiryEstatePrintRegisterDate"].ToString();
					formInquiryEstate.FormInquiryEstateRuleComment1 = row["FormInquiryEstateRuleComment1"].ToString();
					formInquiryEstate.FormInquiryEstateRuleComment2 = row["FormInquiryEstateRuleComment2"].ToString();
					formInquiryEstate.FormInquiryEstateRegisterInformationDate = row["FormInquiryEstateRegisterInformationDate"].ToString();
					formInquiryEstate.FormInquiryEstateDossierClasses = row["FormInquiryEstateDossierClasses"].ToString();
					formInquiryEstate.FormInquiryEstateDeadDeathDate = row["FormInquiryEstateDeadDeathDate"].ToString();
					formInquiryEstate.FormInquiryEstateTaxUnitCode1 = row["FormInquiryEstateTaxUnitCode1"].ToString();
					formInquiryEstate.FormInquiryEstateUser1TaxUnitCode = row["FormInquiryEstateUser1TaxUnitCode"].ToString();
					formInquiryEstate.FormInquiryEstateUser2TaxGroupCode = row["FormInquiryEstateUser2TaxGroupCode"].ToString();
					formInquiryEstate.FormInquiryEstateTaxUnitCode2 = row["FormInquiryEstateTaxUnitCode2"].ToString();
					formInquiryEstate.FormInquiryEstateDeclarationID = (row["FormInquiryEstateDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateDeclarationID"]) : 0 ;
					formInquiryEstate.FormInquiryEstateRegisterarUserNationalCode = (row["FormInquiryEstateRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateRegisterarUserNationalCode"]) : 0 ;
					formInquiryEstate.FormInquiryEstateFormInquiryResponseID = (row["FormInquiryEstateFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateFormInquiryResponseID"]) : 0 ;
					formInquiryEstate.FormInquiryEstateDeadFullName = row["FormInquiryEstateDeadFullName"].ToString();
					formInquiryEstate.FormInquiryEstateUser1FullName = row["FormInquiryEstateUser1FullName"].ToString();
					formInquiryEstate.FormInquiryEstateUser2FullName = row["FormInquiryEstateUser2FullName"].ToString();
					formInquiryEstate.FormInquiryEstateReciver = row["FormInquiryEstateReciver"].ToString();
					formInquiryEstate.FormInquiryEstateReciverRole = row["FormInquiryEstateReciverRole"].ToString();
					formInquiryEstate.FormInquiryEstateReciverHeritageDescription = row["FormInquiryEstateReciverHeritageDescription"].ToString();
					formInquiryEstate.FormInquiryEstateRegisterInformationID = (row["FormInquiryEstateRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateRegisterInformationID"]) : 0 ;
					listFormInquiryEstate.Add(formInquiryEstate);
				}
			}
		}

		return listFormInquiryEstate;
	}

	public bool Exists(Int64 formInquiryEstateID)
	{
		SqlParameter[] parametersFormInquiryEstate = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryEstateID", formInquiryEstateID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryEstate_Exists", CommandType.StoredProcedure, parametersFormInquiryEstate)>0);
	}

	public bool Exists(FormInquiryEstate formInquiryEstate)
	{
		SqlParameter[] parametersFormInquiryEstate = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryEstateID", formInquiryEstate.FormInquiryEstateID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryEstate_Exists", CommandType.StoredProcedure, parametersFormInquiryEstate)>0);
	}

	public List<FormInquiryEstate> SearchLike(FormInquiryEstate formInquiryEstate)
	{
		List<FormInquiryEstate> listFormInquiryEstate = new List<FormInquiryEstate>();


		SqlParameter[] parametersFormInquiryEstate = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryEstateID", formInquiryEstate.FormInquiryEstateID),
			new SqlParameter("@FormInquiryEstatePrintRegisterInformationID", formInquiryEstate.FormInquiryEstatePrintRegisterInformationID),
			new SqlParameter("@FormInquiryEstatePrintRegisterDate", formInquiryEstate.FormInquiryEstatePrintRegisterDate),
			new SqlParameter("@FormInquiryEstateRuleComment1", formInquiryEstate.FormInquiryEstateRuleComment1),
			new SqlParameter("@FormInquiryEstateRuleComment2", formInquiryEstate.FormInquiryEstateRuleComment2),
			new SqlParameter("@FormInquiryEstateRegisterInformationDate", formInquiryEstate.FormInquiryEstateRegisterInformationDate),
			new SqlParameter("@FormInquiryEstateDossierClasses", formInquiryEstate.FormInquiryEstateDossierClasses),
			new SqlParameter("@FormInquiryEstateDeadDeathDate", formInquiryEstate.FormInquiryEstateDeadDeathDate),
			new SqlParameter("@FormInquiryEstateTaxUnitCode1", formInquiryEstate.FormInquiryEstateTaxUnitCode1),
			new SqlParameter("@FormInquiryEstateUser1TaxUnitCode", formInquiryEstate.FormInquiryEstateUser1TaxUnitCode),
			new SqlParameter("@FormInquiryEstateUser2TaxGroupCode", formInquiryEstate.FormInquiryEstateUser2TaxGroupCode),
			new SqlParameter("@FormInquiryEstateTaxUnitCode2", formInquiryEstate.FormInquiryEstateTaxUnitCode2),
			new SqlParameter("@FormInquiryEstateDeclarationID", formInquiryEstate.FormInquiryEstateDeclarationID),
			new SqlParameter("@FormInquiryEstateRegisterarUserNationalCode", formInquiryEstate.FormInquiryEstateRegisterarUserNationalCode),
			new SqlParameter("@FormInquiryEstateFormInquiryResponseID", formInquiryEstate.FormInquiryEstateFormInquiryResponseID),
			new SqlParameter("@FormInquiryEstateDeadFullName", formInquiryEstate.FormInquiryEstateDeadFullName),
			new SqlParameter("@FormInquiryEstateUser1FullName", formInquiryEstate.FormInquiryEstateUser1FullName),
			new SqlParameter("@FormInquiryEstateUser2FullName", formInquiryEstate.FormInquiryEstateUser2FullName),
			new SqlParameter("@FormInquiryEstateReciver", formInquiryEstate.FormInquiryEstateReciver),
			new SqlParameter("@FormInquiryEstateReciverRole", formInquiryEstate.FormInquiryEstateReciverRole),
			new SqlParameter("@FormInquiryEstateReciverHeritageDescription", formInquiryEstate.FormInquiryEstateReciverHeritageDescription),
			new SqlParameter("@FormInquiryEstateRegisterInformationID", formInquiryEstate.FormInquiryEstateRegisterInformationID),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryEstate_SearchLike", CommandType.StoredProcedure, parametersFormInquiryEstate))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormInquiryEstate tmpFormInquiryEstate = new FormInquiryEstate();
					tmpFormInquiryEstate.FormInquiryEstateID = (row["FormInquiryEstateID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateID"]) : 0 ;
					tmpFormInquiryEstate.FormInquiryEstatePrintRegisterInformationID = row["FormInquiryEstatePrintRegisterInformationID"].ToString();
					tmpFormInquiryEstate.FormInquiryEstatePrintRegisterDate = row["FormInquiryEstatePrintRegisterDate"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateRuleComment1 = row["FormInquiryEstateRuleComment1"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateRuleComment2 = row["FormInquiryEstateRuleComment2"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateRegisterInformationDate = row["FormInquiryEstateRegisterInformationDate"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateDossierClasses = row["FormInquiryEstateDossierClasses"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateDeadDeathDate = row["FormInquiryEstateDeadDeathDate"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateTaxUnitCode1 = row["FormInquiryEstateTaxUnitCode1"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateUser1TaxUnitCode = row["FormInquiryEstateUser1TaxUnitCode"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateUser2TaxGroupCode = row["FormInquiryEstateUser2TaxGroupCode"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateTaxUnitCode2 = row["FormInquiryEstateTaxUnitCode2"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateDeclarationID = (row["FormInquiryEstateDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateDeclarationID"]) : 0 ;
					tmpFormInquiryEstate.FormInquiryEstateRegisterarUserNationalCode = (row["FormInquiryEstateRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateRegisterarUserNationalCode"]) : 0 ;
					tmpFormInquiryEstate.FormInquiryEstateFormInquiryResponseID = (row["FormInquiryEstateFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateFormInquiryResponseID"]) : 0 ;
					tmpFormInquiryEstate.FormInquiryEstateDeadFullName = row["FormInquiryEstateDeadFullName"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateUser1FullName = row["FormInquiryEstateUser1FullName"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateUser2FullName = row["FormInquiryEstateUser2FullName"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateReciver = row["FormInquiryEstateReciver"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateReciverRole = row["FormInquiryEstateReciverRole"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateReciverHeritageDescription = row["FormInquiryEstateReciverHeritageDescription"].ToString();
					tmpFormInquiryEstate.FormInquiryEstateRegisterInformationID = (row["FormInquiryEstateRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateRegisterInformationID"]) : 0 ;

					listFormInquiryEstate.Add(tmpFormInquiryEstate);
				}
			}
		}

		return listFormInquiryEstate;
	}

}
}
