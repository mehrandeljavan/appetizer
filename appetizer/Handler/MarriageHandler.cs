using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class MarriageHandler
{
	// Handle to the Marriage DBAccess class
	MarriageDBAccess marriageDb = null;

	public MarriageHandler()
	{
		marriageDb = new MarriageDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of marriages, we can put some logic here if needed 
	public List<Marriage> GetListAll()
	{
		return marriageDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of marriages, we can put some logic here if needed 
	public bool Update(Marriage marriage)
	{
		return marriageDb.Update(marriage);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of marriages, we can put some logic here if needed 
	public Marriage GetDetails(int marriageID)
	{
		return marriageDb.GetDetails(marriageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of marriages, we can put some logic here if needed 
	public bool Delete(int marriageID)
	{
		return marriageDb.Delete(marriageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of marriages, we can put some logic here if needed 
	public Int64 Insert(Marriage marriage)
	{
		return marriageDb.Insert(marriage);
	}

	public bool Exists(Marriage marriage)
	{
		return marriageDb.Exists(marriage);
	}

	public bool Exists(int marriageID)
	{
		return marriageDb.Exists(marriageID);
	}

	public List<Heir> GetListHeir(int marriageID)
	{
		return marriageDb.GetListHeir(marriageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of marriages, we can put some logic here if needed 
	public List<Marriage> SearchLike(Marriage marriage)
	{
		return marriageDb.SearchLike(marriage);
	}

}
}
