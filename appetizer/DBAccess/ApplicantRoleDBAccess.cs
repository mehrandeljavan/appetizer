using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class ApplicantRoleDBAccess
{

	ApplicantDBAccess applicantDBAccess = new ApplicantDBAccess();

	public List<Applicant> GetListApplicant(int applicantRoleID)
	{
		List<Applicant> listApplicant = new List<Applicant>() { };
		SqlParameter[] parametersApplicantRole = new SqlParameter[]
		{
			new SqlParameter("@ApplicantRoleID", applicantRoleID)
		};

		//Lets get the list of Applicant records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Applicant_GetList_UseInApplicantRole", CommandType.StoredProcedure, parametersApplicantRole))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of applicant
				listApplicant = new List<Applicant>();

				//Now lets populate the Applicant details into the list of applicants
				foreach (DataRow row in table.Rows)
				{
					Applicant applicant = ConvertRowToApplicant(row);
					listApplicant.Add(applicant);
				}
			}
		}

		return listApplicant;
	}

	private Applicant ConvertRowToApplicant(DataRow row)
	{
		Applicant applicant = new Applicant();
		applicant.ApplicantID = (row["ApplicantID"] != DBNull.Value) ? Convert.ToInt64(row["ApplicantID"]) : 0 ;
		applicant.ApplicantRoleIDTitle = row["ApplicantRoleIDTitle"].ToString();
		applicant.RequestTypeIDTitle = row["RequestTypeIDTitle"].ToString();
		applicant.RegisterDate = row["RegisterDate"].ToString();
		applicant.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		applicant.OldRegisterDate = row["OldRegisterDate"].ToString();
		applicant.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		applicant.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		applicant.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		applicant.ApplicantRoleID = (row["ApplicantRoleID"] != DBNull.Value) ? Convert.ToInt32(row["ApplicantRoleID"]) : 0 ;
		applicant.RequestTypeID = (row["RequestTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RequestTypeID"]) : 0 ;

		applicant.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		applicant.PrintNationalCode = row["PrintNationalCode"].ToString();
		applicant.FullName = row["FullName"].ToString();
		applicant.GenderIDTitle = row["GenderIDTitle"].ToString();
		applicant.Religion_DinIDTitle = row["Religion_DinIDTitle"].ToString();
		applicant.Religion_MazhabIDTitle = row["Religion_MazhabIDTitle"].ToString();
		applicant.IssuanceProvinceIDTitle = row["IssuanceProvinceIDTitle"].ToString();
		applicant.IssuanceCityIDTitle = row["IssuanceCityIDTitle"].ToString();
		applicant.IssuanceDepartment = row["IssuanceDepartment"].ToString();
		applicant.CertificateNumber = row["CertificateNumber"].ToString();
		applicant.CertificateSerial = row["CertificateSerial"].ToString();
		applicant.ZipCode = row["ZipCode"].ToString();
		applicant.HomeAddress = row["HomeAddress"].ToString();
		applicant.PhoneNumber = row["PhoneNumber"].ToString();
		applicant.Job = row["Job"].ToString();
		applicant.JobAddress = row["JobAddress"].ToString();
		applicant.JobPhoneNumber = row["JobPhoneNumber"].ToString();
		applicant.Comment = row["Comment"].ToString();
		applicant.BirthCity = row["BirthCity"].ToString();
		applicant.JobZipCode = row["JobZipCode"].ToString();
		applicant.CertificateSerialLetter = row["CertificateSerialLetter"].ToString();
		applicant.CertificateSerialNumber = row["CertificateSerialNumber"].ToString();
		applicant.FatherName = row["FatherName"].ToString();
		applicant.Name = row["Name"].ToString();
		applicant.Family = row["Family"].ToString();
		applicant.BirthDate = row["BirthDate"].ToString();
		applicant.IssuanceDate = row["IssuanceDate"].ToString();
		applicant.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
		applicant.IssuanceProvinceID = (row["IssuanceProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceProvinceID"]) : 0 ;
		applicant.IssuanceCityID = (row["IssuanceCityID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceCityID"]) : 0 ;
		applicant.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
		applicant.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
		return applicant;
	}
	public Int64 Insert(ApplicantRole applicantRole)
	{
		SqlParameter[] parametersApplicantRole = new SqlParameter[]
		{
			new SqlParameter("@Title", applicantRole.Title)
		};
		applicantRole.ApplicantRoleID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("ApplicantRole_Insert", CommandType.StoredProcedure, parametersApplicantRole));
		return applicantRole.ApplicantRoleID;
	}

	public bool Update(ApplicantRole applicantRole)
	{
		SqlParameter[] parametersApplicantRole = new SqlParameter[]
		{
			new SqlParameter("@ApplicantRoleID", applicantRole.ApplicantRoleID),
			new SqlParameter("@Title", applicantRole.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("ApplicantRole_Update", CommandType.StoredProcedure, parametersApplicantRole);
	}

	public bool Delete(int applicantRoleID)
	{
		SqlParameter[] parametersApplicantRole = new SqlParameter[]
		{
			new SqlParameter("@ApplicantRoleID", applicantRoleID)
		};
		return SqlDBHelper.ExecuteNonQuery("ApplicantRole_Delete", CommandType.StoredProcedure, parametersApplicantRole);
	}

	public ApplicantRole GetDetails(int applicantRoleID)
	{
		ApplicantRole applicantRole = new ApplicantRole();

		SqlParameter[] parametersApplicantRole = new SqlParameter[]
		{
			new SqlParameter("@ApplicantRoleID", applicantRoleID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ApplicantRole_GetDetails", CommandType.StoredProcedure, parametersApplicantRole))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				applicantRole.ApplicantRoleID = (row["ApplicantRoleID"] != DBNull.Value) ? Convert.ToInt32(row["ApplicantRoleID"]) : 0 ;
				applicantRole.Title = row["Title"].ToString();
			}
		}

		return applicantRole;
	}

	public List<ApplicantRole> GetListAll()
	{
		List<ApplicantRole> listApplicantRole = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("ApplicantRole_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listApplicantRole = new List<ApplicantRole>();

				foreach (DataRow row in table.Rows)
				{
					ApplicantRole applicantRole = new ApplicantRole();
					applicantRole.ApplicantRoleID = (row["ApplicantRoleID"] != DBNull.Value) ? Convert.ToInt32(row["ApplicantRoleID"]) : 0 ;
					applicantRole.Title = row["Title"].ToString();
					listApplicantRole.Add(applicantRole);
				}
			}
		}

		return listApplicantRole;
	}

	public bool Exists(int applicantRoleID)
	{
		SqlParameter[] parametersApplicantRole = new SqlParameter[]
		{
			new SqlParameter("@ApplicantRoleID", applicantRoleID)
		};
		return (SqlDBHelper.ExecuteScalar("ApplicantRole_Exists", CommandType.StoredProcedure, parametersApplicantRole)>0);
	}

	public bool Exists(ApplicantRole applicantRole)
	{
		SqlParameter[] parametersApplicantRole = new SqlParameter[]
		{
			new SqlParameter("@ApplicantRoleID", applicantRole.ApplicantRoleID)
		};
		return (SqlDBHelper.ExecuteScalar("ApplicantRole_Exists", CommandType.StoredProcedure, parametersApplicantRole)>0);
	}

	public List<ApplicantRole> SearchLike(ApplicantRole applicantRole)
	{
		List<ApplicantRole> listApplicantRole = new List<ApplicantRole>();


		SqlParameter[] parametersApplicantRole = new SqlParameter[]
		{
			new SqlParameter("@ApplicantRoleID", applicantRole.ApplicantRoleID),
			new SqlParameter("@Title", applicantRole.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ApplicantRole_SearchLike", CommandType.StoredProcedure, parametersApplicantRole))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					ApplicantRole tmpApplicantRole = new ApplicantRole();
					tmpApplicantRole.ApplicantRoleID = (row["ApplicantRoleID"] != DBNull.Value) ? Convert.ToInt32(row["ApplicantRoleID"]) : 0 ;
					tmpApplicantRole.Title = row["Title"].ToString();

					listApplicantRole.Add(tmpApplicantRole);
				}
			}
		}

		return listApplicantRole;
	}

}
}
