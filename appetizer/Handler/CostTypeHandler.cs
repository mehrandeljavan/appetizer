using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class CostTypeHandler
{
	// Handle to the CostType DBAccess class
	CostTypeDBAccess costTypeDb = null;

	public CostTypeHandler()
	{
		costTypeDb = new CostTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of costTypes, we can put some logic here if needed 
	public List<CostType> GetListAll()
	{
		return costTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of costTypes, we can put some logic here if needed 
	public bool Update(CostType costType)
	{
		return costTypeDb.Update(costType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of costTypes, we can put some logic here if needed 
	public CostType GetDetails(int costTypeID)
	{
		return costTypeDb.GetDetails(costTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of costTypes, we can put some logic here if needed 
	public bool Delete(int costTypeID)
	{
		return costTypeDb.Delete(costTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of costTypes, we can put some logic here if needed 
	public Int64 Insert(CostType costType)
	{
		return costTypeDb.Insert(costType);
	}

	public bool Exists(CostType costType)
	{
		return costTypeDb.Exists(costType);
	}

	public bool Exists(int costTypeID)
	{
		return costTypeDb.Exists(costTypeID);
	}

	public List<Cost> GetListCost(int costTypeID)
	{
		return costTypeDb.GetListCost(costTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of costTypes, we can put some logic here if needed 
	public List<CostType> SearchLike(CostType costType)
	{
		return costTypeDb.SearchLike(costType);
	}

}
}
