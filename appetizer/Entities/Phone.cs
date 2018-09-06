using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Phone : Heritage
{
	private Int64 declarationID;
	private Int64? productionUnitID;
	private string number;
	private string city;
	private bool? type;

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

	public string City
	{
		get
		{
			return city;
		}
		set
		{
			city = value;
		}
	}

	public bool? Type
	{
		get
		{
			return type;
		}
		set
		{
			type = value;
		}
	}

}
}
