using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class RolePart
{
	private int rolePartID;
	private string title;
	private string partTypeIDTitle;
	private string roleTypeIDTitle;
	private int roleTypeID;
	private int partTypeID;
	private List<RolePartActivity> rolePartActivityList;
	private List<UserTaxOfficeActivityRolePart> userTaxOfficeActivityRolePartList;
	private List<UserTaxOfficeRolePart> userTaxOfficeRolePartList;

	public int RolePartID
	{
		get
		{
			return rolePartID;
		}
		set
		{
			rolePartID = value;
		}
	}

	public string Title
	{
		get
		{
			return title;
		}
		set
		{
			title = value;
		}
	}

	public string PartTypeIDTitle
	{
		get
		{
			return partTypeIDTitle;
		}
		set
		{
			partTypeIDTitle = value;
		}
	}

	public string RoleTypeIDTitle
	{
		get
		{
			return roleTypeIDTitle;
		}
		set
		{
			roleTypeIDTitle = value;
		}
	}

	public int RoleTypeID
	{
		get
		{
			return roleTypeID;
		}
		set
		{
			roleTypeID = value;
		}
	}

	public int PartTypeID
	{
		get
		{
			return partTypeID;
		}
		set
		{
			partTypeID = value;
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

	public List<UserTaxOfficeRolePart> UserTaxOfficeRolePartList
	{
		get
		{
			return userTaxOfficeRolePartList;
		}
		set
		{
			userTaxOfficeRolePartList = value;
		}
	}

	public List<RolePartActivity> GetListRolePartActivity()
	{
		RolePartActivityList = new RolePartDBAccess().GetListRolePartActivity(this.RolePartID);
		return RolePartActivityList;
	}

	public List<UserTaxOfficeActivityRolePart> GetListUserTaxOfficeActivityRolePart()
	{
		UserTaxOfficeActivityRolePartList = new RolePartDBAccess().GetListUserTaxOfficeActivityRolePart(this.RolePartID);
		return UserTaxOfficeActivityRolePartList;
	}

	public List<UserTaxOfficeRolePart> GetListUserTaxOfficeRolePart()
	{
		UserTaxOfficeRolePartList = new RolePartDBAccess().GetListUserTaxOfficeRolePart(this.RolePartID);
		return UserTaxOfficeRolePartList;
	}

	public bool AddRolePartActivity(RolePartActivity rolePartActivity)
	{
		rolePartActivity.RolePartID = this.RolePartID;
		RolePartActivityDBAccess rolePartActivityDBAccess = new RolePartActivityDBAccess();
		if (rolePartActivityDBAccess.Insert(rolePartActivity)>0)
			return (true);
		return (false);
	}

	public bool AddUserTaxOfficeActivityRolePart(UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart)
	{
		userTaxOfficeActivityRolePart.RolePartID = this.RolePartID;
		UserTaxOfficeActivityRolePartDBAccess userTaxOfficeActivityRolePartDBAccess = new UserTaxOfficeActivityRolePartDBAccess();
		if (userTaxOfficeActivityRolePartDBAccess.Insert(userTaxOfficeActivityRolePart)>0)
			return (true);
		return (false);
	}

	public bool AddUserTaxOfficeRolePart(UserTaxOfficeRolePart userTaxOfficeRolePart)
	{
		userTaxOfficeRolePart.RolePartID = this.RolePartID;
		UserTaxOfficeRolePartDBAccess userTaxOfficeRolePartDBAccess = new UserTaxOfficeRolePartDBAccess();
		if (userTaxOfficeRolePartDBAccess.Insert(userTaxOfficeRolePart)>0)
			return (true);
		return (false);
	}

}
}
