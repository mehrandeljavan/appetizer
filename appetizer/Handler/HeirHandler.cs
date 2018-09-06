using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class HeirHandler
{
	// Handle to the Heir DBAccess class
	HeirDBAccess heirDb = null;

	public HeirHandler()
	{
		heirDb = new HeirDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heirs, we can put some logic here if needed 
	public List<Heir> GetListAll()
	{
		return heirDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heirs, we can put some logic here if needed 
	public bool Update(Heir heir)
	{
		return heirDb.Update(heir);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heirs, we can put some logic here if needed 
	public Heir GetDetails(Int64 heirID)
	{
		return heirDb.GetDetails(heirID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heirs, we can put some logic here if needed 
	public bool Delete(Int64 heirID)
	{
		return heirDb.Delete(heirID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heirs, we can put some logic here if needed 
	public Int64 Insert(Heir heir)
	{
		return heirDb.Insert(heir);
	}

	public bool Exists(Heir heir)
	{
		return heirDb.Exists(heir);
	}

	public bool Exists(Int64 heirID)
	{
		return heirDb.Exists(heirID);
	}

	public List<AdjustmentHeritage> GetListAdjustmentHeritage(Int64 heirID)
	{
		return heirDb.GetListAdjustmentHeritage(heirID);
	}

	public List<Annunciation> GetListAnnunciation(Int64 heirID)
	{
		return heirDb.GetListAnnunciation(heirID);
	}

	public List<CommissionAdjustmentHeritage> GetListCommissionAdjustmentHeritage(Int64 heirID)
	{
		return heirDb.GetListCommissionAdjustmentHeritage(heirID);
	}

	public List<CommissionInvitation> GetListCommissionInvitation(Int64 heirID)
	{
		return heirDb.GetListCommissionInvitation(heirID);
	}

	public List<CommissionVerdict> GetListCommissionVerdict(Int64 heirID)
	{
		return heirDb.GetListCommissionVerdict(heirID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heirs, we can put some logic here if needed 
	public List<Heir> SearchLike(Heir heir)
	{
		return heirDb.SearchLike(heir);
	}

}
}
