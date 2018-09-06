using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class JusticeSharesHandler
{
	// Handle to the JusticeShares DBAccess class
	JusticeSharesDBAccess justiceSharesDb = null;

	public JusticeSharesHandler()
	{
		justiceSharesDb = new JusticeSharesDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of justiceSharess, we can put some logic here if needed 
	public List<JusticeShares> GetListAll()
	{
		return justiceSharesDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of justiceSharess, we can put some logic here if needed 
	public bool Update(JusticeShares justiceShares)
	{
		return justiceSharesDb.Update(justiceShares);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of justiceSharess, we can put some logic here if needed 
	public JusticeShares GetDetails(Int64 heritageID)
	{
		return justiceSharesDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of justiceSharess, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return justiceSharesDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of justiceSharess, we can put some logic here if needed 
	public Int64 Insert(JusticeShares justiceShares)
	{
		return justiceSharesDb.Insert(justiceShares);
	}

	public bool Exists(JusticeShares justiceShares)
	{
		return justiceSharesDb.Exists(justiceShares);
	}

	public bool Exists(Int64 heritageID)
	{
		return justiceSharesDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of justiceSharess, we can put some logic here if needed 
	public List<JusticeShares> SearchLike(JusticeShares justiceShares)
	{
		return justiceSharesDb.SearchLike(justiceShares);
	}

}
}
