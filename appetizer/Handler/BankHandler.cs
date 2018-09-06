using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class BankHandler
{
	// Handle to the Bank DBAccess class
	BankDBAccess bankDb = null;

	public BankHandler()
	{
		bankDb = new BankDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of banks, we can put some logic here if needed 
	public List<Bank> GetListAll()
	{
		return bankDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of banks, we can put some logic here if needed 
	public bool Update(Bank bank)
	{
		return bankDb.Update(bank);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of banks, we can put some logic here if needed 
	public Bank GetDetails(Int64 bankID)
	{
		return bankDb.GetDetails(bankID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of banks, we can put some logic here if needed 
	public bool Delete(Int64 bankID)
	{
		return bankDb.Delete(bankID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of banks, we can put some logic here if needed 
	public Int64 Insert(Bank bank)
	{
		return bankDb.Insert(bank);
	}

	public bool Exists(Bank bank)
	{
		return bankDb.Exists(bank);
	}

	public bool Exists(Int64 bankID)
	{
		return bankDb.Exists(bankID);
	}

	public List<BankDeposit> GetListBankDeposit(Int64 bankID)
	{
		return bankDb.GetListBankDeposit(bankID);
	}

	public List<BankDepositProfit> GetListBankDepositProfit(Int64 bankID)
	{
		return bankDb.GetListBankDepositProfit(bankID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of banks, we can put some logic here if needed 
	public List<Bank> SearchLike(Bank bank)
	{
		return bankDb.SearchLike(bank);
	}

}
}
