using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormDiagnosisResultHandler
{
	// Handle to the FormDiagnosisResult DBAccess class
	FormDiagnosisResultDBAccess formDiagnosisResultDb = null;

	public FormDiagnosisResultHandler()
	{
		formDiagnosisResultDb = new FormDiagnosisResultDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisResults, we can put some logic here if needed 
	public List<FormDiagnosisResult> GetListAll()
	{
		return formDiagnosisResultDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisResults, we can put some logic here if needed 
	public bool Update(FormDiagnosisResult formDiagnosisResult)
	{
		return formDiagnosisResultDb.Update(formDiagnosisResult);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisResults, we can put some logic here if needed 
	public FormDiagnosisResult GetDetails(Int64 formDiagnosisResultID)
	{
		return formDiagnosisResultDb.GetDetails(formDiagnosisResultID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisResults, we can put some logic here if needed 
	public bool Delete(Int64 formDiagnosisResultID)
	{
		return formDiagnosisResultDb.Delete(formDiagnosisResultID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisResults, we can put some logic here if needed 
	public Int64 Insert(FormDiagnosisResult formDiagnosisResult)
	{
		return formDiagnosisResultDb.Insert(formDiagnosisResult);
	}

	public bool Exists(FormDiagnosisResult formDiagnosisResult)
	{
		return formDiagnosisResultDb.Exists(formDiagnosisResult);
	}

	public bool Exists(Int64 formDiagnosisResultID)
	{
		return formDiagnosisResultDb.Exists(formDiagnosisResultID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisResults, we can put some logic here if needed 
	public List<FormDiagnosisResult> SearchLike(FormDiagnosisResult formDiagnosisResult)
	{
		return formDiagnosisResultDb.SearchLike(formDiagnosisResult);
	}

}
}
