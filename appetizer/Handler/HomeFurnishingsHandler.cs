using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class HomeFurnishingsHandler
{
	// Handle to the HomeFurnishings DBAccess class
	HomeFurnishingsDBAccess homeFurnishingsDb = null;

	public HomeFurnishingsHandler()
	{
		homeFurnishingsDb = new HomeFurnishingsDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of homeFurnishingss, we can put some logic here if needed 
	public List<HomeFurnishings> GetListAll()
	{
		return homeFurnishingsDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of homeFurnishingss, we can put some logic here if needed 
	public bool Update(HomeFurnishings homeFurnishings)
	{
		return homeFurnishingsDb.Update(homeFurnishings);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of homeFurnishingss, we can put some logic here if needed 
	public HomeFurnishings GetDetails(Int64 heritageID)
	{
		return homeFurnishingsDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of homeFurnishingss, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return homeFurnishingsDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of homeFurnishingss, we can put some logic here if needed 
	public Int64 Insert(HomeFurnishings homeFurnishings)
	{
		return homeFurnishingsDb.Insert(homeFurnishings);
	}

	public bool Exists(HomeFurnishings homeFurnishings)
	{
		return homeFurnishingsDb.Exists(homeFurnishings);
	}

	public bool Exists(Int64 heritageID)
	{
		return homeFurnishingsDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of homeFurnishingss, we can put some logic here if needed 
	public List<HomeFurnishings> SearchLike(HomeFurnishings homeFurnishings)
	{
		return homeFurnishingsDb.SearchLike(homeFurnishings);
	}

}
}
