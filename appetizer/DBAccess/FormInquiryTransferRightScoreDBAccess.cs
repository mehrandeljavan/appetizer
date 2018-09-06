using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormInquiryTransferRightScoreDBAccess
{


	public Int64 Insert(FormInquiryTransferRightScore formInquiryTransferRightScore)
	{
		SqlParameter[] parametersFormInquiryTransferRightScore = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightScoreUser2TaxGroupCode", (formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2TaxGroupCode != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreDeadFullName", (formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadFullName != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreComment", (formInquiryTransferRightScore.FormInquiryTransferRightScoreComment != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreComment : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreTitle", (formInquiryTransferRightScore.FormInquiryTransferRightScoreTitle != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreTitle : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScorePlaque", (formInquiryTransferRightScore.FormInquiryTransferRightScorePlaque != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScorePlaque : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScorelSection", (formInquiryTransferRightScore.FormInquiryTransferRightScorelSection != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScorelSection : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScorelRegisterInformationDate", (formInquiryTransferRightScore.FormInquiryTransferRightScorelRegisterInformationDate != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScorelRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreDossierClasses", (formInquiryTransferRightScore.FormInquiryTransferRightScoreDossierClasses != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreDeadDeathDate", (formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadDeathDate != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreRegisterInformationID", (formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterInformationID != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreRegisterarUserNationalCode", (formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterarUserNationalCode > 0) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreDeclarationID", (formInquiryTransferRightScore.FormInquiryTransferRightScoreDeclarationID > 0) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreFormInquiryResponseID", (formInquiryTransferRightScore.FormInquiryTransferRightScoreFormInquiryResponseID > 0) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreInquiryTo", (formInquiryTransferRightScore.FormInquiryTransferRightScoreInquiryTo != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreInquiryTo : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreRuleComment", (formInquiryTransferRightScore.FormInquiryTransferRightScoreRuleComment != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreRuleComment : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreTaxUnitCode", (formInquiryTransferRightScore.FormInquiryTransferRightScoreTaxUnitCode != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreUser1FullName", (formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1FullName != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreUser2FullName", (formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2FullName != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreUser1TaxUnitCode", (formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1TaxUnitCode != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreAddress", (formInquiryTransferRightScore.FormInquiryTransferRightScoreAddress != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreAddress : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreSixth", (formInquiryTransferRightScore.FormInquiryTransferRightScoreSixth != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreSixth : (object)DBNull.Value)
		};
		formInquiryTransferRightScore.FormInquiryTransferRightScorelID = SqlDBHelper.ExecuteScalar("FormInquiryTransferRightScore_Insert", CommandType.StoredProcedure, parametersFormInquiryTransferRightScore);
		return formInquiryTransferRightScore.FormInquiryTransferRightScorelID;
	}

	public bool Update(FormInquiryTransferRightScore formInquiryTransferRightScore)
	{
		SqlParameter[] parametersFormInquiryTransferRightScore = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightScorelID", formInquiryTransferRightScore.FormInquiryTransferRightScorelID),
			new SqlParameter("@FormInquiryTransferRightScoreUser2TaxGroupCode", (formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2TaxGroupCode != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreDeadFullName", (formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadFullName != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreComment", (formInquiryTransferRightScore.FormInquiryTransferRightScoreComment != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreComment : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreTitle", (formInquiryTransferRightScore.FormInquiryTransferRightScoreTitle != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreTitle : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScorePlaque", (formInquiryTransferRightScore.FormInquiryTransferRightScorePlaque != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScorePlaque : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScorelSection", (formInquiryTransferRightScore.FormInquiryTransferRightScorelSection != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScorelSection : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScorelRegisterInformationDate", (formInquiryTransferRightScore.FormInquiryTransferRightScorelRegisterInformationDate != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScorelRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreDossierClasses", (formInquiryTransferRightScore.FormInquiryTransferRightScoreDossierClasses != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreDeadDeathDate", (formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadDeathDate != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreRegisterInformationID", (formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterInformationID != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreRegisterarUserNationalCode", (formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterarUserNationalCode != null && formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterarUserNationalCode >0 ) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreDeclarationID", formInquiryTransferRightScore.FormInquiryTransferRightScoreDeclarationID),
			new SqlParameter("@FormInquiryTransferRightScoreFormInquiryResponseID", (formInquiryTransferRightScore.FormInquiryTransferRightScoreFormInquiryResponseID != null && formInquiryTransferRightScore.FormInquiryTransferRightScoreFormInquiryResponseID >0 ) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreInquiryTo", (formInquiryTransferRightScore.FormInquiryTransferRightScoreInquiryTo != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreInquiryTo : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreRuleComment", (formInquiryTransferRightScore.FormInquiryTransferRightScoreRuleComment != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreRuleComment : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreTaxUnitCode", (formInquiryTransferRightScore.FormInquiryTransferRightScoreTaxUnitCode != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreUser1FullName", (formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1FullName != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreUser2FullName", (formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2FullName != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreUser1TaxUnitCode", (formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1TaxUnitCode != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreAddress", (formInquiryTransferRightScore.FormInquiryTransferRightScoreAddress != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreAddress : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightScoreSixth", (formInquiryTransferRightScore.FormInquiryTransferRightScoreSixth != null) ? formInquiryTransferRightScore.FormInquiryTransferRightScoreSixth : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryTransferRightScore_Update", CommandType.StoredProcedure, parametersFormInquiryTransferRightScore);
	}

	public bool Delete(Int64 formInquiryTransferRightScorelID)
	{
		SqlParameter[] parametersFormInquiryTransferRightScore = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightScorelID", formInquiryTransferRightScorelID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryTransferRightScore_Delete", CommandType.StoredProcedure, parametersFormInquiryTransferRightScore);
	}

	public FormInquiryTransferRightScore GetDetails(Int64 formInquiryTransferRightScorelID)
	{
		FormInquiryTransferRightScore formInquiryTransferRightScore = new FormInquiryTransferRightScore();

		SqlParameter[] parametersFormInquiryTransferRightScore = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightScorelID", formInquiryTransferRightScorelID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryTransferRightScore_GetDetails", CommandType.StoredProcedure, parametersFormInquiryTransferRightScore))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				formInquiryTransferRightScore.FormInquiryTransferRightScorelID = (row["FormInquiryTransferRightScorelID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScorelID"]) : 0 ;
				formInquiryTransferRightScore.FormInquiryTransferRightScorePrintRegisterInformationID = row["FormInquiryTransferRightScorePrintRegisterInformationID"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScorePrintRegisterDate = row["FormInquiryTransferRightScorePrintRegisterDate"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2TaxGroupCode = row["FormInquiryTransferRightScoreUser2TaxGroupCode"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadFullName = row["FormInquiryTransferRightScoreDeadFullName"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScoreComment = row["FormInquiryTransferRightScoreComment"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScoreTitle = row["FormInquiryTransferRightScoreTitle"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScorePlaque = row["FormInquiryTransferRightScorePlaque"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScorelSection = row["FormInquiryTransferRightScorelSection"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScorelRegisterInformationDate = row["FormInquiryTransferRightScorelRegisterInformationDate"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScoreDossierClasses = row["FormInquiryTransferRightScoreDossierClasses"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadDeathDate = row["FormInquiryTransferRightScoreDeadDeathDate"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterInformationID = (row["FormInquiryTransferRightScoreRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreRegisterInformationID"]) : 0 ;
				formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterarUserNationalCode = (row["FormInquiryTransferRightScoreRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreRegisterarUserNationalCode"]) : 0 ;
				formInquiryTransferRightScore.FormInquiryTransferRightScoreDeclarationID = (row["FormInquiryTransferRightScoreDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreDeclarationID"]) : 0 ;
				formInquiryTransferRightScore.FormInquiryTransferRightScoreFormInquiryResponseID = (row["FormInquiryTransferRightScoreFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreFormInquiryResponseID"]) : 0 ;
				formInquiryTransferRightScore.FormInquiryTransferRightScoreInquiryTo = row["FormInquiryTransferRightScoreInquiryTo"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScoreRuleComment = row["FormInquiryTransferRightScoreRuleComment"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScoreTaxUnitCode = row["FormInquiryTransferRightScoreTaxUnitCode"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1FullName = row["FormInquiryTransferRightScoreUser1FullName"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2FullName = row["FormInquiryTransferRightScoreUser2FullName"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1TaxUnitCode = row["FormInquiryTransferRightScoreUser1TaxUnitCode"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScoreAddress = row["FormInquiryTransferRightScoreAddress"].ToString();
				formInquiryTransferRightScore.FormInquiryTransferRightScoreSixth = row["FormInquiryTransferRightScoreSixth"].ToString();
			}
		}

		return formInquiryTransferRightScore;
	}

	public List<FormInquiryTransferRightScore> GetListAll()
	{
		List<FormInquiryTransferRightScore> listFormInquiryTransferRightScore = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormInquiryTransferRightScore_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormInquiryTransferRightScore = new List<FormInquiryTransferRightScore>();

				foreach (DataRow row in table.Rows)
				{
					FormInquiryTransferRightScore formInquiryTransferRightScore = new FormInquiryTransferRightScore();
					formInquiryTransferRightScore.FormInquiryTransferRightScorelID = (row["FormInquiryTransferRightScorelID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScorelID"]) : 0 ;
					formInquiryTransferRightScore.FormInquiryTransferRightScorePrintRegisterInformationID = row["FormInquiryTransferRightScorePrintRegisterInformationID"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScorePrintRegisterDate = row["FormInquiryTransferRightScorePrintRegisterDate"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2TaxGroupCode = row["FormInquiryTransferRightScoreUser2TaxGroupCode"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadFullName = row["FormInquiryTransferRightScoreDeadFullName"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScoreComment = row["FormInquiryTransferRightScoreComment"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScoreTitle = row["FormInquiryTransferRightScoreTitle"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScorePlaque = row["FormInquiryTransferRightScorePlaque"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScorelSection = row["FormInquiryTransferRightScorelSection"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScorelRegisterInformationDate = row["FormInquiryTransferRightScorelRegisterInformationDate"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScoreDossierClasses = row["FormInquiryTransferRightScoreDossierClasses"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadDeathDate = row["FormInquiryTransferRightScoreDeadDeathDate"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterInformationID = (row["FormInquiryTransferRightScoreRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreRegisterInformationID"]) : 0 ;
					formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterarUserNationalCode = (row["FormInquiryTransferRightScoreRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreRegisterarUserNationalCode"]) : 0 ;
					formInquiryTransferRightScore.FormInquiryTransferRightScoreDeclarationID = (row["FormInquiryTransferRightScoreDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreDeclarationID"]) : 0 ;
					formInquiryTransferRightScore.FormInquiryTransferRightScoreFormInquiryResponseID = (row["FormInquiryTransferRightScoreFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreFormInquiryResponseID"]) : 0 ;
					formInquiryTransferRightScore.FormInquiryTransferRightScoreInquiryTo = row["FormInquiryTransferRightScoreInquiryTo"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScoreRuleComment = row["FormInquiryTransferRightScoreRuleComment"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScoreTaxUnitCode = row["FormInquiryTransferRightScoreTaxUnitCode"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1FullName = row["FormInquiryTransferRightScoreUser1FullName"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2FullName = row["FormInquiryTransferRightScoreUser2FullName"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1TaxUnitCode = row["FormInquiryTransferRightScoreUser1TaxUnitCode"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScoreAddress = row["FormInquiryTransferRightScoreAddress"].ToString();
					formInquiryTransferRightScore.FormInquiryTransferRightScoreSixth = row["FormInquiryTransferRightScoreSixth"].ToString();
					listFormInquiryTransferRightScore.Add(formInquiryTransferRightScore);
				}
			}
		}

		return listFormInquiryTransferRightScore;
	}

	public bool Exists(Int64 formInquiryTransferRightScorelID)
	{
		SqlParameter[] parametersFormInquiryTransferRightScore = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightScorelID", formInquiryTransferRightScorelID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryTransferRightScore_Exists", CommandType.StoredProcedure, parametersFormInquiryTransferRightScore)>0);
	}

	public bool Exists(FormInquiryTransferRightScore formInquiryTransferRightScore)
	{
		SqlParameter[] parametersFormInquiryTransferRightScore = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightScorelID", formInquiryTransferRightScore.FormInquiryTransferRightScorelID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryTransferRightScore_Exists", CommandType.StoredProcedure, parametersFormInquiryTransferRightScore)>0);
	}

	public List<FormInquiryTransferRightScore> SearchLike(FormInquiryTransferRightScore formInquiryTransferRightScore)
	{
		List<FormInquiryTransferRightScore> listFormInquiryTransferRightScore = new List<FormInquiryTransferRightScore>();


		SqlParameter[] parametersFormInquiryTransferRightScore = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightScorelID", formInquiryTransferRightScore.FormInquiryTransferRightScorelID),
			new SqlParameter("@FormInquiryTransferRightScorePrintRegisterInformationID", formInquiryTransferRightScore.FormInquiryTransferRightScorePrintRegisterInformationID),
			new SqlParameter("@FormInquiryTransferRightScorePrintRegisterDate", formInquiryTransferRightScore.FormInquiryTransferRightScorePrintRegisterDate),
			new SqlParameter("@FormInquiryTransferRightScoreUser2TaxGroupCode", formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2TaxGroupCode),
			new SqlParameter("@FormInquiryTransferRightScoreDeadFullName", formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadFullName),
			new SqlParameter("@FormInquiryTransferRightScoreComment", formInquiryTransferRightScore.FormInquiryTransferRightScoreComment),
			new SqlParameter("@FormInquiryTransferRightScoreTitle", formInquiryTransferRightScore.FormInquiryTransferRightScoreTitle),
			new SqlParameter("@FormInquiryTransferRightScorePlaque", formInquiryTransferRightScore.FormInquiryTransferRightScorePlaque),
			new SqlParameter("@FormInquiryTransferRightScorelSection", formInquiryTransferRightScore.FormInquiryTransferRightScorelSection),
			new SqlParameter("@FormInquiryTransferRightScorelRegisterInformationDate", formInquiryTransferRightScore.FormInquiryTransferRightScorelRegisterInformationDate),
			new SqlParameter("@FormInquiryTransferRightScoreDossierClasses", formInquiryTransferRightScore.FormInquiryTransferRightScoreDossierClasses),
			new SqlParameter("@FormInquiryTransferRightScoreDeadDeathDate", formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadDeathDate),
			new SqlParameter("@FormInquiryTransferRightScoreRegisterInformationID", formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterInformationID),
			new SqlParameter("@FormInquiryTransferRightScoreRegisterarUserNationalCode", formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterarUserNationalCode),
			new SqlParameter("@FormInquiryTransferRightScoreDeclarationID", formInquiryTransferRightScore.FormInquiryTransferRightScoreDeclarationID),
			new SqlParameter("@FormInquiryTransferRightScoreFormInquiryResponseID", formInquiryTransferRightScore.FormInquiryTransferRightScoreFormInquiryResponseID),
			new SqlParameter("@FormInquiryTransferRightScoreInquiryTo", formInquiryTransferRightScore.FormInquiryTransferRightScoreInquiryTo),
			new SqlParameter("@FormInquiryTransferRightScoreRuleComment", formInquiryTransferRightScore.FormInquiryTransferRightScoreRuleComment),
			new SqlParameter("@FormInquiryTransferRightScoreTaxUnitCode", formInquiryTransferRightScore.FormInquiryTransferRightScoreTaxUnitCode),
			new SqlParameter("@FormInquiryTransferRightScoreUser1FullName", formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1FullName),
			new SqlParameter("@FormInquiryTransferRightScoreUser2FullName", formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2FullName),
			new SqlParameter("@FormInquiryTransferRightScoreUser1TaxUnitCode", formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1TaxUnitCode),
			new SqlParameter("@FormInquiryTransferRightScoreAddress", formInquiryTransferRightScore.FormInquiryTransferRightScoreAddress),
			new SqlParameter("@FormInquiryTransferRightScoreSixth", formInquiryTransferRightScore.FormInquiryTransferRightScoreSixth),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryTransferRightScore_SearchLike", CommandType.StoredProcedure, parametersFormInquiryTransferRightScore))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormInquiryTransferRightScore tmpFormInquiryTransferRightScore = new FormInquiryTransferRightScore();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScorelID = (row["FormInquiryTransferRightScorelID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScorelID"]) : 0 ;
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScorePrintRegisterInformationID = row["FormInquiryTransferRightScorePrintRegisterInformationID"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScorePrintRegisterDate = row["FormInquiryTransferRightScorePrintRegisterDate"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreUser2TaxGroupCode = row["FormInquiryTransferRightScoreUser2TaxGroupCode"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreDeadFullName = row["FormInquiryTransferRightScoreDeadFullName"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreComment = row["FormInquiryTransferRightScoreComment"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreTitle = row["FormInquiryTransferRightScoreTitle"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScorePlaque = row["FormInquiryTransferRightScorePlaque"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScorelSection = row["FormInquiryTransferRightScorelSection"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScorelRegisterInformationDate = row["FormInquiryTransferRightScorelRegisterInformationDate"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreDossierClasses = row["FormInquiryTransferRightScoreDossierClasses"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreDeadDeathDate = row["FormInquiryTransferRightScoreDeadDeathDate"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterInformationID = (row["FormInquiryTransferRightScoreRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreRegisterInformationID"]) : 0 ;
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterarUserNationalCode = (row["FormInquiryTransferRightScoreRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreRegisterarUserNationalCode"]) : 0 ;
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreDeclarationID = (row["FormInquiryTransferRightScoreDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreDeclarationID"]) : 0 ;
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreFormInquiryResponseID = (row["FormInquiryTransferRightScoreFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreFormInquiryResponseID"]) : 0 ;
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreInquiryTo = row["FormInquiryTransferRightScoreInquiryTo"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreRuleComment = row["FormInquiryTransferRightScoreRuleComment"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreTaxUnitCode = row["FormInquiryTransferRightScoreTaxUnitCode"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreUser1FullName = row["FormInquiryTransferRightScoreUser1FullName"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreUser2FullName = row["FormInquiryTransferRightScoreUser2FullName"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreUser1TaxUnitCode = row["FormInquiryTransferRightScoreUser1TaxUnitCode"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreAddress = row["FormInquiryTransferRightScoreAddress"].ToString();
					tmpFormInquiryTransferRightScore.FormInquiryTransferRightScoreSixth = row["FormInquiryTransferRightScoreSixth"].ToString();

					listFormInquiryTransferRightScore.Add(tmpFormInquiryTransferRightScore);
				}
			}
		}

		return listFormInquiryTransferRightScore;
	}

}
}
