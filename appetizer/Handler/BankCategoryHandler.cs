using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class BankCategoryHandler
{
	// Handle to the BankCategory DBAccess class
	BankCategoryDBAccess bankCategoryDb = null;

	public BankCategoryHandler()
	{
		bankCategoryDb = new BankCategoryDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankCategorys, we can put some logic here if needed 
	public List<BankCategory> GetListAll()
	{
		return bankCategoryDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankCategorys, we can put some logic here if needed 
	public bool Update(BankCategory bankCategory)
	{
		return bankCategoryDb.Update(bankCategory);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankCategorys, we can put some logic here if needed 
	public BankCategory GetDetails(Int64 bankCategoryID)
	{
		return bankCategoryDb.GetDetails(bankCategoryID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankCategorys, we can put some logic here if needed 
	public bool Delete(Int64 bankCategoryID)
	{
		return bankCategoryDb.Delete(bankCategoryID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankCategorys, we can put some logic here if needed 
	public Int64 Insert(BankCategory bankCategory)
	{
		return bankCategoryDb.Insert(bankCategory);
	}

	public bool Exists(BankCategory bankCategory)
	{
		return bankCategoryDb.Exists(bankCategory);
	}

	public bool Exists(Int64 bankCategoryID)
	{
		return bankCategoryDb.Exists(bankCategoryID);
	}

	public List<Bank> GetListBank(Int64 bankCategoryID)
	{
		return bankCategoryDb.GetListBank(bankCategoryID);
	}

	public List<BankDeposit> GetListBankDeposit(Int64 bankCategoryID)
	{
		return bankCategoryDb.GetListBankDeposit(bankCategoryID);
	}

	public List<BankDepositProfit> GetListBankDepositProfit(Int64 bankCategoryID)
	{
		return bankCategoryDb.GetListBankDepositProfit(bankCategoryID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankCategorys, we can put some logic here if needed 
	public List<BankCategory> SearchLike(BankCategory bankCategory)
	{
		return bankCategoryDb.SearchLike(bankCategory);
	}

}
}
