using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class BankDepositProfitHandler
{
	// Handle to the BankDepositProfit DBAccess class
	BankDepositProfitDBAccess bankDepositProfitDb = null;

	public BankDepositProfitHandler()
	{
		bankDepositProfitDb = new BankDepositProfitDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankDepositProfits, we can put some logic here if needed 
	public List<BankDepositProfit> GetListAll()
	{
		return bankDepositProfitDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankDepositProfits, we can put some logic here if needed 
	public bool Update(BankDepositProfit bankDepositProfit)
	{
		return bankDepositProfitDb.Update(bankDepositProfit);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankDepositProfits, we can put some logic here if needed 
	public BankDepositProfit GetDetails(Int64 heritageID)
	{
		return bankDepositProfitDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankDepositProfits, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return bankDepositProfitDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankDepositProfits, we can put some logic here if needed 
	public Int64 Insert(BankDepositProfit bankDepositProfit)
	{
		return bankDepositProfitDb.Insert(bankDepositProfit);
	}

	public bool Exists(BankDepositProfit bankDepositProfit)
	{
		return bankDepositProfitDb.Exists(bankDepositProfit);
	}

	public bool Exists(Int64 heritageID)
	{
		return bankDepositProfitDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankDepositProfits, we can put some logic here if needed 
	public List<BankDepositProfit> SearchLike(BankDepositProfit bankDepositProfit)
	{
		return bankDepositProfitDb.SearchLike(bankDepositProfit);
	}

}
}
