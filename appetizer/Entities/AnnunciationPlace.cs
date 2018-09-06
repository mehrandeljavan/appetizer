using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class AnnunciationPlace
{
	private int annunciationPlaceID;
	private int category;
	private string title;
	private List<Annunciation> annunciationList;

	public int AnnunciationPlaceID
	{
		get
		{
			return annunciationPlaceID;
		}
		set
		{
			annunciationPlaceID = value;
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
		AnnunciationList = new AnnunciationPlaceDBAccess().GetListAnnunciation(this.AnnunciationPlaceID);
		return AnnunciationList;
	}

	public bool AddAnnunciation(Annunciation annunciation)
	{
		annunciation.AnnunciationPlaceID = this.AnnunciationPlaceID;
		AnnunciationDBAccess annunciationDBAccess = new AnnunciationDBAccess();
		if (annunciationDBAccess.Insert(annunciation)>0)
			return (true);
		return (false);
	}

}
}
