using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class ReligiousDebtHandler
{
	// Handle to the ReligiousDebt DBAccess class
	ReligiousDebtDBAccess religiousDebtDb = null;

	public ReligiousDebtHandler()
	{
		religiousDebtDb = new ReligiousDebtDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religiousDebts, we can put some logic here if needed 
	public List<ReligiousDebt> GetListAll()
	{
		return religiousDebtDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religiousDebts, we can put some logic here if needed 
	public bool Update(ReligiousDebt religiousDebt)
	{
		return religiousDebtDb.Update(religiousDebt);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religiousDebts, we can put some logic here if needed 
	public ReligiousDebt GetDetails(Int64 heritageID)
	{
		return religiousDebtDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religiousDebts, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return religiousDebtDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religiousDebts, we can put some logic here if needed 
	public Int64 Insert(ReligiousDebt religiousDebt)
	{
		return religiousDebtDb.Insert(religiousDebt);
	}

	public bool Exists(ReligiousDebt religiousDebt)
	{
		return religiousDebtDb.Exists(religiousDebt);
	}

	public bool Exists(Int64 heritageID)
	{
		return religiousDebtDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religiousDebts, we can put some logic here if needed 
	public List<ReligiousDebt> SearchLike(ReligiousDebt religiousDebt)
	{
		return religiousDebtDb.SearchLike(religiousDebt);
	}

}
}
