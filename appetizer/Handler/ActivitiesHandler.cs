using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class ActivitiesHandler
{
	// Handle to the Activities DBAccess class
	ActivitiesDBAccess activitiesDb = null;

	public ActivitiesHandler()
	{
		activitiesDb = new ActivitiesDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activitiess, we can put some logic here if needed 
	public List<Activities> GetListAll()
	{
		return activitiesDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activitiess, we can put some logic here if needed 
	public bool Update(Activities activities)
	{
		return activitiesDb.Update(activities);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activitiess, we can put some logic here if needed 
	public Activities GetDetails(int activityID)
	{
		return activitiesDb.GetDetails(activityID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activitiess, we can put some logic here if needed 
	public bool Delete(int activityID)
	{
		return activitiesDb.Delete(activityID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activitiess, we can put some logic here if needed 
	public Int64 Insert(Activities activities)
	{
		return activitiesDb.Insert(activities);
	}

	public bool Exists(Activities activities)
	{
		return activitiesDb.Exists(activities);
	}

	public bool Exists(int activityID)
	{
		return activitiesDb.Exists(activityID);
	}

	public List<RolePartActivity> GetListRolePartActivity(int activityID)
	{
		return activitiesDb.GetListRolePartActivity(activityID);
	}

	public List<UserTaxOfficeActivityRolePart> GetListUserTaxOfficeActivityRolePart(int activityID)
	{
		return activitiesDb.GetListUserTaxOfficeActivityRolePart(activityID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activitiess, we can put some logic here if needed 
	public List<Activities> SearchLike(Activities activities)
	{
		return activitiesDb.SearchLike(activities);
	}

}
}
