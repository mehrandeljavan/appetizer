using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class DemandsHandler
{
	// Handle to the Demands DBAccess class
	DemandsDBAccess demandsDb = null;

	public DemandsHandler()
	{
		demandsDb = new DemandsDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandss, we can put some logic here if needed 
	public List<Demands> GetListAll()
	{
		return demandsDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandss, we can put some logic here if needed 
	public bool Update(Demands demands)
	{
		return demandsDb.Update(demands);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandss, we can put some logic here if needed 
	public Demands GetDetails(Int64 heritageID)
	{
		return demandsDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandss, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return demandsDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandss, we can put some logic here if needed 
	public Int64 Insert(Demands demands)
	{
		return demandsDb.Insert(demands);
	}

	public bool Exists(Demands demands)
	{
		return demandsDb.Exists(demands);
	}

	public bool Exists(Int64 heritageID)
	{
		return demandsDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandss, we can put some logic here if needed 
	public List<Demands> SearchLike(Demands demands)
	{
		return demandsDb.SearchLike(demands);
	}

}
}
