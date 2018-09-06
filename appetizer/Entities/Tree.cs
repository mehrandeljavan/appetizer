using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Tree : Heritage
{
	private Int64? productionUnitID;
	private string treeType;
	private string registerPlaque;
	private string docNumber;
	private string section;
	private int treeNumber;
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

	public string TreeType
	{
		get
		{
			return treeType;
		}
		set
		{
			treeType = value;
		}
	}

	public string RegisterPlaque
	{
		get
		{
			return registerPlaque;
		}
		set
		{
			registerPlaque = value;
		}
	}

	public string DocNumber
	{
		get
		{
			return docNumber;
		}
		set
		{
			docNumber = value;
		}
	}

	public string Section
	{
		get
		{
			return section;
		}
		set
		{
			section = value;
		}
	}

	public int TreeNumber
	{
		get
		{
			return treeNumber;
		}
		set
		{
			treeNumber = value;
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
