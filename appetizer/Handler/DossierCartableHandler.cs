using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class DossierCartableHandler
{
	// Handle to the DossierCartable DBAccess class
	DossierCartableDBAccess dossierCartableDb = null;

	public DossierCartableHandler()
	{
		dossierCartableDb = new DossierCartableDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dossierCartables, we can put some logic here if needed 
	public List<DossierCartable> GetListAll()
	{
		return dossierCartableDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dossierCartables, we can put some logic here if needed 
	public bool Update(DossierCartable dossierCartable)
	{
		return dossierCartableDb.Update(dossierCartable);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dossierCartables, we can put some logic here if needed 
	public DossierCartable GetDetails(Int64 dossierID)
	{
		return dossierCartableDb.GetDetails(dossierID);
	}

	public DossierCartable GetDetails(int fromTaxOffice)
	{
		return dossierCartableDb.GetDetails(fromTaxOffice);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dossierCartables, we can put some logic here if needed 
	public bool Delete(Int64 dossierID)
	{
		return dossierCartableDb.Delete(dossierID);
	}

	public bool Delete(int fromTaxOffice)
	{
		return dossierCartableDb.Delete(fromTaxOffice);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dossierCartables, we can put some logic here if needed 
	public Int64 Insert(DossierCartable dossierCartable)
	{
		return dossierCartableDb.Insert(dossierCartable);
	}

	public bool Exists(DossierCartable dossierCartable)
	{
		return dossierCartableDb.Exists(dossierCartable);
	}

	public bool Exists(Int64 dossierID)
	{
		return dossierCartableDb.Exists(dossierID);
	}

	public List<DossierCartable> GetListByDossierCartableFromTaxOffice(int fromTaxOffice)
	{
		return dossierCartableDb.GetListByDossierCartableFromTaxOffice(fromTaxOffice);
	}

	public List<DossierCartable> GetListByDossierCartableToTaxOffice(int toTaxOffice)
	{
		return dossierCartableDb.GetListByDossierCartableToTaxOffice(toTaxOffice);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dossierCartables, we can put some logic here if needed 
	public List<DossierCartable> SearchLike(DossierCartable dossierCartable)
	{
		return dossierCartableDb.SearchLike(dossierCartable);
	}

}
}
