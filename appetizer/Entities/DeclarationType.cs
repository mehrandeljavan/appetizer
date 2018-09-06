using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class DeclarationType
{
	private int declarationTypeID;
	private string title;
	private List<Declaration> declarationList;

	public int DeclarationTypeID
	{
		get
		{
			return declarationTypeID;
		}
		set
		{
			declarationTypeID = value;
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

	public List<Declaration> DeclarationList
	{
		get
		{
			return declarationList;
		}
		set
		{
			declarationList = value;
		}
	}

	public List<Declaration> GetListDeclaration()
	{
		DeclarationList = new DeclarationTypeDBAccess().GetListDeclaration(this.DeclarationTypeID);
		return DeclarationList;
	}

	public bool AddDeclaration(Declaration declaration)
	{
		declaration.DeclarationTypeID = this.DeclarationTypeID;
		DeclarationDBAccess declarationDBAccess = new DeclarationDBAccess();
		if (declarationDBAccess.Insert(declaration)>0)
			return (true);
		return (false);
	}

}
}
