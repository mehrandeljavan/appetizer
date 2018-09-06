using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class PermitHandler
{
	// Handle to the Permit DBAccess class
	PermitDBAccess permitDb = null;

	public PermitHandler()
	{
		permitDb = new PermitDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of permits, we can put some logic here if needed 
	public List<Permit> GetListAll()
	{
		return permitDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of permits, we can put some logic here if needed 
	public bool Update(Permit permit)
	{
		return permitDb.Update(permit);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of permits, we can put some logic here if needed 
	public Permit GetDetails(Int64 heritageID)
	{
		return permitDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of permits, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return permitDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of permits, we can put some logic here if needed 
	public Int64 Insert(Permit permit)
	{
		return permitDb.Insert(permit);
	}

	public bool Exists(Permit permit)
	{
		return permitDb.Exists(permit);
	}

	public bool Exists(Int64 heritageID)
	{
		return permitDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of permits, we can put some logic here if needed 
	public List<Permit> SearchLike(Permit permit)
	{
		return permitDb.SearchLike(permit);
	}

}
}
