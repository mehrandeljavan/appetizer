using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Activities
{
	private int activityID;
	private int? orderNumber;
	private string prefix;
	private string activityTitle;
	private string activityConstantTitle;
	private string activityCategory;
	private List<RolePartActivity> rolePartActivityList;
	private List<UserTaxOfficeActivityRolePart> userTaxOfficeActivityRolePartList;

	public int ActivityID
	{
		get
		{
			return activityID;
		}
		set
		{
			activityID = value;
		}
	}

	public int? OrderNumber
	{
		get
		{
			return orderNumber;
		}
		set
		{
			orderNumber = value;
		}
	}

	public string Prefix
	{
		get
		{
			return prefix;
		}
		set
		{
			prefix = value;
		}
	}

	public string ActivityTitle
	{
		get
		{
			return activityTitle;
		}
		set
		{
			activityTitle = value;
		}
	}

	public string ActivityConstantTitle
	{
		get
		{
			return activityConstantTitle;
		}
		set
		{
			activityConstantTitle = value;
		}
	}

	public string ActivityCategory
	{
		get
		{
			return activityCategory;
		}
		set
		{
			activityCategory = value;
		}
	}

	public List<RolePartActivity> RolePartActivityList
	{
		get
		{
			return rolePartActivityList;
		}
		set
		{
			rolePartActivityList = value;
		}
	}

	public List<UserTaxOfficeActivityRolePart> UserTaxOfficeActivityRolePartList
	{
		get
		{
			return userTaxOfficeActivityRolePartList;
		}
		set
		{
			userTaxOfficeActivityRolePartList = value;
		}
	}

	public List<RolePartActivity> GetListRolePartActivity()
	{
		RolePartActivityList = new ActivitiesDBAccess().GetListRolePartActivity(this.ActivityID);
		return RolePartActivityList;
	}

	public List<UserTaxOfficeActivityRolePart> GetListUserTaxOfficeActivityRolePart()
	{
		UserTaxOfficeActivityRolePartList = new ActivitiesDBAccess().GetListUserTaxOfficeActivityRolePart(this.ActivityID);
		return UserTaxOfficeActivityRolePartList;
	}

	public bool AddRolePartActivity(RolePartActivity rolePartActivity)
	{
		rolePartActivity.ActivityID = this.ActivityID;
		RolePartActivityDBAccess rolePartActivityDBAccess = new RolePartActivityDBAccess();
		if (rolePartActivityDBAccess.Insert(rolePartActivity)>0)
			return (true);
		return (false);
	}

	public bool AddUserTaxOfficeActivityRolePart(UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart)
	{
		userTaxOfficeActivityRolePart.ActivityID = this.ActivityID;
		UserTaxOfficeActivityRolePartDBAccess userTaxOfficeActivityRolePartDBAccess = new UserTaxOfficeActivityRolePartDBAccess();
		if (userTaxOfficeActivityRolePartDBAccess.Insert(userTaxOfficeActivityRolePart)>0)
			return (true);
		return (false);
	}

}
}
