using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class HeritageHandler
{
	// Handle to the Heritage DBAccess class
	HeritageDBAccess heritageDb = null;

	public HeritageHandler()
	{
		heritageDb = new HeritageDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heritages, we can put some logic here if needed 
	public List<Heritage> GetListAll()
	{
		return heritageDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heritages, we can put some logic here if needed 
	public bool Update(Heritage heritage)
	{
		return heritageDb.Update(heritage);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heritages, we can put some logic here if needed 
	public Heritage GetDetails(Int64 heritageID)
	{
		return heritageDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heritages, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return heritageDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heritages, we can put some logic here if needed 
	public Int64 Insert(Heritage heritage)
	{
		return heritageDb.Insert(heritage);
	}

	public bool Exists(Heritage heritage)
	{
		return heritageDb.Exists(heritage);
	}

	public bool Exists(Int64 heritageID)
	{
		return heritageDb.Exists(heritageID);
	}

	public List<AdjustmentHeritage> GetListAdjustmentHeritage(Int64 heritageID)
	{
		return heritageDb.GetListAdjustmentHeritage(heritageID);
	}

	public List<CommissionAdjustmentHeritage> GetListCommissionAdjustmentHeritage(Int64 heritageID)
	{
		return heritageDb.GetListCommissionAdjustmentHeritage(heritageID);
	}

	public List<PropertyInOtherCountry> GetListPropertyInOtherCountry(Int64 heritageID)
	{
		return heritageDb.GetListPropertyInOtherCountry(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heritages, we can put some logic here if needed 
	public List<Heritage> SearchLike(Heritage heritage)
	{
		return heritageDb.SearchLike(heritage);
	}

}
}
