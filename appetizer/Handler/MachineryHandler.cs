using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class MachineryHandler
{
	// Handle to the Machinery DBAccess class
	MachineryDBAccess machineryDb = null;

	public MachineryHandler()
	{
		machineryDb = new MachineryDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of machinerys, we can put some logic here if needed 
	public List<Machinery> GetListAll()
	{
		return machineryDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of machinerys, we can put some logic here if needed 
	public bool Update(Machinery machinery)
	{
		return machineryDb.Update(machinery);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of machinerys, we can put some logic here if needed 
	public Machinery GetDetails(Int64 heritageID)
	{
		return machineryDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of machinerys, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return machineryDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of machinerys, we can put some logic here if needed 
	public Int64 Insert(Machinery machinery)
	{
		return machineryDb.Insert(machinery);
	}

	public bool Exists(Machinery machinery)
	{
		return machineryDb.Exists(machinery);
	}

	public bool Exists(Int64 heritageID)
	{
		return machineryDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of machinerys, we can put some logic here if needed 
	public List<Machinery> SearchLike(Machinery machinery)
	{
		return machineryDb.SearchLike(machinery);
	}

}
}
