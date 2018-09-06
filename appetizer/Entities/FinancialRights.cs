using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FinancialRights : Heritage
{
	private Int64 declarationID;
	private Int64? productionUnitID;
	private string titleAndDescription;

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

	public string TitleAndDescription
	{
		get
		{
			return titleAndDescription;
		}
		set
		{
			titleAndDescription = value;
		}
	}

}
}
