using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormTaxBillDBAccess
{

	FormHeirWithShareDBAccess formHeirWithShareDBAccess = new FormHeirWithShareDBAccess();

	public List<FormHeirWithShare> GetListFormHeirWithShare(Int64 formTaxBillID)
	{
		List<FormHeirWithShare> listFormHeirWithShare = new List<FormHeirWithShare>() { };
		SqlParameter[] parametersFormTaxBill = new SqlParameter[]
		{
			new SqlParameter("@FormHeirWithShareFormBillTaxID", formTaxBillID)
		};

		//Lets get the list of FormHeirWithShare records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeirWithShare_GetList_UseInFormTaxBill", CommandType.StoredProcedure, parametersFormTaxBill))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formHeirWithShare
				listFormHeirWithShare = new List<FormHeirWithShare>();

				//Now lets populate the FormHeirWithShare details into the list of formHeirWithShares
				foreach (DataRow row in table.Rows)
				{
					FormHeirWithShare formHeirWithShare = ConvertRowToFormHeirWithShare(row);
					listFormHeirWithShare.Add(formHeirWithShare);
				}
			}
		}

		return listFormHeirWithShare;
	}

	private FormHeirWithShare ConvertRowToFormHeirWithShare(DataRow row)
	{
		FormHeirWithShare formHeirWithShare = new FormHeirWithShare();
		formHeirWithShare.FormHeirWithShareID = (row["FormHeirWithShareID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeirWithShareID"]) : 0 ;
		formHeirWithShare.FormHeirWithShareFormBillTaxID = (row["FormHeirWithShareFormBillTaxID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeirWithShareFormBillTaxID"]) : 0 ;
		formHeirWithShare.FormHeirWithShareNationalCode = (row["FormHeirWithShareNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeirWithShareNationalCode"]) : 0 ;
		formHeirWithShare.FormHeirWithShareFullName = row["FormHeirWithShareFullName"].ToString();
		formHeirWithShare.FormHeirWithShareRelationTitle = row["FormHeirWithShareRelationTitle"].ToString();
		formHeirWithShare.FormHeirWithShareComment = row["FormHeirWithShareComment"].ToString();
		formHeirWithShare.FormHeirWithShareTaxTotalLetter = row["FormHeirWithShareTaxTotalLetter"].ToString();
		formHeirWithShare.FormHeirWithShareHeirShare = (row["FormHeirWithShareHeirShare"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareHeirShare"]) : 0 ;
		formHeirWithShare.FormHeirWithShareReduction = (row["FormHeirWithShareReduction"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareReduction"]) : 0 ;
		formHeirWithShare.FormHeirWithShareRemaining = (row["FormHeirWithShareRemaining"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareRemaining"]) : 0 ;
		formHeirWithShare.FormHeirWithShareTaxTotal = (row["FormHeirWithShareTaxTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareTaxTotal"]) : 0 ;
		formHeirWithShare.FormHeirWithShareTaxTypeB = (row["FormHeirWithShareTaxTypeB"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareTaxTypeB"]) : 0 ;
		formHeirWithShare.FormHeirWithShareTaxTypeA = (row["FormHeirWithShareTaxTypeA"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareTaxTypeA"]) : 0 ;
		return formHeirWithShare;
	}
	public Int64 Insert(FormTaxBill formTaxBill)
	{
		SqlParameter[] parametersFormTaxBill = new SqlParameter[]
		{
			new SqlParameter("@FormTaxBillDossierClasses", (formTaxBill.FormTaxBillDossierClasses != null) ? formTaxBill.FormTaxBillDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillUser2Code", (formTaxBill.FormTaxBillUser2Code != null) ? formTaxBill.FormTaxBillUser2Code : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillDescription", (formTaxBill.FormTaxBillDescription != null) ? formTaxBill.FormTaxBillDescription : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillTaxTotalLetter", (formTaxBill.FormTaxBillTaxTotalLetter != null) ? formTaxBill.FormTaxBillTaxTotalLetter : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillBillType", (formTaxBill.FormTaxBillBillType != null) ? formTaxBill.FormTaxBillBillType : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillTaxTotalDescription", (formTaxBill.FormTaxBillTaxTotalDescription != null) ? formTaxBill.FormTaxBillTaxTotalDescription : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillTaxTypeA", (formTaxBill.FormTaxBillTaxTypeA != null) ? formTaxBill.FormTaxBillTaxTypeA : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillTaxTypeB", (formTaxBill.FormTaxBillTaxTypeB != null) ? formTaxBill.FormTaxBillTaxTypeB : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillTaxTotal", (formTaxBill.FormTaxBillTaxTotal != null) ? formTaxBill.FormTaxBillTaxTotal : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillTotalShare", (formTaxBill.FormTaxBillTotalShare != null) ? formTaxBill.FormTaxBillTotalShare : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillDeclarationID", (formTaxBill.FormTaxBillDeclarationID > 0) ? formTaxBill.FormTaxBillDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillRegisterInformationID", (formTaxBill.FormTaxBillRegisterInformationID > 0) ? formTaxBill.FormTaxBillRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillRegisterarUserNationalCode", (formTaxBill.FormTaxBillRegisterarUserNationalCode > 0) ? formTaxBill.FormTaxBillRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillDeadNationalCode", (formTaxBill.FormTaxBillDeadNationalCode != null) ? formTaxBill.FormTaxBillDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillDeadDeathDate", (formTaxBill.FormTaxBillDeadDeathDate != null) ? formTaxBill.FormTaxBillDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillRegisterInformationDate", (formTaxBill.FormTaxBillRegisterInformationDate != null) ? formTaxBill.FormTaxBillRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillTaxOfficeTitle", (formTaxBill.FormTaxBillTaxOfficeTitle != null) ? formTaxBill.FormTaxBillTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillDeadFullName", (formTaxBill.FormTaxBillDeadFullName != null) ? formTaxBill.FormTaxBillDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillHeirsNumberSummury", (formTaxBill.FormTaxBillHeirsNumberSummury != null) ? formTaxBill.FormTaxBillHeirsNumberSummury : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillUser2FullName", (formTaxBill.FormTaxBillUser2FullName != null) ? formTaxBill.FormTaxBillUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillUser1FullName", (formTaxBill.FormTaxBillUser1FullName != null) ? formTaxBill.FormTaxBillUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillUser1Code", (formTaxBill.FormTaxBillUser1Code != null) ? formTaxBill.FormTaxBillUser1Code : (object)DBNull.Value)
		};
		formTaxBill.FormTaxBillID = SqlDBHelper.ExecuteScalar("FormTaxBill_Insert", CommandType.StoredProcedure, parametersFormTaxBill);
		return formTaxBill.FormTaxBillID;
	}

	public bool Update(FormTaxBill formTaxBill)
	{
		SqlParameter[] parametersFormTaxBill = new SqlParameter[]
		{
			new SqlParameter("@FormTaxBillID", formTaxBill.FormTaxBillID),
			new SqlParameter("@FormTaxBillDossierClasses", (formTaxBill.FormTaxBillDossierClasses != null) ? formTaxBill.FormTaxBillDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillUser2Code", (formTaxBill.FormTaxBillUser2Code != null) ? formTaxBill.FormTaxBillUser2Code : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillDescription", (formTaxBill.FormTaxBillDescription != null) ? formTaxBill.FormTaxBillDescription : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillTaxTotalLetter", (formTaxBill.FormTaxBillTaxTotalLetter != null) ? formTaxBill.FormTaxBillTaxTotalLetter : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillBillType", (formTaxBill.FormTaxBillBillType != null) ? formTaxBill.FormTaxBillBillType : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillTaxTotalDescription", (formTaxBill.FormTaxBillTaxTotalDescription != null) ? formTaxBill.FormTaxBillTaxTotalDescription : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillTaxTypeA", (formTaxBill.FormTaxBillTaxTypeA != null) ? formTaxBill.FormTaxBillTaxTypeA : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillTaxTypeB", (formTaxBill.FormTaxBillTaxTypeB != null) ? formTaxBill.FormTaxBillTaxTypeB : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillTaxTotal", (formTaxBill.FormTaxBillTaxTotal != null) ? formTaxBill.FormTaxBillTaxTotal : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillTotalShare", (formTaxBill.FormTaxBillTotalShare != null) ? formTaxBill.FormTaxBillTotalShare : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillDeclarationID", (formTaxBill.FormTaxBillDeclarationID != null && formTaxBill.FormTaxBillDeclarationID >0 ) ? formTaxBill.FormTaxBillDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillRegisterInformationID", formTaxBill.FormTaxBillRegisterInformationID),
			new SqlParameter("@FormTaxBillRegisterarUserNationalCode", (formTaxBill.FormTaxBillRegisterarUserNationalCode != null && formTaxBill.FormTaxBillRegisterarUserNationalCode >0 ) ? formTaxBill.FormTaxBillRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillDeadNationalCode", (formTaxBill.FormTaxBillDeadNationalCode != null) ? formTaxBill.FormTaxBillDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillDeadDeathDate", (formTaxBill.FormTaxBillDeadDeathDate != null) ? formTaxBill.FormTaxBillDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillRegisterInformationDate", (formTaxBill.FormTaxBillRegisterInformationDate != null) ? formTaxBill.FormTaxBillRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillTaxOfficeTitle", (formTaxBill.FormTaxBillTaxOfficeTitle != null) ? formTaxBill.FormTaxBillTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillDeadFullName", (formTaxBill.FormTaxBillDeadFullName != null) ? formTaxBill.FormTaxBillDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillHeirsNumberSummury", (formTaxBill.FormTaxBillHeirsNumberSummury != null) ? formTaxBill.FormTaxBillHeirsNumberSummury : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillUser2FullName", (formTaxBill.FormTaxBillUser2FullName != null) ? formTaxBill.FormTaxBillUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillUser1FullName", (formTaxBill.FormTaxBillUser1FullName != null) ? formTaxBill.FormTaxBillUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormTaxBillUser1Code", (formTaxBill.FormTaxBillUser1Code != null) ? formTaxBill.FormTaxBillUser1Code : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormTaxBill_Update", CommandType.StoredProcedure, parametersFormTaxBill);
	}

	public bool Delete(Int64 formTaxBillID)
	{
		SqlParameter[] parametersFormTaxBill = new SqlParameter[]
		{
			new SqlParameter("@FormTaxBillID", formTaxBillID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormTaxBill_Delete", CommandType.StoredProcedure, parametersFormTaxBill);
	}

	public FormTaxBill GetDetails(Int64 formTaxBillID)
	{
		FormTaxBill formTaxBill = new FormTaxBill();

		SqlParameter[] parametersFormTaxBill = new SqlParameter[]
		{
			new SqlParameter("@FormTaxBillID", formTaxBillID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormTaxBill_GetDetails", CommandType.StoredProcedure, parametersFormTaxBill))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				formTaxBill.FormTaxBillID = (row["FormTaxBillID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillID"]) : 0 ;
				formTaxBill.FormTaxBillPrintRegisterDate = row["FormTaxBillPrintRegisterDate"].ToString();
				formTaxBill.FormTaxBillPrintRegisterInformationID = row["FormTaxBillPrintRegisterInformationID"].ToString();
				formTaxBill.FormTaxBillDossierClasses = row["FormTaxBillDossierClasses"].ToString();
				formTaxBill.FormTaxBillUser2Code = row["FormTaxBillUser2Code"].ToString();
				formTaxBill.FormTaxBillDescription = row["FormTaxBillDescription"].ToString();
				formTaxBill.FormTaxBillTaxTotalLetter = row["FormTaxBillTaxTotalLetter"].ToString();
				formTaxBill.FormTaxBillBillType = row["FormTaxBillBillType"].ToString();
				formTaxBill.FormTaxBillTaxTotalDescription = row["FormTaxBillTaxTotalDescription"].ToString();
				formTaxBill.FormTaxBillTaxTypeA = (row["FormTaxBillTaxTypeA"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTaxTypeA"]) : 0 ;
				formTaxBill.FormTaxBillTaxTypeB = (row["FormTaxBillTaxTypeB"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTaxTypeB"]) : 0 ;
				formTaxBill.FormTaxBillTaxTotal = (row["FormTaxBillTaxTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTaxTotal"]) : 0 ;
				formTaxBill.FormTaxBillTotalShare = (row["FormTaxBillTotalShare"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTotalShare"]) : 0 ;
				formTaxBill.FormTaxBillDeclarationID = (row["FormTaxBillDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillDeclarationID"]) : 0 ;
				formTaxBill.FormTaxBillRegisterInformationID = (row["FormTaxBillRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillRegisterInformationID"]) : 0 ;
				formTaxBill.FormTaxBillRegisterarUserNationalCode = (row["FormTaxBillRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillRegisterarUserNationalCode"]) : 0 ;
				formTaxBill.FormTaxBillDeadNationalCode = (row["FormTaxBillDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillDeadNationalCode"]) : 0 ;
				formTaxBill.FormTaxBillDeadDeathDate = row["FormTaxBillDeadDeathDate"].ToString();
				formTaxBill.FormTaxBillRegisterInformationDate = row["FormTaxBillRegisterInformationDate"].ToString();
				formTaxBill.FormTaxBillTaxOfficeTitle = row["FormTaxBillTaxOfficeTitle"].ToString();
				formTaxBill.FormTaxBillDeadFullName = row["FormTaxBillDeadFullName"].ToString();
				formTaxBill.FormTaxBillHeirsNumberSummury = row["FormTaxBillHeirsNumberSummury"].ToString();
				formTaxBill.FormTaxBillUser2FullName = row["FormTaxBillUser2FullName"].ToString();
				formTaxBill.FormTaxBillUser1FullName = row["FormTaxBillUser1FullName"].ToString();
				formTaxBill.FormTaxBillUser1Code = row["FormTaxBillUser1Code"].ToString();
			}
		}

		return formTaxBill;
	}

	public List<FormTaxBill> GetListAll()
	{
		List<FormTaxBill> listFormTaxBill = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormTaxBill_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormTaxBill = new List<FormTaxBill>();

				foreach (DataRow row in table.Rows)
				{
					FormTaxBill formTaxBill = new FormTaxBill();
					formTaxBill.FormTaxBillID = (row["FormTaxBillID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillID"]) : 0 ;
					formTaxBill.FormTaxBillPrintRegisterDate = row["FormTaxBillPrintRegisterDate"].ToString();
					formTaxBill.FormTaxBillPrintRegisterInformationID = row["FormTaxBillPrintRegisterInformationID"].ToString();
					formTaxBill.FormTaxBillDossierClasses = row["FormTaxBillDossierClasses"].ToString();
					formTaxBill.FormTaxBillUser2Code = row["FormTaxBillUser2Code"].ToString();
					formTaxBill.FormTaxBillDescription = row["FormTaxBillDescription"].ToString();
					formTaxBill.FormTaxBillTaxTotalLetter = row["FormTaxBillTaxTotalLetter"].ToString();
					formTaxBill.FormTaxBillBillType = row["FormTaxBillBillType"].ToString();
					formTaxBill.FormTaxBillTaxTotalDescription = row["FormTaxBillTaxTotalDescription"].ToString();
					formTaxBill.FormTaxBillTaxTypeA = (row["FormTaxBillTaxTypeA"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTaxTypeA"]) : 0 ;
					formTaxBill.FormTaxBillTaxTypeB = (row["FormTaxBillTaxTypeB"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTaxTypeB"]) : 0 ;
					formTaxBill.FormTaxBillTaxTotal = (row["FormTaxBillTaxTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTaxTotal"]) : 0 ;
					formTaxBill.FormTaxBillTotalShare = (row["FormTaxBillTotalShare"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTotalShare"]) : 0 ;
					formTaxBill.FormTaxBillDeclarationID = (row["FormTaxBillDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillDeclarationID"]) : 0 ;
					formTaxBill.FormTaxBillRegisterInformationID = (row["FormTaxBillRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillRegisterInformationID"]) : 0 ;
					formTaxBill.FormTaxBillRegisterarUserNationalCode = (row["FormTaxBillRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillRegisterarUserNationalCode"]) : 0 ;
					formTaxBill.FormTaxBillDeadNationalCode = (row["FormTaxBillDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillDeadNationalCode"]) : 0 ;
					formTaxBill.FormTaxBillDeadDeathDate = row["FormTaxBillDeadDeathDate"].ToString();
					formTaxBill.FormTaxBillRegisterInformationDate = row["FormTaxBillRegisterInformationDate"].ToString();
					formTaxBill.FormTaxBillTaxOfficeTitle = row["FormTaxBillTaxOfficeTitle"].ToString();
					formTaxBill.FormTaxBillDeadFullName = row["FormTaxBillDeadFullName"].ToString();
					formTaxBill.FormTaxBillHeirsNumberSummury = row["FormTaxBillHeirsNumberSummury"].ToString();
					formTaxBill.FormTaxBillUser2FullName = row["FormTaxBillUser2FullName"].ToString();
					formTaxBill.FormTaxBillUser1FullName = row["FormTaxBillUser1FullName"].ToString();
					formTaxBill.FormTaxBillUser1Code = row["FormTaxBillUser1Code"].ToString();
					listFormTaxBill.Add(formTaxBill);
				}
			}
		}

		return listFormTaxBill;
	}

	public bool Exists(Int64 formTaxBillID)
	{
		SqlParameter[] parametersFormTaxBill = new SqlParameter[]
		{
			new SqlParameter("@FormTaxBillID", formTaxBillID)
		};
		return (SqlDBHelper.ExecuteScalar("FormTaxBill_Exists", CommandType.StoredProcedure, parametersFormTaxBill)>0);
	}

	public bool Exists(FormTaxBill formTaxBill)
	{
		SqlParameter[] parametersFormTaxBill = new SqlParameter[]
		{
			new SqlParameter("@FormTaxBillID", formTaxBill.FormTaxBillID)
		};
		return (SqlDBHelper.ExecuteScalar("FormTaxBill_Exists", CommandType.StoredProcedure, parametersFormTaxBill)>0);
	}

	public List<FormTaxBill> SearchLike(FormTaxBill formTaxBill)
	{
		List<FormTaxBill> listFormTaxBill = new List<FormTaxBill>();


		SqlParameter[] parametersFormTaxBill = new SqlParameter[]
		{
			new SqlParameter("@FormTaxBillID", formTaxBill.FormTaxBillID),
			new SqlParameter("@FormTaxBillPrintRegisterDate", formTaxBill.FormTaxBillPrintRegisterDate),
			new SqlParameter("@FormTaxBillPrintRegisterInformationID", formTaxBill.FormTaxBillPrintRegisterInformationID),
			new SqlParameter("@FormTaxBillDossierClasses", formTaxBill.FormTaxBillDossierClasses),
			new SqlParameter("@FormTaxBillUser2Code", formTaxBill.FormTaxBillUser2Code),
			new SqlParameter("@FormTaxBillDescription", formTaxBill.FormTaxBillDescription),
			new SqlParameter("@FormTaxBillTaxTotalLetter", formTaxBill.FormTaxBillTaxTotalLetter),
			new SqlParameter("@FormTaxBillBillType", formTaxBill.FormTaxBillBillType),
			new SqlParameter("@FormTaxBillTaxTotalDescription", formTaxBill.FormTaxBillTaxTotalDescription),
			new SqlParameter("@FormTaxBillTaxTypeA", formTaxBill.FormTaxBillTaxTypeA),
			new SqlParameter("@FormTaxBillTaxTypeB", formTaxBill.FormTaxBillTaxTypeB),
			new SqlParameter("@FormTaxBillTaxTotal", formTaxBill.FormTaxBillTaxTotal),
			new SqlParameter("@FormTaxBillTotalShare", formTaxBill.FormTaxBillTotalShare),
			new SqlParameter("@FormTaxBillDeclarationID", formTaxBill.FormTaxBillDeclarationID),
			new SqlParameter("@FormTaxBillRegisterInformationID", formTaxBill.FormTaxBillRegisterInformationID),
			new SqlParameter("@FormTaxBillRegisterarUserNationalCode", formTaxBill.FormTaxBillRegisterarUserNationalCode),
			new SqlParameter("@FormTaxBillDeadNationalCode", formTaxBill.FormTaxBillDeadNationalCode),
			new SqlParameter("@FormTaxBillDeadDeathDate", formTaxBill.FormTaxBillDeadDeathDate),
			new SqlParameter("@FormTaxBillRegisterInformationDate", formTaxBill.FormTaxBillRegisterInformationDate),
			new SqlParameter("@FormTaxBillTaxOfficeTitle", formTaxBill.FormTaxBillTaxOfficeTitle),
			new SqlParameter("@FormTaxBillDeadFullName", formTaxBill.FormTaxBillDeadFullName),
			new SqlParameter("@FormTaxBillHeirsNumberSummury", formTaxBill.FormTaxBillHeirsNumberSummury),
			new SqlParameter("@FormTaxBillUser2FullName", formTaxBill.FormTaxBillUser2FullName),
			new SqlParameter("@FormTaxBillUser1FullName", formTaxBill.FormTaxBillUser1FullName),
			new SqlParameter("@FormTaxBillUser1Code", formTaxBill.FormTaxBillUser1Code),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormTaxBill_SearchLike", CommandType.StoredProcedure, parametersFormTaxBill))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormTaxBill tmpFormTaxBill = new FormTaxBill();
					tmpFormTaxBill.FormTaxBillID = (row["FormTaxBillID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillID"]) : 0 ;
					tmpFormTaxBill.FormTaxBillPrintRegisterDate = row["FormTaxBillPrintRegisterDate"].ToString();
					tmpFormTaxBill.FormTaxBillPrintRegisterInformationID = row["FormTaxBillPrintRegisterInformationID"].ToString();
					tmpFormTaxBill.FormTaxBillDossierClasses = row["FormTaxBillDossierClasses"].ToString();
					tmpFormTaxBill.FormTaxBillUser2Code = row["FormTaxBillUser2Code"].ToString();
					tmpFormTaxBill.FormTaxBillDescription = row["FormTaxBillDescription"].ToString();
					tmpFormTaxBill.FormTaxBillTaxTotalLetter = row["FormTaxBillTaxTotalLetter"].ToString();
					tmpFormTaxBill.FormTaxBillBillType = row["FormTaxBillBillType"].ToString();
					tmpFormTaxBill.FormTaxBillTaxTotalDescription = row["FormTaxBillTaxTotalDescription"].ToString();
					tmpFormTaxBill.FormTaxBillTaxTypeA = (row["FormTaxBillTaxTypeA"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTaxTypeA"]) : 0 ;
					tmpFormTaxBill.FormTaxBillTaxTypeB = (row["FormTaxBillTaxTypeB"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTaxTypeB"]) : 0 ;
					tmpFormTaxBill.FormTaxBillTaxTotal = (row["FormTaxBillTaxTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTaxTotal"]) : 0 ;
					tmpFormTaxBill.FormTaxBillTotalShare = (row["FormTaxBillTotalShare"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTotalShare"]) : 0 ;
					tmpFormTaxBill.FormTaxBillDeclarationID = (row["FormTaxBillDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillDeclarationID"]) : 0 ;
					tmpFormTaxBill.FormTaxBillRegisterInformationID = (row["FormTaxBillRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillRegisterInformationID"]) : 0 ;
					tmpFormTaxBill.FormTaxBillRegisterarUserNationalCode = (row["FormTaxBillRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillRegisterarUserNationalCode"]) : 0 ;
					tmpFormTaxBill.FormTaxBillDeadNationalCode = (row["FormTaxBillDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillDeadNationalCode"]) : 0 ;
					tmpFormTaxBill.FormTaxBillDeadDeathDate = row["FormTaxBillDeadDeathDate"].ToString();
					tmpFormTaxBill.FormTaxBillRegisterInformationDate = row["FormTaxBillRegisterInformationDate"].ToString();
					tmpFormTaxBill.FormTaxBillTaxOfficeTitle = row["FormTaxBillTaxOfficeTitle"].ToString();
					tmpFormTaxBill.FormTaxBillDeadFullName = row["FormTaxBillDeadFullName"].ToString();
					tmpFormTaxBill.FormTaxBillHeirsNumberSummury = row["FormTaxBillHeirsNumberSummury"].ToString();
					tmpFormTaxBill.FormTaxBillUser2FullName = row["FormTaxBillUser2FullName"].ToString();
					tmpFormTaxBill.FormTaxBillUser1FullName = row["FormTaxBillUser1FullName"].ToString();
					tmpFormTaxBill.FormTaxBillUser1Code = row["FormTaxBillUser1Code"].ToString();

					listFormTaxBill.Add(tmpFormTaxBill);
				}
			}
		}

		return listFormTaxBill;
	}

}
}
