using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormDeterministicPaperHandler
{
	// Handle to the FormDeterministicPaper DBAccess class
	FormDeterministicPaperDBAccess formDeterministicPaperDb = null;

	public FormDeterministicPaperHandler()
	{
		formDeterministicPaperDb = new FormDeterministicPaperDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeterministicPapers, we can put some logic here if needed 
	public List<FormDeterministicPaper> GetListAll()
	{
		return formDeterministicPaperDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeterministicPapers, we can put some logic here if needed 
	public bool Update(FormDeterministicPaper formDeterministicPaper)
	{
		return formDeterministicPaperDb.Update(formDeterministicPaper);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeterministicPapers, we can put some logic here if needed 
	public FormDeterministicPaper GetDetails(Int64 formDeterministicPaperID)
	{
		return formDeterministicPaperDb.GetDetails(formDeterministicPaperID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeterministicPapers, we can put some logic here if needed 
	public bool Delete(Int64 formDeterministicPaperID)
	{
		return formDeterministicPaperDb.Delete(formDeterministicPaperID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeterministicPapers, we can put some logic here if needed 
	public Int64 Insert(FormDeterministicPaper formDeterministicPaper)
	{
		return formDeterministicPaperDb.Insert(formDeterministicPaper);
	}

	public bool Exists(FormDeterministicPaper formDeterministicPaper)
	{
		return formDeterministicPaperDb.Exists(formDeterministicPaper);
	}

	public bool Exists(Int64 formDeterministicPaperID)
	{
		return formDeterministicPaperDb.Exists(formDeterministicPaperID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeterministicPapers, we can put some logic here if needed 
	public List<FormDeterministicPaper> SearchLike(FormDeterministicPaper formDeterministicPaper)
	{
		return formDeterministicPaperDb.SearchLike(formDeterministicPaper);
	}

}
}
