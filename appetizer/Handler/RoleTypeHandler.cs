using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class RoleTypeHandler
{
	// Handle to the RoleType DBAccess class
	RoleTypeDBAccess roleTypeDb = null;

	public RoleTypeHandler()
	{
		roleTypeDb = new RoleTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of roleTypes, we can put some logic here if needed 
	public List<RoleType> GetListAll()
	{
		return roleTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of roleTypes, we can put some logic here if needed 
	public bool Update(RoleType roleType)
	{
		return roleTypeDb.Update(roleType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of roleTypes, we can put some logic here if needed 
	public RoleType GetDetails(int roleTypeID)
	{
		return roleTypeDb.GetDetails(roleTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of roleTypes, we can put some logic here if needed 
	public bool Delete(int roleTypeID)
	{
		return roleTypeDb.Delete(roleTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of roleTypes, we can put some logic here if needed 
	public Int64 Insert(RoleType roleType)
	{
		return roleTypeDb.Insert(roleType);
	}

	public bool Exists(RoleType roleType)
	{
		return roleTypeDb.Exists(roleType);
	}

	public bool Exists(int roleTypeID)
	{
		return roleTypeDb.Exists(roleTypeID);
	}

	public List<RolePart> GetListRolePart(int roleTypeID)
	{
		return roleTypeDb.GetListRolePart(roleTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of roleTypes, we can put some logic here if needed 
	public List<RoleType> SearchLike(RoleType roleType)
	{
		return roleTypeDb.SearchLike(roleType);
	}

}
}
