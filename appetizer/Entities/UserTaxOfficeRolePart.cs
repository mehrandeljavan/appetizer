using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class UserTaxOfficeRolePart
{
	private Int64 userTaxOfficeRolePartID;
	private string userFullName;
	private string taxOfficeTitle;
	private string rolePartIDTitle;
	private string title;
	private string letters;
	private int taxOfficeCode;
	private int rolePartID;
	private int? taxUnitCode;
	private bool isActive;
	private Int64 userNationalCode;

	public Int64 UserTaxOfficeRolePartID
	{
		get
		{
			return userTaxOfficeRolePartID;
		}
		set
		{
			userTaxOfficeRolePartID = value;
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

	public string TaxOfficeTitle
	{
		get
		{
			return taxOfficeTitle;
		}
		set
		{
			taxOfficeTitle = value;
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

	public string Letters
	{
		get
		{
			return letters;
		}
		set
		{
			letters = value;
		}
	}

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

	public int? TaxUnitCode
	{
		get
		{
			return taxUnitCode;
		}
		set
		{
			taxUnitCode = value;
		}
	}

	public bool IsActive
	{
		get
		{
			return isActive;
		}
		set
		{
			isActive = value;
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

}
}
