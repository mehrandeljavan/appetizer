using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class AnnunciationToType
{
	private int annunciationToTypeID;
	private string title;
	private List<Annunciation> annunciationList;

	public int AnnunciationToTypeID
	{
		get
		{
			return annunciationToTypeID;
		}
		set
		{
			annunciationToTypeID = value;
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
		AnnunciationList = new AnnunciationToTypeDBAccess().GetListAnnunciation(this.AnnunciationToTypeID);
		return AnnunciationList;
	}

	public bool AddAnnunciation(Annunciation annunciation)
	{
		annunciation.AnnunciationToTypeID = this.AnnunciationToTypeID;
		AnnunciationDBAccess annunciationDBAccess = new AnnunciationDBAccess();
		if (annunciationDBAccess.Insert(annunciation)>0)
			return (true);
		return (false);
	}

}
}
