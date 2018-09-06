using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class WeddingIndexHandler
{
	// Handle to the WeddingIndex DBAccess class
	WeddingIndexDBAccess weddingIndexDb = null;

	public WeddingIndexHandler()
	{
		weddingIndexDb = new WeddingIndexDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of weddingIndexs, we can put some logic here if needed 
	public List<WeddingIndex> GetListAll()
	{
		return weddingIndexDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of weddingIndexs, we can put some logic here if needed 
	public bool Update(WeddingIndex weddingIndex)
	{
		return weddingIndexDb.Update(weddingIndex);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of weddingIndexs, we can put some logic here if needed 
	public WeddingIndex GetDetails(int weddingYear)
	{
		return weddingIndexDb.GetDetails(weddingYear);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of weddingIndexs, we can put some logic here if needed 
	public bool Delete(int weddingYear)
	{
		return weddingIndexDb.Delete(weddingYear);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of weddingIndexs, we can put some logic here if needed 
	public Int64 Insert(WeddingIndex weddingIndex)
	{
		return weddingIndexDb.Insert(weddingIndex);
	}

	public bool Exists(WeddingIndex weddingIndex)
	{
		return weddingIndexDb.Exists(weddingIndex);
	}

	public bool Exists(int weddingYear)
	{
		return weddingIndexDb.Exists(weddingYear);
	}

	public List<Dowry> GetListDowry(int weddingYear)
	{
		return weddingIndexDb.GetListDowry(weddingYear);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of weddingIndexs, we can put some logic here if needed 
	public List<WeddingIndex> SearchLike(WeddingIndex weddingIndex)
	{
		return weddingIndexDb.SearchLike(weddingIndex);
	}

}
}
