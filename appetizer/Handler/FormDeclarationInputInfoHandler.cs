using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormDeclarationInputInfoHandler
{
	// Handle to the FormDeclarationInputInfo DBAccess class
	FormDeclarationInputInfoDBAccess formDeclarationInputInfoDb = null;

	public FormDeclarationInputInfoHandler()
	{
		formDeclarationInputInfoDb = new FormDeclarationInputInfoDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeclarationInputInfos, we can put some logic here if needed 
	public List<FormDeclarationInputInfo> GetListAll()
	{
		return formDeclarationInputInfoDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeclarationInputInfos, we can put some logic here if needed 
	public bool Update(FormDeclarationInputInfo formDeclarationInputInfo)
	{
		return formDeclarationInputInfoDb.Update(formDeclarationInputInfo);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeclarationInputInfos, we can put some logic here if needed 
	public FormDeclarationInputInfo GetDetails(Int64 formDeclarationInputInfoID)
	{
		return formDeclarationInputInfoDb.GetDetails(formDeclarationInputInfoID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeclarationInputInfos, we can put some logic here if needed 
	public bool Delete(Int64 formDeclarationInputInfoID)
	{
		return formDeclarationInputInfoDb.Delete(formDeclarationInputInfoID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeclarationInputInfos, we can put some logic here if needed 
	public Int64 Insert(FormDeclarationInputInfo formDeclarationInputInfo)
	{
		return formDeclarationInputInfoDb.Insert(formDeclarationInputInfo);
	}

	public bool Exists(FormDeclarationInputInfo formDeclarationInputInfo)
	{
		return formDeclarationInputInfoDb.Exists(formDeclarationInputInfo);
	}

	public bool Exists(Int64 formDeclarationInputInfoID)
	{
		return formDeclarationInputInfoDb.Exists(formDeclarationInputInfoID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeclarationInputInfos, we can put some logic here if needed 
	public List<FormDeclarationInputInfo> SearchLike(FormDeclarationInputInfo formDeclarationInputInfo)
	{
		return formDeclarationInputInfoDb.SearchLike(formDeclarationInputInfo);
	}

}
}
