using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class AdjustmentHeritageHandler
{
	// Handle to the AdjustmentHeritage DBAccess class
	AdjustmentHeritageDBAccess adjustmentHeritageDb = null;

	public AdjustmentHeritageHandler()
	{
		adjustmentHeritageDb = new AdjustmentHeritageDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of adjustmentHeritages, we can put some logic here if needed 
	public List<AdjustmentHeritage> GetListAll()
	{
		return adjustmentHeritageDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of adjustmentHeritages, we can put some logic here if needed 
	public bool Update(AdjustmentHeritage adjustmentHeritage)
	{
		return adjustmentHeritageDb.Update(adjustmentHeritage);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of adjustmentHeritages, we can put some logic here if needed 
	public AdjustmentHeritage GetDetails(Int64 heirID , Int64 heritageID)
	{
		return adjustmentHeritageDb.GetDetails(heirID , heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of adjustmentHeritages, we can put some logic here if needed 
	public bool Delete(Int64 heirID , Int64 heritageID)
	{
		return adjustmentHeritageDb.Delete(heirID , heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of adjustmentHeritages, we can put some logic here if needed 
	public Int64 Insert(AdjustmentHeritage adjustmentHeritage)
	{
		return adjustmentHeritageDb.Insert(adjustmentHeritage);
	}

	public bool Exists(AdjustmentHeritage adjustmentHeritage)
	{
		return adjustmentHeritageDb.Exists(adjustmentHeritage);
	}

	public bool Exists(Int64 heirID , Int64 heritageID)
	{
		return adjustmentHeritageDb.Exists(heirID , heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of adjustmentHeritages, we can put some logic here if needed 
	public List<AdjustmentHeritage> SearchLike(AdjustmentHeritage adjustmentHeritage)
	{
		return adjustmentHeritageDb.SearchLike(adjustmentHeritage);
	}

}
}
