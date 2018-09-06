using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class PhysicalDossierDelivery
{
	private Int64 physicalDossierDeliveryID;
	private string fromUserFullName;
	private string toUserFullName;
	private string deliveryTypeIDTitle;
	private int? deliveryTypeID;
	private Int64 dossierID;
	private Int64 fromUserNationalCode;
	private Int64 toUserNationalCode;
	private string deliveryDate;
	private string deliveryTime;
	private string description;

	public Int64 PhysicalDossierDeliveryID
	{
		get
		{
			return physicalDossierDeliveryID;
		}
		set
		{
			physicalDossierDeliveryID = value;
		}
	}

	public string FromUserFullName
	{
		get
		{
			return fromUserFullName;
		}
		set
		{
			fromUserFullName = value;
		}
	}

	public string ToUserFullName
	{
		get
		{
			return toUserFullName;
		}
		set
		{
			toUserFullName = value;
		}
	}

	public string DeliveryTypeIDTitle
	{
		get
		{
			return deliveryTypeIDTitle;
		}
		set
		{
			deliveryTypeIDTitle = value;
		}
	}

	public int? DeliveryTypeID
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

	public Int64 DossierID
	{
		get
		{
			return dossierID;
		}
		set
		{
			dossierID = value;
		}
	}

	public Int64 FromUserNationalCode
	{
		get
		{
			return fromUserNationalCode;
		}
		set
		{
			fromUserNationalCode = value;
		}
	}

	public Int64 ToUserNationalCode
	{
		get
		{
			return toUserNationalCode;
		}
		set
		{
			toUserNationalCode = value;
		}
	}

	public string DeliveryDate
	{
		get
		{
			return deliveryDate;
		}
		set
		{
			deliveryDate = value;
		}
	}

	public string DeliveryTime
	{
		get
		{
			return deliveryTime;
		}
		set
		{
			deliveryTime = value;
		}
	}

	public string Description
	{
		get
		{
			return description;
		}
		set
		{
			description = value;
		}
	}

}
}
