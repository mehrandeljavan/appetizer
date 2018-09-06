using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class CityHandler
{
	// Handle to the City DBAccess class
	CityDBAccess cityDb = null;

	public CityHandler()
	{
		cityDb = new CityDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of citys, we can put some logic here if needed 
	public List<City> GetListAll()
	{
		return cityDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of citys, we can put some logic here if needed 
	public bool Update(City city)
	{
		return cityDb.Update(city);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of citys, we can put some logic here if needed 
	public City GetDetails(int cityID)
	{
		return cityDb.GetDetails(cityID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of citys, we can put some logic here if needed 
	public bool Delete(int cityID)
	{
		return cityDb.Delete(cityID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of citys, we can put some logic here if needed 
	public Int64 Insert(City city)
	{
		return cityDb.Insert(city);
	}

	public bool Exists(City city)
	{
		return cityDb.Exists(city);
	}

	public bool Exists(int cityID)
	{
		return cityDb.Exists(cityID);
	}

	public List<Dead> GetListDead(int cityID)
	{
		return cityDb.GetListDead(cityID);
	}

	public List<Person> GetListPerson(int cityID)
	{
		return cityDb.GetListPerson(cityID);
	}

	public List<TaxOffice> GetListTaxOffice(int cityID)
	{
		return cityDb.GetListTaxOffice(cityID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of citys, we can put some logic here if needed 
	public List<City> SearchLike(City city)
	{
		return cityDb.SearchLike(city);
	}

}
}
