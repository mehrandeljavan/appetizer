using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class WellHandler
{
	// Handle to the Well DBAccess class
	WellDBAccess wellDb = null;

	public WellHandler()
	{
		wellDb = new WellDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wells, we can put some logic here if needed 
	public List<Well> GetListAll()
	{
		return wellDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wells, we can put some logic here if needed 
	public bool Update(Well well)
	{
		return wellDb.Update(well);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wells, we can put some logic here if needed 
	public Well GetDetails(Int64 heritageID)
	{
		return wellDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wells, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return wellDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wells, we can put some logic here if needed 
	public Int64 Insert(Well well)
	{
		return wellDb.Insert(well);
	}

	public bool Exists(Well well)
	{
		return wellDb.Exists(well);
	}

	public bool Exists(Int64 heritageID)
	{
		return wellDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wells, we can put some logic here if needed 
	public List<Well> SearchLike(Well well)
	{
		return wellDb.SearchLike(well);
	}

}
}
