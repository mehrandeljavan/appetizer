using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class BankDepositHandler
{
	// Handle to the BankDeposit DBAccess class
	BankDepositDBAccess bankDepositDb = null;

	public BankDepositHandler()
	{
		bankDepositDb = new BankDepositDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankDeposits, we can put some logic here if needed 
	public List<BankDeposit> GetListAll()
	{
		return bankDepositDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankDeposits, we can put some logic here if needed 
	public bool Update(BankDeposit bankDeposit)
	{
		return bankDepositDb.Update(bankDeposit);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankDeposits, we can put some logic here if needed 
	public BankDeposit GetDetails(Int64 heritageID)
	{
		return bankDepositDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankDeposits, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return bankDepositDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankDeposits, we can put some logic here if needed 
	public Int64 Insert(BankDeposit bankDeposit)
	{
		return bankDepositDb.Insert(bankDeposit);
	}

	public bool Exists(BankDeposit bankDeposit)
	{
		return bankDepositDb.Exists(bankDeposit);
	}

	public bool Exists(Int64 heritageID)
	{
		return bankDepositDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankDeposits, we can put some logic here if needed 
	public List<BankDeposit> SearchLike(BankDeposit bankDeposit)
	{
		return bankDepositDb.SearchLike(bankDeposit);
	}

}
}
