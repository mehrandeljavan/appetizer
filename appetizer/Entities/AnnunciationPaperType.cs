using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class AnnunciationPaperType
{
	private int annunciationPaperTypeID;
	private string title;
	private List<Annunciation> annunciationList;

	public int AnnunciationPaperTypeID
	{
		get
		{
			return annunciationPaperTypeID;
		}
		set
		{
			annunciationPaperTypeID = value;
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
		AnnunciationList = new AnnunciationPaperTypeDBAccess().GetListAnnunciation(this.AnnunciationPaperTypeID);
		return AnnunciationList;
	}

	public bool AddAnnunciation(Annunciation annunciation)
	{
		annunciation.AnnunciationPaperTypeID = this.AnnunciationPaperTypeID;
		AnnunciationDBAccess annunciationDBAccess = new AnnunciationDBAccess();
		if (annunciationDBAccess.Insert(annunciation)>0)
			return (true);
		return (false);
	}

}
}
