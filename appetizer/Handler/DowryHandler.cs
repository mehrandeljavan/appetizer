using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class DowryHandler
{
	// Handle to the Dowry DBAccess class
	DowryDBAccess dowryDb = null;

	public DowryHandler()
	{
		dowryDb = new DowryDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dowrys, we can put some logic here if needed 
	public List<Dowry> GetListAll()
	{
		return dowryDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dowrys, we can put some logic here if needed 
	public bool Update(Dowry dowry)
	{
		return dowryDb.Update(dowry);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dowrys, we can put some logic here if needed 
	public Dowry GetDetails(Int64 heritageID)
	{
		return dowryDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dowrys, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return dowryDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dowrys, we can put some logic here if needed 
	public Int64 Insert(Dowry dowry)
	{
		return dowryDb.Insert(dowry);
	}

	public bool Exists(Dowry dowry)
	{
		return dowryDb.Exists(dowry);
	}

	public bool Exists(Int64 heritageID)
	{
		return dowryDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dowrys, we can put some logic here if needed 
	public List<Dowry> SearchLike(Dowry dowry)
	{
		return dowryDb.SearchLike(dowry);
	}

}
}
