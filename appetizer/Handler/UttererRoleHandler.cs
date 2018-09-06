using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class UttererRoleHandler
{
	// Handle to the UttererRole DBAccess class
	UttererRoleDBAccess uttererRoleDb = null;

	public UttererRoleHandler()
	{
		uttererRoleDb = new UttererRoleDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of uttererRoles, we can put some logic here if needed 
	public List<UttererRole> GetListAll()
	{
		return uttererRoleDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of uttererRoles, we can put some logic here if needed 
	public bool Update(UttererRole uttererRole)
	{
		return uttererRoleDb.Update(uttererRole);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of uttererRoles, we can put some logic here if needed 
	public UttererRole GetDetails(int uttererRoleID)
	{
		return uttererRoleDb.GetDetails(uttererRoleID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of uttererRoles, we can put some logic here if needed 
	public bool Delete(int uttererRoleID)
	{
		return uttererRoleDb.Delete(uttererRoleID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of uttererRoles, we can put some logic here if needed 
	public Int64 Insert(UttererRole uttererRole)
	{
		return uttererRoleDb.Insert(uttererRole);
	}

	public bool Exists(UttererRole uttererRole)
	{
		return uttererRoleDb.Exists(uttererRole);
	}

	public bool Exists(int uttererRoleID)
	{
		return uttererRoleDb.Exists(uttererRoleID);
	}

	public List<Utterer> GetListUtterer(int uttererRoleID)
	{
		return uttererRoleDb.GetListUtterer(uttererRoleID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of uttererRoles, we can put some logic here if needed 
	public List<UttererRole> SearchLike(UttererRole uttererRole)
	{
		return uttererRoleDb.SearchLike(uttererRole);
	}

}
}
