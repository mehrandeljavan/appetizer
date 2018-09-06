using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class RegularAnnunciationReason
{
	private int regularAnnunciationReasonID;
	private string title;
	private List<Annunciation> annunciationList;

	public int RegularAnnunciationReasonID
	{
		get
		{
			return regularAnnunciationReasonID;
		}
		set
		{
			regularAnnunciationReasonID = value;
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
		AnnunciationList = new RegularAnnunciationReasonDBAccess().GetListAnnunciation(this.RegularAnnunciationReasonID);
		return AnnunciationList;
	}

	public bool AddAnnunciation(Annunciation annunciation)
	{
		annunciation.RegularAnnunciationReasonID = this.RegularAnnunciationReasonID;
		AnnunciationDBAccess annunciationDBAccess = new AnnunciationDBAccess();
		if (annunciationDBAccess.Insert(annunciation)>0)
			return (true);
		return (false);
	}

}
}
