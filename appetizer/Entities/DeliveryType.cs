using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class DeliveryType
{
	private int deliveryTypeID;
	private string title;
	private List<PhysicalDossierDelivery> physicalDossierDeliveryList;

	public int DeliveryTypeID
	{
		get
		{
			return deliveryTypeID;
		}
		set
		{
			deliveryTypeID = value;
		}
	}

	public string Title
	{
		get
		{
			return title;
		}
		set
		{
			title = value;
		}
	}

	public List<PhysicalDossierDelivery> PhysicalDossierDeliveryList
	{
		get
		{
			return physicalDossierDeliveryList;
		}
		set
		{
			physicalDossierDeliveryList = value;
		}
	}

	public List<PhysicalDossierDelivery> GetListPhysicalDossierDelivery()
	{
		PhysicalDossierDeliveryList = new DeliveryTypeDBAccess().GetListPhysicalDossierDelivery(this.DeliveryTypeID);
		return PhysicalDossierDeliveryList;
	}

	public bool AddPhysicalDossierDelivery(PhysicalDossierDelivery physicalDossierDelivery)
	{
		physicalDossierDelivery.DeliveryTypeID = this.DeliveryTypeID;
		PhysicalDossierDeliveryDBAccess physicalDossierDeliveryDBAccess = new PhysicalDossierDeliveryDBAccess();
		if (physicalDossierDeliveryDBAccess.Insert(physicalDossierDelivery)>0)
			return (true);
		return (false);
	}

}
}
