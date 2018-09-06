using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class AnnunciationHandler
{
	// Handle to the Annunciation DBAccess class
	AnnunciationDBAccess annunciationDb = null;

	public AnnunciationHandler()
	{
		annunciationDb = new AnnunciationDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciations, we can put some logic here if needed 
	public List<Annunciation> GetListAll()
	{
		return annunciationDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciations, we can put some logic here if needed 
	public bool Update(Annunciation annunciation)
	{
		return annunciationDb.Update(annunciation);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciations, we can put some logic here if needed 
	public Annunciation GetDetails(int annunciationPaperTypeID , Int64 heirID)
	{
		return annunciationDb.GetDetails(annunciationPaperTypeID , heirID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciations, we can put some logic here if needed 
	public bool Delete(int annunciationPaperTypeID , Int64 heirID)
	{
		return annunciationDb.Delete(annunciationPaperTypeID , heirID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciations, we can put some logic here if needed 
	public Int64 Insert(Annunciation annunciation)
	{
		return annunciationDb.Insert(annunciation);
	}

	public bool Exists(Annunciation annunciation)
	{
		return annunciationDb.Exists(annunciation);
	}

	public bool Exists(int annunciationPaperTypeID , Int64 heirID)
	{
		return annunciationDb.Exists(annunciationPaperTypeID , heirID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of annunciations, we can put some logic here if needed 
	public List<Annunciation> SearchLike(Annunciation annunciation)
	{
		return annunciationDb.SearchLike(annunciation);
	}

}
}
