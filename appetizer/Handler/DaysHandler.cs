using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class DaysHandler
{
	// Handle to the Days DBAccess class
	DaysDBAccess daysDb = null;

	public DaysHandler()
	{
		daysDb = new DaysDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dayss, we can put some logic here if needed 
	public List<Days> GetListAll()
	{
		return daysDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dayss, we can put some logic here if needed 
	public bool Update(Days days)
	{
		return daysDb.Update(days);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dayss, we can put some logic here if needed 
	public Days GetDetails(int dayID)
	{
		return daysDb.GetDetails(dayID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dayss, we can put some logic here if needed 
	public bool Delete(int dayID)
	{
		return daysDb.Delete(dayID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dayss, we can put some logic here if needed 
	public Int64 Insert(Days days)
	{
		return daysDb.Insert(days);
	}

	public bool Exists(Days days)
	{
		return daysDb.Exists(days);
	}

	public bool Exists(int dayID)
	{
		return daysDb.Exists(dayID);
	}

	public List<CommissionInvitation> GetListCommissionInvitation(int dayID)
	{
		return daysDb.GetListCommissionInvitation(dayID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dayss, we can put some logic here if needed 
	public List<Days> SearchLike(Days days)
	{
		return daysDb.SearchLike(days);
	}

}
}
