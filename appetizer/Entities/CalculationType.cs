using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class CalculationType
{
	private int calculationTypeID;
	private string title;

	public int CalculationTypeID
	{
		get
		{
			return calculationTypeID;
		}
		set
		{
			calculationTypeID = value;
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

}
}
