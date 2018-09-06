using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class TaxRatiosHandler
{
	// Handle to the TaxRatios DBAccess class
	TaxRatiosDBAccess taxRatiosDb = null;

	public TaxRatiosHandler()
	{
		taxRatiosDb = new TaxRatiosDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxRatioss, we can put some logic here if needed 
	public List<TaxRatios> GetListAll()
	{
		return taxRatiosDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxRatioss, we can put some logic here if needed 
	public bool Update(TaxRatios taxRatios)
	{
		return taxRatiosDb.Update(taxRatios);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxRatioss, we can put some logic here if needed 
	public TaxRatios GetDetails(int taxRatiiosID)
	{
		return taxRatiosDb.GetDetails(taxRatiiosID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxRatioss, we can put some logic here if needed 
	public bool Delete(int taxRatiiosID)
	{
		return taxRatiosDb.Delete(taxRatiiosID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxRatioss, we can put some logic here if needed 
	public Int64 Insert(TaxRatios taxRatios)
	{
		return taxRatiosDb.Insert(taxRatios);
	}

	public bool Exists(TaxRatios taxRatios)
	{
		return taxRatiosDb.Exists(taxRatios);
	}

	public bool Exists(int taxRatiiosID)
	{
		return taxRatiosDb.Exists(taxRatiiosID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxRatioss, we can put some logic here if needed 
	public List<TaxRatios> SearchLike(TaxRatios taxRatios)
	{
		return taxRatiosDb.SearchLike(taxRatios);
	}

}
}
