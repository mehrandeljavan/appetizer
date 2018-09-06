using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FinancialRightsHandler
{
	// Handle to the FinancialRights DBAccess class
	FinancialRightsDBAccess financialRightsDb = null;

	public FinancialRightsHandler()
	{
		financialRightsDb = new FinancialRightsDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of financialRightss, we can put some logic here if needed 
	public List<FinancialRights> GetListAll()
	{
		return financialRightsDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of financialRightss, we can put some logic here if needed 
	public bool Update(FinancialRights financialRights)
	{
		return financialRightsDb.Update(financialRights);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of financialRightss, we can put some logic here if needed 
	public FinancialRights GetDetails(Int64 heritageID)
	{
		return financialRightsDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of financialRightss, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return financialRightsDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of financialRightss, we can put some logic here if needed 
	public Int64 Insert(FinancialRights financialRights)
	{
		return financialRightsDb.Insert(financialRights);
	}

	public bool Exists(FinancialRights financialRights)
	{
		return financialRightsDb.Exists(financialRights);
	}

	public bool Exists(Int64 heritageID)
	{
		return financialRightsDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of financialRightss, we can put some logic here if needed 
	public List<FinancialRights> SearchLike(FinancialRights financialRights)
	{
		return financialRightsDb.SearchLike(financialRights);
	}

}
}
