using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class AnnunciationToOthersReasonHandler
{
	// Handle to the AnnunciationToOthersReason DBAccess class
	AnnunciationToOthersReasonDBAccess annunciationToOthersReasonDb = null;

	public AnnunciationToOthersReasonHandler()
	{
		annunciationToOthersReasonDb = new AnnunciationToOthersReasonDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationToOthersReasons, we can put some logic here if needed 
	public List<AnnunciationToOthersReason> GetListAll()
	{
		return annunciationToOthersReasonDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationToOthersReasons, we can put some logic here if needed 
	public bool Update(AnnunciationToOthersReason annunciationToOthersReason)
	{
		return annunciationToOthersReasonDb.Update(annunciationToOthersReason);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationToOthersReasons, we can put some logic here if needed 
	public AnnunciationToOthersReason GetDetails(int annunciationToOthersReasonID)
	{
		return annunciationToOthersReasonDb.GetDetails(annunciationToOthersReasonID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationToOthersReasons, we can put some logic here if needed 
	public bool Delete(int annunciationToOthersReasonID)
	{
		return annunciationToOthersReasonDb.Delete(annunciationToOthersReasonID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationToOthersReasons, we can put some logic here if needed 
	public Int64 Insert(AnnunciationToOthersReason annunciationToOthersReason)
	{
		return annunciationToOthersReasonDb.Insert(annunciationToOthersReason);
	}

	public bool Exists(AnnunciationToOthersReason annunciationToOthersReason)
	{
		return annunciationToOthersReasonDb.Exists(annunciationToOthersReason);
	}

	public bool Exists(int annunciationToOthersReasonID)
	{
		return annunciationToOthersReasonDb.Exists(annunciationToOthersReasonID);
	}

	public List<Annunciation> GetListAnnunciation(int annunciationToOthersReasonID)
	{
		return annunciationToOthersReasonDb.GetListAnnunciation(annunciationToOthersReasonID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationToOthersReasons, we can put some logic here if needed 
	public List<AnnunciationToOthersReason> SearchLike(AnnunciationToOthersReason annunciationToOthersReason)
	{
		return annunciationToOthersReasonDb.SearchLike(annunciationToOthersReason);
	}

}
}
