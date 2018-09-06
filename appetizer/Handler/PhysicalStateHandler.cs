using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class PhysicalStateHandler
{
	// Handle to the PhysicalState DBAccess class
	PhysicalStateDBAccess physicalStateDb = null;

	public PhysicalStateHandler()
	{
		physicalStateDb = new PhysicalStateDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of physicalStates, we can put some logic here if needed 
	public List<PhysicalState> GetListAll()
	{
		return physicalStateDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of physicalStates, we can put some logic here if needed 
	public bool Update(PhysicalState physicalState)
	{
		return physicalStateDb.Update(physicalState);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of physicalStates, we can put some logic here if needed 
	public PhysicalState GetDetails(int physicalStateID)
	{
		return physicalStateDb.GetDetails(physicalStateID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of physicalStates, we can put some logic here if needed 
	public bool Delete(int physicalStateID)
	{
		return physicalStateDb.Delete(physicalStateID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of physicalStates, we can put some logic here if needed 
	public Int64 Insert(PhysicalState physicalState)
	{
		return physicalStateDb.Insert(physicalState);
	}

	public bool Exists(PhysicalState physicalState)
	{
		return physicalStateDb.Exists(physicalState);
	}

	public bool Exists(int physicalStateID)
	{
		return physicalStateDb.Exists(physicalStateID);
	}

	public List<Heir> GetListHeir(int physicalStateID)
	{
		return physicalStateDb.GetListHeir(physicalStateID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of physicalStates, we can put some logic here if needed 
	public List<PhysicalState> SearchLike(PhysicalState physicalState)
	{
		return physicalStateDb.SearchLike(physicalState);
	}

}
}
