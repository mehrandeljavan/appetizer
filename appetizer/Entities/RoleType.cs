using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class RoleType
{
	private int roleTypeID;
	private string title;
	private List<RolePart> rolePartList;

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

	public List<RolePart> RolePartList
	{
		get
		{
			return rolePartList;
		}
		set
		{
			rolePartList = value;
		}
	}

	public List<RolePart> GetListRolePart()
	{
		RolePartList = new RoleTypeDBAccess().GetListRolePart(this.RoleTypeID);
		return RolePartList;
	}

	public bool AddRolePart(RolePart rolePart)
	{
		rolePart.RoleTypeID = this.RoleTypeID;
		RolePartDBAccess rolePartDBAccess = new RolePartDBAccess();
		if (rolePartDBAccess.Insert(rolePart)>0)
			return (true);
		return (false);
	}

}
}
