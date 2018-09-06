using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class WellTypeHandler
{
	// Handle to the WellType DBAccess class
	WellTypeDBAccess wellTypeDb = null;

	public WellTypeHandler()
	{
		wellTypeDb = new WellTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wellTypes, we can put some logic here if needed 
	public List<WellType> GetListAll()
	{
		return wellTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wellTypes, we can put some logic here if needed 
	public bool Update(WellType wellType)
	{
		return wellTypeDb.Update(wellType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wellTypes, we can put some logic here if needed 
	public WellType GetDetails(int wellTypeID)
	{
		return wellTypeDb.GetDetails(wellTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wellTypes, we can put some logic here if needed 
	public bool Delete(int wellTypeID)
	{
		return wellTypeDb.Delete(wellTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wellTypes, we can put some logic here if needed 
	public Int64 Insert(WellType wellType)
	{
		return wellTypeDb.Insert(wellType);
	}

	public bool Exists(WellType wellType)
	{
		return wellTypeDb.Exists(wellType);
	}

	public bool Exists(int wellTypeID)
	{
		return wellTypeDb.Exists(wellTypeID);
	}

	public List<Well> GetListWell(int wellTypeID)
	{
		return wellTypeDb.GetListWell(wellTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of wellTypes, we can put some logic here if needed 
	public List<WellType> SearchLike(WellType wellType)
	{
		return wellTypeDb.SearchLike(wellType);
	}

}
}
