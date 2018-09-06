using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class EstateHandler
{
	// Handle to the Estate DBAccess class
	EstateDBAccess estateDb = null;

	public EstateHandler()
	{
		estateDb = new EstateDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of estates, we can put some logic here if needed 
	public List<Estate> GetListAll()
	{
		return estateDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of estates, we can put some logic here if needed 
	public bool Update(Estate estate)
	{
		return estateDb.Update(estate);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of estates, we can put some logic here if needed 
	public Estate GetDetails(Int64 heritageID)
	{
		return estateDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of estates, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return estateDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of estates, we can put some logic here if needed 
	public Int64 Insert(Estate estate)
	{
		return estateDb.Insert(estate);
	}

	public bool Exists(Estate estate)
	{
		return estateDb.Exists(estate);
	}

	public bool Exists(Int64 heritageID)
	{
		return estateDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of estates, we can put some logic here if needed 
	public List<Estate> SearchLike(Estate estate)
	{
		return estateDb.SearchLike(estate);
	}

}
}
