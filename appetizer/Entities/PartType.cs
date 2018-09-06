using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class PartType
{
	private int partTypeID;
	private string title;
	private List<RolePart> rolePartList;

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
		RolePartList = new PartTypeDBAccess().GetListRolePart(this.PartTypeID);
		return RolePartList;
	}

	public bool AddRolePart(RolePart rolePart)
	{
		rolePart.PartTypeID = this.PartTypeID;
		RolePartDBAccess rolePartDBAccess = new RolePartDBAccess();
		if (rolePartDBAccess.Insert(rolePart)>0)
			return (true);
		return (false);
	}

}
}
