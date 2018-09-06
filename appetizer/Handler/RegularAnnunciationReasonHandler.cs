using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class RegularAnnunciationReasonHandler
{
	// Handle to the RegularAnnunciationReason DBAccess class
	RegularAnnunciationReasonDBAccess regularAnnunciationReasonDb = null;

	public RegularAnnunciationReasonHandler()
	{
		regularAnnunciationReasonDb = new RegularAnnunciationReasonDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of regularAnnunciationReasons, we can put some logic here if needed 
	public List<RegularAnnunciationReason> GetListAll()
	{
		return regularAnnunciationReasonDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of regularAnnunciationReasons, we can put some logic here if needed 
	public bool Update(RegularAnnunciationReason regularAnnunciationReason)
	{
		return regularAnnunciationReasonDb.Update(regularAnnunciationReason);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of regularAnnunciationReasons, we can put some logic here if needed 
	public RegularAnnunciationReason GetDetails(int regularAnnunciationReasonID)
	{
		return regularAnnunciationReasonDb.GetDetails(regularAnnunciationReasonID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of regularAnnunciationReasons, we can put some logic here if needed 
	public bool Delete(int regularAnnunciationReasonID)
	{
		return regularAnnunciationReasonDb.Delete(regularAnnunciationReasonID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of regularAnnunciationReasons, we can put some logic here if needed 
	public Int64 Insert(RegularAnnunciationReason regularAnnunciationReason)
	{
		return regularAnnunciationReasonDb.Insert(regularAnnunciationReason);
	}

	public bool Exists(RegularAnnunciationReason regularAnnunciationReason)
	{
		return regularAnnunciationReasonDb.Exists(regularAnnunciationReason);
	}

	public bool Exists(int regularAnnunciationReasonID)
	{
		return regularAnnunciationReasonDb.Exists(regularAnnunciationReasonID);
	}

	public List<Annunciation> GetListAnnunciation(int regularAnnunciationReasonID)
	{
		return regularAnnunciationReasonDb.GetListAnnunciation(regularAnnunciationReasonID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of regularAnnunciationReasons, we can put some logic here if needed 
	public List<RegularAnnunciationReason> SearchLike(RegularAnnunciationReason regularAnnunciationReason)
	{
		return regularAnnunciationReasonDb.SearchLike(regularAnnunciationReason);
	}

}
}
