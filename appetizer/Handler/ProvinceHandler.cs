using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class ProvinceHandler
{
	// Handle to the Province DBAccess class
	ProvinceDBAccess provinceDb = null;

	public ProvinceHandler()
	{
		provinceDb = new ProvinceDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of provinces, we can put some logic here if needed 
	public List<Province> GetListAll()
	{
		return provinceDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of provinces, we can put some logic here if needed 
	public bool Update(Province province)
	{
		return provinceDb.Update(province);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of provinces, we can put some logic here if needed 
	public Province GetDetails(int provinceID)
	{
		return provinceDb.GetDetails(provinceID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of provinces, we can put some logic here if needed 
	public bool Delete(int provinceID)
	{
		return provinceDb.Delete(provinceID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of provinces, we can put some logic here if needed 
	public Int64 Insert(Province province)
	{
		return provinceDb.Insert(province);
	}

	public bool Exists(Province province)
	{
		return provinceDb.Exists(province);
	}

	public bool Exists(int provinceID)
	{
		return provinceDb.Exists(provinceID);
	}

	public List<City> GetListCity(int provinceID)
	{
		return provinceDb.GetListCity(provinceID);
	}

	public List<Dead> GetListDead(int provinceID)
	{
		return provinceDb.GetListDead(provinceID);
	}

	public List<Person> GetListPerson(int provinceID)
	{
		return provinceDb.GetListPerson(provinceID);
	}

	public List<TaxOffice> GetListTaxOffice(int provinceID)
	{
		return provinceDb.GetListTaxOffice(provinceID);
	}

	public List<User> GetListUser(int provinceID)
	{
		return provinceDb.GetListUser(provinceID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of provinces, we can put some logic here if needed 
	public List<Province> SearchLike(Province province)
	{
		return provinceDb.SearchLike(province);
	}

}
}
