using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Well : Heritage
{
	private string wellTypeIDTitle;
	private int? wellTypeID;
	private Int64 declarationID;
	private Int64? productionUnitID;
	private string plaque;
	private string scope;
	private string docNo;

	public string WellTypeIDTitle
	{
		get
		{
			return wellTypeIDTitle;
		}
		set
		{
			wellTypeIDTitle = value;
		}
	}

	public int? WellTypeID
	{
		get
		{
			return wellTypeID;
		}
		set
		{
			wellTypeID = value;
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

	public string Plaque
	{
		get
		{
			return plaque;
		}
		set
		{
			plaque = value;
		}
	}

	public string Scope
	{
		get
		{
			return scope;
		}
		set
		{
			scope = value;
		}
	}

	public string DocNo
	{
		get
		{
			return docNo;
		}
		set
		{
			docNo = value;
		}
	}

}
}
