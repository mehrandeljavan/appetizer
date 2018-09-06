using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class JewelHandler
{
	// Handle to the Jewel DBAccess class
	JewelDBAccess jewelDb = null;

	public JewelHandler()
	{
		jewelDb = new JewelDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of jewels, we can put some logic here if needed 
	public List<Jewel> GetListAll()
	{
		return jewelDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of jewels, we can put some logic here if needed 
	public bool Update(Jewel jewel)
	{
		return jewelDb.Update(jewel);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of jewels, we can put some logic here if needed 
	public Jewel GetDetails(Int64 heritageID)
	{
		return jewelDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of jewels, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return jewelDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of jewels, we can put some logic here if needed 
	public Int64 Insert(Jewel jewel)
	{
		return jewelDb.Insert(jewel);
	}

	public bool Exists(Jewel jewel)
	{
		return jewelDb.Exists(jewel);
	}

	public bool Exists(Int64 heritageID)
	{
		return jewelDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of jewels, we can put some logic here if needed 
	public List<Jewel> SearchLike(Jewel jewel)
	{
		return jewelDb.SearchLike(jewel);
	}

}
}
