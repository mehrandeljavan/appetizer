using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class PartTypeHandler
{
	// Handle to the PartType DBAccess class
	PartTypeDBAccess partTypeDb = null;

	public PartTypeHandler()
	{
		partTypeDb = new PartTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partTypes, we can put some logic here if needed 
	public List<PartType> GetListAll()
	{
		return partTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partTypes, we can put some logic here if needed 
	public bool Update(PartType partType)
	{
		return partTypeDb.Update(partType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partTypes, we can put some logic here if needed 
	public PartType GetDetails(int partTypeID)
	{
		return partTypeDb.GetDetails(partTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partTypes, we can put some logic here if needed 
	public bool Delete(int partTypeID)
	{
		return partTypeDb.Delete(partTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partTypes, we can put some logic here if needed 
	public Int64 Insert(PartType partType)
	{
		return partTypeDb.Insert(partType);
	}

	public bool Exists(PartType partType)
	{
		return partTypeDb.Exists(partType);
	}

	public bool Exists(int partTypeID)
	{
		return partTypeDb.Exists(partTypeID);
	}

	public List<RolePart> GetListRolePart(int partTypeID)
	{
		return partTypeDb.GetListRolePart(partTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partTypes, we can put some logic here if needed 
	public List<PartType> SearchLike(PartType partType)
	{
		return partTypeDb.SearchLike(partType);
	}

}
}
