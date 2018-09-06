using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class TaxOfficeHandler
{
	// Handle to the TaxOffice DBAccess class
	TaxOfficeDBAccess taxOfficeDb = null;

	public TaxOfficeHandler()
	{
		taxOfficeDb = new TaxOfficeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxOffices, we can put some logic here if needed 
	public List<TaxOffice> GetListAll()
	{
		return taxOfficeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxOffices, we can put some logic here if needed 
	public bool Update(TaxOffice taxOffice)
	{
		return taxOfficeDb.Update(taxOffice);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxOffices, we can put some logic here if needed 
	public TaxOffice GetDetails(int taxOfficeCode)
	{
		return taxOfficeDb.GetDetails(taxOfficeCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxOffices, we can put some logic here if needed 
	public bool Delete(int taxOfficeCode)
	{
		return taxOfficeDb.Delete(taxOfficeCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxOffices, we can put some logic here if needed 
	public Int64 Insert(TaxOffice taxOffice)
	{
		return taxOfficeDb.Insert(taxOffice);
	}

	public bool Exists(TaxOffice taxOffice)
	{
		return taxOfficeDb.Exists(taxOffice);
	}

	public bool Exists(int taxOfficeCode)
	{
		return taxOfficeDb.Exists(taxOfficeCode);
	}

	public List<Dossier> GetListDossier(int taxOfficeCode)
	{
		return taxOfficeDb.GetListDossier(taxOfficeCode);
	}

	public List<UserTaxOfficeActivityRolePart> GetListUserTaxOfficeActivityRolePart(int taxOfficeCode)
	{
		return taxOfficeDb.GetListUserTaxOfficeActivityRolePart(taxOfficeCode);
	}

	public List<UserTaxOfficeRolePart> GetListUserTaxOfficeRolePart(int taxOfficeCode)
	{
		return taxOfficeDb.GetListUserTaxOfficeRolePart(taxOfficeCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of taxOffices, we can put some logic here if needed 
	public List<TaxOffice> SearchLike(TaxOffice taxOffice)
	{
		return taxOfficeDb.SearchLike(taxOffice);
	}

}
}
