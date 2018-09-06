using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class EducationStateDBAccess
{

	HeirDBAccess heirDBAccess = new HeirDBAccess();

	public List<Heir> GetListHeir(int educationStateID)
	{
		List<Heir> listHeir = new List<Heir>() { };
		SqlParameter[] parametersEducationState = new SqlParameter[]
		{
			new SqlParameter("@EducationStateID", educationStateID)
		};

		//Lets get the list of Heir records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Heir_GetList_UseInEducationState", CommandType.StoredProcedure, parametersEducationState))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of heir
				listHeir = new List<Heir>();

				//Now lets populate the Heir details into the list of heirs
				foreach (DataRow row in table.Rows)
				{
					Heir heir = ConvertRowToHeir(row);
					listHeir.Add(heir);
				}
			}
		}

		return listHeir;
	}

	private Heir ConvertRowToHeir(DataRow row)
	{
		Heir heir = new Heir();
		heir.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
		heir.RelationIDTitle = row["RelationIDTitle"].ToString();
		heir.EducationStateIDTitle = row["EducationStateIDTitle"].ToString();
		heir.MarriageIDTitle = row["MarriageIDTitle"].ToString();
		heir.NationalityIDTitle = row["NationalityIDTitle"].ToString();
		heir.PhysicalStateIDTitle = row["PhysicalStateIDTitle"].ToString();
		heir.ResidenceIDTitle = row["ResidenceIDTitle"].ToString();
		heir.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		heir.OldRegisterDate = row["OldRegisterDate"].ToString();
		heir.RelationID = (row["RelationID"] != DBNull.Value) ? Convert.ToInt32(row["RelationID"]) : 0 ;
		heir.NationalityID = (row["NationalityID"] != DBNull.Value) ? Convert.ToInt32(row["NationalityID"]) : 0 ;
		heir.ResidenceID = (row["ResidenceID"] != DBNull.Value) ? Convert.ToInt32(row["ResidenceID"]) : 0 ;
		heir.PhysicalStateID = (row["PhysicalStateID"] != DBNull.Value) ? Convert.ToInt32(row["PhysicalStateID"]) : 0 ;
		heir.EducationStateID = (row["EducationStateID"] != DBNull.Value) ? Convert.ToInt32(row["EducationStateID"]) : 0 ;
		heir.MarriageID = (row["MarriageID"] != DBNull.Value) ? Convert.ToInt32(row["MarriageID"]) : 0 ;
		heir.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		heir.AgreementTypeID = (row["AgreementTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AgreementTypeID"]) : 0 ;
		heir.DeclerativeShare = (row["DeclerativeShare"] != DBNull.Value) ? Convert.ToSingle(row["DeclerativeShare"]) : 0 ;
		heir.DiagnosisShare = (row["DiagnosisShare"] != DBNull.Value) ? Convert.ToSingle(row["DiagnosisShare"]) : 0 ;
		heir.HandShare = (row["HandShare"] != DBNull.Value) ? Convert.ToSingle(row["HandShare"]) : 0 ;
		heir.AdjustmentTaxValue = (row["AdjustmentTaxValue"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentTaxValue"]) : 0 ;
		heir.AdjustmentIncomeValue = (row["AdjustmentIncomeValue"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentIncomeValue"]) : 0 ;
		heir.CommissionAdjustmentShareValue1 = (row["CommissionAdjustmentShareValue1"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue1"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue4 = (row["CommissionAdjustmentIncomeValue4"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue4"]) : 0 ;
		heir.CommissionAdjustmentShareValue5 = (row["CommissionAdjustmentShareValue5"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue5"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue5 = (row["CommissionAdjustmentIncomeValue5"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue5"]) : 0 ;
		heir.CommissionAdjustmentShareValue6 = (row["CommissionAdjustmentShareValue6"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue6"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue6 = (row["CommissionAdjustmentIncomeValue6"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue6"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue1 = (row["CommissionAdjustmentIncomeValue1"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue1"]) : 0 ;
		heir.CommissionAdjustmentShareValue2 = (row["CommissionAdjustmentShareValue2"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue2"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue2 = (row["CommissionAdjustmentIncomeValue2"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue2"]) : 0 ;
		heir.CommissionAdjustmentShareValue3 = (row["CommissionAdjustmentShareValue3"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue3"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue3 = (row["CommissionAdjustmentIncomeValue3"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue3"]) : 0 ;
		heir.CommissionAdjustmentShareValue4 = (row["CommissionAdjustmentShareValue4"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue4"]) : 0 ;
		heir.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		heir.ParentHeirID = (row["ParentHeirID"] != DBNull.Value) ? Convert.ToInt64(row["ParentHeirID"]) : 0 ;
		heir.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		heir.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		heir.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		heir.AdjustmentTaxRegisterInformationID = (row["AdjustmentTaxRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentTaxRegisterInformationID"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID5 = (row["CommissionAdjustmentIncomeRegisterInformationID5"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID5"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID6 = (row["CommissionAdjustmentShareRegisterInformationID6"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID6"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID6 = (row["CommissionAdjustmentIncomeRegisterInformationID6"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID6"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID2 = (row["CommissionAdjustmentIncomeRegisterInformationID2"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID2"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID3 = (row["CommissionAdjustmentShareRegisterInformationID3"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID3"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID3 = (row["CommissionAdjustmentIncomeRegisterInformationID3"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID3"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID4 = (row["CommissionAdjustmentShareRegisterInformationID4"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID4"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID4 = (row["CommissionAdjustmentIncomeRegisterInformationID4"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID4"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID5 = (row["CommissionAdjustmentShareRegisterInformationID5"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID5"]) : 0 ;
		heir.AdjustmentIncomeRegisterInformationID = (row["AdjustmentIncomeRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentIncomeRegisterInformationID"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID1 = (row["CommissionAdjustmentShareRegisterInformationID1"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID1"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID1 = (row["CommissionAdjustmentIncomeRegisterInformationID1"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID1"]) : 0 ;
		heir.AdjustmentHeritageRegisterInformationID = (row["AdjustmentHeritageRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentHeritageRegisterInformationID"]) : 0 ;
		heir.CommissionAdjustmentHeritageRegisterInformationID = (row["CommissionAdjustmentHeritageRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentHeritageRegisterInformationID"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID2 = (row["CommissionAdjustmentShareRegisterInformationID2"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID2"]) : 0 ;
		heir.AdjustmentTaxDate = row["AdjustmentTaxDate"].ToString();
		heir.AdjustmentIncomeDate = row["AdjustmentIncomeDate"].ToString();
		heir.CommissionAdjustmentShareDate1 = row["CommissionAdjustmentShareDate1"].ToString();
		heir.CommissionAdjustmentIncomeDate1 = row["CommissionAdjustmentIncomeDate1"].ToString();
		heir.AdjustmentHeritageDate = row["AdjustmentHeritageDate"].ToString();
		heir.CommissionAdjustmentHeritageDate = row["CommissionAdjustmentHeritageDate"].ToString();
		heir.CommissionAdjustmentIncomeDate4 = row["CommissionAdjustmentIncomeDate4"].ToString();
		heir.CommissionAdjustmentShareDate5 = row["CommissionAdjustmentShareDate5"].ToString();
		heir.CommissionAdjustmentIncomeDate5 = row["CommissionAdjustmentIncomeDate5"].ToString();
		heir.CommissionAdjustmentShareDate6 = row["CommissionAdjustmentShareDate6"].ToString();
		heir.CommissionAdjustmentIncomeDate6 = row["CommissionAdjustmentIncomeDate6"].ToString();
		heir.AdjustmentFinalizationDate = row["AdjustmentFinalizationDate"].ToString();
		heir.CommissionAdjustmentShareDate2 = row["CommissionAdjustmentShareDate2"].ToString();
		heir.CommissionAdjustmentIncomeDate2 = row["CommissionAdjustmentIncomeDate2"].ToString();
		heir.CommissionAdjustmentShareDate3 = row["CommissionAdjustmentShareDate3"].ToString();
		heir.CommissionAdjustmentIncomeDate3 = row["CommissionAdjustmentIncomeDate3"].ToString();
		heir.CommissionAdjustmentShareDate4 = row["CommissionAdjustmentShareDate4"].ToString();

		heir.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		heir.PrintNationalCode = row["PrintNationalCode"].ToString();
		heir.FullName = row["FullName"].ToString();
		heir.GenderIDTitle = row["GenderIDTitle"].ToString();
		heir.Religion_DinIDTitle = row["Religion_DinIDTitle"].ToString();
		heir.Religion_MazhabIDTitle = row["Religion_MazhabIDTitle"].ToString();
		heir.IssuanceProvinceIDTitle = row["IssuanceProvinceIDTitle"].ToString();
		heir.IssuanceCityIDTitle = row["IssuanceCityIDTitle"].ToString();
		heir.IssuanceDepartment = row["IssuanceDepartment"].ToString();
		heir.CertificateNumber = row["CertificateNumber"].ToString();
		heir.CertificateSerial = row["CertificateSerial"].ToString();
		heir.ZipCode = row["ZipCode"].ToString();
		heir.HomeAddress = row["HomeAddress"].ToString();
		heir.PhoneNumber = row["PhoneNumber"].ToString();
		heir.Job = row["Job"].ToString();
		heir.JobAddress = row["JobAddress"].ToString();
		heir.JobPhoneNumber = row["JobPhoneNumber"].ToString();
		heir.Comment = row["Comment"].ToString();
		heir.BirthCity = row["BirthCity"].ToString();
		heir.JobZipCode = row["JobZipCode"].ToString();
		heir.CertificateSerialLetter = row["CertificateSerialLetter"].ToString();
		heir.CertificateSerialNumber = row["CertificateSerialNumber"].ToString();
		heir.FatherName = row["FatherName"].ToString();
		heir.Name = row["Name"].ToString();
		heir.Family = row["Family"].ToString();
		heir.BirthDate = row["BirthDate"].ToString();
		heir.IssuanceDate = row["IssuanceDate"].ToString();
		heir.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
		heir.IssuanceProvinceID = (row["IssuanceProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceProvinceID"]) : 0 ;
		heir.IssuanceCityID = (row["IssuanceCityID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceCityID"]) : 0 ;
		heir.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
		heir.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
		return heir;
	}
	public Int64 Insert(EducationState educationState)
	{
		SqlParameter[] parametersEducationState = new SqlParameter[]
		{
			new SqlParameter("@Title", educationState.Title)
		};
		educationState.EducationStateID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("EducationState_Insert", CommandType.StoredProcedure, parametersEducationState));
		return educationState.EducationStateID;
	}

	public bool Update(EducationState educationState)
	{
		SqlParameter[] parametersEducationState = new SqlParameter[]
		{
			new SqlParameter("@EducationStateID", educationState.EducationStateID),
			new SqlParameter("@Title", educationState.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("EducationState_Update", CommandType.StoredProcedure, parametersEducationState);
	}

	public bool Delete(int educationStateID)
	{
		SqlParameter[] parametersEducationState = new SqlParameter[]
		{
			new SqlParameter("@EducationStateID", educationStateID)
		};
		return SqlDBHelper.ExecuteNonQuery("EducationState_Delete", CommandType.StoredProcedure, parametersEducationState);
	}

	public EducationState GetDetails(int educationStateID)
	{
		EducationState educationState = new EducationState();

		SqlParameter[] parametersEducationState = new SqlParameter[]
		{
			new SqlParameter("@EducationStateID", educationStateID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("EducationState_GetDetails", CommandType.StoredProcedure, parametersEducationState))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				educationState.EducationStateID = (row["EducationStateID"] != DBNull.Value) ? Convert.ToInt32(row["EducationStateID"]) : 0 ;
				educationState.Title = row["Title"].ToString();
			}
		}

		return educationState;
	}

	public List<EducationState> GetListAll()
	{
		List<EducationState> listEducationState = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("EducationState_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listEducationState = new List<EducationState>();

				foreach (DataRow row in table.Rows)
				{
					EducationState educationState = new EducationState();
					educationState.EducationStateID = (row["EducationStateID"] != DBNull.Value) ? Convert.ToInt32(row["EducationStateID"]) : 0 ;
					educationState.Title = row["Title"].ToString();
					listEducationState.Add(educationState);
				}
			}
		}

		return listEducationState;
	}

	public bool Exists(int educationStateID)
	{
		SqlParameter[] parametersEducationState = new SqlParameter[]
		{
			new SqlParameter("@EducationStateID", educationStateID)
		};
		return (SqlDBHelper.ExecuteScalar("EducationState_Exists", CommandType.StoredProcedure, parametersEducationState)>0);
	}

	public bool Exists(EducationState educationState)
	{
		SqlParameter[] parametersEducationState = new SqlParameter[]
		{
			new SqlParameter("@EducationStateID", educationState.EducationStateID)
		};
		return (SqlDBHelper.ExecuteScalar("EducationState_Exists", CommandType.StoredProcedure, parametersEducationState)>0);
	}

	public List<EducationState> SearchLike(EducationState educationState)
	{
		List<EducationState> listEducationState = new List<EducationState>();


		SqlParameter[] parametersEducationState = new SqlParameter[]
		{
			new SqlParameter("@EducationStateID", educationState.EducationStateID),
			new SqlParameter("@Title", educationState.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("EducationState_SearchLike", CommandType.StoredProcedure, parametersEducationState))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					EducationState tmpEducationState = new EducationState();
					tmpEducationState.EducationStateID = (row["EducationStateID"] != DBNull.Value) ? Convert.ToInt32(row["EducationStateID"]) : 0 ;
					tmpEducationState.Title = row["Title"].ToString();

					listEducationState.Add(tmpEducationState);
				}
			}
		}

		return listEducationState;
	}

}
}
