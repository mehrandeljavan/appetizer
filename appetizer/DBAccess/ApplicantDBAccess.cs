using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class ApplicantDBAccess
{
	PersonDBAccess personDBAccess = new PersonDBAccess();


	public Int64 Insert(Applicant applicant)
	{
		if (!personDBAccess.Exists(applicant))
			applicant.NationalCode = personDBAccess.Insert(applicant);

		SqlParameter[] parametersApplicant = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", (applicant.NationalCode > 0) ? applicant.NationalCode : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (applicant.DeclarationID > 0) ? applicant.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (applicant.RegisterInformationID > 0) ? applicant.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@ApplicantRoleID", (applicant.ApplicantRoleID > 0) ? applicant.ApplicantRoleID : (object)DBNull.Value),
			new SqlParameter("@RequestTypeID", (applicant.RequestTypeID > 0) ? applicant.RequestTypeID : (object)DBNull.Value)
		};
		applicant.ApplicantID = SqlDBHelper.ExecuteScalar("Applicant_Insert", CommandType.StoredProcedure, parametersApplicant);
		return applicant.ApplicantID;
	}

	public bool Update(Applicant applicant)
	{
		personDBAccess.Update(applicant);

		SqlParameter[] parametersApplicant = new SqlParameter[]
		{
			new SqlParameter("@ApplicantID", applicant.ApplicantID),
			new SqlParameter("@NationalCode", applicant.NationalCode),
			new SqlParameter("@DeclarationID", (applicant.DeclarationID != null && applicant.DeclarationID >0 ) ? applicant.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (applicant.RegisterInformationID != null && applicant.RegisterInformationID >0 ) ? applicant.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@ApplicantRoleID", (applicant.ApplicantRoleID != null && applicant.ApplicantRoleID >0 ) ? applicant.ApplicantRoleID : (object)DBNull.Value),
			new SqlParameter("@RequestTypeID", (applicant.RequestTypeID != null && applicant.RequestTypeID >0 ) ? applicant.RequestTypeID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Applicant_Update", CommandType.StoredProcedure, parametersApplicant);
	}

	public bool Delete(Int64 applicantID)
	{
		SqlParameter[] parametersApplicant = new SqlParameter[]
		{
			new SqlParameter("@ApplicantID", applicantID)
		};
		return SqlDBHelper.ExecuteNonQuery("Applicant_Delete", CommandType.StoredProcedure, parametersApplicant);
	}

	public Applicant GetDetails(Int64 applicantID)
	{
		Applicant applicant = new Applicant();

		SqlParameter[] parametersApplicant = new SqlParameter[]
		{
			new SqlParameter("@ApplicantID", applicantID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Applicant_GetDetails", CommandType.StoredProcedure, parametersApplicant))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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

				Person person = personDBAccess.GetDetails(applicant.NationalCode);
				applicant.NationalCode = person.NationalCode;
				applicant.PrintNationalCode = person.PrintNationalCode;
				applicant.FullName = person.FullName;
				applicant.GenderIDTitle = person.GenderIDTitle;
				applicant.Religion_DinIDTitle = person.Religion_DinIDTitle;
				applicant.Religion_MazhabIDTitle = person.Religion_MazhabIDTitle;
				applicant.IssuanceProvinceIDTitle = person.IssuanceProvinceIDTitle;
				applicant.IssuanceCityIDTitle = person.IssuanceCityIDTitle;
				applicant.IssuanceDepartment = person.IssuanceDepartment;
				applicant.CertificateNumber = person.CertificateNumber;
				applicant.CertificateSerial = person.CertificateSerial;
				applicant.ZipCode = person.ZipCode;
				applicant.HomeAddress = person.HomeAddress;
				applicant.PhoneNumber = person.PhoneNumber;
				applicant.Job = person.Job;
				applicant.JobAddress = person.JobAddress;
				applicant.JobPhoneNumber = person.JobPhoneNumber;
				applicant.Comment = person.Comment;
				applicant.BirthCity = person.BirthCity;
				applicant.JobZipCode = person.JobZipCode;
				applicant.CertificateSerialLetter = person.CertificateSerialLetter;
				applicant.CertificateSerialNumber = person.CertificateSerialNumber;
				applicant.FatherName = person.FatherName;
				applicant.Name = person.Name;
				applicant.Family = person.Family;
				applicant.BirthDate = person.BirthDate;
				applicant.IssuanceDate = person.IssuanceDate;
				applicant.GenderID = person.GenderID;
				applicant.IssuanceProvinceID = person.IssuanceProvinceID;
				applicant.IssuanceCityID = person.IssuanceCityID;
				applicant.Religion_DinID = person.Religion_DinID;
				applicant.Religion_MazhabID = person.Religion_MazhabID;
			}
		}

		return applicant;
	}

	public List<Applicant> GetListAll()
	{
		List<Applicant> listApplicant = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Applicant_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listApplicant = new List<Applicant>();

				foreach (DataRow row in table.Rows)
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

					Person person = personDBAccess.GetDetails(applicant.NationalCode);
					applicant.PrintNationalCode = person.PrintNationalCode;
					applicant.FullName = person.FullName;
					applicant.GenderIDTitle = person.GenderIDTitle;
					applicant.Religion_DinIDTitle = person.Religion_DinIDTitle;
					applicant.Religion_MazhabIDTitle = person.Religion_MazhabIDTitle;
					applicant.IssuanceProvinceIDTitle = person.IssuanceProvinceIDTitle;
					applicant.IssuanceCityIDTitle = person.IssuanceCityIDTitle;
					applicant.IssuanceDepartment = person.IssuanceDepartment;
					applicant.CertificateNumber = person.CertificateNumber;
					applicant.CertificateSerial = person.CertificateSerial;
					applicant.ZipCode = person.ZipCode;
					applicant.HomeAddress = person.HomeAddress;
					applicant.PhoneNumber = person.PhoneNumber;
					applicant.Job = person.Job;
					applicant.JobAddress = person.JobAddress;
					applicant.JobPhoneNumber = person.JobPhoneNumber;
					applicant.Comment = person.Comment;
					applicant.BirthCity = person.BirthCity;
					applicant.JobZipCode = person.JobZipCode;
					applicant.CertificateSerialLetter = person.CertificateSerialLetter;
					applicant.CertificateSerialNumber = person.CertificateSerialNumber;
					applicant.FatherName = person.FatherName;
					applicant.Name = person.Name;
					applicant.Family = person.Family;
					applicant.BirthDate = person.BirthDate;
					applicant.IssuanceDate = person.IssuanceDate;
					applicant.GenderID = person.GenderID;
					applicant.IssuanceProvinceID = person.IssuanceProvinceID;
					applicant.IssuanceCityID = person.IssuanceCityID;
					applicant.Religion_DinID = person.Religion_DinID;
					applicant.Religion_MazhabID = person.Religion_MazhabID;
					listApplicant.Add(applicant);
				}
			}
		}

		return listApplicant;
	}

	public bool Exists(Int64 applicantID)
	{
		SqlParameter[] parametersApplicant = new SqlParameter[]
		{
			new SqlParameter("@ApplicantID", applicantID)
		};
		return (SqlDBHelper.ExecuteScalar("Applicant_Exists", CommandType.StoredProcedure, parametersApplicant)>0);
	}

	public bool Exists(Applicant applicant)
	{
		SqlParameter[] parametersApplicant = new SqlParameter[]
		{
			new SqlParameter("@ApplicantID", applicant.ApplicantID)
		};
		return (SqlDBHelper.ExecuteScalar("Applicant_Exists", CommandType.StoredProcedure, parametersApplicant)>0);
	}

	public List<Applicant> SearchLike(Applicant applicant)
	{
		List<Applicant> listApplicant = new List<Applicant>();


		SqlParameter[] parametersApplicant = new SqlParameter[]
		{
			new SqlParameter("@ApplicantID", applicant.ApplicantID),
			new SqlParameter("@ApplicantRoleIDTitle", applicant.ApplicantRoleIDTitle),
			new SqlParameter("@RequestTypeIDTitle", applicant.RequestTypeIDTitle),
			new SqlParameter("@RegisterDate", applicant.RegisterDate),
			new SqlParameter("@OldRegisterInformationID", applicant.OldRegisterInformationID),
			new SqlParameter("@OldRegisterDate", applicant.OldRegisterDate),
			new SqlParameter("@NationalCode", applicant.NationalCode),
			new SqlParameter("@DeclarationID", applicant.DeclarationID),
			new SqlParameter("@RegisterInformationID", applicant.RegisterInformationID),
			new SqlParameter("@ApplicantRoleID", applicant.ApplicantRoleID),
			new SqlParameter("@RequestTypeID", applicant.RequestTypeID),

			new SqlParameter("@PrintNationalCode", applicant.PrintNationalCode),
			new SqlParameter("@FullName", applicant.FullName),
			new SqlParameter("@GenderIDTitle", applicant.GenderIDTitle),
			new SqlParameter("@Religion_DinIDTitle", applicant.Religion_DinIDTitle),
			new SqlParameter("@Religion_MazhabIDTitle", applicant.Religion_MazhabIDTitle),
			new SqlParameter("@IssuanceProvinceIDTitle", applicant.IssuanceProvinceIDTitle),
			new SqlParameter("@IssuanceCityIDTitle", applicant.IssuanceCityIDTitle),
			new SqlParameter("@IssuanceDepartment", applicant.IssuanceDepartment),
			new SqlParameter("@CertificateNumber", applicant.CertificateNumber),
			new SqlParameter("@CertificateSerial", applicant.CertificateSerial),
			new SqlParameter("@ZipCode", applicant.ZipCode),
			new SqlParameter("@HomeAddress", applicant.HomeAddress),
			new SqlParameter("@PhoneNumber", applicant.PhoneNumber),
			new SqlParameter("@Job", applicant.Job),
			new SqlParameter("@JobAddress", applicant.JobAddress),
			new SqlParameter("@JobPhoneNumber", applicant.JobPhoneNumber),
			new SqlParameter("@Comment", applicant.Comment),
			new SqlParameter("@BirthCity", applicant.BirthCity),
			new SqlParameter("@JobZipCode", applicant.JobZipCode),
			new SqlParameter("@CertificateSerialLetter", applicant.CertificateSerialLetter),
			new SqlParameter("@CertificateSerialNumber", applicant.CertificateSerialNumber),
			new SqlParameter("@FatherName", applicant.FatherName),
			new SqlParameter("@Name", applicant.Name),
			new SqlParameter("@Family", applicant.Family),
			new SqlParameter("@BirthDate", applicant.BirthDate),
			new SqlParameter("@IssuanceDate", applicant.IssuanceDate),
			new SqlParameter("@GenderID", applicant.GenderID),
			new SqlParameter("@IssuanceProvinceID", applicant.IssuanceProvinceID),
			new SqlParameter("@IssuanceCityID", applicant.IssuanceCityID),
			new SqlParameter("@Religion_DinID", applicant.Religion_DinID),
			new SqlParameter("@Religion_MazhabID", applicant.Religion_MazhabID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Applicant_SearchLike", CommandType.StoredProcedure, parametersApplicant))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Applicant tmpApplicant = new Applicant();
					tmpApplicant.ApplicantID = (row["ApplicantID"] != DBNull.Value) ? Convert.ToInt64(row["ApplicantID"]) : 0 ;
					tmpApplicant.ApplicantRoleIDTitle = row["ApplicantRoleIDTitle"].ToString();
					tmpApplicant.RequestTypeIDTitle = row["RequestTypeIDTitle"].ToString();
					tmpApplicant.RegisterDate = row["RegisterDate"].ToString();
					tmpApplicant.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					tmpApplicant.OldRegisterDate = row["OldRegisterDate"].ToString();
					tmpApplicant.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					tmpApplicant.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpApplicant.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					tmpApplicant.ApplicantRoleID = (row["ApplicantRoleID"] != DBNull.Value) ? Convert.ToInt32(row["ApplicantRoleID"]) : 0 ;
					tmpApplicant.RequestTypeID = (row["RequestTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RequestTypeID"]) : 0 ;

					Person person = personDBAccess.GetDetails(tmpApplicant.NationalCode);
					tmpApplicant.NationalCode = person.NationalCode;
					tmpApplicant.PrintNationalCode = person.PrintNationalCode;
					tmpApplicant.FullName = person.FullName;
					tmpApplicant.GenderIDTitle = person.GenderIDTitle;
					tmpApplicant.Religion_DinIDTitle = person.Religion_DinIDTitle;
					tmpApplicant.Religion_MazhabIDTitle = person.Religion_MazhabIDTitle;
					tmpApplicant.IssuanceProvinceIDTitle = person.IssuanceProvinceIDTitle;
					tmpApplicant.IssuanceCityIDTitle = person.IssuanceCityIDTitle;
					tmpApplicant.IssuanceDepartment = person.IssuanceDepartment;
					tmpApplicant.CertificateNumber = person.CertificateNumber;
					tmpApplicant.CertificateSerial = person.CertificateSerial;
					tmpApplicant.ZipCode = person.ZipCode;
					tmpApplicant.HomeAddress = person.HomeAddress;
					tmpApplicant.PhoneNumber = person.PhoneNumber;
					tmpApplicant.Job = person.Job;
					tmpApplicant.JobAddress = person.JobAddress;
					tmpApplicant.JobPhoneNumber = person.JobPhoneNumber;
					tmpApplicant.Comment = person.Comment;
					tmpApplicant.BirthCity = person.BirthCity;
					tmpApplicant.JobZipCode = person.JobZipCode;
					tmpApplicant.CertificateSerialLetter = person.CertificateSerialLetter;
					tmpApplicant.CertificateSerialNumber = person.CertificateSerialNumber;
					tmpApplicant.FatherName = person.FatherName;
					tmpApplicant.Name = person.Name;
					tmpApplicant.Family = person.Family;
					tmpApplicant.BirthDate = person.BirthDate;
					tmpApplicant.IssuanceDate = person.IssuanceDate;
					tmpApplicant.GenderID = person.GenderID;
					tmpApplicant.IssuanceProvinceID = person.IssuanceProvinceID;
					tmpApplicant.IssuanceCityID = person.IssuanceCityID;
					tmpApplicant.Religion_DinID = person.Religion_DinID;
					tmpApplicant.Religion_MazhabID = person.Religion_MazhabID;

					listApplicant.Add(tmpApplicant);
				}
			}
		}

		return listApplicant;
	}

}
}
