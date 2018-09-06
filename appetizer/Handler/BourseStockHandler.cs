using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class BourseStockHandler
{
	// Handle to the BourseStock DBAccess class
	BourseStockDBAccess bourseStockDb = null;

	public BourseStockHandler()
	{
		bourseStockDb = new BourseStockDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bourseStocks, we can put some logic here if needed 
	public List<BourseStock> GetListAll()
	{
		return bourseStockDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bourseStocks, we can put some logic here if needed 
	public bool Update(BourseStock bourseStock)
	{
		return bourseStockDb.Update(bourseStock);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bourseStocks, we can put some logic here if needed 
	public BourseStock GetDetails(Int64 heritageID)
	{
		return bourseStockDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bourseStocks, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return bourseStockDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bourseStocks, we can put some logic here if needed 
	public Int64 Insert(BourseStock bourseStock)
	{
		return bourseStockDb.Insert(bourseStock);
	}

	public bool Exists(BourseStock bourseStock)
	{
		return bourseStockDb.Exists(bourseStock);
	}

	public bool Exists(Int64 heritageID)
	{
		return bourseStockDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bourseStocks, we can put some logic here if needed 
	public List<BourseStock> SearchLike(BourseStock bourseStock)
	{
		return bourseStockDb.SearchLike(bourseStock);
	}

}
}
