using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class TransferRight : Heritage
{
	private string transferRightTypeIDTitle;
	private string balconyArea;
	private string balconyHeight;
	private string undergroundArea;
	private string undergroundHeight;
	private string adderss;
	private string registerPart;
	private int? transferRightTypeID;
	private Int64 declarationID;
	private Int64? productionUnitID;
	private string name;
	private string shopArea;
	private string shopHeight;
	private string door;
	private string doorsNumber;
	private string doorNumber;
	private string registerPlague;

	public string TransferRightTypeIDTitle
	{
		get
		{
			return transferRightTypeIDTitle;
		}
		set
		{
			transferRightTypeIDTitle = value;
		}
	}

	public string BalconyArea
	{
		get
		{
			return balconyArea;
		}
		set
		{
			balconyArea = value;
		}
	}

	public string BalconyHeight
	{
		get
		{
			return balconyHeight;
		}
		set
		{
			balconyHeight = value;
		}
	}

	public string UndergroundArea
	{
		get
		{
			return undergroundArea;
		}
		set
		{
			undergroundArea = value;
		}
	}

	public string UndergroundHeight
	{
		get
		{
			return undergroundHeight;
		}
		set
		{
			undergroundHeight = value;
		}
	}

	public string Adderss
	{
		get
		{
			return adderss;
		}
		set
		{
			adderss = value;
		}
	}

	public string RegisterPart
	{
		get
		{
			return registerPart;
		}
		set
		{
			registerPart = value;
		}
	}

	public int? TransferRightTypeID
	{
		get
		{
			return transferRightTypeID;
		}
		set
		{
			transferRightTypeID = value;
		}
	}

	public Int64 DeclarationID
	{
		get
		{
			return declarationID;
		}
		set
		{
			declarationID = value;
		}
	}

	public Int64? ProductionUnitID
	{
		get
		{
			return productionUnitID;
		}
		set
		{
			productionUnitID = value;
		}
	}

	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			name = value;
		}
	}

	public string ShopArea
	{
		get
		{
			return shopArea;
		}
		set
		{
			shopArea = value;
		}
	}

	public string ShopHeight
	{
		get
		{
			return shopHeight;
		}
		set
		{
			shopHeight = value;
		}
	}

	public string Door
	{
		get
		{
			return door;
		}
		set
		{
			door = value;
		}
	}

	public string DoorsNumber
	{
		get
		{
			return doorsNumber;
		}
		set
		{
			doorsNumber = value;
		}
	}

	public string DoorNumber
	{
		get
		{
			return doorNumber;
		}
		set
		{
			doorNumber = value;
		}
	}

	public string RegisterPlague
	{
		get
		{
			return registerPlague;
		}
		set
		{
			registerPlague = value;
		}
	}

}
}
