using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class UttererRole
{
	private int uttererRoleID;
	private string title;
	private List<Utterer> uttererList;

	public int UttererRoleID
	{
		get
		{
			return uttererRoleID;
		}
		set
		{
			uttererRoleID = value;
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

	public List<Utterer> UttererList
	{
		get
		{
			return uttererList;
		}
		set
		{
			uttererList = value;
		}
	}

	public List<Utterer> GetListUtterer()
	{
		UttererList = new UttererRoleDBAccess().GetListUtterer(this.UttererRoleID);
		return UttererList;
	}

	public bool AddUtterer(Utterer utterer)
	{
		utterer.UttererRoleID = this.UttererRoleID;
		UttererDBAccess uttererDBAccess = new UttererDBAccess();
		if (uttererDBAccess.Insert(utterer)>0)
			return (true);
		return (false);
	}

}
}
