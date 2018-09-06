using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormHeritagesDescriptionsHandler
{
	// Handle to the FormHeritagesDescriptions DBAccess class
	FormHeritagesDescriptionsDBAccess formHeritagesDescriptionsDb = null;

	public FormHeritagesDescriptionsHandler()
	{
		formHeritagesDescriptionsDb = new FormHeritagesDescriptionsDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritagesDescriptionss, we can put some logic here if needed 
	public List<FormHeritagesDescriptions> GetListAll()
	{
		return formHeritagesDescriptionsDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritagesDescriptionss, we can put some logic here if needed 
	public bool Update(FormHeritagesDescriptions formHeritagesDescriptions)
	{
		return formHeritagesDescriptionsDb.Update(formHeritagesDescriptions);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritagesDescriptionss, we can put some logic here if needed 
	public FormHeritagesDescriptions GetDetails(Int64 formHeritagesDescriptionsID)
	{
		return formHeritagesDescriptionsDb.GetDetails(formHeritagesDescriptionsID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritagesDescriptionss, we can put some logic here if needed 
	public bool Delete(Int64 formHeritagesDescriptionsID)
	{
		return formHeritagesDescriptionsDb.Delete(formHeritagesDescriptionsID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritagesDescriptionss, we can put some logic here if needed 
	public Int64 Insert(FormHeritagesDescriptions formHeritagesDescriptions)
	{
		return formHeritagesDescriptionsDb.Insert(formHeritagesDescriptions);
	}

	public bool Exists(FormHeritagesDescriptions formHeritagesDescriptions)
	{
		return formHeritagesDescriptionsDb.Exists(formHeritagesDescriptions);
	}

	public bool Exists(Int64 formHeritagesDescriptionsID)
	{
		return formHeritagesDescriptionsDb.Exists(formHeritagesDescriptionsID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritagesDescriptionss, we can put some logic here if needed 
	public List<FormHeritagesDescriptions> SearchLike(FormHeritagesDescriptions formHeritagesDescriptions)
	{
		return formHeritagesDescriptionsDb.SearchLike(formHeritagesDescriptions);
	}

}
}
