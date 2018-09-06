using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class HajjTypeHandler
{
	// Handle to the HajjType DBAccess class
	HajjTypeDBAccess hajjTypeDb = null;

	public HajjTypeHandler()
	{
		hajjTypeDb = new HajjTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of hajjTypes, we can put some logic here if needed 
	public List<HajjType> GetListAll()
	{
		return hajjTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of hajjTypes, we can put some logic here if needed 
	public bool Update(HajjType hajjType)
	{
		return hajjTypeDb.Update(hajjType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of hajjTypes, we can put some logic here if needed 
	public HajjType GetDetails(int hajjTypeID)
	{
		return hajjTypeDb.GetDetails(hajjTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of hajjTypes, we can put some logic here if needed 
	public bool Delete(int hajjTypeID)
	{
		return hajjTypeDb.Delete(hajjTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of hajjTypes, we can put some logic here if needed 
	public Int64 Insert(HajjType hajjType)
	{
		return hajjTypeDb.Insert(hajjType);
	}

	public bool Exists(HajjType hajjType)
	{
		return hajjTypeDb.Exists(hajjType);
	}

	public bool Exists(int hajjTypeID)
	{
		return hajjTypeDb.Exists(hajjTypeID);
	}

	public List<Hajj> GetListHajj(int hajjTypeID)
	{
		return hajjTypeDb.GetListHajj(hajjTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of hajjTypes, we can put some logic here if needed 
	public List<HajjType> SearchLike(HajjType hajjType)
	{
		return hajjTypeDb.SearchLike(hajjType);
	}

}
}
