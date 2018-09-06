using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class RolePartActivityHandler
{
	// Handle to the RolePartActivity DBAccess class
	RolePartActivityDBAccess rolePartActivityDb = null;

	public RolePartActivityHandler()
	{
		rolePartActivityDb = new RolePartActivityDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of rolePartActivitys, we can put some logic here if needed 
	public List<RolePartActivity> GetListAll()
	{
		return rolePartActivityDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of rolePartActivitys, we can put some logic here if needed 
	public bool Update(RolePartActivity rolePartActivity)
	{
		return rolePartActivityDb.Update(rolePartActivity);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of rolePartActivitys, we can put some logic here if needed 
	public RolePartActivity GetDetails(int rolePartActivityID)
	{
		return rolePartActivityDb.GetDetails(rolePartActivityID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of rolePartActivitys, we can put some logic here if needed 
	public bool Delete(int rolePartActivityID)
	{
		return rolePartActivityDb.Delete(rolePartActivityID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of rolePartActivitys, we can put some logic here if needed 
	public Int64 Insert(RolePartActivity rolePartActivity)
	{
		return rolePartActivityDb.Insert(rolePartActivity);
	}

	public bool Exists(RolePartActivity rolePartActivity)
	{
		return rolePartActivityDb.Exists(rolePartActivity);
	}

	public bool Exists(int rolePartActivityID)
	{
		return rolePartActivityDb.Exists(rolePartActivityID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of rolePartActivitys, we can put some logic here if needed 
	public List<RolePartActivity> SearchLike(RolePartActivity rolePartActivity)
	{
		return rolePartActivityDb.SearchLike(rolePartActivity);
	}

}
}
