using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Jewel : Heritage
{
	private string name;
	private string weight;
	private string factorNumber;
	private string place;
	private int? number;
	private Int64 declarationID;

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

	public string Weight
	{
		get
		{
			return weight;
		}
		set
		{
			weight = value;
		}
	}

	public string FactorNumber
	{
		get
		{
			return factorNumber;
		}
		set
		{
			factorNumber = value;
		}
	}

	public string Place
	{
		get
		{
			return place;
		}
		set
		{
			place = value;
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

}
}
