using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class StockInOtherCompaniesHandler
{
	// Handle to the StockInOtherCompanies DBAccess class
	StockInOtherCompaniesDBAccess stockInOtherCompaniesDb = null;

	public StockInOtherCompaniesHandler()
	{
		stockInOtherCompaniesDb = new StockInOtherCompaniesDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of stockInOtherCompaniess, we can put some logic here if needed 
	public List<StockInOtherCompanies> GetListAll()
	{
		return stockInOtherCompaniesDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of stockInOtherCompaniess, we can put some logic here if needed 
	public bool Update(StockInOtherCompanies stockInOtherCompanies)
	{
		return stockInOtherCompaniesDb.Update(stockInOtherCompanies);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of stockInOtherCompaniess, we can put some logic here if needed 
	public StockInOtherCompanies GetDetails(Int64 heritageID)
	{
		return stockInOtherCompaniesDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of stockInOtherCompaniess, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return stockInOtherCompaniesDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of stockInOtherCompaniess, we can put some logic here if needed 
	public Int64 Insert(StockInOtherCompanies stockInOtherCompanies)
	{
		return stockInOtherCompaniesDb.Insert(stockInOtherCompanies);
	}

	public bool Exists(StockInOtherCompanies stockInOtherCompanies)
	{
		return stockInOtherCompaniesDb.Exists(stockInOtherCompanies);
	}

	public bool Exists(Int64 heritageID)
	{
		return stockInOtherCompaniesDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of stockInOtherCompaniess, we can put some logic here if needed 
	public List<StockInOtherCompanies> SearchLike(StockInOtherCompanies stockInOtherCompanies)
	{
		return stockInOtherCompaniesDb.SearchLike(stockInOtherCompanies);
	}

}
}
