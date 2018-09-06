using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class AnnunciationPaperTypeHandler
{
	// Handle to the AnnunciationPaperType DBAccess class
	AnnunciationPaperTypeDBAccess annunciationPaperTypeDb = null;

	public AnnunciationPaperTypeHandler()
	{
		annunciationPaperTypeDb = new AnnunciationPaperTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationPaperTypes, we can put some logic here if needed 
	public List<AnnunciationPaperType> GetListAll()
	{
		return annunciationPaperTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationPaperTypes, we can put some logic here if needed 
	public bool Update(AnnunciationPaperType annunciationPaperType)
	{
		return annunciationPaperTypeDb.Update(annunciationPaperType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationPaperTypes, we can put some logic here if needed 
	public AnnunciationPaperType GetDetails(int annunciationPaperTypeID)
	{
		return annunciationPaperTypeDb.GetDetails(annunciationPaperTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationPaperTypes, we can put some logic here if needed 
	public bool Delete(int annunciationPaperTypeID)
	{
		return annunciationPaperTypeDb.Delete(annunciationPaperTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationPaperTypes, we can put some logic here if needed 
	public Int64 Insert(AnnunciationPaperType annunciationPaperType)
	{
		return annunciationPaperTypeDb.Insert(annunciationPaperType);
	}

	public bool Exists(AnnunciationPaperType annunciationPaperType)
	{
		return annunciationPaperTypeDb.Exists(annunciationPaperType);
	}

	public bool Exists(int annunciationPaperTypeID)
	{
		return annunciationPaperTypeDb.Exists(annunciationPaperTypeID);
	}

	public List<Annunciation> GetListAnnunciation(int annunciationPaperTypeID)
	{
		return annunciationPaperTypeDb.GetListAnnunciation(annunciationPaperTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciationPaperTypes, we can put some logic here if needed 
	public List<AnnunciationPaperType> SearchLike(AnnunciationPaperType annunciationPaperType)
	{
		return annunciationPaperTypeDb.SearchLike(annunciationPaperType);
	}

}
}
