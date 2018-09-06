using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class AdjustmentHeritage
{
	private Int64 heirID;
	private Int64 heritageID;
	private string oldRegisterInformationID;
	private string oldRegisterDate;
	private Int64? registerInformationID;
	private float? adjustmentValue1;
	private float? adjustmentValue2;

	public Int64 HeirID
	{
		get
		{
			return heirID;
		}
		set
		{
			heirID = value;
		}
	}

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

	public float? AdjustmentValue1
	{
		get
		{
			return adjustmentValue1;
		}
		set
		{
			adjustmentValue1 = value;
		}
	}

	public float? AdjustmentValue2
	{
		get
		{
			return adjustmentValue2;
		}
		set
		{
			adjustmentValue2 = value;
		}
	}

}
}
