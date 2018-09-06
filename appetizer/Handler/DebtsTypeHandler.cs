using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class DebtsTypeHandler
{
	// Handle to the DebtsType DBAccess class
	DebtsTypeDBAccess debtsTypeDb = null;

	public DebtsTypeHandler()
	{
		debtsTypeDb = new DebtsTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of debtsTypes, we can put some logic here if needed 
	public List<DebtsType> GetListAll()
	{
		return debtsTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of debtsTypes, we can put some logic here if needed 
	public bool Update(DebtsType debtsType)
	{
		return debtsTypeDb.Update(debtsType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of debtsTypes, we can put some logic here if needed 
	public DebtsType GetDetails(int debtsTypeID)
	{
		return debtsTypeDb.GetDetails(debtsTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of debtsTypes, we can put some logic here if needed 
	public bool Delete(int debtsTypeID)
	{
		return debtsTypeDb.Delete(debtsTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of debtsTypes, we can put some logic here if needed 
	public Int64 Insert(DebtsType debtsType)
	{
		return debtsTypeDb.Insert(debtsType);
	}

	public bool Exists(DebtsType debtsType)
	{
		return debtsTypeDb.Exists(debtsType);
	}

	public bool Exists(int debtsTypeID)
	{
		return debtsTypeDb.Exists(debtsTypeID);
	}

	public List<Debts> GetListDebts(int debtsTypeID)
	{
		return debtsTypeDb.GetListDebts(debtsTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of debtsTypes, we can put some logic here if needed 
	public List<DebtsType> SearchLike(DebtsType debtsType)
	{
		return debtsTypeDb.SearchLike(debtsType);
	}

}
}
