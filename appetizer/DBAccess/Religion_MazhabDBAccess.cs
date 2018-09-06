using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class Religion_MazhabDBAccess
{

	PersonDBAccess personDBAccess = new PersonDBAccess();

	public List<Person> GetListPerson(int religion_MazhabID)
	{
		List<Person> listPerson = new List<Person>() { };
		SqlParameter[] parametersReligion_Mazhab = new SqlParameter[]
		{
			new SqlParameter("@Religion_MazhabID", religion_MazhabID)
		};

		//Lets get the list of Person records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Person_GetList_UseInReligion_Mazhab", CommandType.StoredProcedure, parametersReligion_Mazhab))
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
	public Int64 Insert(Religion_Mazhab religion_Mazhab)
	{
		SqlParameter[] parametersReligion_Mazhab = new SqlParameter[]
		{
			new SqlParameter("@Religion_MazhabID", religion_Mazhab.Religion_MazhabID),
			new SqlParameter("@Title", (religion_Mazhab.Title != null) ? religion_Mazhab.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Religion_Mazhab_Insert", CommandType.StoredProcedure, parametersReligion_Mazhab);
	}

	public bool Update(Religion_Mazhab religion_Mazhab)
	{
		SqlParameter[] parametersReligion_Mazhab = new SqlParameter[]
		{
			new SqlParameter("@Religion_MazhabID", religion_Mazhab.Religion_MazhabID),
			new SqlParameter("@Title", (religion_Mazhab.Title != null) ? religion_Mazhab.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Religion_Mazhab_Update", CommandType.StoredProcedure, parametersReligion_Mazhab);
	}

	public bool Delete(int religion_MazhabID)
	{
		SqlParameter[] parametersReligion_Mazhab = new SqlParameter[]
		{
			new SqlParameter("@Religion_MazhabID", religion_MazhabID)
		};
		return SqlDBHelper.ExecuteNonQuery("Religion_Mazhab_Delete", CommandType.StoredProcedure, parametersReligion_Mazhab);
	}

	public Religion_Mazhab GetDetails(int religion_MazhabID)
	{
		Religion_Mazhab religion_Mazhab = new Religion_Mazhab();

		SqlParameter[] parametersReligion_Mazhab = new SqlParameter[]
		{
			new SqlParameter("@Religion_MazhabID", religion_MazhabID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Religion_Mazhab_GetDetails", CommandType.StoredProcedure, parametersReligion_Mazhab))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				religion_Mazhab.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
				religion_Mazhab.Title = row["Title"].ToString();
			}
		}

		return religion_Mazhab;
	}

	public List<Religion_Mazhab> GetListAll()
	{
		List<Religion_Mazhab> listReligion_Mazhab = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Religion_Mazhab_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listReligion_Mazhab = new List<Religion_Mazhab>();

				foreach (DataRow row in table.Rows)
				{
					Religion_Mazhab religion_Mazhab = new Religion_Mazhab();
					religion_Mazhab.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
					religion_Mazhab.Title = row["Title"].ToString();
					listReligion_Mazhab.Add(religion_Mazhab);
				}
			}
		}

		return listReligion_Mazhab;
	}

	public bool Exists(int religion_MazhabID)
	{
		SqlParameter[] parametersReligion_Mazhab = new SqlParameter[]
		{
			new SqlParameter("@Religion_MazhabID", religion_MazhabID)
		};
		return (SqlDBHelper.ExecuteScalar("Religion_Mazhab_Exists", CommandType.StoredProcedure, parametersReligion_Mazhab)>0);
	}

	public bool Exists(Religion_Mazhab religion_Mazhab)
	{
		SqlParameter[] parametersReligion_Mazhab = new SqlParameter[]
		{
			new SqlParameter("@Religion_MazhabID", religion_Mazhab.Religion_MazhabID)
		};
		return (SqlDBHelper.ExecuteScalar("Religion_Mazhab_Exists", CommandType.StoredProcedure, parametersReligion_Mazhab)>0);
	}

	public List<Religion_Mazhab> SearchLike(Religion_Mazhab religion_Mazhab)
	{
		List<Religion_Mazhab> listReligion_Mazhab = new List<Religion_Mazhab>();


		SqlParameter[] parametersReligion_Mazhab = new SqlParameter[]
		{
			new SqlParameter("@Religion_MazhabID", religion_Mazhab.Religion_MazhabID),
			new SqlParameter("@Title", religion_Mazhab.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Religion_Mazhab_SearchLike", CommandType.StoredProcedure, parametersReligion_Mazhab))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Religion_Mazhab tmpReligion_Mazhab = new Religion_Mazhab();
					tmpReligion_Mazhab.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
					tmpReligion_Mazhab.Title = row["Title"].ToString();

					listReligion_Mazhab.Add(tmpReligion_Mazhab);
				}
			}
		}

		return listReligion_Mazhab;
	}

}
}
