using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class CityDBAccess
{

	DeadDBAccess deadDBAccess = new DeadDBAccess();
	PersonDBAccess personDBAccess = new PersonDBAccess();
	TaxOfficeDBAccess taxOfficeDBAccess = new TaxOfficeDBAccess();

	public List<Dead> GetListDead(int cityID)
	{
		List<Dead> listDead = new List<Dead>() { };
		SqlParameter[] parametersCity = new SqlParameter[]
		{
			new SqlParameter("@DeathCityID", cityID)
		};

		//Lets get the list of Dead records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dead_GetList_UseInCity", CommandType.StoredProcedure, parametersCity))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of dead
				listDead = new List<Dead>();

				//Now lets populate the Dead details into the list of deads
				foreach (DataRow row in table.Rows)
				{
					Dead dead = ConvertRowToDead(row);
					listDead.Add(dead);
				}
			}
		}

		return listDead;
	}

	private Dead ConvertRowToDead(DataRow row)
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

		dead.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		dead.PrintNationalCode = row["PrintNationalCode"].ToString();
		dead.FullName = row["FullName"].ToString();
		dead.GenderIDTitle = row["GenderIDTitle"].ToString();
		dead.Religion_DinIDTitle = row["Religion_DinIDTitle"].ToString();
		dead.Religion_MazhabIDTitle = row["Religion_MazhabIDTitle"].ToString();
		dead.IssuanceProvinceIDTitle = row["IssuanceProvinceIDTitle"].ToString();
		dead.IssuanceCityIDTitle = row["IssuanceCityIDTitle"].ToString();
		dead.IssuanceDepartment = row["IssuanceDepartment"].ToString();
		dead.CertificateNumber = row["CertificateNumber"].ToString();
		dead.CertificateSerial = row["CertificateSerial"].ToString();
		dead.ZipCode = row["ZipCode"].ToString();
		dead.HomeAddress = row["HomeAddress"].ToString();
		dead.PhoneNumber = row["PhoneNumber"].ToString();
		dead.Job = row["Job"].ToString();
		dead.JobAddress = row["JobAddress"].ToString();
		dead.JobPhoneNumber = row["JobPhoneNumber"].ToString();
		dead.Comment = row["Comment"].ToString();
		dead.BirthCity = row["BirthCity"].ToString();
		dead.JobZipCode = row["JobZipCode"].ToString();
		dead.CertificateSerialLetter = row["CertificateSerialLetter"].ToString();
		dead.CertificateSerialNumber = row["CertificateSerialNumber"].ToString();
		dead.FatherName = row["FatherName"].ToString();
		dead.Name = row["Name"].ToString();
		dead.Family = row["Family"].ToString();
		dead.BirthDate = row["BirthDate"].ToString();
		dead.IssuanceDate = row["IssuanceDate"].ToString();
		dead.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
		dead.IssuanceProvinceID = (row["IssuanceProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceProvinceID"]) : 0 ;
		dead.IssuanceCityID = (row["IssuanceCityID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceCityID"]) : 0 ;
		dead.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
		dead.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
		return dead;
	}
	public List<Person> GetListPerson(int cityID)
	{
		List<Person> listPerson = new List<Person>() { };
		SqlParameter[] parametersCity = new SqlParameter[]
		{
			new SqlParameter("@IssuanceCityID", cityID)
		};

		//Lets get the list of Person records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Person_GetList_UseInCity", CommandType.StoredProcedure, parametersCity))
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
	public List<TaxOffice> GetListTaxOffice(int cityID)
	{
		List<TaxOffice> listTaxOffice = new List<TaxOffice>() { };
		SqlParameter[] parametersCity = new SqlParameter[]
		{
			new SqlParameter("@CityID", cityID)
		};

		//Lets get the list of TaxOffice records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TaxOffice_GetList_UseInCity", CommandType.StoredProcedure, parametersCity))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of taxOffice
				listTaxOffice = new List<TaxOffice>();

				//Now lets populate the TaxOffice details into the list of taxOffices
				foreach (DataRow row in table.Rows)
				{
					TaxOffice taxOffice = ConvertRowToTaxOffice(row);
					listTaxOffice.Add(taxOffice);
				}
			}
		}

		return listTaxOffice;
	}

	private TaxOffice ConvertRowToTaxOffice(DataRow row)
	{
		TaxOffice taxOffice = new TaxOffice();
		taxOffice.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
		taxOffice.Title = row["Title"].ToString();
		taxOffice.CityIDTitle = row["CityIDTitle"].ToString();
		taxOffice.TaxOfficeDossierAssignMethodIDTitle = row["TaxOfficeDossierAssignMethodIDTitle"].ToString();
		taxOffice.ProvinceIDTitle = row["ProvinceIDTitle"].ToString();
		taxOffice.ParentTaxOfficeTitle = row["ParentTaxOfficeTitle"].ToString();
		taxOffice.PrivateTitle = row["PrivateTitle"].ToString();
		taxOffice.Address = row["Address"].ToString();
		taxOffice.Comment = row["Comment"].ToString();
		taxOffice.Fax = row["Fax"].ToString();
		taxOffice.Website = row["Website"].ToString();
		taxOffice.Email = row["Email"].ToString();
		taxOffice.CityID = (row["CityID"] != DBNull.Value) ? Convert.ToInt32(row["CityID"]) : 0 ;
		taxOffice.ParentTaxOfficeCode = (row["ParentTaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["ParentTaxOfficeCode"]) : 0 ;
		taxOffice.TaxOfficeDossierAssignMethodID = (row["TaxOfficeDossierAssignMethodID"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeDossierAssignMethodID"]) : 0 ;
		taxOffice.ProvinceID = (row["ProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["ProvinceID"]) : 0 ;
		taxOffice.MainOfficeID = (row["MainOfficeID"] != DBNull.Value) ? Convert.ToInt32(row["MainOfficeID"]) : 0 ;
		taxOffice.BossNationalCode = (row["BossNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["BossNationalCode"]) : 0 ;
		taxOffice.ZipCode = row["ZipCode"].ToString();
		taxOffice.PhoneNumber = row["PhoneNumber"].ToString();
		return taxOffice;
	}
	public Int64 Insert(City city)
	{
		SqlParameter[] parametersCity = new SqlParameter[]
		{
			new SqlParameter("@CityID", city.CityID),
			new SqlParameter("@ProvinceID", (city.ProvinceID > 0) ? city.ProvinceID : (object)DBNull.Value),
			new SqlParameter("@Title", city.Title)
		};
		return SqlDBHelper.ExecuteScalar("City_Insert", CommandType.StoredProcedure, parametersCity);
	}

	public bool Update(City city)
	{
		SqlParameter[] parametersCity = new SqlParameter[]
		{
			new SqlParameter("@CityID", city.CityID),
			new SqlParameter("@ProvinceID", city.ProvinceID),
			new SqlParameter("@Title", city.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("City_Update", CommandType.StoredProcedure, parametersCity);
	}

	public bool Delete(int cityID)
	{
		SqlParameter[] parametersCity = new SqlParameter[]
		{
			new SqlParameter("@CityID", cityID)
		};
		return SqlDBHelper.ExecuteNonQuery("City_Delete", CommandType.StoredProcedure, parametersCity);
	}

	public City GetDetails(int cityID)
	{
		City city = new City();

		SqlParameter[] parametersCity = new SqlParameter[]
		{
			new SqlParameter("@CityID", cityID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("City_GetDetails", CommandType.StoredProcedure, parametersCity))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				city.CityID = (row["CityID"] != DBNull.Value) ? Convert.ToInt32(row["CityID"]) : 0 ;
				city.ProvinceIDTitle = row["ProvinceIDTitle"].ToString();
				city.ProvinceID = (row["ProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["ProvinceID"]) : 0 ;
				city.Title = row["Title"].ToString();
			}
		}

		return city;
	}

	public List<City> GetListAll()
	{
		List<City> listCity = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("City_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listCity = new List<City>();

				foreach (DataRow row in table.Rows)
				{
					City city = new City();
					city.CityID = (row["CityID"] != DBNull.Value) ? Convert.ToInt32(row["CityID"]) : 0 ;
					city.ProvinceIDTitle = row["ProvinceIDTitle"].ToString();
					city.ProvinceID = (row["ProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["ProvinceID"]) : 0 ;
					city.Title = row["Title"].ToString();
					listCity.Add(city);
				}
			}
		}

		return listCity;
	}

	public bool Exists(int cityID)
	{
		SqlParameter[] parametersCity = new SqlParameter[]
		{
			new SqlParameter("@CityID", cityID)
		};
		return (SqlDBHelper.ExecuteScalar("City_Exists", CommandType.StoredProcedure, parametersCity)>0);
	}

	public bool Exists(City city)
	{
		SqlParameter[] parametersCity = new SqlParameter[]
		{
			new SqlParameter("@CityID", city.CityID)
		};
		return (SqlDBHelper.ExecuteScalar("City_Exists", CommandType.StoredProcedure, parametersCity)>0);
	}

	public List<City> SearchLike(City city)
	{
		List<City> listCity = new List<City>();


		SqlParameter[] parametersCity = new SqlParameter[]
		{
			new SqlParameter("@CityID", city.CityID),
			new SqlParameter("@ProvinceIDTitle", city.ProvinceIDTitle),
			new SqlParameter("@ProvinceID", city.ProvinceID),
			new SqlParameter("@Title", city.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("City_SearchLike", CommandType.StoredProcedure, parametersCity))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					City tmpCity = new City();
					tmpCity.CityID = (row["CityID"] != DBNull.Value) ? Convert.ToInt32(row["CityID"]) : 0 ;
					tmpCity.ProvinceIDTitle = row["ProvinceIDTitle"].ToString();
					tmpCity.ProvinceID = (row["ProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["ProvinceID"]) : 0 ;
					tmpCity.Title = row["Title"].ToString();

					listCity.Add(tmpCity);
				}
			}
		}

		return listCity;
	}

}
}
