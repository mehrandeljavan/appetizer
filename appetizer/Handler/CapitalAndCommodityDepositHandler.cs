using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class CapitalAndCommodityDepositHandler
{
	// Handle to the CapitalAndCommodityDeposit DBAccess class
	CapitalAndCommodityDepositDBAccess capitalAndCommodityDepositDb = null;

	public CapitalAndCommodityDepositHandler()
	{
		capitalAndCommodityDepositDb = new CapitalAndCommodityDepositDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of capitalAndCommodityDeposits, we can put some logic here if needed 
	public List<CapitalAndCommodityDeposit> GetListAll()
	{
		return capitalAndCommodityDepositDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of capitalAndCommodityDeposits, we can put some logic here if needed 
	public bool Update(CapitalAndCommodityDeposit capitalAndCommodityDeposit)
	{
		return capitalAndCommodityDepositDb.Update(capitalAndCommodityDeposit);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of capitalAndCommodityDeposits, we can put some logic here if needed 
	public CapitalAndCommodityDeposit GetDetails(Int64 heritageID)
	{
		return capitalAndCommodityDepositDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of capitalAndCommodityDeposits, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return capitalAndCommodityDepositDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of capitalAndCommodityDeposits, we can put some logic here if needed 
	public Int64 Insert(CapitalAndCommodityDeposit capitalAndCommodityDeposit)
	{
		return capitalAndCommodityDepositDb.Insert(capitalAndCommodityDeposit);
	}

	public bool Exists(CapitalAndCommodityDeposit capitalAndCommodityDeposit)
	{
		return capitalAndCommodityDepositDb.Exists(capitalAndCommodityDeposit);
	}

	public bool Exists(Int64 heritageID)
	{
		return capitalAndCommodityDepositDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of capitalAndCommodityDeposits, we can put some logic here if needed 
	public List<CapitalAndCommodityDeposit> SearchLike(CapitalAndCommodityDeposit capitalAndCommodityDeposit)
	{
		return capitalAndCommodityDepositDb.SearchLike(capitalAndCommodityDeposit);
	}

}
}
