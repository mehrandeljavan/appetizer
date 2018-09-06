using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class CompanyTypeHandler
{
	// Handle to the CompanyType DBAccess class
	CompanyTypeDBAccess companyTypeDb = null;

	public CompanyTypeHandler()
	{
		companyTypeDb = new CompanyTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of companyTypes, we can put some logic here if needed 
	public List<CompanyType> GetListAll()
	{
		return companyTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of companyTypes, we can put some logic here if needed 
	public bool Update(CompanyType companyType)
	{
		return companyTypeDb.Update(companyType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of companyTypes, we can put some logic here if needed 
	public CompanyType GetDetails(Int64 companyTypeID)
	{
		return companyTypeDb.GetDetails(companyTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of companyTypes, we can put some logic here if needed 
	public bool Delete(Int64 companyTypeID)
	{
		return companyTypeDb.Delete(companyTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of companyTypes, we can put some logic here if needed 
	public Int64 Insert(CompanyType companyType)
	{
		return companyTypeDb.Insert(companyType);
	}

	public bool Exists(CompanyType companyType)
	{
		return companyTypeDb.Exists(companyType);
	}

	public bool Exists(Int64 companyTypeID)
	{
		return companyTypeDb.Exists(companyTypeID);
	}

	public List<StockInOtherCompanies> GetListStockInOtherCompanies(Int64 companyTypeID)
	{
		return companyTypeDb.GetListStockInOtherCompanies(companyTypeID);
	}

	public List<StockProfit> GetListStockProfit(Int64 companyTypeID)
	{
		return companyTypeDb.GetListStockProfit(companyTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of companyTypes, we can put some logic here if needed 
	public List<CompanyType> SearchLike(CompanyType companyType)
	{
		return companyTypeDb.SearchLike(companyType);
	}

}
}
