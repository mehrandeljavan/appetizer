using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Heritage
{
	private Int64 heritageID;
	private string stageTitle;
	private string registerDate;
	private string oldRegisterDate;
	private string oldRegisterInformationID;
	private string sixth;
	private string previousOwner;
	private string comment;
	private Int64? registerInformationID;
	private Int64? adjustmentID;
	private Int64? commissionAdjustmentID;
	private int stage;
	private int userOrder;
	private float? value1;
	private float? value2;
	private float? value3;
	private bool deadIsOwner;
	private bool? isDiagonesed;
	private List<AdjustmentHeritage> adjustmentHeritageList;
	private List<CommissionAdjustmentHeritage> commissionAdjustmentHeritageList;
	private List<PropertyInOtherCountry> propertyInOtherCountryList;

	public Int64 HeritageID
	{
		get
		{
			return heritageID;
		}
		set
		{
			heritageID = value;
		}
	}

	public string StageTitle
	{
		get
		{
			return stageTitle;
		}
		set
		{
			stageTitle = value;
		}
	}

	public string RegisterDate
	{
		get
		{
			return registerDate;
		}
		set
		{
			registerDate = value;
		}
	}

	public string OldRegisterDate
	{
		get
		{
			return oldRegisterDate;
		}
		set
		{
			oldRegisterDate = value;
		}
	}

	public string OldRegisterInformationID
	{
		get
		{
			return oldRegisterInformationID;
		}
		set
		{
			oldRegisterInformationID = value;
		}
	}

	public string Sixth
	{
		get
		{
			return sixth;
		}
		set
		{
			sixth = value;
		}
	}

	public string PreviousOwner
	{
		get
		{
			return previousOwner;
		}
		set
		{
			previousOwner = value;
		}
	}

	public string Comment
	{
		get
		{
			return comment;
		}
		set
		{
			comment = value;
		}
	}

	public Int64? RegisterInformationID
	{
		get
		{
			return registerInformationID;
		}
		set
		{
			registerInformationID = value;
		}
	}

	public Int64? AdjustmentID
	{
		get
		{
			return adjustmentID;
		}
		set
		{
			adjustmentID = value;
		}
	}

	public Int64? CommissionAdjustmentID
	{
		get
		{
			return commissionAdjustmentID;
		}
		set
		{
			commissionAdjustmentID = value;
		}
	}

	public int Stage
	{
		get
		{
			return stage;
		}
		set
		{
			stage = value;
		}
	}

	public int UserOrder
	{
		get
		{
			return userOrder;
		}
		set
		{
			userOrder = value;
		}
	}

	public float? Value1
	{
		get
		{
			return value1;
		}
		set
		{
			value1 = value;
		}
	}

	public float? Value2
	{
		get
		{
			return value2;
		}
		set
		{
			value2 = value;
		}
	}

	public float? Value3
	{
		get
		{
			return value3;
		}
		set
		{
			value3 = value;
		}
	}

	public bool DeadIsOwner
	{
		get
		{
			return deadIsOwner;
		}
		set
		{
			deadIsOwner = value;
		}
	}

	public bool? IsDiagonesed
	{
		get
		{
			return isDiagonesed;
		}
		set
		{
			isDiagonesed = value;
		}
	}

	public List<AdjustmentHeritage> AdjustmentHeritageList
	{
		get
		{
			return adjustmentHeritageList;
		}
		set
		{
			adjustmentHeritageList = value;
		}
	}

	public List<CommissionAdjustmentHeritage> CommissionAdjustmentHeritageList
	{
		get
		{
			return commissionAdjustmentHeritageList;
		}
		set
		{
			commissionAdjustmentHeritageList = value;
		}
	}

	public List<PropertyInOtherCountry> PropertyInOtherCountryList
	{
		get
		{
			return propertyInOtherCountryList;
		}
		set
		{
			propertyInOtherCountryList = value;
		}
	}

	public List<AdjustmentHeritage> GetListAdjustmentHeritage()
	{
		AdjustmentHeritageList = new HeritageDBAccess().GetListAdjustmentHeritage(this.HeritageID);
		return AdjustmentHeritageList;
	}

	public List<CommissionAdjustmentHeritage> GetListCommissionAdjustmentHeritage()
	{
		CommissionAdjustmentHeritageList = new HeritageDBAccess().GetListCommissionAdjustmentHeritage(this.HeritageID);
		return CommissionAdjustmentHeritageList;
	}

	public List<PropertyInOtherCountry> GetListPropertyInOtherCountry()
	{
		PropertyInOtherCountryList = new HeritageDBAccess().GetListPropertyInOtherCountry(this.HeritageID);
		return PropertyInOtherCountryList;
	}

	public bool AddAdjustmentHeritage(AdjustmentHeritage adjustmentHeritage)
	{
		adjustmentHeritage.HeritageID = this.HeritageID;
		AdjustmentHeritageDBAccess adjustmentHeritageDBAccess = new AdjustmentHeritageDBAccess();
		if (adjustmentHeritageDBAccess.Insert(adjustmentHeritage)>0)
			return (true);
		return (false);
	}

	public bool AddCommissionAdjustmentHeritage(CommissionAdjustmentHeritage commissionAdjustmentHeritage)
	{
		commissionAdjustmentHeritage.HeritageID = this.HeritageID;
		CommissionAdjustmentHeritageDBAccess commissionAdjustmentHeritageDBAccess = new CommissionAdjustmentHeritageDBAccess();
		if (commissionAdjustmentHeritageDBAccess.Insert(commissionAdjustmentHeritage)>0)
			return (true);
		return (false);
	}

	public bool AddPropertyInOtherCountry(PropertyInOtherCountry propertyInOtherCountry)
	{
		propertyInOtherCountry.HeritageID = this.HeritageID;
		PropertyInOtherCountryDBAccess propertyInOtherCountryDBAccess = new PropertyInOtherCountryDBAccess();
		if (propertyInOtherCountryDBAccess.Insert(propertyInOtherCountry)>0)
			return (true);
		return (false);
	}

}
}
