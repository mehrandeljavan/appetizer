using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormDeclarationInputInfoDBAccess
{


	public Int64 Insert(FormDeclarationInputInfo formDeclarationInputInfo)
	{
		SqlParameter[] parametersFormDeclarationInputInfo = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationInputInfoDeadDeathProvince", (formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathProvince != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathProvince : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadDeathCity", (formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathCity != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoTaxOfficeRegisterInfoProvince", (formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoProvince != null) ? formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoProvince : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoTaxOfficeRegisterInfoCity", (formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoCity != null) ? formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoTaxUnitCode", (formDeclarationInputInfo.FormDeclarationInputInfoTaxUnitCode != null) ? formDeclarationInputInfo.FormDeclarationInputInfoTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadZipCode", (formDeclarationInputInfo.FormDeclarationInputInfoDeadZipCode != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadZipCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadFatherName", (formDeclarationInputInfo.FormDeclarationInputInfoDeadFatherName != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadFatherName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadCertificateNumber", (formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateNumber != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadCertificateSerial", (formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateSerial != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateSerial : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadIssuanceProvice", (formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceProvice != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceProvice : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadIssuanceCity", (formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceCity != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadIssuanceDepartmant", (formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDepartmant != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDepartmant : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeclarationID", (formDeclarationInputInfo.FormDeclarationInputInfoDeclarationID > 0) ? formDeclarationInputInfo.FormDeclarationInputInfoDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoRegisterInformationID", (formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationID > 0) ? formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeclarationRegisterInformationID", (formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationID != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoRegisterarUserNationalCode", (formDeclarationInputInfo.FormDeclarationInputInfoRegisterarUserNationalCode > 0) ? formDeclarationInputInfo.FormDeclarationInputInfoRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadIssuanceDate", (formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDate != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadBirthDate", (formDeclarationInputInfo.FormDeclarationInputInfoDeadBirthDate != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadBirthDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadDeathDate", (formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathDate != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeclarationRegisterInformationDate", (formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationDate != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoApproveDate", (formDeclarationInputInfo.FormDeclarationInputInfoApproveDate != null) ? formDeclarationInputInfo.FormDeclarationInputInfoApproveDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoRegisterInformationDate", (formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationDate != null) ? formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadNationalCode", (formDeclarationInputInfo.FormDeclarationInputInfoDeadNationalCode != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoTaxOfficeTitle", (formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeTitle != null) ? formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoTaxOfficeCity", (formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeCity != null) ? formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeclarationStage", (formDeclarationInputInfo.FormDeclarationInputInfoDeclarationStage != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeclarationStage : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadName", (formDeclarationInputInfo.FormDeclarationInputInfoDeadName != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadFamily", (formDeclarationInputInfo.FormDeclarationInputInfoDeadFamily != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadFamily : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadUniqueCode", (formDeclarationInputInfo.FormDeclarationInputInfoDeadUniqueCode != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadUniqueCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoApprovalUserName", (formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserName != null) ? formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoApprovalUserFamily", (formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserFamily != null) ? formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserFamily : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoTaxOfficeProvince", (formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeProvince != null) ? formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeProvince : (object)DBNull.Value)
		};
		formDeclarationInputInfo.FormDeclarationInputInfoID = SqlDBHelper.ExecuteScalar("FormDeclarationInputInfo_Insert", CommandType.StoredProcedure, parametersFormDeclarationInputInfo);
		return formDeclarationInputInfo.FormDeclarationInputInfoID;
	}

	public bool Update(FormDeclarationInputInfo formDeclarationInputInfo)
	{
		SqlParameter[] parametersFormDeclarationInputInfo = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationInputInfoID", formDeclarationInputInfo.FormDeclarationInputInfoID),
			new SqlParameter("@FormDeclarationInputInfoDeadDeathProvince", (formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathProvince != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathProvince : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadDeathCity", (formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathCity != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoTaxOfficeRegisterInfoProvince", (formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoProvince != null) ? formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoProvince : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoTaxOfficeRegisterInfoCity", (formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoCity != null) ? formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoTaxUnitCode", (formDeclarationInputInfo.FormDeclarationInputInfoTaxUnitCode != null) ? formDeclarationInputInfo.FormDeclarationInputInfoTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadZipCode", (formDeclarationInputInfo.FormDeclarationInputInfoDeadZipCode != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadZipCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadFatherName", (formDeclarationInputInfo.FormDeclarationInputInfoDeadFatherName != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadFatherName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadCertificateNumber", (formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateNumber != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadCertificateSerial", (formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateSerial != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateSerial : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadIssuanceProvice", (formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceProvice != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceProvice : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadIssuanceCity", (formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceCity != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadIssuanceDepartmant", (formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDepartmant != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDepartmant : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeclarationID", (formDeclarationInputInfo.FormDeclarationInputInfoDeclarationID != null && formDeclarationInputInfo.FormDeclarationInputInfoDeclarationID >0 ) ? formDeclarationInputInfo.FormDeclarationInputInfoDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoRegisterInformationID", (formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationID != null && formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationID >0 ) ? formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeclarationRegisterInformationID", (formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationID != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoRegisterarUserNationalCode", (formDeclarationInputInfo.FormDeclarationInputInfoRegisterarUserNationalCode != null && formDeclarationInputInfo.FormDeclarationInputInfoRegisterarUserNationalCode >0 ) ? formDeclarationInputInfo.FormDeclarationInputInfoRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadIssuanceDate", (formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDate != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadBirthDate", (formDeclarationInputInfo.FormDeclarationInputInfoDeadBirthDate != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadBirthDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadDeathDate", (formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathDate != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeclarationRegisterInformationDate", (formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationDate != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoApproveDate", (formDeclarationInputInfo.FormDeclarationInputInfoApproveDate != null) ? formDeclarationInputInfo.FormDeclarationInputInfoApproveDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoRegisterInformationDate", (formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationDate != null) ? formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadNationalCode", (formDeclarationInputInfo.FormDeclarationInputInfoDeadNationalCode != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoTaxOfficeTitle", (formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeTitle != null) ? formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoTaxOfficeCity", (formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeCity != null) ? formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeclarationStage", (formDeclarationInputInfo.FormDeclarationInputInfoDeclarationStage != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeclarationStage : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadName", (formDeclarationInputInfo.FormDeclarationInputInfoDeadName != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadFamily", (formDeclarationInputInfo.FormDeclarationInputInfoDeadFamily != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadFamily : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoDeadUniqueCode", (formDeclarationInputInfo.FormDeclarationInputInfoDeadUniqueCode != null) ? formDeclarationInputInfo.FormDeclarationInputInfoDeadUniqueCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoApprovalUserName", (formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserName != null) ? formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoApprovalUserFamily", (formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserFamily != null) ? formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserFamily : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationInputInfoTaxOfficeProvince", (formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeProvince != null) ? formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeProvince : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormDeclarationInputInfo_Update", CommandType.StoredProcedure, parametersFormDeclarationInputInfo);
	}

	public bool Delete(Int64 formDeclarationInputInfoID)
	{
		SqlParameter[] parametersFormDeclarationInputInfo = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationInputInfoID", formDeclarationInputInfoID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormDeclarationInputInfo_Delete", CommandType.StoredProcedure, parametersFormDeclarationInputInfo);
	}

	public FormDeclarationInputInfo GetDetails(Int64 formDeclarationInputInfoID)
	{
		FormDeclarationInputInfo formDeclarationInputInfo = new FormDeclarationInputInfo();

		SqlParameter[] parametersFormDeclarationInputInfo = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationInputInfoID", formDeclarationInputInfoID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDeclarationInputInfo_GetDetails", CommandType.StoredProcedure, parametersFormDeclarationInputInfo))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				formDeclarationInputInfo.FormDeclarationInputInfoID = (row["FormDeclarationInputInfoID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoID"]) : 0 ;
				formDeclarationInputInfo.FormDeclarationInputInfoPrintRegisterInformationID = row["FormDeclarationInputInfoPrintRegisterInformationID"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoPrintRegisterDate = row["FormDeclarationInputInfoPrintRegisterDate"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathProvince = row["FormDeclarationInputInfoDeadDeathProvince"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathCity = row["FormDeclarationInputInfoDeadDeathCity"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoProvince = row["FormDeclarationInputInfoTaxOfficeRegisterInfoProvince"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoCity = row["FormDeclarationInputInfoTaxOfficeRegisterInfoCity"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoTaxUnitCode = row["FormDeclarationInputInfoTaxUnitCode"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeadZipCode = row["FormDeclarationInputInfoDeadZipCode"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeadFatherName = row["FormDeclarationInputInfoDeadFatherName"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateNumber = row["FormDeclarationInputInfoDeadCertificateNumber"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateSerial = row["FormDeclarationInputInfoDeadCertificateSerial"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceProvice = row["FormDeclarationInputInfoDeadIssuanceProvice"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceCity = row["FormDeclarationInputInfoDeadIssuanceCity"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDepartmant = row["FormDeclarationInputInfoDeadIssuanceDepartmant"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeclarationID = (row["FormDeclarationInputInfoDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoDeclarationID"]) : 0 ;
				formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationID = (row["FormDeclarationInputInfoRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoRegisterInformationID"]) : 0 ;
				formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationID = (row["FormDeclarationInputInfoDeclarationRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoDeclarationRegisterInformationID"]) : 0 ;
				formDeclarationInputInfo.FormDeclarationInputInfoRegisterarUserNationalCode = (row["FormDeclarationInputInfoRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoRegisterarUserNationalCode"]) : 0 ;
				formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDate = row["FormDeclarationInputInfoDeadIssuanceDate"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeadBirthDate = row["FormDeclarationInputInfoDeadBirthDate"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathDate = row["FormDeclarationInputInfoDeadDeathDate"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationDate = row["FormDeclarationInputInfoDeclarationRegisterInformationDate"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoApproveDate = row["FormDeclarationInputInfoApproveDate"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationDate = row["FormDeclarationInputInfoRegisterInformationDate"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeadNationalCode = row["FormDeclarationInputInfoDeadNationalCode"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeTitle = row["FormDeclarationInputInfoTaxOfficeTitle"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeCity = row["FormDeclarationInputInfoTaxOfficeCity"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeclarationStage = row["FormDeclarationInputInfoDeclarationStage"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeadName = row["FormDeclarationInputInfoDeadName"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeadFamily = row["FormDeclarationInputInfoDeadFamily"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoDeadUniqueCode = row["FormDeclarationInputInfoDeadUniqueCode"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserName = row["FormDeclarationInputInfoApprovalUserName"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserFamily = row["FormDeclarationInputInfoApprovalUserFamily"].ToString();
				formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeProvince = row["FormDeclarationInputInfoTaxOfficeProvince"].ToString();
			}
		}

		return formDeclarationInputInfo;
	}

	public List<FormDeclarationInputInfo> GetListAll()
	{
		List<FormDeclarationInputInfo> listFormDeclarationInputInfo = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormDeclarationInputInfo_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormDeclarationInputInfo = new List<FormDeclarationInputInfo>();

				foreach (DataRow row in table.Rows)
				{
					FormDeclarationInputInfo formDeclarationInputInfo = new FormDeclarationInputInfo();
					formDeclarationInputInfo.FormDeclarationInputInfoID = (row["FormDeclarationInputInfoID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoID"]) : 0 ;
					formDeclarationInputInfo.FormDeclarationInputInfoPrintRegisterInformationID = row["FormDeclarationInputInfoPrintRegisterInformationID"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoPrintRegisterDate = row["FormDeclarationInputInfoPrintRegisterDate"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathProvince = row["FormDeclarationInputInfoDeadDeathProvince"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathCity = row["FormDeclarationInputInfoDeadDeathCity"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoProvince = row["FormDeclarationInputInfoTaxOfficeRegisterInfoProvince"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoCity = row["FormDeclarationInputInfoTaxOfficeRegisterInfoCity"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoTaxUnitCode = row["FormDeclarationInputInfoTaxUnitCode"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeadZipCode = row["FormDeclarationInputInfoDeadZipCode"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeadFatherName = row["FormDeclarationInputInfoDeadFatherName"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateNumber = row["FormDeclarationInputInfoDeadCertificateNumber"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateSerial = row["FormDeclarationInputInfoDeadCertificateSerial"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceProvice = row["FormDeclarationInputInfoDeadIssuanceProvice"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceCity = row["FormDeclarationInputInfoDeadIssuanceCity"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDepartmant = row["FormDeclarationInputInfoDeadIssuanceDepartmant"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeclarationID = (row["FormDeclarationInputInfoDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoDeclarationID"]) : 0 ;
					formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationID = (row["FormDeclarationInputInfoRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoRegisterInformationID"]) : 0 ;
					formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationID = (row["FormDeclarationInputInfoDeclarationRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoDeclarationRegisterInformationID"]) : 0 ;
					formDeclarationInputInfo.FormDeclarationInputInfoRegisterarUserNationalCode = (row["FormDeclarationInputInfoRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoRegisterarUserNationalCode"]) : 0 ;
					formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDate = row["FormDeclarationInputInfoDeadIssuanceDate"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeadBirthDate = row["FormDeclarationInputInfoDeadBirthDate"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathDate = row["FormDeclarationInputInfoDeadDeathDate"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationDate = row["FormDeclarationInputInfoDeclarationRegisterInformationDate"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoApproveDate = row["FormDeclarationInputInfoApproveDate"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationDate = row["FormDeclarationInputInfoRegisterInformationDate"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeadNationalCode = row["FormDeclarationInputInfoDeadNationalCode"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeTitle = row["FormDeclarationInputInfoTaxOfficeTitle"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeCity = row["FormDeclarationInputInfoTaxOfficeCity"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeclarationStage = row["FormDeclarationInputInfoDeclarationStage"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeadName = row["FormDeclarationInputInfoDeadName"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeadFamily = row["FormDeclarationInputInfoDeadFamily"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoDeadUniqueCode = row["FormDeclarationInputInfoDeadUniqueCode"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserName = row["FormDeclarationInputInfoApprovalUserName"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserFamily = row["FormDeclarationInputInfoApprovalUserFamily"].ToString();
					formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeProvince = row["FormDeclarationInputInfoTaxOfficeProvince"].ToString();
					listFormDeclarationInputInfo.Add(formDeclarationInputInfo);
				}
			}
		}

		return listFormDeclarationInputInfo;
	}

	public bool Exists(Int64 formDeclarationInputInfoID)
	{
		SqlParameter[] parametersFormDeclarationInputInfo = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationInputInfoID", formDeclarationInputInfoID)
		};
		return (SqlDBHelper.ExecuteScalar("FormDeclarationInputInfo_Exists", CommandType.StoredProcedure, parametersFormDeclarationInputInfo)>0);
	}

	public bool Exists(FormDeclarationInputInfo formDeclarationInputInfo)
	{
		SqlParameter[] parametersFormDeclarationInputInfo = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationInputInfoID", formDeclarationInputInfo.FormDeclarationInputInfoID)
		};
		return (SqlDBHelper.ExecuteScalar("FormDeclarationInputInfo_Exists", CommandType.StoredProcedure, parametersFormDeclarationInputInfo)>0);
	}

	public List<FormDeclarationInputInfo> SearchLike(FormDeclarationInputInfo formDeclarationInputInfo)
	{
		List<FormDeclarationInputInfo> listFormDeclarationInputInfo = new List<FormDeclarationInputInfo>();


		SqlParameter[] parametersFormDeclarationInputInfo = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationInputInfoID", formDeclarationInputInfo.FormDeclarationInputInfoID),
			new SqlParameter("@FormDeclarationInputInfoPrintRegisterInformationID", formDeclarationInputInfo.FormDeclarationInputInfoPrintRegisterInformationID),
			new SqlParameter("@FormDeclarationInputInfoPrintRegisterDate", formDeclarationInputInfo.FormDeclarationInputInfoPrintRegisterDate),
			new SqlParameter("@FormDeclarationInputInfoDeadDeathProvince", formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathProvince),
			new SqlParameter("@FormDeclarationInputInfoDeadDeathCity", formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathCity),
			new SqlParameter("@FormDeclarationInputInfoTaxOfficeRegisterInfoProvince", formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoProvince),
			new SqlParameter("@FormDeclarationInputInfoTaxOfficeRegisterInfoCity", formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoCity),
			new SqlParameter("@FormDeclarationInputInfoTaxUnitCode", formDeclarationInputInfo.FormDeclarationInputInfoTaxUnitCode),
			new SqlParameter("@FormDeclarationInputInfoDeadZipCode", formDeclarationInputInfo.FormDeclarationInputInfoDeadZipCode),
			new SqlParameter("@FormDeclarationInputInfoDeadFatherName", formDeclarationInputInfo.FormDeclarationInputInfoDeadFatherName),
			new SqlParameter("@FormDeclarationInputInfoDeadCertificateNumber", formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateNumber),
			new SqlParameter("@FormDeclarationInputInfoDeadCertificateSerial", formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateSerial),
			new SqlParameter("@FormDeclarationInputInfoDeadIssuanceProvice", formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceProvice),
			new SqlParameter("@FormDeclarationInputInfoDeadIssuanceCity", formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceCity),
			new SqlParameter("@FormDeclarationInputInfoDeadIssuanceDepartmant", formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDepartmant),
			new SqlParameter("@FormDeclarationInputInfoDeclarationID", formDeclarationInputInfo.FormDeclarationInputInfoDeclarationID),
			new SqlParameter("@FormDeclarationInputInfoRegisterInformationID", formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationID),
			new SqlParameter("@FormDeclarationInputInfoDeclarationRegisterInformationID", formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationID),
			new SqlParameter("@FormDeclarationInputInfoRegisterarUserNationalCode", formDeclarationInputInfo.FormDeclarationInputInfoRegisterarUserNationalCode),
			new SqlParameter("@FormDeclarationInputInfoDeadIssuanceDate", formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDate),
			new SqlParameter("@FormDeclarationInputInfoDeadBirthDate", formDeclarationInputInfo.FormDeclarationInputInfoDeadBirthDate),
			new SqlParameter("@FormDeclarationInputInfoDeadDeathDate", formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathDate),
			new SqlParameter("@FormDeclarationInputInfoDeclarationRegisterInformationDate", formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationDate),
			new SqlParameter("@FormDeclarationInputInfoApproveDate", formDeclarationInputInfo.FormDeclarationInputInfoApproveDate),
			new SqlParameter("@FormDeclarationInputInfoRegisterInformationDate", formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationDate),
			new SqlParameter("@FormDeclarationInputInfoDeadNationalCode", formDeclarationInputInfo.FormDeclarationInputInfoDeadNationalCode),
			new SqlParameter("@FormDeclarationInputInfoTaxOfficeTitle", formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeTitle),
			new SqlParameter("@FormDeclarationInputInfoTaxOfficeCity", formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeCity),
			new SqlParameter("@FormDeclarationInputInfoDeclarationStage", formDeclarationInputInfo.FormDeclarationInputInfoDeclarationStage),
			new SqlParameter("@FormDeclarationInputInfoDeadName", formDeclarationInputInfo.FormDeclarationInputInfoDeadName),
			new SqlParameter("@FormDeclarationInputInfoDeadFamily", formDeclarationInputInfo.FormDeclarationInputInfoDeadFamily),
			new SqlParameter("@FormDeclarationInputInfoDeadUniqueCode", formDeclarationInputInfo.FormDeclarationInputInfoDeadUniqueCode),
			new SqlParameter("@FormDeclarationInputInfoApprovalUserName", formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserName),
			new SqlParameter("@FormDeclarationInputInfoApprovalUserFamily", formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserFamily),
			new SqlParameter("@FormDeclarationInputInfoTaxOfficeProvince", formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeProvince),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDeclarationInputInfo_SearchLike", CommandType.StoredProcedure, parametersFormDeclarationInputInfo))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormDeclarationInputInfo tmpFormDeclarationInputInfo = new FormDeclarationInputInfo();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoID = (row["FormDeclarationInputInfoID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoID"]) : 0 ;
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoPrintRegisterInformationID = row["FormDeclarationInputInfoPrintRegisterInformationID"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoPrintRegisterDate = row["FormDeclarationInputInfoPrintRegisterDate"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadDeathProvince = row["FormDeclarationInputInfoDeadDeathProvince"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadDeathCity = row["FormDeclarationInputInfoDeadDeathCity"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoProvince = row["FormDeclarationInputInfoTaxOfficeRegisterInfoProvince"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoCity = row["FormDeclarationInputInfoTaxOfficeRegisterInfoCity"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoTaxUnitCode = row["FormDeclarationInputInfoTaxUnitCode"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadZipCode = row["FormDeclarationInputInfoDeadZipCode"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadFatherName = row["FormDeclarationInputInfoDeadFatherName"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateNumber = row["FormDeclarationInputInfoDeadCertificateNumber"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateSerial = row["FormDeclarationInputInfoDeadCertificateSerial"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceProvice = row["FormDeclarationInputInfoDeadIssuanceProvice"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceCity = row["FormDeclarationInputInfoDeadIssuanceCity"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDepartmant = row["FormDeclarationInputInfoDeadIssuanceDepartmant"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeclarationID = (row["FormDeclarationInputInfoDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoDeclarationID"]) : 0 ;
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationID = (row["FormDeclarationInputInfoRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoRegisterInformationID"]) : 0 ;
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationID = (row["FormDeclarationInputInfoDeclarationRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoDeclarationRegisterInformationID"]) : 0 ;
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoRegisterarUserNationalCode = (row["FormDeclarationInputInfoRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoRegisterarUserNationalCode"]) : 0 ;
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDate = row["FormDeclarationInputInfoDeadIssuanceDate"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadBirthDate = row["FormDeclarationInputInfoDeadBirthDate"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadDeathDate = row["FormDeclarationInputInfoDeadDeathDate"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationDate = row["FormDeclarationInputInfoDeclarationRegisterInformationDate"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoApproveDate = row["FormDeclarationInputInfoApproveDate"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationDate = row["FormDeclarationInputInfoRegisterInformationDate"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadNationalCode = row["FormDeclarationInputInfoDeadNationalCode"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeTitle = row["FormDeclarationInputInfoTaxOfficeTitle"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeCity = row["FormDeclarationInputInfoTaxOfficeCity"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeclarationStage = row["FormDeclarationInputInfoDeclarationStage"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadName = row["FormDeclarationInputInfoDeadName"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadFamily = row["FormDeclarationInputInfoDeadFamily"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoDeadUniqueCode = row["FormDeclarationInputInfoDeadUniqueCode"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoApprovalUserName = row["FormDeclarationInputInfoApprovalUserName"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoApprovalUserFamily = row["FormDeclarationInputInfoApprovalUserFamily"].ToString();
					tmpFormDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeProvince = row["FormDeclarationInputInfoTaxOfficeProvince"].ToString();

					listFormDeclarationInputInfo.Add(tmpFormDeclarationInputInfo);
				}
			}
		}

		return listFormDeclarationInputInfo;
	}

}
}
