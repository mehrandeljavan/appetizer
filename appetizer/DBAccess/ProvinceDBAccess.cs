using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class ProvinceDBAccess
{

	CityDBAccess cityDBAccess = new CityDBAccess();
	DeadDBAccess deadDBAccess = new DeadDBAccess();
	PersonDBAccess personDBAccess = new PersonDBAccess();
	TaxOfficeDBAccess taxOfficeDBAccess = new TaxOfficeDBAccess();
	UserDBAccess userDBAccess = new UserDBAccess();

	public List<City> GetListCity(int provinceID)
	{
		List<City> listCity = new List<City>() { };
		SqlParameter[] parametersProvince = new SqlParameter[]
		{
			new SqlParameter("@ProvinceID", provinceID)
		};

		//Lets get the list of City records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("City_GetList_UseInProvince", CommandType.StoredProcedure, parametersProvince))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of city
				listCity = new List<City>();

				//Now lets populate the City details into the list of citys
				foreach (DataRow row in table.Rows)
				{
					City city = ConvertRowToCity(row);
					listCity.Add(city);
				}
			}
		}

		return listCity;
	}

	private City ConvertRowToCity(DataRow row)
	{
		City city = new City();
		city.CityID = (row["CityID"] != DBNull.Value) ? Convert.ToInt32(row["CityID"]) : 0 ;
		city.ProvinceIDTitle = row["ProvinceIDTitle"].ToString();
		city.ProvinceID = (row["ProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["ProvinceID"]) : 0 ;
		city.Title = row["Title"].ToString();
		return city;
	}
	public List<Dead> GetListDead(int provinceID)
	{
		List<Dead> listDead = new List<Dead>() { };
		SqlParameter[] parametersProvince = new SqlParameter[]
		{
			new SqlParameter("@DeathProvinceID", provinceID)
		};

		//Lets get the list of Dead records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dead_GetList_UseInProvince", CommandType.StoredProcedure, parametersProvince))
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
	public List<Person> GetListPerson(int provinceID)
	{
		List<Person> listPerson = new List<Person>() { };
		SqlParameter[] parametersProvince = new SqlParameter[]
		{
			new SqlParameter("@IssuanceProvinceID", provinceID)
		};

		//Lets get the list of Person records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Person_GetList_UseInProvince", CommandType.StoredProcedure, parametersProvince))
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
	public List<TaxOffice> GetListTaxOffice(int provinceID)
	{
		List<TaxOffice> listTaxOffice = new List<TaxOffice>() { };
		SqlParameter[] parametersProvince = new SqlParameter[]
		{
			new SqlParameter("@ProvinceID", provinceID)
		};

		//Lets get the list of TaxOffice records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TaxOffice_GetList_UseInProvince", CommandType.StoredProcedure, parametersProvince))
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
	public List<User> GetListUser(int provinceID)
	{
		List<User> listUser = new List<User>() { };
		SqlParameter[] parametersProvince = new SqlParameter[]
		{
			new SqlParameter("@ProvinceIDDefault", provinceID)
		};

		//Lets get the list of User records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("User_GetList_UseInProvince", CommandType.StoredProcedure, parametersProvince))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of user
				listUser = new List<User>();

				//Now lets populate the User details into the list of users
				foreach (DataRow row in table.Rows)
				{
					User user = ConvertRowToUser(row);
					listUser.Add(user);
				}
			}
		}

		return listUser;
	}

	private User ConvertRowToUser(DataRow row)
	{
		User user = new User();
		user.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		user.UserFullName = row["UserFullName"].ToString();
		user.ProvinceIDDefaultTitle = row["ProvinceIDDefaultTitle"].ToString();
		user.Password = row["Password"].ToString();
		user.PersonalCode = row["PersonalCode"].ToString();
		user.StartDate = row["StartDate"].ToString();
		user.EndDate = row["EndDate"].ToString();
		user.Signature = (row["Signature"] != DBNull.Value) ? Convert.ToInt32(row["Signature"]) : 0 ;
		user.ProvinceIDDefault = (row["ProvinceIDDefault"] != DBNull.Value) ? Convert.ToInt32(row["ProvinceIDDefault"]) : 0 ;
		user.SignaturePrint = (row["SignaturePrint"] != DBNull.Value) ? Convert.ToBoolean((row["SignaturePrint"].ToString() == "1" || row["SignaturePrint"].ToString().ToLower() == "true" ) ? true : false) : false ;
		user.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;

		user.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		user.PrintNationalCode = row["PrintNationalCode"].ToString();
		user.FullName = row["FullName"].ToString();
		user.GenderIDTitle = row["GenderIDTitle"].ToString();
		user.Religion_DinIDTitle = row["Religion_DinIDTitle"].ToString();
		user.Religion_MazhabIDTitle = row["Religion_MazhabIDTitle"].ToString();
		user.IssuanceProvinceIDTitle = row["IssuanceProvinceIDTitle"].ToString();
		user.IssuanceCityIDTitle = row["IssuanceCityIDTitle"].ToString();
		user.IssuanceDepartment = row["IssuanceDepartment"].ToString();
		user.CertificateNumber = row["CertificateNumber"].ToString();
		user.CertificateSerial = row["CertificateSerial"].ToString();
		user.ZipCode = row["ZipCode"].ToString();
		user.HomeAddress = row["HomeAddress"].ToString();
		user.PhoneNumber = row["PhoneNumber"].ToString();
		user.Job = row["Job"].ToString();
		user.JobAddress = row["JobAddress"].ToString();
		user.JobPhoneNumber = row["JobPhoneNumber"].ToString();
		user.Comment = row["Comment"].ToString();
		user.BirthCity = row["BirthCity"].ToString();
		user.JobZipCode = row["JobZipCode"].ToString();
		user.CertificateSerialLetter = row["CertificateSerialLetter"].ToString();
		user.CertificateSerialNumber = row["CertificateSerialNumber"].ToString();
		user.FatherName = row["FatherName"].ToString();
		user.Name = row["Name"].ToString();
		user.Family = row["Family"].ToString();
		user.BirthDate = row["BirthDate"].ToString();
		user.IssuanceDate = row["IssuanceDate"].ToString();
		user.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
		user.IssuanceProvinceID = (row["IssuanceProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceProvinceID"]) : 0 ;
		user.IssuanceCityID = (row["IssuanceCityID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceCityID"]) : 0 ;
		user.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
		user.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
		return user;
	}
	public Int64 Insert(Province province)
	{
		SqlParameter[] parametersProvince = new SqlParameter[]
		{
			new SqlParameter("@ProvinceID", province.ProvinceID),
			new SqlParameter("@Title", province.Title)
		};
		return SqlDBHelper.ExecuteScalar("Province_Insert", CommandType.StoredProcedure, parametersProvince);
	}

	public bool Update(Province province)
	{
		SqlParameter[] parametersProvince = new SqlParameter[]
		{
			new SqlParameter("@ProvinceID", province.ProvinceID),
			new SqlParameter("@Title", province.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("Province_Update", CommandType.StoredProcedure, parametersProvince);
	}

	public bool Delete(int provinceID)
	{
		SqlParameter[] parametersProvince = new SqlParameter[]
		{
			new SqlParameter("@ProvinceID", provinceID)
		};
		return SqlDBHelper.ExecuteNonQuery("Province_Delete", CommandType.StoredProcedure, parametersProvince);
	}

	public Province GetDetails(int provinceID)
	{
		Province province = new Province();

		SqlParameter[] parametersProvince = new SqlParameter[]
		{
			new SqlParameter("@ProvinceID", provinceID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Province_GetDetails", CommandType.StoredProcedure, parametersProvince))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				province.ProvinceID = (row["ProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["ProvinceID"]) : 0 ;
				province.Title = row["Title"].ToString();
			}
		}

		return province;
	}

	public List<Province> GetListAll()
	{
		List<Province> listProvince = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Province_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listProvince = new List<Province>();

				foreach (DataRow row in table.Rows)
				{
					Province province = new Province();
					province.ProvinceID = (row["ProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["ProvinceID"]) : 0 ;
					province.Title = row["Title"].ToString();
					listProvince.Add(province);
				}
			}
		}

		return listProvince;
	}

	public bool Exists(int provinceID)
	{
		SqlParameter[] parametersProvince = new SqlParameter[]
		{
			new SqlParameter("@ProvinceID", provinceID)
		};
		return (SqlDBHelper.ExecuteScalar("Province_Exists", CommandType.StoredProcedure, parametersProvince)>0);
	}

	public bool Exists(Province province)
	{
		SqlParameter[] parametersProvince = new SqlParameter[]
		{
			new SqlParameter("@ProvinceID", province.ProvinceID)
		};
		return (SqlDBHelper.ExecuteScalar("Province_Exists", CommandType.StoredProcedure, parametersProvince)>0);
	}

	public List<Province> SearchLike(Province province)
	{
		List<Province> listProvince = new List<Province>();


		SqlParameter[] parametersProvince = new SqlParameter[]
		{
			new SqlParameter("@ProvinceID", province.ProvinceID),
			new SqlParameter("@Title", province.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Province_SearchLike", CommandType.StoredProcedure, parametersProvince))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Province tmpProvince = new Province();
					tmpProvince.ProvinceID = (row["ProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["ProvinceID"]) : 0 ;
					tmpProvince.Title = row["Title"].ToString();

					listProvince.Add(tmpProvince);
				}
			}
		}

		return listProvince;
	}

}
}
