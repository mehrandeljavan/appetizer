using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class ReDiagnosisRequestHandler
{
	// Handle to the ReDiagnosisRequest DBAccess class
	ReDiagnosisRequestDBAccess reDiagnosisRequestDb = null;

	public ReDiagnosisRequestHandler()
	{
		reDiagnosisRequestDb = new ReDiagnosisRequestDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reDiagnosisRequests, we can put some logic here if needed 
	public List<ReDiagnosisRequest> GetListAll()
	{
		return reDiagnosisRequestDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reDiagnosisRequests, we can put some logic here if needed 
	public bool Update(ReDiagnosisRequest reDiagnosisRequest)
	{
		return reDiagnosisRequestDb.Update(reDiagnosisRequest);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reDiagnosisRequests, we can put some logic here if needed 
	public ReDiagnosisRequest GetDetails(Int64 reDiagnosisRequestID)
	{
		return reDiagnosisRequestDb.GetDetails(reDiagnosisRequestID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reDiagnosisRequests, we can put some logic here if needed 
	public bool Delete(Int64 reDiagnosisRequestID)
	{
		return reDiagnosisRequestDb.Delete(reDiagnosisRequestID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reDiagnosisRequests, we can put some logic here if needed 
	public Int64 Insert(ReDiagnosisRequest reDiagnosisRequest)
	{
		return reDiagnosisRequestDb.Insert(reDiagnosisRequest);
	}

	public bool Exists(ReDiagnosisRequest reDiagnosisRequest)
	{
		return reDiagnosisRequestDb.Exists(reDiagnosisRequest);
	}

	public bool Exists(Int64 reDiagnosisRequestID)
	{
		return reDiagnosisRequestDb.Exists(reDiagnosisRequestID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of reDiagnosisRequests, we can put some logic here if needed 
	public List<ReDiagnosisRequest> SearchLike(ReDiagnosisRequest reDiagnosisRequest)
	{
		return reDiagnosisRequestDb.SearchLike(reDiagnosisRequest);
	}

}
}
