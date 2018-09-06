using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Cost : Heritage
{
	private string costTypeIDTitle;
	private string costTitle;
	private int? costTypeID;
	private Int64 declarationID;

	public string CostTypeIDTitle
	{
		get
		{
			return costTypeIDTitle;
		}
		set
		{
			costTypeIDTitle = value;
		}
	}

	public string CostTitle
	{
		get
		{
			return costTitle;
		}
		set
		{
			costTitle = value;
		}
	}

	public int? CostTypeID
	{
		get
		{
			return costTypeID;
		}
		set
		{
			costTypeID = value;
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
