using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class AnnunciationPlaceHandler
{
	// Handle to the AnnunciationPlace DBAccess class
	AnnunciationPlaceDBAccess annunciationPlaceDb = null;

	public AnnunciationPlaceHandler()
	{
		annunciationPlaceDb = new AnnunciationPlaceDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationPlaces, we can put some logic here if needed 
	public List<AnnunciationPlace> GetListAll()
	{
		return annunciationPlaceDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationPlaces, we can put some logic here if needed 
	public bool Update(AnnunciationPlace annunciationPlace)
	{
		return annunciationPlaceDb.Update(annunciationPlace);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationPlaces, we can put some logic here if needed 
	public AnnunciationPlace GetDetails(int annunciationPlaceID)
	{
		return annunciationPlaceDb.GetDetails(annunciationPlaceID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationPlaces, we can put some logic here if needed 
	public bool Delete(int annunciationPlaceID)
	{
		return annunciationPlaceDb.Delete(annunciationPlaceID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationPlaces, we can put some logic here if needed 
	public Int64 Insert(AnnunciationPlace annunciationPlace)
	{
		return annunciationPlaceDb.Insert(annunciationPlace);
	}

	public bool Exists(AnnunciationPlace annunciationPlace)
	{
		return annunciationPlaceDb.Exists(annunciationPlace);
	}

	public bool Exists(int annunciationPlaceID)
	{
		return annunciationPlaceDb.Exists(annunciationPlaceID);
	}

	public List<Annunciation> GetListAnnunciation(int annunciationPlaceID)
	{
		return annunciationPlaceDb.GetListAnnunciation(annunciationPlaceID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationPlaces, we can put some logic here if needed 
	public List<AnnunciationPlace> SearchLike(AnnunciationPlace annunciationPlace)
	{
		return annunciationPlaceDb.SearchLike(annunciationPlace);
	}

}
}
