using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class HajjHandler
{
	// Handle to the Hajj DBAccess class
	HajjDBAccess hajjDb = null;

	public HajjHandler()
	{
		hajjDb = new HajjDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of hajjs, we can put some logic here if needed 
	public List<Hajj> GetListAll()
	{
		return hajjDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of hajjs, we can put some logic here if needed 
	public bool Update(Hajj hajj)
	{
		return hajjDb.Update(hajj);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of hajjs, we can put some logic here if needed 
	public Hajj GetDetails(Int64 heritageID)
	{
		return hajjDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of hajjs, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return hajjDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of hajjs, we can put some logic here if needed 
	public Int64 Insert(Hajj hajj)
	{
		return hajjDb.Insert(hajj);
	}

	public bool Exists(Hajj hajj)
	{
		return hajjDb.Exists(hajj);
	}

	public bool Exists(Int64 heritageID)
	{
		return hajjDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of hajjs, we can put some logic here if needed 
	public List<Hajj> SearchLike(Hajj hajj)
	{
		return hajjDb.SearchLike(hajj);
	}

}
}
