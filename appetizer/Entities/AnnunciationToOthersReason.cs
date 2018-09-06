using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class AnnunciationToOthersReason
{
	private int annunciationToOthersReasonID;
	private string title;
	private List<Annunciation> annunciationList;

	public int AnnunciationToOthersReasonID
	{
		get
		{
			return annunciationToOthersReasonID;
		}
		set
		{
			annunciationToOthersReasonID = value;
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
		AnnunciationList = new AnnunciationToOthersReasonDBAccess().GetListAnnunciation(this.AnnunciationToOthersReasonID);
		return AnnunciationList;
	}

	public bool AddAnnunciation(Annunciation annunciation)
	{
		annunciation.AnnunciationToOthersReasonID = this.AnnunciationToOthersReasonID;
		AnnunciationDBAccess annunciationDBAccess = new AnnunciationDBAccess();
		if (annunciationDBAccess.Insert(annunciation)>0)
			return (true);
		return (false);
	}

}
}
