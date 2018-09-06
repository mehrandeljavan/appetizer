using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class DeadHandler
{
	// Handle to the Dead DBAccess class
	DeadDBAccess deadDb = null;

	public DeadHandler()
	{
		deadDb = new DeadDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of deads, we can put some logic here if needed 
	public List<Dead> GetListAll()
	{
		return deadDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of deads, we can put some logic here if needed 
	public bool Update(Dead dead)
	{
		return deadDb.Update(dead);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of deads, we can put some logic here if needed 
	public Dead GetDetails(Int64 nationalCode)
	{
		return deadDb.GetDetails(nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of deads, we can put some logic here if needed 
	public bool Delete(Int64 nationalCode)
	{
		return deadDb.Delete(nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of deads, we can put some logic here if needed 
	public Int64 Insert(Dead dead)
	{
		return deadDb.Insert(dead);
	}

	public bool Exists(Dead dead)
	{
		return deadDb.Exists(dead);
	}

	public bool Exists(Int64 nationalCode)
	{
		return deadDb.Exists(nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of deads, we can put some logic here if needed 
	public List<Dead> SearchLike(Dead dead)
	{
		return deadDb.SearchLike(dead);
	}

}
}
