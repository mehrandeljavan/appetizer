using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class PropertyInOtherCountry
{
	private Int64 heritageID;
	private string name;
	private string hostCountry;
	private float payedTaxInHostCountry;

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

	public string HostCountry
	{
		get
		{
			return hostCountry;
		}
		set
		{
			hostCountry = value;
		}
	}

	public float PayedTaxInHostCountry
	{
		get
		{
			return payedTaxInHostCountry;
		}
		set
		{
			payedTaxInHostCountry = value;
		}
	}

}
}
