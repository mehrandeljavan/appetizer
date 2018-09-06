using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Demands : Heritage
{
	private string demandDocumentIDTitle;
	private string demandsTypeIDTitle;
	private int? demandsTypeID;
	private int? demandDocumentID;
	private Int64 declarationID;
	private Int64? productionUnitID;
	private string debtorName;
	private string documentNumber;

	public string DemandDocumentIDTitle
	{
		get
		{
			return demandDocumentIDTitle;
		}
		set
		{
			demandDocumentIDTitle = value;
		}
	}

	public string DemandsTypeIDTitle
	{
		get
		{
			return demandsTypeIDTitle;
		}
		set
		{
			demandsTypeIDTitle = value;
		}
	}

	public int? DemandsTypeID
	{
		get
		{
			return demandsTypeID;
		}
		set
		{
			demandsTypeID = value;
		}
	}

	public int? DemandDocumentID
	{
		get
		{
			return demandDocumentID;
		}
		set
		{
			demandDocumentID = value;
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

	public string DebtorName
	{
		get
		{
			return debtorName;
		}
		set
		{
			debtorName = value;
		}
	}

	public string DocumentNumber
	{
		get
		{
			return documentNumber;
		}
		set
		{
			documentNumber = value;
		}
	}

}
}
