using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class DemandDocumentHandler
{
	// Handle to the DemandDocument DBAccess class
	DemandDocumentDBAccess demandDocumentDb = null;

	public DemandDocumentHandler()
	{
		demandDocumentDb = new DemandDocumentDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandDocuments, we can put some logic here if needed 
	public List<DemandDocument> GetListAll()
	{
		return demandDocumentDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandDocuments, we can put some logic here if needed 
	public bool Update(DemandDocument demandDocument)
	{
		return demandDocumentDb.Update(demandDocument);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandDocuments, we can put some logic here if needed 
	public DemandDocument GetDetails(int demandDocumentID)
	{
		return demandDocumentDb.GetDetails(demandDocumentID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandDocuments, we can put some logic here if needed 
	public bool Delete(int demandDocumentID)
	{
		return demandDocumentDb.Delete(demandDocumentID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandDocuments, we can put some logic here if needed 
	public Int64 Insert(DemandDocument demandDocument)
	{
		return demandDocumentDb.Insert(demandDocument);
	}

	public bool Exists(DemandDocument demandDocument)
	{
		return demandDocumentDb.Exists(demandDocument);
	}

	public bool Exists(int demandDocumentID)
	{
		return demandDocumentDb.Exists(demandDocumentID);
	}

	public List<Demands> GetListDemands(int demandDocumentID)
	{
		return demandDocumentDb.GetListDemands(demandDocumentID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of demandDocuments, we can put some logic here if needed 
	public List<DemandDocument> SearchLike(DemandDocument demandDocument)
	{
		return demandDocumentDb.SearchLike(demandDocument);
	}

}
}
