using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class TaxRatios
{
	private int taxRatiiosID;
	private int? orderNumber;
	private float exemptionPercentLevel1;
	private float exemptionPercentLevel2;
	private float exemptionPercentLevel3;
	private Int64 valueUpperBound;
	private string rangeStartDate;
	private string rangeEndDate;

	public int TaxRatiiosID
	{
		get
		{
			return taxRatiiosID;
		}
		set
		{
			taxRatiiosID = value;
		}
	}

	public int? OrderNumber
	{
		get
		{
			return orderNumber;
		}
		set
		{
			orderNumber = value;
		}
	}

	public float ExemptionPercentLevel1
	{
		get
		{
			return exemptionPercentLevel1;
		}
		set
		{
			exemptionPercentLevel1 = value;
		}
	}

	public float ExemptionPercentLevel2
	{
		get
		{
			return exemptionPercentLevel2;
		}
		set
		{
			exemptionPercentLevel2 = value;
		}
	}

	public float ExemptionPercentLevel3
	{
		get
		{
			return exemptionPercentLevel3;
		}
		set
		{
			exemptionPercentLevel3 = value;
		}
	}

	public Int64 ValueUpperBound
	{
		get
		{
			return valueUpperBound;
		}
		set
		{
			valueUpperBound = value;
		}
	}

	public string RangeStartDate
	{
		get
		{
			return rangeStartDate;
		}
		set
		{
			rangeStartDate = value;
		}
	}

	public string RangeEndDate
	{
		get
		{
			return rangeEndDate;
		}
		set
		{
			rangeEndDate = value;
		}
	}

}
}
