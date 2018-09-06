using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Car : Heritage
{
	private Int64 declarationID;
	private Int64? productionUnitID;
	private string title;
	private string plaqueNumber;
	private string color;
	private string motorNumber;
	private string chassisNumber;
	private int productionYear;

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

	public string Title
	{
		get
		{
			return title;
		}
		set
		{
			title = value;
		}
	}

	public string PlaqueNumber
	{
		get
		{
			return plaqueNumber;
		}
		set
		{
			plaqueNumber = value;
		}
	}

	public string Color
	{
		get
		{
			return color;
		}
		set
		{
			color = value;
		}
	}

	public string MotorNumber
	{
		get
		{
			return motorNumber;
		}
		set
		{
			motorNumber = value;
		}
	}

	public string ChassisNumber
	{
		get
		{
			return chassisNumber;
		}
		set
		{
			chassisNumber = value;
		}
	}

	public int ProductionYear
	{
		get
		{
			return productionYear;
		}
		set
		{
			productionYear = value;
		}
	}

}
}
