using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Machinery : Heritage
{
	private Int64? productionUnitID;
	private string name;
	private string year;
	private string country;
	private string usage;
	private string number;
	private Int64 declarationID;

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

	public string Year
	{
		get
		{
			return year;
		}
		set
		{
			year = value;
		}
	}

	public string Country
	{
		get
		{
			return country;
		}
		set
		{
			country = value;
		}
	}

	public string Usage
	{
		get
		{
			return usage;
		}
		set
		{
			usage = value;
		}
	}

	public string Number
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
