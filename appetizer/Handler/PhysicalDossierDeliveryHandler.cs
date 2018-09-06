using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class PhysicalDossierDeliveryHandler
{
	// Handle to the PhysicalDossierDelivery DBAccess class
	PhysicalDossierDeliveryDBAccess physicalDossierDeliveryDb = null;

	public PhysicalDossierDeliveryHandler()
	{
		physicalDossierDeliveryDb = new PhysicalDossierDeliveryDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of physicalDossierDeliverys, we can put some logic here if needed 
	public List<PhysicalDossierDelivery> GetListAll()
	{
		return physicalDossierDeliveryDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of physicalDossierDeliverys, we can put some logic here if needed 
	public bool Update(PhysicalDossierDelivery physicalDossierDelivery)
	{
		return physicalDossierDeliveryDb.Update(physicalDossierDelivery);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of physicalDossierDeliverys, we can put some logic here if needed 
	public PhysicalDossierDelivery GetDetails(Int64 physicalDossierDeliveryID)
	{
		return physicalDossierDeliveryDb.GetDetails(physicalDossierDeliveryID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of physicalDossierDeliverys, we can put some logic here if needed 
	public bool Delete(Int64 physicalDossierDeliveryID)
	{
		return physicalDossierDeliveryDb.Delete(physicalDossierDeliveryID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of physicalDossierDeliverys, we can put some logic here if needed 
	public Int64 Insert(PhysicalDossierDelivery physicalDossierDelivery)
	{
		return physicalDossierDeliveryDb.Insert(physicalDossierDelivery);
	}

	public bool Exists(PhysicalDossierDelivery physicalDossierDelivery)
	{
		return physicalDossierDeliveryDb.Exists(physicalDossierDelivery);
	}

	public bool Exists(Int64 physicalDossierDeliveryID)
	{
		return physicalDossierDeliveryDb.Exists(physicalDossierDeliveryID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of physicalDossierDeliverys, we can put some logic here if needed 
	public List<PhysicalDossierDelivery> SearchLike(PhysicalDossierDelivery physicalDossierDelivery)
	{
		return physicalDossierDeliveryDb.SearchLike(physicalDossierDelivery);
	}

}
}
