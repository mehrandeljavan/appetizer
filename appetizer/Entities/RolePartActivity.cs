using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class RolePartActivity
{
	private int rolePartActivityID;
	private string activityTitle;
	private string rolePartIDTitle;
	private int rolePartID;
	private int activityID;
	private int? permission;

	public int RolePartActivityID
	{
		get
		{
			return rolePartActivityID;
		}
		set
		{
			rolePartActivityID = value;
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

	public string RolePartIDTitle
	{
		get
		{
			return rolePartIDTitle;
		}
		set
		{
			rolePartIDTitle = value;
		}
	}

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

	public int? Permission
	{
		get
		{
			return permission;
		}
		set
		{
			permission = value;
		}
	}

}
}
