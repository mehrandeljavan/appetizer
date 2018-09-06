using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Score : Heritage
{
	private string scoreTypeIDTitle;
	private int? scoreTypeID;
	private int? number;
	private Int64 declarationID;
	private Int64? productionUnitID;
	private string licenseDate;
	private string name;
	private string proofReference;
	private string licenseNo;
	private string address;
	private string partialPlaque;
	private string registerScope;
	private string area;
	private string balcony;
	private string baseMent;

	public string ScoreTypeIDTitle
	{
		get
		{
			return scoreTypeIDTitle;
		}
		set
		{
			scoreTypeIDTitle = value;
		}
	}

	public int? ScoreTypeID
	{
		get
		{
			return scoreTypeID;
		}
		set
		{
			scoreTypeID = value;
		}
	}

	public int? Number
	{
		get
		{
			return number;
		}
		set
		{
			number = value;
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

	public string LicenseDate
	{
		get
		{
			return licenseDate;
		}
		set
		{
			licenseDate = value;
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

	public string ProofReference
	{
		get
		{
			return proofReference;
		}
		set
		{
			proofReference = value;
		}
	}

	public string LicenseNo
	{
		get
		{
			return licenseNo;
		}
		set
		{
			licenseNo = value;
		}
	}

	public string Address
	{
		get
		{
			return address;
		}
		set
		{
			address = value;
		}
	}

	public string PartialPlaque
	{
		get
		{
			return partialPlaque;
		}
		set
		{
			partialPlaque = value;
		}
	}

	public string RegisterScope
	{
		get
		{
			return registerScope;
		}
		set
		{
			registerScope = value;
		}
	}

	public string Area
	{
		get
		{
			return area;
		}
		set
		{
			area = value;
		}
	}

	public string Balcony
	{
		get
		{
			return balcony;
		}
		set
		{
			balcony = value;
		}
	}

	public string BaseMent
	{
		get
		{
			return baseMent;
		}
		set
		{
			baseMent = value;
		}
	}

}
}
