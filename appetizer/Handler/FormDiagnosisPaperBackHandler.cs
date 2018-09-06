using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormDiagnosisPaperBackHandler
{
	// Handle to the FormDiagnosisPaperBack DBAccess class
	FormDiagnosisPaperBackDBAccess formDiagnosisPaperBackDb = null;

	public FormDiagnosisPaperBackHandler()
	{
		formDiagnosisPaperBackDb = new FormDiagnosisPaperBackDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisPaperBacks, we can put some logic here if needed 
	public List<FormDiagnosisPaperBack> GetListAll()
	{
		return formDiagnosisPaperBackDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisPaperBacks, we can put some logic here if needed 
	public bool Update(FormDiagnosisPaperBack formDiagnosisPaperBack)
	{
		return formDiagnosisPaperBackDb.Update(formDiagnosisPaperBack);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisPaperBacks, we can put some logic here if needed 
	public FormDiagnosisPaperBack GetDetails(Int64 formDiagnosisPaperBackID)
	{
		return formDiagnosisPaperBackDb.GetDetails(formDiagnosisPaperBackID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisPaperBacks, we can put some logic here if needed 
	public bool Delete(Int64 formDiagnosisPaperBackID)
	{
		return formDiagnosisPaperBackDb.Delete(formDiagnosisPaperBackID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisPaperBacks, we can put some logic here if needed 
	public Int64 Insert(FormDiagnosisPaperBack formDiagnosisPaperBack)
	{
		return formDiagnosisPaperBackDb.Insert(formDiagnosisPaperBack);
	}

	public bool Exists(FormDiagnosisPaperBack formDiagnosisPaperBack)
	{
		return formDiagnosisPaperBackDb.Exists(formDiagnosisPaperBack);
	}

	public bool Exists(Int64 formDiagnosisPaperBackID)
	{
		return formDiagnosisPaperBackDb.Exists(formDiagnosisPaperBackID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisPaperBacks, we can put some logic here if needed 
	public List<FormDiagnosisPaperBack> SearchLike(FormDiagnosisPaperBack formDiagnosisPaperBack)
	{
		return formDiagnosisPaperBackDb.SearchLike(formDiagnosisPaperBack);
	}

}
}
