using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class WillHandler
{
	// Handle to the Will DBAccess class
	WillDBAccess willDb = null;

	public WillHandler()
	{
		willDb = new WillDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wills, we can put some logic here if needed 
	public List<Will> GetListAll()
	{
		return willDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wills, we can put some logic here if needed 
	public bool Update(Will will)
	{
		return willDb.Update(will);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wills, we can put some logic here if needed 
	public Will GetDetails(Int64 willID)
	{
		return willDb.GetDetails(willID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wills, we can put some logic here if needed 
	public bool Delete(Int64 willID)
	{
		return willDb.Delete(willID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wills, we can put some logic here if needed 
	public Int64 Insert(Will will)
	{
		return willDb.Insert(will);
	}

	public bool Exists(Will will)
	{
		return willDb.Exists(will);
	}

	public bool Exists(Int64 willID)
	{
		return willDb.Exists(willID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wills, we can put some logic here if needed 
	public List<Will> SearchLike(Will will)
	{
		return willDb.SearchLike(will);
	}

}
}
