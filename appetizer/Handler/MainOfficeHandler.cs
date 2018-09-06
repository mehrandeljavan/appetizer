using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class MainOfficeHandler
{
	// Handle to the MainOffice DBAccess class
	MainOfficeDBAccess mainOfficeDb = null;

	public MainOfficeHandler()
	{
		mainOfficeDb = new MainOfficeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of mainOffices, we can put some logic here if needed 
	public List<MainOffice> GetListAll()
	{
		return mainOfficeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of mainOffices, we can put some logic here if needed 
	public bool Update(MainOffice mainOffice)
	{
		return mainOfficeDb.Update(mainOffice);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of mainOffices, we can put some logic here if needed 
	public MainOffice GetDetails(int mainOfficeID)
	{
		return mainOfficeDb.GetDetails(mainOfficeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of mainOffices, we can put some logic here if needed 
	public bool Delete(int mainOfficeID)
	{
		return mainOfficeDb.Delete(mainOfficeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of mainOffices, we can put some logic here if needed 
	public Int64 Insert(MainOffice mainOffice)
	{
		return mainOfficeDb.Insert(mainOffice);
	}

	public bool Exists(MainOffice mainOffice)
	{
		return mainOfficeDb.Exists(mainOffice);
	}

	public bool Exists(int mainOfficeID)
	{
		return mainOfficeDb.Exists(mainOfficeID);
	}

	public List<TaxOffice> GetListTaxOffice(int mainOfficeID)
	{
		return mainOfficeDb.GetListTaxOffice(mainOfficeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of mainOffices, we can put some logic here if needed 
	public List<MainOffice> SearchLike(MainOffice mainOffice)
	{
		return mainOfficeDb.SearchLike(mainOffice);
	}

}
}
