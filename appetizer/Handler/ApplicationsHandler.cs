using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class ApplicationsHandler
{
	// Handle to the Applications DBAccess class
	ApplicationsDBAccess applicationsDb = null;

	public ApplicationsHandler()
	{
		applicationsDb = new ApplicationsDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicationss, we can put some logic here if needed 
	public List<Applications> GetListAll()
	{
		return applicationsDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicationss, we can put some logic here if needed 
	public bool Update(Applications applications)
	{
		return applicationsDb.Update(applications);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicationss, we can put some logic here if needed 
	public Applications GetDetails(int appID)
	{
		return applicationsDb.GetDetails(appID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicationss, we can put some logic here if needed 
	public bool Delete(int appID)
	{
		return applicationsDb.Delete(appID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicationss, we can put some logic here if needed 
	public Int64 Insert(Applications applications)
	{
		return applicationsDb.Insert(applications);
	}

	public bool Exists(Applications applications)
	{
		return applicationsDb.Exists(applications);
	}

	public bool Exists(int appID)
	{
		return applicationsDb.Exists(appID);
	}

	public List<Logging> GetListLogging(int appID)
	{
		return applicationsDb.GetListLogging(appID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicationss, we can put some logic here if needed 
	public List<Applications> SearchLike(Applications applications)
	{
		return applicationsDb.SearchLike(applications);
	}

}
}
