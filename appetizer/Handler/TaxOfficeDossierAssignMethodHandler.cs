using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class TaxOfficeDossierAssignMethodHandler
{
	// Handle to the TaxOfficeDossierAssignMethod DBAccess class
	TaxOfficeDossierAssignMethodDBAccess taxOfficeDossierAssignMethodDb = null;

	public TaxOfficeDossierAssignMethodHandler()
	{
		taxOfficeDossierAssignMethodDb = new TaxOfficeDossierAssignMethodDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxOfficeDossierAssignMethods, we can put some logic here if needed 
	public List<TaxOfficeDossierAssignMethod> GetListAll()
	{
		return taxOfficeDossierAssignMethodDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxOfficeDossierAssignMethods, we can put some logic here if needed 
	public bool Update(TaxOfficeDossierAssignMethod taxOfficeDossierAssignMethod)
	{
		return taxOfficeDossierAssignMethodDb.Update(taxOfficeDossierAssignMethod);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxOfficeDossierAssignMethods, we can put some logic here if needed 
	public TaxOfficeDossierAssignMethod GetDetails(int taxOfficeDossierAssignMethodID)
	{
		return taxOfficeDossierAssignMethodDb.GetDetails(taxOfficeDossierAssignMethodID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxOfficeDossierAssignMethods, we can put some logic here if needed 
	public bool Delete(int taxOfficeDossierAssignMethodID)
	{
		return taxOfficeDossierAssignMethodDb.Delete(taxOfficeDossierAssignMethodID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxOfficeDossierAssignMethods, we can put some logic here if needed 
	public Int64 Insert(TaxOfficeDossierAssignMethod taxOfficeDossierAssignMethod)
	{
		return taxOfficeDossierAssignMethodDb.Insert(taxOfficeDossierAssignMethod);
	}

	public bool Exists(TaxOfficeDossierAssignMethod taxOfficeDossierAssignMethod)
	{
		return taxOfficeDossierAssignMethodDb.Exists(taxOfficeDossierAssignMethod);
	}

	public bool Exists(int taxOfficeDossierAssignMethodID)
	{
		return taxOfficeDossierAssignMethodDb.Exists(taxOfficeDossierAssignMethodID);
	}

	public List<TaxOffice> GetListTaxOffice(int taxOfficeDossierAssignMethodID)
	{
		return taxOfficeDossierAssignMethodDb.GetListTaxOffice(taxOfficeDossierAssignMethodID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxOfficeDossierAssignMethods, we can put some logic here if needed 
	public List<TaxOfficeDossierAssignMethod> SearchLike(TaxOfficeDossierAssignMethod taxOfficeDossierAssignMethod)
	{
		return taxOfficeDossierAssignMethodDb.SearchLike(taxOfficeDossierAssignMethod);
	}

}
}
