using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class BankTypeHandler
{
	// Handle to the BankType DBAccess class
	BankTypeDBAccess bankTypeDb = null;

	public BankTypeHandler()
	{
		bankTypeDb = new BankTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankTypes, we can put some logic here if needed 
	public List<BankType> GetListAll()
	{
		return bankTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankTypes, we can put some logic here if needed 
	public bool Update(BankType bankType)
	{
		return bankTypeDb.Update(bankType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankTypes, we can put some logic here if needed 
	public BankType GetDetails(Int64 bankTypeID)
	{
		return bankTypeDb.GetDetails(bankTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankTypes, we can put some logic here if needed 
	public bool Delete(Int64 bankTypeID)
	{
		return bankTypeDb.Delete(bankTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankTypes, we can put some logic here if needed 
	public Int64 Insert(BankType bankType)
	{
		return bankTypeDb.Insert(bankType);
	}

	public bool Exists(BankType bankType)
	{
		return bankTypeDb.Exists(bankType);
	}

	public bool Exists(Int64 bankTypeID)
	{
		return bankTypeDb.Exists(bankTypeID);
	}

	public List<BankCategory> GetListBankCategory(Int64 bankTypeID)
	{
		return bankTypeDb.GetListBankCategory(bankTypeID);
	}

	public List<BankDeposit> GetListBankDeposit(Int64 bankTypeID)
	{
		return bankTypeDb.GetListBankDeposit(bankTypeID);
	}

	public List<BankDepositProfit> GetListBankDepositProfit(Int64 bankTypeID)
	{
		return bankTypeDb.GetListBankDepositProfit(bankTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankTypes, we can put some logic here if needed 
	public List<BankType> SearchLike(BankType bankType)
	{
		return bankTypeDb.SearchLike(bankType);
	}

}
}
