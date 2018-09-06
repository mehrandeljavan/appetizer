using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class WillTypeHandler
{
	// Handle to the WillType DBAccess class
	WillTypeDBAccess willTypeDb = null;

	public WillTypeHandler()
	{
		willTypeDb = new WillTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of willTypes, we can put some logic here if needed 
	public List<WillType> GetListAll()
	{
		return willTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of willTypes, we can put some logic here if needed 
	public bool Update(WillType willType)
	{
		return willTypeDb.Update(willType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of willTypes, we can put some logic here if needed 
	public WillType GetDetails(int willTypeID)
	{
		return willTypeDb.GetDetails(willTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of willTypes, we can put some logic here if needed 
	public bool Delete(int willTypeID)
	{
		return willTypeDb.Delete(willTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of willTypes, we can put some logic here if needed 
	public Int64 Insert(WillType willType)
	{
		return willTypeDb.Insert(willType);
	}

	public bool Exists(WillType willType)
	{
		return willTypeDb.Exists(willType);
	}

	public bool Exists(int willTypeID)
	{
		return willTypeDb.Exists(willTypeID);
	}

	public List<Will> GetListWill(int willTypeID)
	{
		return willTypeDb.GetListWill(willTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of willTypes, we can put some logic here if needed 
	public List<WillType> SearchLike(WillType willType)
	{
		return willTypeDb.SearchLike(willType);
	}

}
}
