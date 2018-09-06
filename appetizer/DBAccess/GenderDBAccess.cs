using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class GenderDBAccess
{

	PersonDBAccess personDBAccess = new PersonDBAccess();

	public List<Person> GetListPerson(int genderID)
	{
		List<Person> listPerson = new List<Person>() { };
		SqlParameter[] parametersGender = new SqlParameter[]
		{
			new SqlParameter("@GenderID", genderID)
		};

		//Lets get the list of Person records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Person_GetList_UseInGender", CommandType.StoredProcedure, parametersGender))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of person
				listPerson = new List<Person>();

				//Now lets populate the Person details into the list of persons
				foreach (DataRow row in table.Rows)
				{
					Person person = ConvertRowToPerson(row);
					listPerson.Add(person);
				}
			}
		}

		return listPerson;
	}

	private Person ConvertRowToPerson(DataRow row)
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
		return person;
	}
	public Int64 Insert(Gender gender)
	{
		SqlParameter[] parametersGender = new SqlParameter[]
		{
			new SqlParameter("@Title", gender.Title)
		};
		gender.GenderID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("Gender_Insert", CommandType.StoredProcedure, parametersGender));
		return gender.GenderID;
	}

	public bool Update(Gender gender)
	{
		SqlParameter[] parametersGender = new SqlParameter[]
		{
			new SqlParameter("@GenderID", gender.GenderID),
			new SqlParameter("@Title", gender.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("Gender_Update", CommandType.StoredProcedure, parametersGender);
	}

	public bool Delete(int genderID)
	{
		SqlParameter[] parametersGender = new SqlParameter[]
		{
			new SqlParameter("@GenderID", genderID)
		};
		return SqlDBHelper.ExecuteNonQuery("Gender_Delete", CommandType.StoredProcedure, parametersGender);
	}

	public Gender GetDetails(int genderID)
	{
		Gender gender = new Gender();

		SqlParameter[] parametersGender = new SqlParameter[]
		{
			new SqlParameter("@GenderID", genderID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Gender_GetDetails", CommandType.StoredProcedure, parametersGender))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				gender.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
				gender.Title = row["Title"].ToString();
			}
		}

		return gender;
	}

	public List<Gender> GetListAll()
	{
		List<Gender> listGender = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Gender_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listGender = new List<Gender>();

				foreach (DataRow row in table.Rows)
				{
					Gender gender = new Gender();
					gender.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
					gender.Title = row["Title"].ToString();
					listGender.Add(gender);
				}
			}
		}

		return listGender;
	}

	public bool Exists(int genderID)
	{
		SqlParameter[] parametersGender = new SqlParameter[]
		{
			new SqlParameter("@GenderID", genderID)
		};
		return (SqlDBHelper.ExecuteScalar("Gender_Exists", CommandType.StoredProcedure, parametersGender)>0);
	}

	public bool Exists(Gender gender)
	{
		SqlParameter[] parametersGender = new SqlParameter[]
		{
			new SqlParameter("@GenderID", gender.GenderID)
		};
		return (SqlDBHelper.ExecuteScalar("Gender_Exists", CommandType.StoredProcedure, parametersGender)>0);
	}

	public List<Gender> SearchLike(Gender gender)
	{
		List<Gender> listGender = new List<Gender>();


		SqlParameter[] parametersGender = new SqlParameter[]
		{
			new SqlParameter("@GenderID", gender.GenderID),
			new SqlParameter("@Title", gender.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Gender_SearchLike", CommandType.StoredProcedure, parametersGender))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Gender tmpGender = new Gender();
					tmpGender.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
					tmpGender.Title = row["Title"].ToString();

					listGender.Add(tmpGender);
				}
			}
		}

		return listGender;
	}

}
}
