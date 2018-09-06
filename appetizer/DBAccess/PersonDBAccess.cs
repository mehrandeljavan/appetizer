using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class PersonDBAccess
{


	public Int64 Insert(Person person)
	{
		SqlParameter[] parametersPerson = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", person.NationalCode),
			new SqlParameter("@IssuanceDepartment", (person.IssuanceDepartment != null) ? person.IssuanceDepartment : (object)DBNull.Value),
			new SqlParameter("@CertificateNumber", (person.CertificateNumber != null) ? person.CertificateNumber : (object)DBNull.Value),
			new SqlParameter("@CertificateSerial", (person.CertificateSerial != null) ? person.CertificateSerial : (object)DBNull.Value),
			new SqlParameter("@ZipCode", (person.ZipCode != null) ? person.ZipCode : (object)DBNull.Value),
			new SqlParameter("@HomeAddress", (person.HomeAddress != null) ? person.HomeAddress : (object)DBNull.Value),
			new SqlParameter("@PhoneNumber", (person.PhoneNumber != null) ? person.PhoneNumber : (object)DBNull.Value),
			new SqlParameter("@Job", (person.Job != null) ? person.Job : (object)DBNull.Value),
			new SqlParameter("@JobAddress", (person.JobAddress != null) ? person.JobAddress : (object)DBNull.Value),
			new SqlParameter("@JobPhoneNumber", (person.JobPhoneNumber != null) ? person.JobPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@Comment", (person.Comment != null) ? person.Comment : (object)DBNull.Value),
			new SqlParameter("@BirthCity", (person.BirthCity != null) ? person.BirthCity : (object)DBNull.Value),
			new SqlParameter("@JobZipCode", (person.JobZipCode != null) ? person.JobZipCode : (object)DBNull.Value),
			new SqlParameter("@CertificateSerialLetter", (person.CertificateSerialLetter != null) ? person.CertificateSerialLetter : (object)DBNull.Value),
			new SqlParameter("@CertificateSerialNumber", (person.CertificateSerialNumber != null) ? person.CertificateSerialNumber : (object)DBNull.Value),
			new SqlParameter("@FatherName", (person.FatherName != null) ? person.FatherName : (object)DBNull.Value),
			new SqlParameter("@Name", person.Name),
			new SqlParameter("@Family", person.Family),
			new SqlParameter("@BirthDate", (person.BirthDate != null) ? person.BirthDate : (object)DBNull.Value),
			new SqlParameter("@IssuanceDate", (person.IssuanceDate != null) ? person.IssuanceDate : (object)DBNull.Value),
			new SqlParameter("@GenderID", (person.GenderID > 0) ? person.GenderID : (object)DBNull.Value),
			new SqlParameter("@IssuanceProvinceID", (person.IssuanceProvinceID > 0) ? person.IssuanceProvinceID : (object)DBNull.Value),
			new SqlParameter("@IssuanceCityID", (person.IssuanceCityID > 0) ? person.IssuanceCityID : (object)DBNull.Value),
			new SqlParameter("@Religion_DinID", (person.Religion_DinID > 0) ? person.Religion_DinID : (object)DBNull.Value),
			new SqlParameter("@Religion_MazhabID", (person.Religion_MazhabID > 0) ? person.Religion_MazhabID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Person_Insert", CommandType.StoredProcedure, parametersPerson);
	}

	public bool Update(Person person)
	{
		SqlParameter[] parametersPerson = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", person.NationalCode),
			new SqlParameter("@IssuanceDepartment", (person.IssuanceDepartment != null) ? person.IssuanceDepartment : (object)DBNull.Value),
			new SqlParameter("@CertificateNumber", (person.CertificateNumber != null) ? person.CertificateNumber : (object)DBNull.Value),
			new SqlParameter("@CertificateSerial", (person.CertificateSerial != null) ? person.CertificateSerial : (object)DBNull.Value),
			new SqlParameter("@ZipCode", (person.ZipCode != null) ? person.ZipCode : (object)DBNull.Value),
			new SqlParameter("@HomeAddress", (person.HomeAddress != null) ? person.HomeAddress : (object)DBNull.Value),
			new SqlParameter("@PhoneNumber", (person.PhoneNumber != null) ? person.PhoneNumber : (object)DBNull.Value),
			new SqlParameter("@Job", (person.Job != null) ? person.Job : (object)DBNull.Value),
			new SqlParameter("@JobAddress", (person.JobAddress != null) ? person.JobAddress : (object)DBNull.Value),
			new SqlParameter("@JobPhoneNumber", (person.JobPhoneNumber != null) ? person.JobPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@Comment", (person.Comment != null) ? person.Comment : (object)DBNull.Value),
			new SqlParameter("@BirthCity", (person.BirthCity != null) ? person.BirthCity : (object)DBNull.Value),
			new SqlParameter("@JobZipCode", (person.JobZipCode != null) ? person.JobZipCode : (object)DBNull.Value),
			new SqlParameter("@CertificateSerialLetter", (person.CertificateSerialLetter != null) ? person.CertificateSerialLetter : (object)DBNull.Value),
			new SqlParameter("@CertificateSerialNumber", (person.CertificateSerialNumber != null) ? person.CertificateSerialNumber : (object)DBNull.Value),
			new SqlParameter("@FatherName", (person.FatherName != null) ? person.FatherName : (object)DBNull.Value),
			new SqlParameter("@Name", person.Name),
			new SqlParameter("@Family", person.Family),
			new SqlParameter("@BirthDate", (person.BirthDate != null) ? person.BirthDate : (object)DBNull.Value),
			new SqlParameter("@IssuanceDate", (person.IssuanceDate != null) ? person.IssuanceDate : (object)DBNull.Value),
			new SqlParameter("@GenderID", (person.GenderID != null && person.GenderID >0 ) ? person.GenderID : (object)DBNull.Value),
			new SqlParameter("@IssuanceProvinceID", (person.IssuanceProvinceID != null && person.IssuanceProvinceID >0 ) ? person.IssuanceProvinceID : (object)DBNull.Value),
			new SqlParameter("@IssuanceCityID", (person.IssuanceCityID != null && person.IssuanceCityID >0 ) ? person.IssuanceCityID : (object)DBNull.Value),
			new SqlParameter("@Religion_DinID", (person.Religion_DinID != null && person.Religion_DinID >0 ) ? person.Religion_DinID : (object)DBNull.Value),
			new SqlParameter("@Religion_MazhabID", (person.Religion_MazhabID != null && person.Religion_MazhabID >0 ) ? person.Religion_MazhabID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Person_Update", CommandType.StoredProcedure, parametersPerson);
	}

	public bool Delete(Int64 nationalCode)
	{
		SqlParameter[] parametersPerson = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};
		return SqlDBHelper.ExecuteNonQuery("Person_Delete", CommandType.StoredProcedure, parametersPerson);
	}

	public Person GetDetails(Int64 nationalCode)
	{
		Person person = new Person();

		SqlParameter[] parametersPerson = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Person_GetDetails", CommandType.StoredProcedure, parametersPerson))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				person.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
				person.PrintNationalCode = row["PrintNationalCode"].ToString();
				person.FullName = row["FullName"].ToString();
				person.GenderIDTitle = row["GenderIDTitle"].ToString();
				person.Religion_DinIDTitle = row["Religion_DinIDTitle"].ToString();
				person.Religion_MazhabIDTitle = row["Religion_MazhabIDTitle"].ToString();
				person.IssuanceProvinceIDTitle = row["IssuanceProvinceIDTitle"].ToString();
				person.IssuanceCityIDTitle = row["IssuanceCityIDTitle"].ToString();
				person.IssuanceDepartment = row["IssuanceDepartment"].ToString();
				person.CertificateNumber = row["CertificateNumber"].ToString();
				person.CertificateSerial = row["CertificateSerial"].ToString();
				person.ZipCode = row["ZipCode"].ToString();
				person.HomeAddress = row["HomeAddress"].ToString();
				person.PhoneNumber = row["PhoneNumber"].ToString();
				person.Job = row["Job"].ToString();
				person.JobAddress = row["JobAddress"].ToString();
				person.JobPhoneNumber = row["JobPhoneNumber"].ToString();
				person.Comment = row["Comment"].ToString();
				person.BirthCity = row["BirthCity"].ToString();
				person.JobZipCode = row["JobZipCode"].ToString();
				person.CertificateSerialLetter = row["CertificateSerialLetter"].ToString();
				person.CertificateSerialNumber = row["CertificateSerialNumber"].ToString();
				person.FatherName = row["FatherName"].ToString();
				person.Name = row["Name"].ToString();
				person.Family = row["Family"].ToString();
				person.BirthDate = row["BirthDate"].ToString();
				person.IssuanceDate = row["IssuanceDate"].ToString();
				person.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
				person.IssuanceProvinceID = (row["IssuanceProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceProvinceID"]) : 0 ;
				person.IssuanceCityID = (row["IssuanceCityID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceCityID"]) : 0 ;
				person.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
				person.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
			}
		}

		return person;
	}

	public List<Person> GetListAll()
	{
		List<Person> listPerson = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Person_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listPerson = new List<Person>();

				foreach (DataRow row in table.Rows)
				{
					Person person = new Person();
					person.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					person.PrintNationalCode = row["PrintNationalCode"].ToString();
					person.FullName = row["FullName"].ToString();
					person.GenderIDTitle = row["GenderIDTitle"].ToString();
					person.Religion_DinIDTitle = row["Religion_DinIDTitle"].ToString();
					person.Religion_MazhabIDTitle = row["Religion_MazhabIDTitle"].ToString();
					person.IssuanceProvinceIDTitle = row["IssuanceProvinceIDTitle"].ToString();
					person.IssuanceCityIDTitle = row["IssuanceCityIDTitle"].ToString();
					person.IssuanceDepartment = row["IssuanceDepartment"].ToString();
					person.CertificateNumber = row["CertificateNumber"].ToString();
					person.CertificateSerial = row["CertificateSerial"].ToString();
					person.ZipCode = row["ZipCode"].ToString();
					person.HomeAddress = row["HomeAddress"].ToString();
					person.PhoneNumber = row["PhoneNumber"].ToString();
					person.Job = row["Job"].ToString();
					person.JobAddress = row["JobAddress"].ToString();
					person.JobPhoneNumber = row["JobPhoneNumber"].ToString();
					person.Comment = row["Comment"].ToString();
					person.BirthCity = row["BirthCity"].ToString();
					person.JobZipCode = row["JobZipCode"].ToString();
					person.CertificateSerialLetter = row["CertificateSerialLetter"].ToString();
					person.CertificateSerialNumber = row["CertificateSerialNumber"].ToString();
					person.FatherName = row["FatherName"].ToString();
					person.Name = row["Name"].ToString();
					person.Family = row["Family"].ToString();
					person.BirthDate = row["BirthDate"].ToString();
					person.IssuanceDate = row["IssuanceDate"].ToString();
					person.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
					person.IssuanceProvinceID = (row["IssuanceProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceProvinceID"]) : 0 ;
					person.IssuanceCityID = (row["IssuanceCityID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceCityID"]) : 0 ;
					person.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
					person.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
					listPerson.Add(person);
				}
			}
		}

		return listPerson;
	}

	public bool Exists(Int64 nationalCode)
	{
		SqlParameter[] parametersPerson = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("Person_Exists", CommandType.StoredProcedure, parametersPerson)>0);
	}

	public bool Exists(Person person)
	{
		SqlParameter[] parametersPerson = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", person.NationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("Person_Exists", CommandType.StoredProcedure, parametersPerson)>0);
	}

	public List<Person> SearchLike(Person person)
	{
		List<Person> listPerson = new List<Person>();


		SqlParameter[] parametersPerson = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", person.NationalCode),
			new SqlParameter("@PrintNationalCode", person.PrintNationalCode),
			new SqlParameter("@FullName", person.FullName),
			new SqlParameter("@GenderIDTitle", person.GenderIDTitle),
			new SqlParameter("@Religion_DinIDTitle", person.Religion_DinIDTitle),
			new SqlParameter("@Religion_MazhabIDTitle", person.Religion_MazhabIDTitle),
			new SqlParameter("@IssuanceProvinceIDTitle", person.IssuanceProvinceIDTitle),
			new SqlParameter("@IssuanceCityIDTitle", person.IssuanceCityIDTitle),
			new SqlParameter("@IssuanceDepartment", person.IssuanceDepartment),
			new SqlParameter("@CertificateNumber", person.CertificateNumber),
			new SqlParameter("@CertificateSerial", person.CertificateSerial),
			new SqlParameter("@ZipCode", person.ZipCode),
			new SqlParameter("@HomeAddress", person.HomeAddress),
			new SqlParameter("@PhoneNumber", person.PhoneNumber),
			new SqlParameter("@Job", person.Job),
			new SqlParameter("@JobAddress", person.JobAddress),
			new SqlParameter("@JobPhoneNumber", person.JobPhoneNumber),
			new SqlParameter("@Comment", person.Comment),
			new SqlParameter("@BirthCity", person.BirthCity),
			new SqlParameter("@JobZipCode", person.JobZipCode),
			new SqlParameter("@CertificateSerialLetter", person.CertificateSerialLetter),
			new SqlParameter("@CertificateSerialNumber", person.CertificateSerialNumber),
			new SqlParameter("@FatherName", person.FatherName),
			new SqlParameter("@Name", person.Name),
			new SqlParameter("@Family", person.Family),
			new SqlParameter("@BirthDate", person.BirthDate),
			new SqlParameter("@IssuanceDate", person.IssuanceDate),
			new SqlParameter("@GenderID", person.GenderID),
			new SqlParameter("@IssuanceProvinceID", person.IssuanceProvinceID),
			new SqlParameter("@IssuanceCityID", person.IssuanceCityID),
			new SqlParameter("@Religion_DinID", person.Religion_DinID),
			new SqlParameter("@Religion_MazhabID", person.Religion_MazhabID),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Person_SearchLike", CommandType.StoredProcedure, parametersPerson))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Person tmpPerson = new Person();
					tmpPerson.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					tmpPerson.PrintNationalCode = row["PrintNationalCode"].ToString();
					tmpPerson.FullName = row["FullName"].ToString();
					tmpPerson.GenderIDTitle = row["GenderIDTitle"].ToString();
					tmpPerson.Religion_DinIDTitle = row["Religion_DinIDTitle"].ToString();
					tmpPerson.Religion_MazhabIDTitle = row["Religion_MazhabIDTitle"].ToString();
					tmpPerson.IssuanceProvinceIDTitle = row["IssuanceProvinceIDTitle"].ToString();
					tmpPerson.IssuanceCityIDTitle = row["IssuanceCityIDTitle"].ToString();
					tmpPerson.IssuanceDepartment = row["IssuanceDepartment"].ToString();
					tmpPerson.CertificateNumber = row["CertificateNumber"].ToString();
					tmpPerson.CertificateSerial = row["CertificateSerial"].ToString();
					tmpPerson.ZipCode = row["ZipCode"].ToString();
					tmpPerson.HomeAddress = row["HomeAddress"].ToString();
					tmpPerson.PhoneNumber = row["PhoneNumber"].ToString();
					tmpPerson.Job = row["Job"].ToString();
					tmpPerson.JobAddress = row["JobAddress"].ToString();
					tmpPerson.JobPhoneNumber = row["JobPhoneNumber"].ToString();
					tmpPerson.Comment = row["Comment"].ToString();
					tmpPerson.BirthCity = row["BirthCity"].ToString();
					tmpPerson.JobZipCode = row["JobZipCode"].ToString();
					tmpPerson.CertificateSerialLetter = row["CertificateSerialLetter"].ToString();
					tmpPerson.CertificateSerialNumber = row["CertificateSerialNumber"].ToString();
					tmpPerson.FatherName = row["FatherName"].ToString();
					tmpPerson.Name = row["Name"].ToString();
					tmpPerson.Family = row["Family"].ToString();
					tmpPerson.BirthDate = row["BirthDate"].ToString();
					tmpPerson.IssuanceDate = row["IssuanceDate"].ToString();
					tmpPerson.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
					tmpPerson.IssuanceProvinceID = (row["IssuanceProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceProvinceID"]) : 0 ;
					tmpPerson.IssuanceCityID = (row["IssuanceCityID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceCityID"]) : 0 ;
					tmpPerson.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
					tmpPerson.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;

					listPerson.Add(tmpPerson);
				}
			}
		}

		return listPerson;
	}

}
}
