using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class Form19DBAccess
{


	public Int64 Insert(Form19 form19)
	{
		SqlParameter[] parametersForm19 = new SqlParameter[]
		{
			new SqlParameter("@Form19RequestNumber", (form19.Form19RequestNumber != null) ? form19.Form19RequestNumber : (object)DBNull.Value),
			new SqlParameter("@Form19RequestFullName", (form19.Form19RequestFullName != null) ? form19.Form19RequestFullName : (object)DBNull.Value),
			new SqlParameter("@Form19HeirFullName", (form19.Form19HeirFullName != null) ? form19.Form19HeirFullName : (object)DBNull.Value),
			new SqlParameter("@Form19TaxUnitCode", (form19.Form19TaxUnitCode != null) ? form19.Form19TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@Form19TaxUnitUserFullName", (form19.Form19TaxUnitUserFullName != null) ? form19.Form19TaxUnitUserFullName : (object)DBNull.Value),
			new SqlParameter("@Form19TaxGroupCode", (form19.Form19TaxGroupCode != null) ? form19.Form19TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@Form19DeadIssuanceCity", (form19.Form19DeadIssuanceCity != null) ? form19.Form19DeadIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@Form19DeadDeathCity", (form19.Form19DeadDeathCity != null) ? form19.Form19DeadDeathCity : (object)DBNull.Value),
			new SqlParameter("@Form19Comment1", (form19.Form19Comment1 != null) ? form19.Form19Comment1 : (object)DBNull.Value),
			new SqlParameter("@Form19Comment2", (form19.Form19Comment2 != null) ? form19.Form19Comment2 : (object)DBNull.Value),
			new SqlParameter("@Form19Comment3", (form19.Form19Comment3 != null) ? form19.Form19Comment3 : (object)DBNull.Value),
			new SqlParameter("@Form19HeritagesDescription", (form19.Form19HeritagesDescription != null) ? form19.Form19HeritagesDescription : (object)DBNull.Value),
			new SqlParameter("@Form19RequestFamily", (form19.Form19RequestFamily != null) ? form19.Form19RequestFamily : (object)DBNull.Value),
			new SqlParameter("@Form19RequestCertificateNumber", (form19.Form19RequestCertificateNumber != null) ? form19.Form19RequestCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@Form19RequestIssuanceCity", (form19.Form19RequestIssuanceCity != null) ? form19.Form19RequestIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@Form19DeadName", (form19.Form19DeadName != null) ? form19.Form19DeadName : (object)DBNull.Value),
			new SqlParameter("@Form19DeadFamily", (form19.Form19DeadFamily != null) ? form19.Form19DeadFamily : (object)DBNull.Value),
			new SqlParameter("@Form19DeadCertificateNumber", (form19.Form19DeadCertificateNumber != null) ? form19.Form19DeadCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@Form19RegisterInformationID", (form19.Form19RegisterInformationID > 0) ? form19.Form19RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@Form19RequestNationalCode", (form19.Form19RequestNationalCode != null) ? form19.Form19RequestNationalCode : (object)DBNull.Value),
			new SqlParameter("@Form19RegisterarUserNationalCode", (form19.Form19RegisterarUserNationalCode != null) ? form19.Form19RegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@Form19DeclarationID", (form19.Form19DeclarationID > 0) ? form19.Form19DeclarationID : (object)DBNull.Value),
			new SqlParameter("@Form19DeadNationalCode", (form19.Form19DeadNationalCode != null) ? form19.Form19DeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@Form19RegisterInformationDate", (form19.Form19RegisterInformationDate != null) ? form19.Form19RegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@Form19DeadDeathDate", (form19.Form19DeadDeathDate != null) ? form19.Form19DeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@Form19RequestDate", (form19.Form19RequestDate != null) ? form19.Form19RequestDate : (object)DBNull.Value),
			new SqlParameter("@Form19DossierClasses", (form19.Form19DossierClasses != null) ? form19.Form19DossierClasses : (object)DBNull.Value),
			new SqlParameter("@Form19TaxOfficeProvince", (form19.Form19TaxOfficeProvince != null) ? form19.Form19TaxOfficeProvince : (object)DBNull.Value),
			new SqlParameter("@Form19TaxOfficeCity", (form19.Form19TaxOfficeCity != null) ? form19.Form19TaxOfficeCity : (object)DBNull.Value),
			new SqlParameter("@Form19TaxOfficePhoneNumber", (form19.Form19TaxOfficePhoneNumber != null) ? form19.Form19TaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@Form19TaxOfficeAddress", (form19.Form19TaxOfficeAddress != null) ? form19.Form19TaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@Form19RequestName", (form19.Form19RequestName != null) ? form19.Form19RequestName : (object)DBNull.Value),
			new SqlParameter("@Form19TaxGroupUserFullName", (form19.Form19TaxGroupUserFullName != null) ? form19.Form19TaxGroupUserFullName : (object)DBNull.Value),
			new SqlParameter("@Form19RequestRelationship", (form19.Form19RequestRelationship != null) ? form19.Form19RequestRelationship : (object)DBNull.Value),
			new SqlParameter("@Form19HeirShareDescription", (form19.Form19HeirShareDescription != null) ? form19.Form19HeirShareDescription : (object)DBNull.Value),
			new SqlParameter("@Form19TaxOfficeCode", (form19.Form19TaxOfficeCode != null) ? form19.Form19TaxOfficeCode : (object)DBNull.Value)
		};
		form19.Form19ID = SqlDBHelper.ExecuteScalar("Form19_Insert", CommandType.StoredProcedure, parametersForm19);
		return form19.Form19ID;
	}

	public bool Update(Form19 form19)
	{
		SqlParameter[] parametersForm19 = new SqlParameter[]
		{
			new SqlParameter("@Form19ID", form19.Form19ID),
			new SqlParameter("@Form19RequestNumber", (form19.Form19RequestNumber != null) ? form19.Form19RequestNumber : (object)DBNull.Value),
			new SqlParameter("@Form19RequestFullName", (form19.Form19RequestFullName != null) ? form19.Form19RequestFullName : (object)DBNull.Value),
			new SqlParameter("@Form19HeirFullName", (form19.Form19HeirFullName != null) ? form19.Form19HeirFullName : (object)DBNull.Value),
			new SqlParameter("@Form19TaxUnitCode", (form19.Form19TaxUnitCode != null) ? form19.Form19TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@Form19TaxUnitUserFullName", (form19.Form19TaxUnitUserFullName != null) ? form19.Form19TaxUnitUserFullName : (object)DBNull.Value),
			new SqlParameter("@Form19TaxGroupCode", (form19.Form19TaxGroupCode != null) ? form19.Form19TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@Form19DeadIssuanceCity", (form19.Form19DeadIssuanceCity != null) ? form19.Form19DeadIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@Form19DeadDeathCity", (form19.Form19DeadDeathCity != null) ? form19.Form19DeadDeathCity : (object)DBNull.Value),
			new SqlParameter("@Form19Comment1", (form19.Form19Comment1 != null) ? form19.Form19Comment1 : (object)DBNull.Value),
			new SqlParameter("@Form19Comment2", (form19.Form19Comment2 != null) ? form19.Form19Comment2 : (object)DBNull.Value),
			new SqlParameter("@Form19Comment3", (form19.Form19Comment3 != null) ? form19.Form19Comment3 : (object)DBNull.Value),
			new SqlParameter("@Form19HeritagesDescription", (form19.Form19HeritagesDescription != null) ? form19.Form19HeritagesDescription : (object)DBNull.Value),
			new SqlParameter("@Form19RequestFamily", (form19.Form19RequestFamily != null) ? form19.Form19RequestFamily : (object)DBNull.Value),
			new SqlParameter("@Form19RequestCertificateNumber", (form19.Form19RequestCertificateNumber != null) ? form19.Form19RequestCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@Form19RequestIssuanceCity", (form19.Form19RequestIssuanceCity != null) ? form19.Form19RequestIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@Form19DeadName", (form19.Form19DeadName != null) ? form19.Form19DeadName : (object)DBNull.Value),
			new SqlParameter("@Form19DeadFamily", (form19.Form19DeadFamily != null) ? form19.Form19DeadFamily : (object)DBNull.Value),
			new SqlParameter("@Form19DeadCertificateNumber", (form19.Form19DeadCertificateNumber != null) ? form19.Form19DeadCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@Form19RegisterInformationID", form19.Form19RegisterInformationID),
			new SqlParameter("@Form19RequestNationalCode", (form19.Form19RequestNationalCode != null) ? form19.Form19RequestNationalCode : (object)DBNull.Value),
			new SqlParameter("@Form19RegisterarUserNationalCode", (form19.Form19RegisterarUserNationalCode != null) ? form19.Form19RegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@Form19DeclarationID", form19.Form19DeclarationID),
			new SqlParameter("@Form19DeadNationalCode", (form19.Form19DeadNationalCode != null) ? form19.Form19DeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@Form19RegisterInformationDate", (form19.Form19RegisterInformationDate != null) ? form19.Form19RegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@Form19DeadDeathDate", (form19.Form19DeadDeathDate != null) ? form19.Form19DeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@Form19RequestDate", (form19.Form19RequestDate != null) ? form19.Form19RequestDate : (object)DBNull.Value),
			new SqlParameter("@Form19DossierClasses", (form19.Form19DossierClasses != null) ? form19.Form19DossierClasses : (object)DBNull.Value),
			new SqlParameter("@Form19TaxOfficeProvince", (form19.Form19TaxOfficeProvince != null) ? form19.Form19TaxOfficeProvince : (object)DBNull.Value),
			new SqlParameter("@Form19TaxOfficeCity", (form19.Form19TaxOfficeCity != null) ? form19.Form19TaxOfficeCity : (object)DBNull.Value),
			new SqlParameter("@Form19TaxOfficePhoneNumber", (form19.Form19TaxOfficePhoneNumber != null) ? form19.Form19TaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@Form19TaxOfficeAddress", (form19.Form19TaxOfficeAddress != null) ? form19.Form19TaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@Form19RequestName", (form19.Form19RequestName != null) ? form19.Form19RequestName : (object)DBNull.Value),
			new SqlParameter("@Form19TaxGroupUserFullName", (form19.Form19TaxGroupUserFullName != null) ? form19.Form19TaxGroupUserFullName : (object)DBNull.Value),
			new SqlParameter("@Form19RequestRelationship", (form19.Form19RequestRelationship != null) ? form19.Form19RequestRelationship : (object)DBNull.Value),
			new SqlParameter("@Form19HeirShareDescription", (form19.Form19HeirShareDescription != null) ? form19.Form19HeirShareDescription : (object)DBNull.Value),
			new SqlParameter("@Form19TaxOfficeCode", (form19.Form19TaxOfficeCode != null) ? form19.Form19TaxOfficeCode : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Form19_Update", CommandType.StoredProcedure, parametersForm19);
	}

	public bool Delete(Int64 form19ID)
	{
		SqlParameter[] parametersForm19 = new SqlParameter[]
		{
			new SqlParameter("@Form19ID", form19ID)
		};
		return SqlDBHelper.ExecuteNonQuery("Form19_Delete", CommandType.StoredProcedure, parametersForm19);
	}

	public Form19 GetDetails(Int64 form19ID)
	{
		Form19 form19 = new Form19();

		SqlParameter[] parametersForm19 = new SqlParameter[]
		{
			new SqlParameter("@Form19ID", form19ID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Form19_GetDetails", CommandType.StoredProcedure, parametersForm19))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				form19.Form19ID = (row["Form19ID"] != DBNull.Value) ? Convert.ToInt64(row["Form19ID"]) : 0 ;
				form19.Form19PrintRegisterInformationID = row["Form19PrintRegisterInformationID"].ToString();
				form19.Form19PrintRegisterDate = row["Form19PrintRegisterDate"].ToString();
				form19.Form19RequestNumber = row["Form19RequestNumber"].ToString();
				form19.Form19RequestFullName = row["Form19RequestFullName"].ToString();
				form19.Form19HeirFullName = row["Form19HeirFullName"].ToString();
				form19.Form19TaxUnitCode = row["Form19TaxUnitCode"].ToString();
				form19.Form19TaxUnitUserFullName = row["Form19TaxUnitUserFullName"].ToString();
				form19.Form19TaxGroupCode = row["Form19TaxGroupCode"].ToString();
				form19.Form19DeadIssuanceCity = row["Form19DeadIssuanceCity"].ToString();
				form19.Form19DeadDeathCity = row["Form19DeadDeathCity"].ToString();
				form19.Form19Comment1 = row["Form19Comment1"].ToString();
				form19.Form19Comment2 = row["Form19Comment2"].ToString();
				form19.Form19Comment3 = row["Form19Comment3"].ToString();
				form19.Form19HeritagesDescription = row["Form19HeritagesDescription"].ToString();
				form19.Form19RequestFamily = row["Form19RequestFamily"].ToString();
				form19.Form19RequestCertificateNumber = row["Form19RequestCertificateNumber"].ToString();
				form19.Form19RequestIssuanceCity = row["Form19RequestIssuanceCity"].ToString();
				form19.Form19DeadName = row["Form19DeadName"].ToString();
				form19.Form19DeadFamily = row["Form19DeadFamily"].ToString();
				form19.Form19DeadCertificateNumber = row["Form19DeadCertificateNumber"].ToString();
				form19.Form19RegisterInformationID = (row["Form19RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["Form19RegisterInformationID"]) : 0 ;
				form19.Form19RequestNationalCode = (row["Form19RequestNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["Form19RequestNationalCode"]) : 0 ;
				form19.Form19RegisterarUserNationalCode = (row["Form19RegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["Form19RegisterarUserNationalCode"]) : 0 ;
				form19.Form19DeclarationID = (row["Form19DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["Form19DeclarationID"]) : 0 ;
				form19.Form19DeadNationalCode = (row["Form19DeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["Form19DeadNationalCode"]) : 0 ;
				form19.Form19RegisterInformationDate = row["Form19RegisterInformationDate"].ToString();
				form19.Form19DeadDeathDate = row["Form19DeadDeathDate"].ToString();
				form19.Form19RequestDate = row["Form19RequestDate"].ToString();
				form19.Form19DossierClasses = row["Form19DossierClasses"].ToString();
				form19.Form19TaxOfficeProvince = row["Form19TaxOfficeProvince"].ToString();
				form19.Form19TaxOfficeCity = row["Form19TaxOfficeCity"].ToString();
				form19.Form19TaxOfficePhoneNumber = row["Form19TaxOfficePhoneNumber"].ToString();
				form19.Form19TaxOfficeAddress = row["Form19TaxOfficeAddress"].ToString();
				form19.Form19RequestName = row["Form19RequestName"].ToString();
				form19.Form19TaxGroupUserFullName = row["Form19TaxGroupUserFullName"].ToString();
				form19.Form19RequestRelationship = row["Form19RequestRelationship"].ToString();
				form19.Form19HeirShareDescription = row["Form19HeirShareDescription"].ToString();
				form19.Form19TaxOfficeCode = (row["Form19TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["Form19TaxOfficeCode"]) : 0 ;
			}
		}

		return form19;
	}

	public List<Form19> GetListAll()
	{
		List<Form19> listForm19 = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Form19_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listForm19 = new List<Form19>();

				foreach (DataRow row in table.Rows)
				{
					Form19 form19 = new Form19();
					form19.Form19ID = (row["Form19ID"] != DBNull.Value) ? Convert.ToInt64(row["Form19ID"]) : 0 ;
					form19.Form19PrintRegisterInformationID = row["Form19PrintRegisterInformationID"].ToString();
					form19.Form19PrintRegisterDate = row["Form19PrintRegisterDate"].ToString();
					form19.Form19RequestNumber = row["Form19RequestNumber"].ToString();
					form19.Form19RequestFullName = row["Form19RequestFullName"].ToString();
					form19.Form19HeirFullName = row["Form19HeirFullName"].ToString();
					form19.Form19TaxUnitCode = row["Form19TaxUnitCode"].ToString();
					form19.Form19TaxUnitUserFullName = row["Form19TaxUnitUserFullName"].ToString();
					form19.Form19TaxGroupCode = row["Form19TaxGroupCode"].ToString();
					form19.Form19DeadIssuanceCity = row["Form19DeadIssuanceCity"].ToString();
					form19.Form19DeadDeathCity = row["Form19DeadDeathCity"].ToString();
					form19.Form19Comment1 = row["Form19Comment1"].ToString();
					form19.Form19Comment2 = row["Form19Comment2"].ToString();
					form19.Form19Comment3 = row["Form19Comment3"].ToString();
					form19.Form19HeritagesDescription = row["Form19HeritagesDescription"].ToString();
					form19.Form19RequestFamily = row["Form19RequestFamily"].ToString();
					form19.Form19RequestCertificateNumber = row["Form19RequestCertificateNumber"].ToString();
					form19.Form19RequestIssuanceCity = row["Form19RequestIssuanceCity"].ToString();
					form19.Form19DeadName = row["Form19DeadName"].ToString();
					form19.Form19DeadFamily = row["Form19DeadFamily"].ToString();
					form19.Form19DeadCertificateNumber = row["Form19DeadCertificateNumber"].ToString();
					form19.Form19RegisterInformationID = (row["Form19RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["Form19RegisterInformationID"]) : 0 ;
					form19.Form19RequestNationalCode = (row["Form19RequestNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["Form19RequestNationalCode"]) : 0 ;
					form19.Form19RegisterarUserNationalCode = (row["Form19RegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["Form19RegisterarUserNationalCode"]) : 0 ;
					form19.Form19DeclarationID = (row["Form19DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["Form19DeclarationID"]) : 0 ;
					form19.Form19DeadNationalCode = (row["Form19DeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["Form19DeadNationalCode"]) : 0 ;
					form19.Form19RegisterInformationDate = row["Form19RegisterInformationDate"].ToString();
					form19.Form19DeadDeathDate = row["Form19DeadDeathDate"].ToString();
					form19.Form19RequestDate = row["Form19RequestDate"].ToString();
					form19.Form19DossierClasses = row["Form19DossierClasses"].ToString();
					form19.Form19TaxOfficeProvince = row["Form19TaxOfficeProvince"].ToString();
					form19.Form19TaxOfficeCity = row["Form19TaxOfficeCity"].ToString();
					form19.Form19TaxOfficePhoneNumber = row["Form19TaxOfficePhoneNumber"].ToString();
					form19.Form19TaxOfficeAddress = row["Form19TaxOfficeAddress"].ToString();
					form19.Form19RequestName = row["Form19RequestName"].ToString();
					form19.Form19TaxGroupUserFullName = row["Form19TaxGroupUserFullName"].ToString();
					form19.Form19RequestRelationship = row["Form19RequestRelationship"].ToString();
					form19.Form19HeirShareDescription = row["Form19HeirShareDescription"].ToString();
					form19.Form19TaxOfficeCode = (row["Form19TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["Form19TaxOfficeCode"]) : 0 ;
					listForm19.Add(form19);
				}
			}
		}

		return listForm19;
	}

	public bool Exists(Int64 form19ID)
	{
		SqlParameter[] parametersForm19 = new SqlParameter[]
		{
			new SqlParameter("@Form19ID", form19ID)
		};
		return (SqlDBHelper.ExecuteScalar("Form19_Exists", CommandType.StoredProcedure, parametersForm19)>0);
	}

	public bool Exists(Form19 form19)
	{
		SqlParameter[] parametersForm19 = new SqlParameter[]
		{
			new SqlParameter("@Form19ID", form19.Form19ID)
		};
		return (SqlDBHelper.ExecuteScalar("Form19_Exists", CommandType.StoredProcedure, parametersForm19)>0);
	}

	public List<Form19> SearchLike(Form19 form19)
	{
		List<Form19> listForm19 = new List<Form19>();


		SqlParameter[] parametersForm19 = new SqlParameter[]
		{
			new SqlParameter("@Form19ID", form19.Form19ID),
			new SqlParameter("@Form19PrintRegisterInformationID", form19.Form19PrintRegisterInformationID),
			new SqlParameter("@Form19PrintRegisterDate", form19.Form19PrintRegisterDate),
			new SqlParameter("@Form19RequestNumber", form19.Form19RequestNumber),
			new SqlParameter("@Form19RequestFullName", form19.Form19RequestFullName),
			new SqlParameter("@Form19HeirFullName", form19.Form19HeirFullName),
			new SqlParameter("@Form19TaxUnitCode", form19.Form19TaxUnitCode),
			new SqlParameter("@Form19TaxUnitUserFullName", form19.Form19TaxUnitUserFullName),
			new SqlParameter("@Form19TaxGroupCode", form19.Form19TaxGroupCode),
			new SqlParameter("@Form19DeadIssuanceCity", form19.Form19DeadIssuanceCity),
			new SqlParameter("@Form19DeadDeathCity", form19.Form19DeadDeathCity),
			new SqlParameter("@Form19Comment1", form19.Form19Comment1),
			new SqlParameter("@Form19Comment2", form19.Form19Comment2),
			new SqlParameter("@Form19Comment3", form19.Form19Comment3),
			new SqlParameter("@Form19HeritagesDescription", form19.Form19HeritagesDescription),
			new SqlParameter("@Form19RequestFamily", form19.Form19RequestFamily),
			new SqlParameter("@Form19RequestCertificateNumber", form19.Form19RequestCertificateNumber),
			new SqlParameter("@Form19RequestIssuanceCity", form19.Form19RequestIssuanceCity),
			new SqlParameter("@Form19DeadName", form19.Form19DeadName),
			new SqlParameter("@Form19DeadFamily", form19.Form19DeadFamily),
			new SqlParameter("@Form19DeadCertificateNumber", form19.Form19DeadCertificateNumber),
			new SqlParameter("@Form19RegisterInformationID", form19.Form19RegisterInformationID),
			new SqlParameter("@Form19RequestNationalCode", form19.Form19RequestNationalCode),
			new SqlParameter("@Form19RegisterarUserNationalCode", form19.Form19RegisterarUserNationalCode),
			new SqlParameter("@Form19DeclarationID", form19.Form19DeclarationID),
			new SqlParameter("@Form19DeadNationalCode", form19.Form19DeadNationalCode),
			new SqlParameter("@Form19RegisterInformationDate", form19.Form19RegisterInformationDate),
			new SqlParameter("@Form19DeadDeathDate", form19.Form19DeadDeathDate),
			new SqlParameter("@Form19RequestDate", form19.Form19RequestDate),
			new SqlParameter("@Form19DossierClasses", form19.Form19DossierClasses),
			new SqlParameter("@Form19TaxOfficeProvince", form19.Form19TaxOfficeProvince),
			new SqlParameter("@Form19TaxOfficeCity", form19.Form19TaxOfficeCity),
			new SqlParameter("@Form19TaxOfficePhoneNumber", form19.Form19TaxOfficePhoneNumber),
			new SqlParameter("@Form19TaxOfficeAddress", form19.Form19TaxOfficeAddress),
			new SqlParameter("@Form19RequestName", form19.Form19RequestName),
			new SqlParameter("@Form19TaxGroupUserFullName", form19.Form19TaxGroupUserFullName),
			new SqlParameter("@Form19RequestRelationship", form19.Form19RequestRelationship),
			new SqlParameter("@Form19HeirShareDescription", form19.Form19HeirShareDescription),
			new SqlParameter("@Form19TaxOfficeCode", form19.Form19TaxOfficeCode),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Form19_SearchLike", CommandType.StoredProcedure, parametersForm19))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Form19 tmpForm19 = new Form19();
					tmpForm19.Form19ID = (row["Form19ID"] != DBNull.Value) ? Convert.ToInt64(row["Form19ID"]) : 0 ;
					tmpForm19.Form19PrintRegisterInformationID = row["Form19PrintRegisterInformationID"].ToString();
					tmpForm19.Form19PrintRegisterDate = row["Form19PrintRegisterDate"].ToString();
					tmpForm19.Form19RequestNumber = row["Form19RequestNumber"].ToString();
					tmpForm19.Form19RequestFullName = row["Form19RequestFullName"].ToString();
					tmpForm19.Form19HeirFullName = row["Form19HeirFullName"].ToString();
					tmpForm19.Form19TaxUnitCode = row["Form19TaxUnitCode"].ToString();
					tmpForm19.Form19TaxUnitUserFullName = row["Form19TaxUnitUserFullName"].ToString();
					tmpForm19.Form19TaxGroupCode = row["Form19TaxGroupCode"].ToString();
					tmpForm19.Form19DeadIssuanceCity = row["Form19DeadIssuanceCity"].ToString();
					tmpForm19.Form19DeadDeathCity = row["Form19DeadDeathCity"].ToString();
					tmpForm19.Form19Comment1 = row["Form19Comment1"].ToString();
					tmpForm19.Form19Comment2 = row["Form19Comment2"].ToString();
					tmpForm19.Form19Comment3 = row["Form19Comment3"].ToString();
					tmpForm19.Form19HeritagesDescription = row["Form19HeritagesDescription"].ToString();
					tmpForm19.Form19RequestFamily = row["Form19RequestFamily"].ToString();
					tmpForm19.Form19RequestCertificateNumber = row["Form19RequestCertificateNumber"].ToString();
					tmpForm19.Form19RequestIssuanceCity = row["Form19RequestIssuanceCity"].ToString();
					tmpForm19.Form19DeadName = row["Form19DeadName"].ToString();
					tmpForm19.Form19DeadFamily = row["Form19DeadFamily"].ToString();
					tmpForm19.Form19DeadCertificateNumber = row["Form19DeadCertificateNumber"].ToString();
					tmpForm19.Form19RegisterInformationID = (row["Form19RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["Form19RegisterInformationID"]) : 0 ;
					tmpForm19.Form19RequestNationalCode = (row["Form19RequestNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["Form19RequestNationalCode"]) : 0 ;
					tmpForm19.Form19RegisterarUserNationalCode = (row["Form19RegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["Form19RegisterarUserNationalCode"]) : 0 ;
					tmpForm19.Form19DeclarationID = (row["Form19DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["Form19DeclarationID"]) : 0 ;
					tmpForm19.Form19DeadNationalCode = (row["Form19DeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["Form19DeadNationalCode"]) : 0 ;
					tmpForm19.Form19RegisterInformationDate = row["Form19RegisterInformationDate"].ToString();
					tmpForm19.Form19DeadDeathDate = row["Form19DeadDeathDate"].ToString();
					tmpForm19.Form19RequestDate = row["Form19RequestDate"].ToString();
					tmpForm19.Form19DossierClasses = row["Form19DossierClasses"].ToString();
					tmpForm19.Form19TaxOfficeProvince = row["Form19TaxOfficeProvince"].ToString();
					tmpForm19.Form19TaxOfficeCity = row["Form19TaxOfficeCity"].ToString();
					tmpForm19.Form19TaxOfficePhoneNumber = row["Form19TaxOfficePhoneNumber"].ToString();
					tmpForm19.Form19TaxOfficeAddress = row["Form19TaxOfficeAddress"].ToString();
					tmpForm19.Form19RequestName = row["Form19RequestName"].ToString();
					tmpForm19.Form19TaxGroupUserFullName = row["Form19TaxGroupUserFullName"].ToString();
					tmpForm19.Form19RequestRelationship = row["Form19RequestRelationship"].ToString();
					tmpForm19.Form19HeirShareDescription = row["Form19HeirShareDescription"].ToString();
					tmpForm19.Form19TaxOfficeCode = (row["Form19TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["Form19TaxOfficeCode"]) : 0 ;

					listForm19.Add(tmpForm19);
				}
			}
		}

		return listForm19;
	}

}
}
