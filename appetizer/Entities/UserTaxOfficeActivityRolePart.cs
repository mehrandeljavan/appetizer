using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class UserTaxOfficeActivityRolePart
{
	private int taxOfficeCode;
	private int activityID;
	private int rolePartID;
	private Int64 userNationalCode;
	private string userFullName;
	private string taxOfficeCodeTitle;
	private string rolePartIDTitle;
	private string activityTitle;
	private int permission;

	public int TaxOfficeCode
	{
		get
		{
			return taxOfficeCode;
		}
		set
		{
			taxOfficeCode = value;
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

	public Int64 UserNationalCode
	{
		get
		{
			return userNationalCode;
		}
		set
		{
			userNationalCode = value;
		}
	}

	public string UserFullName
	{
		get
		{
			return userFullName;
		}
		set
		{
			userFullName = value;
		}
	}

	public string TaxOfficeCodeTitle
	{
		get
		{
			return taxOfficeCodeTitle;
		}
		set
		{
			taxOfficeCodeTitle = value;
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

	public int Permission
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
