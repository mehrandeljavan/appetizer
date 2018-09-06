using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormInquiryOtherDBAccess
{


	public Int64 Insert(FormInquiryOther formInquiryOther)
	{
		SqlParameter[] parametersFormInquiryOther = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryOtherRegisterInformationDate", (formInquiryOther.FormInquiryOtherRegisterInformationDate != null) ? formInquiryOther.FormInquiryOtherRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherDossierClasses", (formInquiryOther.FormInquiryOtherDossierClasses != null) ? formInquiryOther.FormInquiryOtherDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherDeadDeathDate", (formInquiryOther.FormInquiryOtherDeadDeathDate != null) ? formInquiryOther.FormInquiryOtherDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherRegisterInformationID", (formInquiryOther.FormInquiryOtherRegisterInformationID != null) ? formInquiryOther.FormInquiryOtherRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherRegisterarUserNationalCode", (formInquiryOther.FormInquiryOtherRegisterarUserNationalCode > 0) ? formInquiryOther.FormInquiryOtherRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherDeclarationID", (formInquiryOther.FormInquiryOtherDeclarationID > 0) ? formInquiryOther.FormInquiryOtherDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherFormInquiryResponseID", (formInquiryOther.FormInquiryOtherFormInquiryResponseID > 0) ? formInquiryOther.FormInquiryOtherFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherDescription", (formInquiryOther.FormInquiryOtherDescription != null) ? formInquiryOther.FormInquiryOtherDescription : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherReciever", (formInquiryOther.FormInquiryOtherReciever != null) ? formInquiryOther.FormInquiryOtherReciever : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherDeadFullName", (formInquiryOther.FormInquiryOtherDeadFullName != null) ? formInquiryOther.FormInquiryOtherDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherTaxUnitCode", (formInquiryOther.FormInquiryOtherTaxUnitCode != null) ? formInquiryOther.FormInquiryOtherTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherUser1FullName", (formInquiryOther.FormInquiryOtherUser1FullName != null) ? formInquiryOther.FormInquiryOtherUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherUser2FullName", (formInquiryOther.FormInquiryOtherUser2FullName != null) ? formInquiryOther.FormInquiryOtherUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherUser1TaxUnitCode", (formInquiryOther.FormInquiryOtherUser1TaxUnitCode != null) ? formInquiryOther.FormInquiryOtherUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherUser2TaxGroupCode", (formInquiryOther.FormInquiryOtherUser2TaxGroupCode != null) ? formInquiryOther.FormInquiryOtherUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherHeritageDescription", (formInquiryOther.FormInquiryOtherHeritageDescription != null) ? formInquiryOther.FormInquiryOtherHeritageDescription : (object)DBNull.Value)
		};
		formInquiryOther.FormInquiryOtherID = SqlDBHelper.ExecuteScalar("FormInquiryOther_Insert", CommandType.StoredProcedure, parametersFormInquiryOther);
		return formInquiryOther.FormInquiryOtherID;
	}

	public bool Update(FormInquiryOther formInquiryOther)
	{
		SqlParameter[] parametersFormInquiryOther = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryOtherID", formInquiryOther.FormInquiryOtherID),
			new SqlParameter("@FormInquiryOtherRegisterInformationDate", (formInquiryOther.FormInquiryOtherRegisterInformationDate != null) ? formInquiryOther.FormInquiryOtherRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherDossierClasses", (formInquiryOther.FormInquiryOtherDossierClasses != null) ? formInquiryOther.FormInquiryOtherDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherDeadDeathDate", (formInquiryOther.FormInquiryOtherDeadDeathDate != null) ? formInquiryOther.FormInquiryOtherDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherRegisterInformationID", (formInquiryOther.FormInquiryOtherRegisterInformationID != null) ? formInquiryOther.FormInquiryOtherRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherRegisterarUserNationalCode", (formInquiryOther.FormInquiryOtherRegisterarUserNationalCode != null && formInquiryOther.FormInquiryOtherRegisterarUserNationalCode >0 ) ? formInquiryOther.FormInquiryOtherRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherDeclarationID", formInquiryOther.FormInquiryOtherDeclarationID),
			new SqlParameter("@FormInquiryOtherFormInquiryResponseID", (formInquiryOther.FormInquiryOtherFormInquiryResponseID != null && formInquiryOther.FormInquiryOtherFormInquiryResponseID >0 ) ? formInquiryOther.FormInquiryOtherFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherDescription", (formInquiryOther.FormInquiryOtherDescription != null) ? formInquiryOther.FormInquiryOtherDescription : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherReciever", (formInquiryOther.FormInquiryOtherReciever != null) ? formInquiryOther.FormInquiryOtherReciever : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherDeadFullName", (formInquiryOther.FormInquiryOtherDeadFullName != null) ? formInquiryOther.FormInquiryOtherDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherTaxUnitCode", (formInquiryOther.FormInquiryOtherTaxUnitCode != null) ? formInquiryOther.FormInquiryOtherTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherUser1FullName", (formInquiryOther.FormInquiryOtherUser1FullName != null) ? formInquiryOther.FormInquiryOtherUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherUser2FullName", (formInquiryOther.FormInquiryOtherUser2FullName != null) ? formInquiryOther.FormInquiryOtherUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherUser1TaxUnitCode", (formInquiryOther.FormInquiryOtherUser1TaxUnitCode != null) ? formInquiryOther.FormInquiryOtherUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherUser2TaxGroupCode", (formInquiryOther.FormInquiryOtherUser2TaxGroupCode != null) ? formInquiryOther.FormInquiryOtherUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryOtherHeritageDescription", (formInquiryOther.FormInquiryOtherHeritageDescription != null) ? formInquiryOther.FormInquiryOtherHeritageDescription : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryOther_Update", CommandType.StoredProcedure, parametersFormInquiryOther);
	}

	public bool Delete(Int64 formInquiryOtherID)
	{
		SqlParameter[] parametersFormInquiryOther = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryOtherID", formInquiryOtherID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryOther_Delete", CommandType.StoredProcedure, parametersFormInquiryOther);
	}

	public FormInquiryOther GetDetails(Int64 formInquiryOtherID)
	{
		FormInquiryOther formInquiryOther = new FormInquiryOther();

		SqlParameter[] parametersFormInquiryOther = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryOtherID", formInquiryOtherID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryOther_GetDetails", CommandType.StoredProcedure, parametersFormInquiryOther))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				formInquiryOther.FormInquiryOtherID = (row["FormInquiryOtherID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherID"]) : 0 ;
				formInquiryOther.FormInquiryOtherPrintRegisterInformationID = row["FormInquiryOtherPrintRegisterInformationID"].ToString();
				formInquiryOther.FormInquiryOtherPrintRegisterDate = row["FormInquiryOtherPrintRegisterDate"].ToString();
				formInquiryOther.FormInquiryOtherRegisterInformationDate = row["FormInquiryOtherRegisterInformationDate"].ToString();
				formInquiryOther.FormInquiryOtherDossierClasses = row["FormInquiryOtherDossierClasses"].ToString();
				formInquiryOther.FormInquiryOtherDeadDeathDate = row["FormInquiryOtherDeadDeathDate"].ToString();
				formInquiryOther.FormInquiryOtherRegisterInformationID = (row["FormInquiryOtherRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherRegisterInformationID"]) : 0 ;
				formInquiryOther.FormInquiryOtherRegisterarUserNationalCode = (row["FormInquiryOtherRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherRegisterarUserNationalCode"]) : 0 ;
				formInquiryOther.FormInquiryOtherDeclarationID = (row["FormInquiryOtherDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherDeclarationID"]) : 0 ;
				formInquiryOther.FormInquiryOtherFormInquiryResponseID = (row["FormInquiryOtherFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherFormInquiryResponseID"]) : 0 ;
				formInquiryOther.FormInquiryOtherDescription = row["FormInquiryOtherDescription"].ToString();
				formInquiryOther.FormInquiryOtherReciever = row["FormInquiryOtherReciever"].ToString();
				formInquiryOther.FormInquiryOtherDeadFullName = row["FormInquiryOtherDeadFullName"].ToString();
				formInquiryOther.FormInquiryOtherTaxUnitCode = row["FormInquiryOtherTaxUnitCode"].ToString();
				formInquiryOther.FormInquiryOtherUser1FullName = row["FormInquiryOtherUser1FullName"].ToString();
				formInquiryOther.FormInquiryOtherUser2FullName = row["FormInquiryOtherUser2FullName"].ToString();
				formInquiryOther.FormInquiryOtherUser1TaxUnitCode = row["FormInquiryOtherUser1TaxUnitCode"].ToString();
				formInquiryOther.FormInquiryOtherUser2TaxGroupCode = row["FormInquiryOtherUser2TaxGroupCode"].ToString();
				formInquiryOther.FormInquiryOtherHeritageDescription = row["FormInquiryOtherHeritageDescription"].ToString();
			}
		}

		return formInquiryOther;
	}

	public List<FormInquiryOther> GetListAll()
	{
		List<FormInquiryOther> listFormInquiryOther = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormInquiryOther_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormInquiryOther = new List<FormInquiryOther>();

				foreach (DataRow row in table.Rows)
				{
					FormInquiryOther formInquiryOther = new FormInquiryOther();
					formInquiryOther.FormInquiryOtherID = (row["FormInquiryOtherID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherID"]) : 0 ;
					formInquiryOther.FormInquiryOtherPrintRegisterInformationID = row["FormInquiryOtherPrintRegisterInformationID"].ToString();
					formInquiryOther.FormInquiryOtherPrintRegisterDate = row["FormInquiryOtherPrintRegisterDate"].ToString();
					formInquiryOther.FormInquiryOtherRegisterInformationDate = row["FormInquiryOtherRegisterInformationDate"].ToString();
					formInquiryOther.FormInquiryOtherDossierClasses = row["FormInquiryOtherDossierClasses"].ToString();
					formInquiryOther.FormInquiryOtherDeadDeathDate = row["FormInquiryOtherDeadDeathDate"].ToString();
					formInquiryOther.FormInquiryOtherRegisterInformationID = (row["FormInquiryOtherRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherRegisterInformationID"]) : 0 ;
					formInquiryOther.FormInquiryOtherRegisterarUserNationalCode = (row["FormInquiryOtherRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherRegisterarUserNationalCode"]) : 0 ;
					formInquiryOther.FormInquiryOtherDeclarationID = (row["FormInquiryOtherDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherDeclarationID"]) : 0 ;
					formInquiryOther.FormInquiryOtherFormInquiryResponseID = (row["FormInquiryOtherFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherFormInquiryResponseID"]) : 0 ;
					formInquiryOther.FormInquiryOtherDescription = row["FormInquiryOtherDescription"].ToString();
					formInquiryOther.FormInquiryOtherReciever = row["FormInquiryOtherReciever"].ToString();
					formInquiryOther.FormInquiryOtherDeadFullName = row["FormInquiryOtherDeadFullName"].ToString();
					formInquiryOther.FormInquiryOtherTaxUnitCode = row["FormInquiryOtherTaxUnitCode"].ToString();
					formInquiryOther.FormInquiryOtherUser1FullName = row["FormInquiryOtherUser1FullName"].ToString();
					formInquiryOther.FormInquiryOtherUser2FullName = row["FormInquiryOtherUser2FullName"].ToString();
					formInquiryOther.FormInquiryOtherUser1TaxUnitCode = row["FormInquiryOtherUser1TaxUnitCode"].ToString();
					formInquiryOther.FormInquiryOtherUser2TaxGroupCode = row["FormInquiryOtherUser2TaxGroupCode"].ToString();
					formInquiryOther.FormInquiryOtherHeritageDescription = row["FormInquiryOtherHeritageDescription"].ToString();
					listFormInquiryOther.Add(formInquiryOther);
				}
			}
		}

		return listFormInquiryOther;
	}

	public bool Exists(Int64 formInquiryOtherID)
	{
		SqlParameter[] parametersFormInquiryOther = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryOtherID", formInquiryOtherID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryOther_Exists", CommandType.StoredProcedure, parametersFormInquiryOther)>0);
	}

	public bool Exists(FormInquiryOther formInquiryOther)
	{
		SqlParameter[] parametersFormInquiryOther = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryOtherID", formInquiryOther.FormInquiryOtherID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryOther_Exists", CommandType.StoredProcedure, parametersFormInquiryOther)>0);
	}

	public List<FormInquiryOther> SearchLike(FormInquiryOther formInquiryOther)
	{
		List<FormInquiryOther> listFormInquiryOther = new List<FormInquiryOther>();


		SqlParameter[] parametersFormInquiryOther = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryOtherID", formInquiryOther.FormInquiryOtherID),
			new SqlParameter("@FormInquiryOtherPrintRegisterInformationID", formInquiryOther.FormInquiryOtherPrintRegisterInformationID),
			new SqlParameter("@FormInquiryOtherPrintRegisterDate", formInquiryOther.FormInquiryOtherPrintRegisterDate),
			new SqlParameter("@FormInquiryOtherRegisterInformationDate", formInquiryOther.FormInquiryOtherRegisterInformationDate),
			new SqlParameter("@FormInquiryOtherDossierClasses", formInquiryOther.FormInquiryOtherDossierClasses),
			new SqlParameter("@FormInquiryOtherDeadDeathDate", formInquiryOther.FormInquiryOtherDeadDeathDate),
			new SqlParameter("@FormInquiryOtherRegisterInformationID", formInquiryOther.FormInquiryOtherRegisterInformationID),
			new SqlParameter("@FormInquiryOtherRegisterarUserNationalCode", formInquiryOther.FormInquiryOtherRegisterarUserNationalCode),
			new SqlParameter("@FormInquiryOtherDeclarationID", formInquiryOther.FormInquiryOtherDeclarationID),
			new SqlParameter("@FormInquiryOtherFormInquiryResponseID", formInquiryOther.FormInquiryOtherFormInquiryResponseID),
			new SqlParameter("@FormInquiryOtherDescription", formInquiryOther.FormInquiryOtherDescription),
			new SqlParameter("@FormInquiryOtherReciever", formInquiryOther.FormInquiryOtherReciever),
			new SqlParameter("@FormInquiryOtherDeadFullName", formInquiryOther.FormInquiryOtherDeadFullName),
			new SqlParameter("@FormInquiryOtherTaxUnitCode", formInquiryOther.FormInquiryOtherTaxUnitCode),
			new SqlParameter("@FormInquiryOtherUser1FullName", formInquiryOther.FormInquiryOtherUser1FullName),
			new SqlParameter("@FormInquiryOtherUser2FullName", formInquiryOther.FormInquiryOtherUser2FullName),
			new SqlParameter("@FormInquiryOtherUser1TaxUnitCode", formInquiryOther.FormInquiryOtherUser1TaxUnitCode),
			new SqlParameter("@FormInquiryOtherUser2TaxGroupCode", formInquiryOther.FormInquiryOtherUser2TaxGroupCode),
			new SqlParameter("@FormInquiryOtherHeritageDescription", formInquiryOther.FormInquiryOtherHeritageDescription),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryOther_SearchLike", CommandType.StoredProcedure, parametersFormInquiryOther))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormInquiryOther tmpFormInquiryOther = new FormInquiryOther();
					tmpFormInquiryOther.FormInquiryOtherID = (row["FormInquiryOtherID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherID"]) : 0 ;
					tmpFormInquiryOther.FormInquiryOtherPrintRegisterInformationID = row["FormInquiryOtherPrintRegisterInformationID"].ToString();
					tmpFormInquiryOther.FormInquiryOtherPrintRegisterDate = row["FormInquiryOtherPrintRegisterDate"].ToString();
					tmpFormInquiryOther.FormInquiryOtherRegisterInformationDate = row["FormInquiryOtherRegisterInformationDate"].ToString();
					tmpFormInquiryOther.FormInquiryOtherDossierClasses = row["FormInquiryOtherDossierClasses"].ToString();
					tmpFormInquiryOther.FormInquiryOtherDeadDeathDate = row["FormInquiryOtherDeadDeathDate"].ToString();
					tmpFormInquiryOther.FormInquiryOtherRegisterInformationID = (row["FormInquiryOtherRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherRegisterInformationID"]) : 0 ;
					tmpFormInquiryOther.FormInquiryOtherRegisterarUserNationalCode = (row["FormInquiryOtherRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherRegisterarUserNationalCode"]) : 0 ;
					tmpFormInquiryOther.FormInquiryOtherDeclarationID = (row["FormInquiryOtherDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherDeclarationID"]) : 0 ;
					tmpFormInquiryOther.FormInquiryOtherFormInquiryResponseID = (row["FormInquiryOtherFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherFormInquiryResponseID"]) : 0 ;
					tmpFormInquiryOther.FormInquiryOtherDescription = row["FormInquiryOtherDescription"].ToString();
					tmpFormInquiryOther.FormInquiryOtherReciever = row["FormInquiryOtherReciever"].ToString();
					tmpFormInquiryOther.FormInquiryOtherDeadFullName = row["FormInquiryOtherDeadFullName"].ToString();
					tmpFormInquiryOther.FormInquiryOtherTaxUnitCode = row["FormInquiryOtherTaxUnitCode"].ToString();
					tmpFormInquiryOther.FormInquiryOtherUser1FullName = row["FormInquiryOtherUser1FullName"].ToString();
					tmpFormInquiryOther.FormInquiryOtherUser2FullName = row["FormInquiryOtherUser2FullName"].ToString();
					tmpFormInquiryOther.FormInquiryOtherUser1TaxUnitCode = row["FormInquiryOtherUser1TaxUnitCode"].ToString();
					tmpFormInquiryOther.FormInquiryOtherUser2TaxGroupCode = row["FormInquiryOtherUser2TaxGroupCode"].ToString();
					tmpFormInquiryOther.FormInquiryOtherHeritageDescription = row["FormInquiryOtherHeritageDescription"].ToString();

					listFormInquiryOther.Add(tmpFormInquiryOther);
				}
			}
		}

		return listFormInquiryOther;
	}

}
}
