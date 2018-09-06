using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class Religion_DinDBAccess
{

	PersonDBAccess personDBAccess = new PersonDBAccess();

	public List<Person> GetListPerson(int religion_DinID)
	{
		List<Person> listPerson = new List<Person>() { };
		SqlParameter[] parametersReligion_Din = new SqlParameter[]
		{
			new SqlParameter("@Religion_DinID", religion_DinID)
		};

		//Lets get the list of Person records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Person_GetList_UseInReligion_Din", CommandType.StoredProcedure, parametersReligion_Din))
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
	public Int64 Insert(Religion_Din religion_Din)
	{
		SqlParameter[] parametersReligion_Din = new SqlParameter[]
		{
			new SqlParameter("@Title", religion_Din.Title)
		};
		religion_Din.Religion_DinID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("Religion_Din_Insert", CommandType.StoredProcedure, parametersReligion_Din));
		return religion_Din.Religion_DinID;
	}

	public bool Update(Religion_Din religion_Din)
	{
		SqlParameter[] parametersReligion_Din = new SqlParameter[]
		{
			new SqlParameter("@Religion_DinID", religion_Din.Religion_DinID),
			new SqlParameter("@Title", religion_Din.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("Religion_Din_Update", CommandType.StoredProcedure, parametersReligion_Din);
	}

	public bool Delete(int religion_DinID)
	{
		SqlParameter[] parametersReligion_Din = new SqlParameter[]
		{
			new SqlParameter("@Religion_DinID", religion_DinID)
		};
		return SqlDBHelper.ExecuteNonQuery("Religion_Din_Delete", CommandType.StoredProcedure, parametersReligion_Din);
	}

	public Religion_Din GetDetails(int religion_DinID)
	{
		Religion_Din religion_Din = new Religion_Din();

		SqlParameter[] parametersReligion_Din = new SqlParameter[]
		{
			new SqlParameter("@Religion_DinID", religion_DinID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Religion_Din_GetDetails", CommandType.StoredProcedure, parametersReligion_Din))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				religion_Din.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
				religion_Din.Title = row["Title"].ToString();
			}
		}

		return religion_Din;
	}

	public List<Religion_Din> GetListAll()
	{
		List<Religion_Din> listReligion_Din = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Religion_Din_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listReligion_Din = new List<Religion_Din>();

				foreach (DataRow row in table.Rows)
				{
					Religion_Din religion_Din = new Religion_Din();
					religion_Din.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
					religion_Din.Title = row["Title"].ToString();
					listReligion_Din.Add(religion_Din);
				}
			}
		}

		return listReligion_Din;
	}

	public bool Exists(int religion_DinID)
	{
		SqlParameter[] parametersReligion_Din = new SqlParameter[]
		{
			new SqlParameter("@Religion_DinID", religion_DinID)
		};
		return (SqlDBHelper.ExecuteScalar("Religion_Din_Exists", CommandType.StoredProcedure, parametersReligion_Din)>0);
	}

	public bool Exists(Religion_Din religion_Din)
	{
		SqlParameter[] parametersReligion_Din = new SqlParameter[]
		{
			new SqlParameter("@Religion_DinID", religion_Din.Religion_DinID)
		};
		return (SqlDBHelper.ExecuteScalar("Religion_Din_Exists", CommandType.StoredProcedure, parametersReligion_Din)>0);
	}

	public List<Religion_Din> SearchLike(Religion_Din religion_Din)
	{
		List<Religion_Din> listReligion_Din = new List<Religion_Din>();


		SqlParameter[] parametersReligion_Din = new SqlParameter[]
		{
			new SqlParameter("@Religion_DinID", religion_Din.Religion_DinID),
			new SqlParameter("@Title", religion_Din.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Religion_Din_SearchLike", CommandType.StoredProcedure, parametersReligion_Din))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Religion_Din tmpReligion_Din = new Religion_Din();
					tmpReligion_Din.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
					tmpReligion_Din.Title = row["Title"].ToString();

					listReligion_Din.Add(tmpReligion_Din);
				}
			}
		}

		return listReligion_Din;
	}

}
}
