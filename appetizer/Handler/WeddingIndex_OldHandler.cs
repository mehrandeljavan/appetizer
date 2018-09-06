using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class WeddingIndex_OldHandler
{
	// Handle to the WeddingIndex_Old DBAccess class
	WeddingIndex_OldDBAccess weddingIndex_OldDb = null;

	public WeddingIndex_OldHandler()
	{
		weddingIndex_OldDb = new WeddingIndex_OldDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of weddingIndex_Olds, we can put some logic here if needed 
	public List<WeddingIndex_Old> GetListAll()
	{
		return weddingIndex_OldDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of weddingIndex_Olds, we can put some logic here if needed 
	public bool Update(WeddingIndex_Old weddingIndex_Old)
	{
		return weddingIndex_OldDb.Update(weddingIndex_Old);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of weddingIndex_Olds, we can put some logic here if needed 
	public WeddingIndex_Old GetDetails(int weddingYear)
	{
		return weddingIndex_OldDb.GetDetails(weddingYear);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of weddingIndex_Olds, we can put some logic here if needed 
	public bool Delete(int weddingYear)
	{
		return weddingIndex_OldDb.Delete(weddingYear);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of weddingIndex_Olds, we can put some logic here if needed 
	public Int64 Insert(WeddingIndex_Old weddingIndex_Old)
	{
		return weddingIndex_OldDb.Insert(weddingIndex_Old);
	}

	public bool Exists(WeddingIndex_Old weddingIndex_Old)
	{
		return weddingIndex_OldDb.Exists(weddingIndex_Old);
	}

	public bool Exists(int weddingYear)
	{
		return weddingIndex_OldDb.Exists(weddingYear);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of weddingIndex_Olds, we can put some logic here if needed 
	public List<WeddingIndex_Old> SearchLike(WeddingIndex_Old weddingIndex_Old)
	{
		return weddingIndex_OldDb.SearchLike(weddingIndex_Old);
	}

}
}
