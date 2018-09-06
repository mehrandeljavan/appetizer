using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class DemandsTypeHandler
{
	// Handle to the DemandsType DBAccess class
	DemandsTypeDBAccess demandsTypeDb = null;

	public DemandsTypeHandler()
	{
		demandsTypeDb = new DemandsTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandsTypes, we can put some logic here if needed 
	public List<DemandsType> GetListAll()
	{
		return demandsTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandsTypes, we can put some logic here if needed 
	public bool Update(DemandsType demandsType)
	{
		return demandsTypeDb.Update(demandsType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandsTypes, we can put some logic here if needed 
	public DemandsType GetDetails(int demandsTypeID)
	{
		return demandsTypeDb.GetDetails(demandsTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandsTypes, we can put some logic here if needed 
	public bool Delete(int demandsTypeID)
	{
		return demandsTypeDb.Delete(demandsTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandsTypes, we can put some logic here if needed 
	public Int64 Insert(DemandsType demandsType)
	{
		return demandsTypeDb.Insert(demandsType);
	}

	public bool Exists(DemandsType demandsType)
	{
		return demandsTypeDb.Exists(demandsType);
	}

	public bool Exists(int demandsTypeID)
	{
		return demandsTypeDb.Exists(demandsTypeID);
	}

	public List<Demands> GetListDemands(int demandsTypeID)
	{
		return demandsTypeDb.GetListDemands(demandsTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandsTypes, we can put some logic here if needed 
	public List<DemandsType> SearchLike(DemandsType demandsType)
	{
		return demandsTypeDb.SearchLike(demandsType);
	}

}
}
