using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Estate : Heritage
{
	private string estateTypeIDTitle;
	private string independentOf;
	private string inquiryTo;
	private Int64? productionUnitID;
	private string mainPlaqueNumber;
	private string subPlaqueNumber;
	private string sectionPlaqueNumber;
	private string registerState;
	private int? estateTypeID;
	private int? water;
	private int? electric;
	private int? gass;
	private int? wastewater;
	private float goodwillValue;
	private float? area1;
	private float? area2;
	private Int64 declarationID;

	public string EstateTypeIDTitle
	{
		get
		{
			return estateTypeIDTitle;
		}
		set
		{
			estateTypeIDTitle = value;
		}
	}

	public string IndependentOf
	{
		get
		{
			return independentOf;
		}
		set
		{
			independentOf = value;
		}
	}

	public string InquiryTo
	{
		get
		{
			return inquiryTo;
		}
		set
		{
			inquiryTo = value;
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

	public string MainPlaqueNumber
	{
		get
		{
			return mainPlaqueNumber;
		}
		set
		{
			mainPlaqueNumber = value;
		}
	}

	public string SubPlaqueNumber
	{
		get
		{
			return subPlaqueNumber;
		}
		set
		{
			subPlaqueNumber = value;
		}
	}

	public string SectionPlaqueNumber
	{
		get
		{
			return sectionPlaqueNumber;
		}
		set
		{
			sectionPlaqueNumber = value;
		}
	}

	public string RegisterState
	{
		get
		{
			return registerState;
		}
		set
		{
			registerState = value;
		}
	}

	public int? EstateTypeID
	{
		get
		{
			return estateTypeID;
		}
		set
		{
			estateTypeID = value;
		}
	}

	public int? Water
	{
		get
		{
			return water;
		}
		set
		{
			water = value;
		}
	}

	public int? Electric
	{
		get
		{
			return electric;
		}
		set
		{
			electric = value;
		}
	}

	public int? Gass
	{
		get
		{
			return gass;
		}
		set
		{
			gass = value;
		}
	}

	public int? Wastewater
	{
		get
		{
			return wastewater;
		}
		set
		{
			wastewater = value;
		}
	}

	public float GoodwillValue
	{
		get
		{
			return goodwillValue;
		}
		set
		{
			goodwillValue = value;
		}
	}

	public float? Area1
	{
		get
		{
			return area1;
		}
		set
		{
			area1 = value;
		}
	}

	public float? Area2
	{
		get
		{
			return area2;
		}
		set
		{
			area2 = value;
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

}
}
