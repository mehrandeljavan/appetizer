using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class RegularAnnunciationTypeHandler
{
	// Handle to the RegularAnnunciationType DBAccess class
	RegularAnnunciationTypeDBAccess regularAnnunciationTypeDb = null;

	public RegularAnnunciationTypeHandler()
	{
		regularAnnunciationTypeDb = new RegularAnnunciationTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of regularAnnunciationTypes, we can put some logic here if needed 
	public List<RegularAnnunciationType> GetListAll()
	{
		return regularAnnunciationTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of regularAnnunciationTypes, we can put some logic here if needed 
	public bool Update(RegularAnnunciationType regularAnnunciationType)
	{
		return regularAnnunciationTypeDb.Update(regularAnnunciationType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of regularAnnunciationTypes, we can put some logic here if needed 
	public RegularAnnunciationType GetDetails(int regularAnnunciationTypeID)
	{
		return regularAnnunciationTypeDb.GetDetails(regularAnnunciationTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of regularAnnunciationTypes, we can put some logic here if needed 
	public bool Delete(int regularAnnunciationTypeID)
	{
		return regularAnnunciationTypeDb.Delete(regularAnnunciationTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of regularAnnunciationTypes, we can put some logic here if needed 
	public Int64 Insert(RegularAnnunciationType regularAnnunciationType)
	{
		return regularAnnunciationTypeDb.Insert(regularAnnunciationType);
	}

	public bool Exists(RegularAnnunciationType regularAnnunciationType)
	{
		return regularAnnunciationTypeDb.Exists(regularAnnunciationType);
	}

	public bool Exists(int regularAnnunciationTypeID)
	{
		return regularAnnunciationTypeDb.Exists(regularAnnunciationTypeID);
	}

	public List<Annunciation> GetListAnnunciation(int regularAnnunciationTypeID)
	{
		return regularAnnunciationTypeDb.GetListAnnunciation(regularAnnunciationTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of regularAnnunciationTypes, we can put some logic here if needed 
	public List<RegularAnnunciationType> SearchLike(RegularAnnunciationType regularAnnunciationType)
	{
		return regularAnnunciationTypeDb.SearchLike(regularAnnunciationType);
	}

}
}
