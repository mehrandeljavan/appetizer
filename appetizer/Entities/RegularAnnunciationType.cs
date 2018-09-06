using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class RegularAnnunciationType
{
	private int regularAnnunciationTypeID;
	private int category;
	private string title;
	private List<Annunciation> annunciationList;

	public int RegularAnnunciationTypeID
	{
		get
		{
			return regularAnnunciationTypeID;
		}
		set
		{
			regularAnnunciationTypeID = value;
		}
	}

	public int Category
	{
		get
		{
			return category;
		}
		set
		{
			category = value;
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

	public List<Annunciation> AnnunciationList
	{
		get
		{
			return annunciationList;
		}
		set
		{
			annunciationList = value;
		}
	}

	public List<Annunciation> GetListAnnunciation()
	{
		AnnunciationList = new RegularAnnunciationTypeDBAccess().GetListAnnunciation(this.RegularAnnunciationTypeID);
		return AnnunciationList;
	}

	public bool AddAnnunciation(Annunciation annunciation)
	{
		annunciation.RegularAnnunciationTypeID = this.RegularAnnunciationTypeID;
		AnnunciationDBAccess annunciationDBAccess = new AnnunciationDBAccess();
		if (annunciationDBAccess.Insert(annunciation)>0)
			return (true);
		return (false);
	}

}
}
