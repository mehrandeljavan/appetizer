using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class DossierHandler
{
	// Handle to the Dossier DBAccess class
	DossierDBAccess dossierDb = null;

	public DossierHandler()
	{
		dossierDb = new DossierDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dossiers, we can put some logic here if needed 
	public List<Dossier> GetListAll()
	{
		return dossierDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dossiers, we can put some logic here if needed 
	public bool Update(Dossier dossier)
	{
		return dossierDb.Update(dossier);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dossiers, we can put some logic here if needed 
	public Dossier GetDetails(Int64 dossierID)
	{
		return dossierDb.GetDetails(dossierID);
	}

	public Dossier GetDetails(int taxOfficeCode)
	{
		return dossierDb.GetDetails(taxOfficeCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dossiers, we can put some logic here if needed 
	public bool Delete(Int64 dossierID)
	{
		return dossierDb.Delete(dossierID);
	}

	public bool Delete(int taxOfficeCode)
	{
		return dossierDb.Delete(taxOfficeCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dossiers, we can put some logic here if needed 
	public Int64 Insert(Dossier dossier)
	{
		return dossierDb.Insert(dossier);
	}

	public bool Exists(Dossier dossier)
	{
		return dossierDb.Exists(dossier);
	}

	public bool Exists(Int64 dossierID)
	{
		return dossierDb.Exists(dossierID);
	}

	public List<Dossier> GetListByDossierTaxOfficeCode(int taxOfficeCode)
	{
		return dossierDb.GetListByDossierTaxOfficeCode(taxOfficeCode);
	}

	public List<Dead> GetListDead(Int64 dossierID)
	{
		return dossierDb.GetListDead(dossierID);
	}

	public List<Declaration> GetListDeclaration(Int64 dossierID)
	{
		return dossierDb.GetListDeclaration(dossierID);
	}

	public List<DossierCartable> GetListDossierCartable(Int64 dossierID)
	{
		return dossierDb.GetListDossierCartable(dossierID);
	}

	public List<Payment> GetListPayment(Int64 dossierID)
	{
		return dossierDb.GetListPayment(dossierID);
	}

	public List<PhysicalDossierDelivery> GetListPhysicalDossierDelivery(Int64 dossierID)
	{
		return dossierDb.GetListPhysicalDossierDelivery(dossierID);
	}

	public List<Reports> GetListReports(Int64 dossierID)
	{
		return dossierDb.GetListReports(dossierID);
	}

	public List<UserDossier> GetListUserDossier(Int64 dossierID)
	{
		return dossierDb.GetListUserDossier(dossierID);
	}

	public List<Utterer> GetListUtterer(Int64 dossierID)
	{
		return dossierDb.GetListUtterer(dossierID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dossiers, we can put some logic here if needed 
	public List<Dossier> SearchLike(Dossier dossier)
	{
		return dossierDb.SearchLike(dossier);
	}

}
}
