using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class UttererHandler
{
	// Handle to the Utterer DBAccess class
	UttererDBAccess uttererDb = null;

	public UttererHandler()
	{
		uttererDb = new UttererDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of utterers, we can put some logic here if needed 
	public List<Utterer> GetListAll()
	{
		return uttererDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of utterers, we can put some logic here if needed 
	public bool Update(Utterer utterer)
	{
		return uttererDb.Update(utterer);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of utterers, we can put some logic here if needed 
	public Utterer GetDetails(Int64 uttererID)
	{
		return uttererDb.GetDetails(uttererID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of utterers, we can put some logic here if needed 
	public bool Delete(Int64 uttererID)
	{
		return uttererDb.Delete(uttererID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of utterers, we can put some logic here if needed 
	public Int64 Insert(Utterer utterer)
	{
		return uttererDb.Insert(utterer);
	}

	public bool Exists(Utterer utterer)
	{
		return uttererDb.Exists(utterer);
	}

	public bool Exists(Int64 uttererID)
	{
		return uttererDb.Exists(uttererID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of utterers, we can put some logic here if needed 
	public List<Utterer> SearchLike(Utterer utterer)
	{
		return uttererDb.SearchLike(utterer);
	}

}
}
