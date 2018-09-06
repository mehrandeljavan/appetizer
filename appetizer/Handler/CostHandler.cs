using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class CostHandler
{
	// Handle to the Cost DBAccess class
	CostDBAccess costDb = null;

	public CostHandler()
	{
		costDb = new CostDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of costs, we can put some logic here if needed 
	public List<Cost> GetListAll()
	{
		return costDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of costs, we can put some logic here if needed 
	public bool Update(Cost cost)
	{
		return costDb.Update(cost);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of costs, we can put some logic here if needed 
	public Cost GetDetails(Int64 heritageID)
	{
		return costDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of costs, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return costDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of costs, we can put some logic here if needed 
	public Int64 Insert(Cost cost)
	{
		return costDb.Insert(cost);
	}

	public bool Exists(Cost cost)
	{
		return costDb.Exists(cost);
	}

	public bool Exists(Int64 heritageID)
	{
		return costDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of costs, we can put some logic here if needed 
	public List<Cost> SearchLike(Cost cost)
	{
		return costDb.SearchLike(cost);
	}

}
}
