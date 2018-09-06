using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class SafeBoxHandler
{
	// Handle to the SafeBox DBAccess class
	SafeBoxDBAccess safeBoxDb = null;

	public SafeBoxHandler()
	{
		safeBoxDb = new SafeBoxDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of safeBoxs, we can put some logic here if needed 
	public List<SafeBox> GetListAll()
	{
		return safeBoxDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of safeBoxs, we can put some logic here if needed 
	public bool Update(SafeBox safeBox)
	{
		return safeBoxDb.Update(safeBox);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of safeBoxs, we can put some logic here if needed 
	public SafeBox GetDetails(Int64 heritageID)
	{
		return safeBoxDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of safeBoxs, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return safeBoxDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of safeBoxs, we can put some logic here if needed 
	public Int64 Insert(SafeBox safeBox)
	{
		return safeBoxDb.Insert(safeBox);
	}

	public bool Exists(SafeBox safeBox)
	{
		return safeBoxDb.Exists(safeBox);
	}

	public bool Exists(Int64 heritageID)
	{
		return safeBoxDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of safeBoxs, we can put some logic here if needed 
	public List<SafeBox> SearchLike(SafeBox safeBox)
	{
		return safeBoxDb.SearchLike(safeBox);
	}

}
}
