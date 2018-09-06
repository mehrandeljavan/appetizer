using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class AnnunciationResultType
{
	private int annunciationResultTypeID;
	private string title;
	private List<Annunciation> annunciationList;

	public int AnnunciationResultTypeID
	{
		get
		{
			return annunciationResultTypeID;
		}
		set
		{
			annunciationResultTypeID = value;
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
		AnnunciationList = new AnnunciationResultTypeDBAccess().GetListAnnunciation(this.AnnunciationResultTypeID);
		return AnnunciationList;
	}

	public bool AddAnnunciation(Annunciation annunciation)
	{
		annunciation.AnnunciationResultTypeID = this.AnnunciationResultTypeID;
		AnnunciationDBAccess annunciationDBAccess = new AnnunciationDBAccess();
		if (annunciationDBAccess.Insert(annunciation)>0)
			return (true);
		return (false);
	}

}
}
