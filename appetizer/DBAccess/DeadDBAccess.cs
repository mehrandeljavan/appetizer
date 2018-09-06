using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class DeadDBAccess
{
	PersonDBAccess personDBAccess = new PersonDBAccess();


	public Int64 Insert(Dead dead)
	{
		if (!personDBAccess.Exists(dead))
			dead.NationalCode = personDBAccess.Insert(dead);

		SqlParameter[] parametersDead = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", (dead.NationalCode > 0) ? dead.NationalCode : (object)DBNull.Value),
			new SqlParameter("@MartyrProfDescription", (dead.MartyrProfDescription != null) ? dead.MartyrProfDescription : (object)DBNull.Value),
			new SqlParameter("@UniqeCode", (dead.UniqeCode != null) ? dead.UniqeCode : (object)DBNull.Value),
			new SqlParameter("@ProbateIssuedCity", (dead.ProbateIssuedCity != null) ? dead.ProbateIssuedCity : (object)DBNull.Value),
			new SqlParameter("@DossierID", (dead.DossierID > 0) ? dead.DossierID : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (dead.RegisterInformationID > 0) ? dead.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@ProbateDocNumber", (dead.ProbateDocNumber != null) ? dead.ProbateDocNumber : (object)DBNull.Value),
			new SqlParameter("@ProbateIssued", (dead.ProbateIssued != null) ? dead.ProbateIssued : (object)DBNull.Value),
			new SqlParameter("@DeathDate", (dead.DeathDate != null) ? dead.DeathDate : (object)DBNull.Value),
			new SqlParameter("@ProbateDate", (dead.ProbateDate != null) ? dead.ProbateDate : (object)DBNull.Value),
			new SqlParameter("@DeathProvinceID", (dead.DeathProvinceID > 0) ? dead.DeathProvinceID : (object)DBNull.Value),
			new SqlParameter("@DeathCityID", (dead.DeathCityID > 0) ? dead.DeathCityID : (object)DBNull.Value),
			new SqlParameter("@MartyrProfReferenceID", (dead.MartyrProfReferenceID > 0) ? dead.MartyrProfReferenceID : (object)DBNull.Value),
			new SqlParameter("@NationalityID", (dead.NationalityID > 0) ? dead.NationalityID : (object)DBNull.Value),
			new SqlParameter("@ResidenceID", (dead.ResidenceID > 0) ? dead.ResidenceID : (object)DBNull.Value),
			new SqlParameter("@IsMartyr", (dead.IsMartyr != null) ? dead.IsMartyr : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Dead_Insert", CommandType.StoredProcedure, parametersDead);
	}

	public bool Update(Dead dead)
	{
		personDBAccess.Update(dead);

		SqlParameter[] parametersDead = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", dead.NationalCode),
			new SqlParameter("@MartyrProfDescription", (dead.MartyrProfDescription != null) ? dead.MartyrProfDescription : (object)DBNull.Value),
			new SqlParameter("@UniqeCode", (dead.UniqeCode != null) ? dead.UniqeCode : (object)DBNull.Value),
			new SqlParameter("@ProbateIssuedCity", (dead.ProbateIssuedCity != null) ? dead.ProbateIssuedCity : (object)DBNull.Value),
			new SqlParameter("@DossierID", (dead.DossierID != null && dead.DossierID >0 ) ? dead.DossierID : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (dead.RegisterInformationID != null && dead.RegisterInformationID >0 ) ? dead.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@ProbateDocNumber", (dead.ProbateDocNumber != null) ? dead.ProbateDocNumber : (object)DBNull.Value),
			new SqlParameter("@ProbateIssued", (dead.ProbateIssued != null) ? dead.ProbateIssued : (object)DBNull.Value),
			new SqlParameter("@DeathDate", (dead.DeathDate != null) ? dead.DeathDate : (object)DBNull.Value),
			new SqlParameter("@ProbateDate", (dead.ProbateDate != null) ? dead.ProbateDate : (object)DBNull.Value),
			new SqlParameter("@DeathProvinceID", (dead.DeathProvinceID != null && dead.DeathProvinceID >0 ) ? dead.DeathProvinceID : (object)DBNull.Value),
			new SqlParameter("@DeathCityID", (dead.DeathCityID != null && dead.DeathCityID >0 ) ? dead.DeathCityID : (object)DBNull.Value),
			new SqlParameter("@MartyrProfReferenceID", (dead.MartyrProfReferenceID != null && dead.MartyrProfReferenceID >0 ) ? dead.MartyrProfReferenceID : (object)DBNull.Value),
			new SqlParameter("@NationalityID", (dead.NationalityID != null && dead.NationalityID >0 ) ? dead.NationalityID : (object)DBNull.Value),
			new SqlParameter("@ResidenceID", (dead.ResidenceID != null && dead.ResidenceID >0 ) ? dead.ResidenceID : (object)DBNull.Value),
			new SqlParameter("@IsMartyr", (dead.IsMartyr != null) ? dead.IsMartyr : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Dead_Update", CommandType.StoredProcedure, parametersDead);
	}

	public bool Delete(Int64 nationalCode)
	{
		SqlParameter[] parametersDead = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};
		return SqlDBHelper.ExecuteNonQuery("Dead_Delete", CommandType.StoredProcedure, parametersDead);
	}

	public Dead GetDetails(Int64 nationalCode)
	{
		Dead dead = new Dead();

		SqlParameter[] parametersDead = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dead_GetDetails", CommandType.StoredProcedure, parametersDead))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				dead.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
				dead.RegisterDate = row["RegisterDate"].ToString();
				dead.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
				dead.OldRegisterDate = row["OldRegisterDate"].ToString();
				dead.DeathProvinceIDTitle = row["DeathProvinceIDTitle"].ToString();
				dead.DeathCityIDTitle = row["DeathCityIDTitle"].ToString();
				dead.MartyrProfReferenceIDTitle = row["MartyrProfReferenceIDTitle"].ToString();
				dead.NationalityIDTitle = row["NationalityIDTitle"].ToString();
				dead.ResidenceIDTitle = row["ResidenceIDTitle"].ToString();
				dead.MartyrProfDescription = row["MartyrProfDescription"].ToString();
				dead.UniqeCode = row["UniqeCode"].ToString();
				dead.ProbateIssuedCity = row["ProbateIssuedCity"].ToString();
				dead.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
				dead.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
				dead.ProbateDocNumber = row["ProbateDocNumber"].ToString();
				dead.ProbateIssued = row["ProbateIssued"].ToString();
				dead.DeathDate = row["DeathDate"].ToString();
				dead.ProbateDate = row["ProbateDate"].ToString();
				dead.DeathProvinceID = (row["DeathProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["DeathProvinceID"]) : 0 ;
				dead.DeathCityID = (row["DeathCityID"] != DBNull.Value) ? Convert.ToInt32(row["DeathCityID"]) : 0 ;
				dead.MartyrProfReferenceID = (row["MartyrProfReferenceID"] != DBNull.Value) ? Convert.ToInt32(row["MartyrProfReferenceID"]) : 0 ;
				dead.NationalityID = (row["NationalityID"] != DBNull.Value) ? Convert.ToInt32(row["NationalityID"]) : 0 ;
				dead.ResidenceID = (row["ResidenceID"] != DBNull.Value) ? Convert.ToInt32(row["ResidenceID"]) : 0 ;
				dead.IsMartyr = (row["IsMartyr"] != DBNull.Value) ? Convert.ToBoolean((row["IsMartyr"].ToString() == "1" || row["IsMartyr"].ToString().ToLower() == "true" ) ? true : false) : false ;

				Person person = personDBAccess.GetDetails(dead.NationalCode);
				dead.NationalCode = person.NationalCode;
				dead.PrintNationalCode = person.PrintNationalCode;
				dead.FullName = person.FullName;
				dead.GenderIDTitle = person.GenderIDTitle;
				dead.Religion_DinIDTitle = person.Religion_DinIDTitle;
				dead.Religion_MazhabIDTitle = person.Religion_MazhabIDTitle;
				dead.IssuanceProvinceIDTitle = person.IssuanceProvinceIDTitle;
				dead.IssuanceCityIDTitle = person.IssuanceCityIDTitle;
				dead.IssuanceDepartment = person.IssuanceDepartment;
				dead.CertificateNumber = person.CertificateNumber;
				dead.CertificateSerial = person.CertificateSerial;
				dead.ZipCode = person.ZipCode;
				dead.HomeAddress = person.HomeAddress;
				dead.PhoneNumber = person.PhoneNumber;
				dead.Job = person.Job;
				dead.JobAddress = person.JobAddress;
				dead.JobPhoneNumber = person.JobPhoneNumber;
				dead.Comment = person.Comment;
				dead.BirthCity = person.BirthCity;
				dead.JobZipCode = person.JobZipCode;
				dead.CertificateSerialLetter = person.CertificateSerialLetter;
				dead.CertificateSerialNumber = person.CertificateSerialNumber;
				dead.FatherName = person.FatherName;
				dead.Name = person.Name;
				dead.Family = person.Family;
				dead.BirthDate = person.BirthDate;
				dead.IssuanceDate = person.IssuanceDate;
				dead.GenderID = person.GenderID;
				dead.IssuanceProvinceID = person.IssuanceProvinceID;
				dead.IssuanceCityID = person.IssuanceCityID;
				dead.Religion_DinID = person.Religion_DinID;
				dead.Religion_MazhabID = person.Religion_MazhabID;
			}
		}

		return dead;
	}

	public List<Dead> GetListAll()
	{
		List<Dead> listDead = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Dead_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDead = new List<Dead>();

				foreach (DataRow row in table.Rows)
				{
					Dead dead = new Dead();
					dead.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					dead.RegisterDate = row["RegisterDate"].ToString();
					dead.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					dead.OldRegisterDate = row["OldRegisterDate"].ToString();
					dead.DeathProvinceIDTitle = row["DeathProvinceIDTitle"].ToString();
					dead.DeathCityIDTitle = row["DeathCityIDTitle"].ToString();
					dead.MartyrProfReferenceIDTitle = row["MartyrProfReferenceIDTitle"].ToString();
					dead.NationalityIDTitle = row["NationalityIDTitle"].ToString();
					dead.ResidenceIDTitle = row["ResidenceIDTitle"].ToString();
					dead.MartyrProfDescription = row["MartyrProfDescription"].ToString();
					dead.UniqeCode = row["UniqeCode"].ToString();
					dead.ProbateIssuedCity = row["ProbateIssuedCity"].ToString();
					dead.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					dead.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					dead.ProbateDocNumber = row["ProbateDocNumber"].ToString();
					dead.ProbateIssued = row["ProbateIssued"].ToString();
					dead.DeathDate = row["DeathDate"].ToString();
					dead.ProbateDate = row["ProbateDate"].ToString();
					dead.DeathProvinceID = (row["DeathProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["DeathProvinceID"]) : 0 ;
					dead.DeathCityID = (row["DeathCityID"] != DBNull.Value) ? Convert.ToInt32(row["DeathCityID"]) : 0 ;
					dead.MartyrProfReferenceID = (row["MartyrProfReferenceID"] != DBNull.Value) ? Convert.ToInt32(row["MartyrProfReferenceID"]) : 0 ;
					dead.NationalityID = (row["NationalityID"] != DBNull.Value) ? Convert.ToInt32(row["NationalityID"]) : 0 ;
					dead.ResidenceID = (row["ResidenceID"] != DBNull.Value) ? Convert.ToInt32(row["ResidenceID"]) : 0 ;
				dead.IsMartyr = (row["IsMartyr"] != DBNull.Value) ? Convert.ToBoolean((row["IsMartyr"].ToString() == "1" || row["IsMartyr"].ToString().ToLower() == "true" ) ? true : false) : false ;

					Person person = personDBAccess.GetDetails(dead.NationalCode);
					dead.PrintNationalCode = person.PrintNationalCode;
					dead.FullName = person.FullName;
					dead.GenderIDTitle = person.GenderIDTitle;
					dead.Religion_DinIDTitle = person.Religion_DinIDTitle;
					dead.Religion_MazhabIDTitle = person.Religion_MazhabIDTitle;
					dead.IssuanceProvinceIDTitle = person.IssuanceProvinceIDTitle;
					dead.IssuanceCityIDTitle = person.IssuanceCityIDTitle;
					dead.IssuanceDepartment = person.IssuanceDepartment;
					dead.CertificateNumber = person.CertificateNumber;
					dead.CertificateSerial = person.CertificateSerial;
					dead.ZipCode = person.ZipCode;
					dead.HomeAddress = person.HomeAddress;
					dead.PhoneNumber = person.PhoneNumber;
					dead.Job = person.Job;
					dead.JobAddress = person.JobAddress;
					dead.JobPhoneNumber = person.JobPhoneNumber;
					dead.Comment = person.Comment;
					dead.BirthCity = person.BirthCity;
					dead.JobZipCode = person.JobZipCode;
					dead.CertificateSerialLetter = person.CertificateSerialLetter;
					dead.CertificateSerialNumber = person.CertificateSerialNumber;
					dead.FatherName = person.FatherName;
					dead.Name = person.Name;
					dead.Family = person.Family;
					dead.BirthDate = person.BirthDate;
					dead.IssuanceDate = person.IssuanceDate;
					dead.GenderID = person.GenderID;
					dead.IssuanceProvinceID = person.IssuanceProvinceID;
					dead.IssuanceCityID = person.IssuanceCityID;
					dead.Religion_DinID = person.Religion_DinID;
					dead.Religion_MazhabID = person.Religion_MazhabID;
					listDead.Add(dead);
				}
			}
		}

		return listDead;
	}

	public bool Exists(Int64 nationalCode)
	{
		SqlParameter[] parametersDead = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("Dead_Exists", CommandType.StoredProcedure, parametersDead)>0);
	}

	public bool Exists(Dead dead)
	{
		SqlParameter[] parametersDead = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", dead.NationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("Dead_Exists", CommandType.StoredProcedure, parametersDead)>0);
	}

	public List<Dead> SearchLike(Dead dead)
	{
		List<Dead> listDead = new List<Dead>();


		SqlParameter[] parametersDead = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", dead.NationalCode),
			new SqlParameter("@RegisterDate", dead.RegisterDate),
			new SqlParameter("@OldRegisterInformationID", dead.OldRegisterInformationID),
			new SqlParameter("@OldRegisterDate", dead.OldRegisterDate),
			new SqlParameter("@DeathProvinceIDTitle", dead.DeathProvinceIDTitle),
			new SqlParameter("@DeathCityIDTitle", dead.DeathCityIDTitle),
			new SqlParameter("@MartyrProfReferenceIDTitle", dead.MartyrProfReferenceIDTitle),
			new SqlParameter("@NationalityIDTitle", dead.NationalityIDTitle),
			new SqlParameter("@ResidenceIDTitle", dead.ResidenceIDTitle),
			new SqlParameter("@MartyrProfDescription", dead.MartyrProfDescription),
			new SqlParameter("@UniqeCode", dead.UniqeCode),
			new SqlParameter("@ProbateIssuedCity", dead.ProbateIssuedCity),
			new SqlParameter("@DossierID", dead.DossierID),
			new SqlParameter("@RegisterInformationID", dead.RegisterInformationID),
			new SqlParameter("@ProbateDocNumber", dead.ProbateDocNumber),
			new SqlParameter("@ProbateIssued", dead.ProbateIssued),
			new SqlParameter("@DeathDate", dead.DeathDate),
			new SqlParameter("@ProbateDate", dead.ProbateDate),
			new SqlParameter("@DeathProvinceID", dead.DeathProvinceID),
			new SqlParameter("@DeathCityID", dead.DeathCityID),
			new SqlParameter("@MartyrProfReferenceID", dead.MartyrProfReferenceID),
			new SqlParameter("@NationalityID", dead.NationalityID),
			new SqlParameter("@ResidenceID", dead.ResidenceID),
			new SqlParameter("@IsMartyr", dead.IsMartyr),

			new SqlParameter("@PrintNationalCode", dead.PrintNationalCode),
			new SqlParameter("@FullName", dead.FullName),
			new SqlParameter("@GenderIDTitle", dead.GenderIDTitle),
			new SqlParameter("@Religion_DinIDTitle", dead.Religion_DinIDTitle),
			new SqlParameter("@Religion_MazhabIDTitle", dead.Religion_MazhabIDTitle),
			new SqlParameter("@IssuanceProvinceIDTitle", dead.IssuanceProvinceIDTitle),
			new SqlParameter("@IssuanceCityIDTitle", dead.IssuanceCityIDTitle),
			new SqlParameter("@IssuanceDepartment", dead.IssuanceDepartment),
			new SqlParameter("@CertificateNumber", dead.CertificateNumber),
			new SqlParameter("@CertificateSerial", dead.CertificateSerial),
			new SqlParameter("@ZipCode", dead.ZipCode),
			new SqlParameter("@HomeAddress", dead.HomeAddress),
			new SqlParameter("@PhoneNumber", dead.PhoneNumber),
			new SqlParameter("@Job", dead.Job),
			new SqlParameter("@JobAddress", dead.JobAddress),
			new SqlParameter("@JobPhoneNumber", dead.JobPhoneNumber),
			new SqlParameter("@Comment", dead.Comment),
			new SqlParameter("@BirthCity", dead.BirthCity),
			new SqlParameter("@JobZipCode", dead.JobZipCode),
			new SqlParameter("@CertificateSerialLetter", dead.CertificateSerialLetter),
			new SqlParameter("@CertificateSerialNumber", dead.CertificateSerialNumber),
			new SqlParameter("@FatherName", dead.FatherName),
			new SqlParameter("@Name", dead.Name),
			new SqlParameter("@Family", dead.Family),
			new SqlParameter("@BirthDate", dead.BirthDate),
			new SqlParameter("@IssuanceDate", dead.IssuanceDate),
			new SqlParameter("@GenderID", dead.GenderID),
			new SqlParameter("@IssuanceProvinceID", dead.IssuanceProvinceID),
			new SqlParameter("@IssuanceCityID", dead.IssuanceCityID),
			new SqlParameter("@Religion_DinID", dead.Religion_DinID),
			new SqlParameter("@Religion_MazhabID", dead.Religion_MazhabID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dead_SearchLike", CommandType.StoredProcedure, parametersDead))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Dead tmpDead = new Dead();
					tmpDead.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					tmpDead.RegisterDate = row["RegisterDate"].ToString();
					tmpDead.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					tmpDead.OldRegisterDate = row["OldRegisterDate"].ToString();
					tmpDead.DeathProvinceIDTitle = row["DeathProvinceIDTitle"].ToString();
					tmpDead.DeathCityIDTitle = row["DeathCityIDTitle"].ToString();
					tmpDead.MartyrProfReferenceIDTitle = row["MartyrProfReferenceIDTitle"].ToString();
					tmpDead.NationalityIDTitle = row["NationalityIDTitle"].ToString();
					tmpDead.ResidenceIDTitle = row["ResidenceIDTitle"].ToString();
					tmpDead.MartyrProfDescription = row["MartyrProfDescription"].ToString();
					tmpDead.UniqeCode = row["UniqeCode"].ToString();
					tmpDead.ProbateIssuedCity = row["ProbateIssuedCity"].ToString();
					tmpDead.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					tmpDead.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					tmpDead.ProbateDocNumber = row["ProbateDocNumber"].ToString();
					tmpDead.ProbateIssued = row["ProbateIssued"].ToString();
					tmpDead.DeathDate = row["DeathDate"].ToString();
					tmpDead.ProbateDate = row["ProbateDate"].ToString();
					tmpDead.DeathProvinceID = (row["DeathProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["DeathProvinceID"]) : 0 ;
					tmpDead.DeathCityID = (row["DeathCityID"] != DBNull.Value) ? Convert.ToInt32(row["DeathCityID"]) : 0 ;
					tmpDead.MartyrProfReferenceID = (row["MartyrProfReferenceID"] != DBNull.Value) ? Convert.ToInt32(row["MartyrProfReferenceID"]) : 0 ;
					tmpDead.NationalityID = (row["NationalityID"] != DBNull.Value) ? Convert.ToInt32(row["NationalityID"]) : 0 ;
					tmpDead.ResidenceID = (row["ResidenceID"] != DBNull.Value) ? Convert.ToInt32(row["ResidenceID"]) : 0 ;
					tmpDead.IsMartyr = (row["IsMartyr"] != DBNull.Value) ? Convert.ToBoolean((row["IsMartyr"].ToString() == "1" || row["IsMartyr"].ToString().ToLower() == "true" ) ? true : false) : false ;

					Person person = personDBAccess.GetDetails(tmpDead.NationalCode);
					tmpDead.NationalCode = person.NationalCode;
					tmpDead.PrintNationalCode = person.PrintNationalCode;
					tmpDead.FullName = person.FullName;
					tmpDead.GenderIDTitle = person.GenderIDTitle;
					tmpDead.Religion_DinIDTitle = person.Religion_DinIDTitle;
					tmpDead.Religion_MazhabIDTitle = person.Religion_MazhabIDTitle;
					tmpDead.IssuanceProvinceIDTitle = person.IssuanceProvinceIDTitle;
					tmpDead.IssuanceCityIDTitle = person.IssuanceCityIDTitle;
					tmpDead.IssuanceDepartment = person.IssuanceDepartment;
					tmpDead.CertificateNumber = person.CertificateNumber;
					tmpDead.CertificateSerial = person.CertificateSerial;
					tmpDead.ZipCode = person.ZipCode;
					tmpDead.HomeAddress = person.HomeAddress;
					tmpDead.PhoneNumber = person.PhoneNumber;
					tmpDead.Job = person.Job;
					tmpDead.JobAddress = person.JobAddress;
					tmpDead.JobPhoneNumber = person.JobPhoneNumber;
					tmpDead.Comment = person.Comment;
					tmpDead.BirthCity = person.BirthCity;
					tmpDead.JobZipCode = person.JobZipCode;
					tmpDead.CertificateSerialLetter = person.CertificateSerialLetter;
					tmpDead.CertificateSerialNumber = person.CertificateSerialNumber;
					tmpDead.FatherName = person.FatherName;
					tmpDead.Name = person.Name;
					tmpDead.Family = person.Family;
					tmpDead.BirthDate = person.BirthDate;
					tmpDead.IssuanceDate = person.IssuanceDate;
					tmpDead.GenderID = person.GenderID;
					tmpDead.IssuanceProvinceID = person.IssuanceProvinceID;
					tmpDead.IssuanceCityID = person.IssuanceCityID;
					tmpDead.Religion_DinID = person.Religion_DinID;
					tmpDead.Religion_MazhabID = person.Religion_MazhabID;

					listDead.Add(tmpDead);
				}
			}
		}

		return listDead;
	}

}
}
