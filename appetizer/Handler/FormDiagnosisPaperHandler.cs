using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormDiagnosisPaperHandler
{
	// Handle to the FormDiagnosisPaper DBAccess class
	FormDiagnosisPaperDBAccess formDiagnosisPaperDb = null;

	public FormDiagnosisPaperHandler()
	{
		formDiagnosisPaperDb = new FormDiagnosisPaperDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisPapers, we can put some logic here if needed 
	public List<FormDiagnosisPaper> GetListAll()
	{
		return formDiagnosisPaperDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisPapers, we can put some logic here if needed 
	public bool Update(FormDiagnosisPaper formDiagnosisPaper)
	{
		return formDiagnosisPaperDb.Update(formDiagnosisPaper);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisPapers, we can put some logic here if needed 
	public FormDiagnosisPaper GetDetails(Int64 formDiagnosisPaperID)
	{
		return formDiagnosisPaperDb.GetDetails(formDiagnosisPaperID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisPapers, we can put some logic here if needed 
	public bool Delete(Int64 formDiagnosisPaperID)
	{
		return formDiagnosisPaperDb.Delete(formDiagnosisPaperID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisPapers, we can put some logic here if needed 
	public Int64 Insert(FormDiagnosisPaper formDiagnosisPaper)
	{
		return formDiagnosisPaperDb.Insert(formDiagnosisPaper);
	}

	public bool Exists(FormDiagnosisPaper formDiagnosisPaper)
	{
		return formDiagnosisPaperDb.Exists(formDiagnosisPaper);
	}

	public bool Exists(Int64 formDiagnosisPaperID)
	{
		return formDiagnosisPaperDb.Exists(formDiagnosisPaperID);
	}

	public List<FormDiagnosisPaperBack> GetListFormDiagnosisPaperBack(Int64 formDiagnosisPaperID)
	{
		return formDiagnosisPaperDb.GetListFormDiagnosisPaperBack(formDiagnosisPaperID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDiagnosisPapers, we can put some logic here if needed 
	public List<FormDiagnosisPaper> SearchLike(FormDiagnosisPaper formDiagnosisPaper)
	{
		return formDiagnosisPaperDb.SearchLike(formDiagnosisPaper);
	}

}
}
