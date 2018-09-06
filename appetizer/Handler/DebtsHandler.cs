using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class DebtsHandler
{
	// Handle to the Debts DBAccess class
	DebtsDBAccess debtsDb = null;

	public DebtsHandler()
	{
		debtsDb = new DebtsDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of debtss, we can put some logic here if needed 
	public List<Debts> GetListAll()
	{
		return debtsDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of debtss, we can put some logic here if needed 
	public bool Update(Debts debts)
	{
		return debtsDb.Update(debts);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of debtss, we can put some logic here if needed 
	public Debts GetDetails(Int64 heritageID)
	{
		return debtsDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of debtss, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return debtsDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of debtss, we can put some logic here if needed 
	public Int64 Insert(Debts debts)
	{
		return debtsDb.Insert(debts);
	}

	public bool Exists(Debts debts)
	{
		return debtsDb.Exists(debts);
	}

	public bool Exists(Int64 heritageID)
	{
		return debtsDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of debtss, we can put some logic here if needed 
	public List<Debts> SearchLike(Debts debts)
	{
		return debtsDb.SearchLike(debts);
	}

}
}
