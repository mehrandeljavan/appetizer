using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class EducationState
{
	private int educationStateID;
	private string title;
	private List<Heir> heirList;

	public int EducationStateID
	{
		get
		{
			return educationStateID;
		}
		set
		{
			educationStateID = value;
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
		HeirList = new EducationStateDBAccess().GetListHeir(this.EducationStateID);
		return HeirList;
	}

	public bool AddHeir(Heir heir)
	{
		heir.EducationStateID = this.EducationStateID;
		HeirDBAccess heirDBAccess = new HeirDBAccess();
		if (heirDBAccess.Insert(heir)>0)
			return (true);
		return (false);
	}

}
}
