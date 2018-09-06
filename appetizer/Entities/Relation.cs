using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Relation
{
	private int relationID;
	private int? relationLevel;
	private int? degree;
	private int? parentRelationID;
	private string title;
	private List<Heir> heirList;

	public int RelationID
	{
		get
		{
			return relationID;
		}
		set
		{
			relationID = value;
		}
	}

	public int? RelationLevel
	{
		get
		{
			return relationLevel;
		}
		set
		{
			relationLevel = value;
		}
	}

	public int? Degree
	{
		get
		{
			return degree;
		}
		set
		{
			degree = value;
		}
	}

	public int? ParentRelationID
	{
		get
		{
			return parentRelationID;
		}
		set
		{
			parentRelationID = value;
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

	public List<Heir> HeirList
	{
		get
		{
			return heirList;
		}
		set
		{
			heirList = value;
		}
	}

	public List<Heir> GetListHeir()
	{
		HeirList = new RelationDBAccess().GetListHeir(this.RelationID);
		return HeirList;
	}

	public bool AddHeir(Heir heir)
	{
		heir.RelationID = this.RelationID;
		HeirDBAccess heirDBAccess = new HeirDBAccess();
		if (heirDBAccess.Insert(heir)>0)
			return (true);
		return (false);
	}

}
}
