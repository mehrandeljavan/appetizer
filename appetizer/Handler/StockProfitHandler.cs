using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class StockProfitHandler
{
	// Handle to the StockProfit DBAccess class
	StockProfitDBAccess stockProfitDb = null;

	public StockProfitHandler()
	{
		stockProfitDb = new StockProfitDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of stockProfits, we can put some logic here if needed 
	public List<StockProfit> GetListAll()
	{
		return stockProfitDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of stockProfits, we can put some logic here if needed 
	public bool Update(StockProfit stockProfit)
	{
		return stockProfitDb.Update(stockProfit);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of stockProfits, we can put some logic here if needed 
	public StockProfit GetDetails(Int64 heritageID)
	{
		return stockProfitDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of stockProfits, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return stockProfitDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of stockProfits, we can put some logic here if needed 
	public Int64 Insert(StockProfit stockProfit)
	{
		return stockProfitDb.Insert(stockProfit);
	}

	public bool Exists(StockProfit stockProfit)
	{
		return stockProfitDb.Exists(stockProfit);
	}

	public bool Exists(Int64 heritageID)
	{
		return stockProfitDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of stockProfits, we can put some logic here if needed 
	public List<StockProfit> SearchLike(StockProfit stockProfit)
	{
		return stockProfitDb.SearchLike(stockProfit);
	}

}
}
