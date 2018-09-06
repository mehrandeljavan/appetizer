using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class DeliveryTypeHandler
{
	// Handle to the DeliveryType DBAccess class
	DeliveryTypeDBAccess deliveryTypeDb = null;

	public DeliveryTypeHandler()
	{
		deliveryTypeDb = new DeliveryTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of deliveryTypes, we can put some logic here if needed 
	public List<DeliveryType> GetListAll()
	{
		return deliveryTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of deliveryTypes, we can put some logic here if needed 
	public bool Update(DeliveryType deliveryType)
	{
		return deliveryTypeDb.Update(deliveryType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of deliveryTypes, we can put some logic here if needed 
	public DeliveryType GetDetails(int deliveryTypeID)
	{
		return deliveryTypeDb.GetDetails(deliveryTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of deliveryTypes, we can put some logic here if needed 
	public bool Delete(int deliveryTypeID)
	{
		return deliveryTypeDb.Delete(deliveryTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of deliveryTypes, we can put some logic here if needed 
	public Int64 Insert(DeliveryType deliveryType)
	{
		return deliveryTypeDb.Insert(deliveryType);
	}

	public bool Exists(DeliveryType deliveryType)
	{
		return deliveryTypeDb.Exists(deliveryType);
	}

	public bool Exists(int deliveryTypeID)
	{
		return deliveryTypeDb.Exists(deliveryTypeID);
	}

	public List<PhysicalDossierDelivery> GetListPhysicalDossierDelivery(int deliveryTypeID)
	{
		return deliveryTypeDb.GetListPhysicalDossierDelivery(deliveryTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of deliveryTypes, we can put some logic here if needed 
	public List<DeliveryType> SearchLike(DeliveryType deliveryType)
	{
		return deliveryTypeDb.SearchLike(deliveryType);
	}

}
}
