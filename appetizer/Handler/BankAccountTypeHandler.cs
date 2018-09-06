using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class BankAccountTypeHandler
{
	// Handle to the BankAccountType DBAccess class
	BankAccountTypeDBAccess bankAccountTypeDb = null;

	public BankAccountTypeHandler()
	{
		bankAccountTypeDb = new BankAccountTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankAccountTypes, we can put some logic here if needed 
	public List<BankAccountType> GetListAll()
	{
		return bankAccountTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankAccountTypes, we can put some logic here if needed 
	public bool Update(BankAccountType bankAccountType)
	{
		return bankAccountTypeDb.Update(bankAccountType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankAccountTypes, we can put some logic here if needed 
	public BankAccountType GetDetails(int bankAccountTypeID)
	{
		return bankAccountTypeDb.GetDetails(bankAccountTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankAccountTypes, we can put some logic here if needed 
	public bool Delete(int bankAccountTypeID)
	{
		return bankAccountTypeDb.Delete(bankAccountTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankAccountTypes, we can put some logic here if needed 
	public Int64 Insert(BankAccountType bankAccountType)
	{
		return bankAccountTypeDb.Insert(bankAccountType);
	}

	public bool Exists(BankAccountType bankAccountType)
	{
		return bankAccountTypeDb.Exists(bankAccountType);
	}

	public bool Exists(int bankAccountTypeID)
	{
		return bankAccountTypeDb.Exists(bankAccountTypeID);
	}

	public List<BankDeposit> GetListBankDeposit(int bankAccountTypeID)
	{
		return bankAccountTypeDb.GetListBankDeposit(bankAccountTypeID);
	}

	public List<BankDepositProfit> GetListBankDepositProfit(int bankAccountTypeID)
	{
		return bankAccountTypeDb.GetListBankDepositProfit(bankAccountTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankAccountTypes, we can put some logic here if needed 
	public List<BankAccountType> SearchLike(BankAccountType bankAccountType)
	{
		return bankAccountTypeDb.SearchLike(bankAccountType);
	}

}
}
