using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class AnnunciationResultTypeHandler
{
	// Handle to the AnnunciationResultType DBAccess class
	AnnunciationResultTypeDBAccess annunciationResultTypeDb = null;

	public AnnunciationResultTypeHandler()
	{
		annunciationResultTypeDb = new AnnunciationResultTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationResultTypes, we can put some logic here if needed 
	public List<AnnunciationResultType> GetListAll()
	{
		return annunciationResultTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationResultTypes, we can put some logic here if needed 
	public bool Update(AnnunciationResultType annunciationResultType)
	{
		return annunciationResultTypeDb.Update(annunciationResultType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationResultTypes, we can put some logic here if needed 
	public AnnunciationResultType GetDetails(int annunciationResultTypeID)
	{
		return annunciationResultTypeDb.GetDetails(annunciationResultTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationResultTypes, we can put some logic here if needed 
	public bool Delete(int annunciationResultTypeID)
	{
		return annunciationResultTypeDb.Delete(annunciationResultTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationResultTypes, we can put some logic here if needed 
	public Int64 Insert(AnnunciationResultType annunciationResultType)
	{
		return annunciationResultTypeDb.Insert(annunciationResultType);
	}

	public bool Exists(AnnunciationResultType annunciationResultType)
	{
		return annunciationResultTypeDb.Exists(annunciationResultType);
	}

	public bool Exists(int annunciationResultTypeID)
	{
		return annunciationResultTypeDb.Exists(annunciationResultTypeID);
	}

	public List<Annunciation> GetListAnnunciation(int annunciationResultTypeID)
	{
		return annunciationResultTypeDb.GetListAnnunciation(annunciationResultTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationResultTypes, we can put some logic here if needed 
	public List<AnnunciationResultType> SearchLike(AnnunciationResultType annunciationResultType)
	{
		return annunciationResultTypeDb.SearchLike(annunciationResultType);
	}

}
}
