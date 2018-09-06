using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class UttererDBAccess
{
	PersonDBAccess personDBAccess = new PersonDBAccess();


	public Int64 Insert(Utterer utterer)
	{
		if (!personDBAccess.Exists(utterer))
			utterer.NationalCode = personDBAccess.Insert(utterer);

		SqlParameter[] parametersUtterer = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", (utterer.NationalCode > 0) ? utterer.NationalCode : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (utterer.RegisterInformationID > 0) ? utterer.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@DossierID", (utterer.DossierID > 0) ? utterer.DossierID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (utterer.DeclarationID > 0) ? utterer.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@UttererRoleID", (utterer.UttererRoleID > 0) ? utterer.UttererRoleID : (object)DBNull.Value),
			new SqlParameter("@AssertionOrder", utterer.AssertionOrder),
			new SqlParameter("@IsApplicant", utterer.IsApplicant)
		};
		utterer.UttererID = SqlDBHelper.ExecuteScalar("Utterer_Insert", CommandType.StoredProcedure, parametersUtterer);
		return utterer.UttererID;
	}

	public bool Update(Utterer utterer)
	{
		personDBAccess.Update(utterer);

		SqlParameter[] parametersUtterer = new SqlParameter[]
		{
			new SqlParameter("@UttererID", utterer.UttererID),
			new SqlParameter("@NationalCode", utterer.NationalCode),
			new SqlParameter("@RegisterInformationID", (utterer.RegisterInformationID != null && utterer.RegisterInformationID >0 ) ? utterer.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@DossierID", (utterer.DossierID != null && utterer.DossierID >0 ) ? utterer.DossierID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (utterer.DeclarationID != null && utterer.DeclarationID >0 ) ? utterer.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@UttererRoleID", (utterer.UttererRoleID != null && utterer.UttererRoleID >0 ) ? utterer.UttererRoleID : (object)DBNull.Value),
			new SqlParameter("@AssertionOrder", utterer.AssertionOrder),
			new SqlParameter("@IsApplicant", utterer.IsApplicant)
		};
		return SqlDBHelper.ExecuteNonQuery("Utterer_Update", CommandType.StoredProcedure, parametersUtterer);
	}

	public bool Delete(Int64 uttererID)
	{
		SqlParameter[] parametersUtterer = new SqlParameter[]
		{
			new SqlParameter("@UttererID", uttererID)
		};
		return SqlDBHelper.ExecuteNonQuery("Utterer_Delete", CommandType.StoredProcedure, parametersUtterer);
	}

	public Utterer GetDetails(Int64 uttererID)
	{
		Utterer utterer = new Utterer();

		SqlParameter[] parametersUtterer = new SqlParameter[]
		{
			new SqlParameter("@UttererID", uttererID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Utterer_GetDetails", CommandType.StoredProcedure, parametersUtterer))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				utterer.UttererID = (row["UttererID"] != DBNull.Value) ? Convert.ToInt64(row["UttererID"]) : 0 ;
				utterer.RegisterDate = row["RegisterDate"].ToString();
				utterer.UttererRoleIDTitle = row["UttererRoleIDTitle"].ToString();
				utterer.OldRegisterDate = row["OldRegisterDate"].ToString();
				utterer.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
				utterer.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
				utterer.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
				utterer.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
				utterer.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				utterer.UttererRoleID = (row["UttererRoleID"] != DBNull.Value) ? Convert.ToInt32(row["UttererRoleID"]) : 0 ;
				utterer.AssertionOrder = (row["AssertionOrder"] != DBNull.Value) ? Convert.ToInt32(row["AssertionOrder"]) : 0 ;
				utterer.IsApplicant = (row["IsApplicant"] != DBNull.Value) ? Convert.ToBoolean((row["IsApplicant"].ToString() == "1" || row["IsApplicant"].ToString().ToLower() == "true" ) ? true : false) : false ;

				Person person = personDBAccess.GetDetails(utterer.NationalCode);
				utterer.NationalCode = person.NationalCode;
				utterer.PrintNationalCode = person.PrintNationalCode;
				utterer.FullName = person.FullName;
				utterer.GenderIDTitle = person.GenderIDTitle;
				utterer.Religion_DinIDTitle = person.Religion_DinIDTitle;
				utterer.Religion_MazhabIDTitle = person.Religion_MazhabIDTitle;
				utterer.IssuanceProvinceIDTitle = person.IssuanceProvinceIDTitle;
				utterer.IssuanceCityIDTitle = person.IssuanceCityIDTitle;
				utterer.IssuanceDepartment = person.IssuanceDepartment;
				utterer.CertificateNumber = person.CertificateNumber;
				utterer.CertificateSerial = person.CertificateSerial;
				utterer.ZipCode = person.ZipCode;
				utterer.HomeAddress = person.HomeAddress;
				utterer.PhoneNumber = person.PhoneNumber;
				utterer.Job = person.Job;
				utterer.JobAddress = person.JobAddress;
				utterer.JobPhoneNumber = person.JobPhoneNumber;
				utterer.Comment = person.Comment;
				utterer.BirthCity = person.BirthCity;
				utterer.JobZipCode = person.JobZipCode;
				utterer.CertificateSerialLetter = person.CertificateSerialLetter;
				utterer.CertificateSerialNumber = person.CertificateSerialNumber;
				utterer.FatherName = person.FatherName;
				utterer.Name = person.Name;
				utterer.Family = person.Family;
				utterer.BirthDate = person.BirthDate;
				utterer.IssuanceDate = person.IssuanceDate;
				utterer.GenderID = person.GenderID;
				utterer.IssuanceProvinceID = person.IssuanceProvinceID;
				utterer.IssuanceCityID = person.IssuanceCityID;
				utterer.Religion_DinID = person.Religion_DinID;
				utterer.Religion_MazhabID = person.Religion_MazhabID;
			}
		}

		return utterer;
	}

	public List<Utterer> GetListAll()
	{
		List<Utterer> listUtterer = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Utterer_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listUtterer = new List<Utterer>();

				foreach (DataRow row in table.Rows)
				{
					Utterer utterer = new Utterer();
					utterer.UttererID = (row["UttererID"] != DBNull.Value) ? Convert.ToInt64(row["UttererID"]) : 0 ;
					utterer.RegisterDate = row["RegisterDate"].ToString();
					utterer.UttererRoleIDTitle = row["UttererRoleIDTitle"].ToString();
					utterer.OldRegisterDate = row["OldRegisterDate"].ToString();
					utterer.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					utterer.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					utterer.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					utterer.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					utterer.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					utterer.UttererRoleID = (row["UttererRoleID"] != DBNull.Value) ? Convert.ToInt32(row["UttererRoleID"]) : 0 ;
					utterer.AssertionOrder = (row["AssertionOrder"] != DBNull.Value) ? Convert.ToInt32(row["AssertionOrder"]) : 0 ;
				utterer.IsApplicant = (row["IsApplicant"] != DBNull.Value) ? Convert.ToBoolean((row["IsApplicant"].ToString() == "1" || row["IsApplicant"].ToString().ToLower() == "true" ) ? true : false) : false ;

					Person person = personDBAccess.GetDetails(utterer.NationalCode);
					utterer.PrintNationalCode = person.PrintNationalCode;
					utterer.FullName = person.FullName;
					utterer.GenderIDTitle = person.GenderIDTitle;
					utterer.Religion_DinIDTitle = person.Religion_DinIDTitle;
					utterer.Religion_MazhabIDTitle = person.Religion_MazhabIDTitle;
					utterer.IssuanceProvinceIDTitle = person.IssuanceProvinceIDTitle;
					utterer.IssuanceCityIDTitle = person.IssuanceCityIDTitle;
					utterer.IssuanceDepartment = person.IssuanceDepartment;
					utterer.CertificateNumber = person.CertificateNumber;
					utterer.CertificateSerial = person.CertificateSerial;
					utterer.ZipCode = person.ZipCode;
					utterer.HomeAddress = person.HomeAddress;
					utterer.PhoneNumber = person.PhoneNumber;
					utterer.Job = person.Job;
					utterer.JobAddress = person.JobAddress;
					utterer.JobPhoneNumber = person.JobPhoneNumber;
					utterer.Comment = person.Comment;
					utterer.BirthCity = person.BirthCity;
					utterer.JobZipCode = person.JobZipCode;
					utterer.CertificateSerialLetter = person.CertificateSerialLetter;
					utterer.CertificateSerialNumber = person.CertificateSerialNumber;
					utterer.FatherName = person.FatherName;
					utterer.Name = person.Name;
					utterer.Family = person.Family;
					utterer.BirthDate = person.BirthDate;
					utterer.IssuanceDate = person.IssuanceDate;
					utterer.GenderID = person.GenderID;
					utterer.IssuanceProvinceID = person.IssuanceProvinceID;
					utterer.IssuanceCityID = person.IssuanceCityID;
					utterer.Religion_DinID = person.Religion_DinID;
					utterer.Religion_MazhabID = person.Religion_MazhabID;
					listUtterer.Add(utterer);
				}
			}
		}

		return listUtterer;
	}

	public bool Exists(Int64 uttererID)
	{
		SqlParameter[] parametersUtterer = new SqlParameter[]
		{
			new SqlParameter("@UttererID", uttererID)
		};
		return (SqlDBHelper.ExecuteScalar("Utterer_Exists", CommandType.StoredProcedure, parametersUtterer)>0);
	}

	public bool Exists(Utterer utterer)
	{
		SqlParameter[] parametersUtterer = new SqlParameter[]
		{
			new SqlParameter("@UttererID", utterer.UttererID)
		};
		return (SqlDBHelper.ExecuteScalar("Utterer_Exists", CommandType.StoredProcedure, parametersUtterer)>0);
	}

	public List<Utterer> SearchLike(Utterer utterer)
	{
		List<Utterer> listUtterer = new List<Utterer>();


		SqlParameter[] parametersUtterer = new SqlParameter[]
		{
			new SqlParameter("@UttererID", utterer.UttererID),
			new SqlParameter("@RegisterDate", utterer.RegisterDate),
			new SqlParameter("@UttererRoleIDTitle", utterer.UttererRoleIDTitle),
			new SqlParameter("@OldRegisterDate", utterer.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", utterer.OldRegisterInformationID),
			new SqlParameter("@NationalCode", utterer.NationalCode),
			new SqlParameter("@RegisterInformationID", utterer.RegisterInformationID),
			new SqlParameter("@DossierID", utterer.DossierID),
			new SqlParameter("@DeclarationID", utterer.DeclarationID),
			new SqlParameter("@UttererRoleID", utterer.UttererRoleID),
			new SqlParameter("@AssertionOrder", utterer.AssertionOrder),
			new SqlParameter("@IsApplicant", utterer.IsApplicant),

			new SqlParameter("@PrintNationalCode", utterer.PrintNationalCode),
			new SqlParameter("@FullName", utterer.FullName),
			new SqlParameter("@GenderIDTitle", utterer.GenderIDTitle),
			new SqlParameter("@Religion_DinIDTitle", utterer.Religion_DinIDTitle),
			new SqlParameter("@Religion_MazhabIDTitle", utterer.Religion_MazhabIDTitle),
			new SqlParameter("@IssuanceProvinceIDTitle", utterer.IssuanceProvinceIDTitle),
			new SqlParameter("@IssuanceCityIDTitle", utterer.IssuanceCityIDTitle),
			new SqlParameter("@IssuanceDepartment", utterer.IssuanceDepartment),
			new SqlParameter("@CertificateNumber", utterer.CertificateNumber),
			new SqlParameter("@CertificateSerial", utterer.CertificateSerial),
			new SqlParameter("@ZipCode", utterer.ZipCode),
			new SqlParameter("@HomeAddress", utterer.HomeAddress),
			new SqlParameter("@PhoneNumber", utterer.PhoneNumber),
			new SqlParameter("@Job", utterer.Job),
			new SqlParameter("@JobAddress", utterer.JobAddress),
			new SqlParameter("@JobPhoneNumber", utterer.JobPhoneNumber),
			new SqlParameter("@Comment", utterer.Comment),
			new SqlParameter("@BirthCity", utterer.BirthCity),
			new SqlParameter("@JobZipCode", utterer.JobZipCode),
			new SqlParameter("@CertificateSerialLetter", utterer.CertificateSerialLetter),
			new SqlParameter("@CertificateSerialNumber", utterer.CertificateSerialNumber),
			new SqlParameter("@FatherName", utterer.FatherName),
			new SqlParameter("@Name", utterer.Name),
			new SqlParameter("@Family", utterer.Family),
			new SqlParameter("@BirthDate", utterer.BirthDate),
			new SqlParameter("@IssuanceDate", utterer.IssuanceDate),
			new SqlParameter("@GenderID", utterer.GenderID),
			new SqlParameter("@IssuanceProvinceID", utterer.IssuanceProvinceID),
			new SqlParameter("@IssuanceCityID", utterer.IssuanceCityID),
			new SqlParameter("@Religion_DinID", utterer.Religion_DinID),
			new SqlParameter("@Religion_MazhabID", utterer.Religion_MazhabID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Utterer_SearchLike", CommandType.StoredProcedure, parametersUtterer))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Utterer tmpUtterer = new Utterer();
					tmpUtterer.UttererID = (row["UttererID"] != DBNull.Value) ? Convert.ToInt64(row["UttererID"]) : 0 ;
					tmpUtterer.RegisterDate = row["RegisterDate"].ToString();
					tmpUtterer.UttererRoleIDTitle = row["UttererRoleIDTitle"].ToString();
					tmpUtterer.OldRegisterDate = row["OldRegisterDate"].ToString();
					tmpUtterer.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					tmpUtterer.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					tmpUtterer.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					tmpUtterer.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					tmpUtterer.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpUtterer.UttererRoleID = (row["UttererRoleID"] != DBNull.Value) ? Convert.ToInt32(row["UttererRoleID"]) : 0 ;
					tmpUtterer.AssertionOrder = (row["AssertionOrder"] != DBNull.Value) ? Convert.ToInt32(row["AssertionOrder"]) : 0 ;
					tmpUtterer.IsApplicant = (row["IsApplicant"] != DBNull.Value) ? Convert.ToBoolean((row["IsApplicant"].ToString() == "1" || row["IsApplicant"].ToString().ToLower() == "true" ) ? true : false) : false ;

					Person person = personDBAccess.GetDetails(tmpUtterer.NationalCode);
					tmpUtterer.NationalCode = person.NationalCode;
					tmpUtterer.PrintNationalCode = person.PrintNationalCode;
					tmpUtterer.FullName = person.FullName;
					tmpUtterer.GenderIDTitle = person.GenderIDTitle;
					tmpUtterer.Religion_DinIDTitle = person.Religion_DinIDTitle;
					tmpUtterer.Religion_MazhabIDTitle = person.Religion_MazhabIDTitle;
					tmpUtterer.IssuanceProvinceIDTitle = person.IssuanceProvinceIDTitle;
					tmpUtterer.IssuanceCityIDTitle = person.IssuanceCityIDTitle;
					tmpUtterer.IssuanceDepartment = person.IssuanceDepartment;
					tmpUtterer.CertificateNumber = person.CertificateNumber;
					tmpUtterer.CertificateSerial = person.CertificateSerial;
					tmpUtterer.ZipCode = person.ZipCode;
					tmpUtterer.HomeAddress = person.HomeAddress;
					tmpUtterer.PhoneNumber = person.PhoneNumber;
					tmpUtterer.Job = person.Job;
					tmpUtterer.JobAddress = person.JobAddress;
					tmpUtterer.JobPhoneNumber = person.JobPhoneNumber;
					tmpUtterer.Comment = person.Comment;
					tmpUtterer.BirthCity = person.BirthCity;
					tmpUtterer.JobZipCode = person.JobZipCode;
					tmpUtterer.CertificateSerialLetter = person.CertificateSerialLetter;
					tmpUtterer.CertificateSerialNumber = person.CertificateSerialNumber;
					tmpUtterer.FatherName = person.FatherName;
					tmpUtterer.Name = person.Name;
					tmpUtterer.Family = person.Family;
					tmpUtterer.BirthDate = person.BirthDate;
					tmpUtterer.IssuanceDate = person.IssuanceDate;
					tmpUtterer.GenderID = person.GenderID;
					tmpUtterer.IssuanceProvinceID = person.IssuanceProvinceID;
					tmpUtterer.IssuanceCityID = person.IssuanceCityID;
					tmpUtterer.Religion_DinID = person.Religion_DinID;
					tmpUtterer.Religion_MazhabID = person.Religion_MazhabID;

					listUtterer.Add(tmpUtterer);
				}
			}
		}

		return listUtterer;
	}

}
}
