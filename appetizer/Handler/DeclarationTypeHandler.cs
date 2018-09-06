using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class DeclarationTypeHandler
{
	// Handle to the DeclarationType DBAccess class
	DeclarationTypeDBAccess declarationTypeDb = null;

	public DeclarationTypeHandler()
	{
		declarationTypeDb = new DeclarationTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of declarationTypes, we can put some logic here if needed 
	public List<DeclarationType> GetListAll()
	{
		return declarationTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of declarationTypes, we can put some logic here if needed 
	public bool Update(DeclarationType declarationType)
	{
		return declarationTypeDb.Update(declarationType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of declarationTypes, we can put some logic here if needed 
	public DeclarationType GetDetails(int declarationTypeID)
	{
		return declarationTypeDb.GetDetails(declarationTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of declarationTypes, we can put some logic here if needed 
	public bool Delete(int declarationTypeID)
	{
		return declarationTypeDb.Delete(declarationTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of declarationTypes, we can put some logic here if needed 
	public Int64 Insert(DeclarationType declarationType)
	{
		return declarationTypeDb.Insert(declarationType);
	}

	public bool Exists(DeclarationType declarationType)
	{
		return declarationTypeDb.Exists(declarationType);
	}

	public bool Exists(int declarationTypeID)
	{
		return declarationTypeDb.Exists(declarationTypeID);
	}

	public List<Declaration> GetListDeclaration(int declarationTypeID)
	{
		return declarationTypeDb.GetListDeclaration(declarationTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of declarationTypes, we can put some logic here if needed 
	public List<DeclarationType> SearchLike(DeclarationType declarationType)
	{
		return declarationTypeDb.SearchLike(declarationType);
	}

}
}
