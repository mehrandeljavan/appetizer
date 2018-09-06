using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class RolePartHandler
{
	// Handle to the RolePart DBAccess class
	RolePartDBAccess rolePartDb = null;

	public RolePartHandler()
	{
		rolePartDb = new RolePartDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of roleParts, we can put some logic here if needed 
	public List<RolePart> GetListAll()
	{
		return rolePartDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of roleParts, we can put some logic here if needed 
	public bool Update(RolePart rolePart)
	{
		return rolePartDb.Update(rolePart);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of roleParts, we can put some logic here if needed 
	public RolePart GetDetails(int rolePartID)
	{
		return rolePartDb.GetDetails(rolePartID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of roleParts, we can put some logic here if needed 
	public bool Delete(int rolePartID)
	{
		return rolePartDb.Delete(rolePartID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of roleParts, we can put some logic here if needed 
	public Int64 Insert(RolePart rolePart)
	{
		return rolePartDb.Insert(rolePart);
	}

	public bool Exists(RolePart rolePart)
	{
		return rolePartDb.Exists(rolePart);
	}

	public bool Exists(int rolePartID)
	{
		return rolePartDb.Exists(rolePartID);
	}

	public List<RolePartActivity> GetListRolePartActivity(int rolePartID)
	{
		return rolePartDb.GetListRolePartActivity(rolePartID);
	}

	public List<UserTaxOfficeActivityRolePart> GetListUserTaxOfficeActivityRolePart(int rolePartID)
	{
		return rolePartDb.GetListUserTaxOfficeActivityRolePart(rolePartID);
	}

	public List<UserTaxOfficeRolePart> GetListUserTaxOfficeRolePart(int rolePartID)
	{
		return rolePartDb.GetListUserTaxOfficeRolePart(rolePartID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of roleParts, we can put some logic here if needed 
	public List<RolePart> SearchLike(RolePart rolePart)
	{
		return rolePartDb.SearchLike(rolePart);
	}

}
}
