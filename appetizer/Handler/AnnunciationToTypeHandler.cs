using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class AnnunciationToTypeHandler
{
	// Handle to the AnnunciationToType DBAccess class
	AnnunciationToTypeDBAccess annunciationToTypeDb = null;

	public AnnunciationToTypeHandler()
	{
		annunciationToTypeDb = new AnnunciationToTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationToTypes, we can put some logic here if needed 
	public List<AnnunciationToType> GetListAll()
	{
		return annunciationToTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationToTypes, we can put some logic here if needed 
	public bool Update(AnnunciationToType annunciationToType)
	{
		return annunciationToTypeDb.Update(annunciationToType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationToTypes, we can put some logic here if needed 
	public AnnunciationToType GetDetails(int annunciationToTypeID)
	{
		return annunciationToTypeDb.GetDetails(annunciationToTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationToTypes, we can put some logic here if needed 
	public bool Delete(int annunciationToTypeID)
	{
		return annunciationToTypeDb.Delete(annunciationToTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationToTypes, we can put some logic here if needed 
	public Int64 Insert(AnnunciationToType annunciationToType)
	{
		return annunciationToTypeDb.Insert(annunciationToType);
	}

	public bool Exists(AnnunciationToType annunciationToType)
	{
		return annunciationToTypeDb.Exists(annunciationToType);
	}

	public bool Exists(int annunciationToTypeID)
	{
		return annunciationToTypeDb.Exists(annunciationToTypeID);
	}

	public List<Annunciation> GetListAnnunciation(int annunciationToTypeID)
	{
		return annunciationToTypeDb.GetListAnnunciation(annunciationToTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationToTypes, we can put some logic here if needed 
	public List<AnnunciationToType> SearchLike(AnnunciationToType annunciationToType)
	{
		return annunciationToTypeDb.SearchLike(annunciationToType);
	}

}
}
