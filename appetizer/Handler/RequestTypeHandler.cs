using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class RequestTypeHandler
{
	// Handle to the RequestType DBAccess class
	RequestTypeDBAccess requestTypeDb = null;

	public RequestTypeHandler()
	{
		requestTypeDb = new RequestTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of requestTypes, we can put some logic here if needed 
	public List<RequestType> GetListAll()
	{
		return requestTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of requestTypes, we can put some logic here if needed 
	public bool Update(RequestType requestType)
	{
		return requestTypeDb.Update(requestType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of requestTypes, we can put some logic here if needed 
	public RequestType GetDetails(int requestTypeID)
	{
		return requestTypeDb.GetDetails(requestTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of requestTypes, we can put some logic here if needed 
	public bool Delete(int requestTypeID)
	{
		return requestTypeDb.Delete(requestTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of requestTypes, we can put some logic here if needed 
	public Int64 Insert(RequestType requestType)
	{
		return requestTypeDb.Insert(requestType);
	}

	public bool Exists(RequestType requestType)
	{
		return requestTypeDb.Exists(requestType);
	}

	public bool Exists(int requestTypeID)
	{
		return requestTypeDb.Exists(requestTypeID);
	}

	public List<Applicant> GetListApplicant(int requestTypeID)
	{
		return requestTypeDb.GetListApplicant(requestTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of requestTypes, we can put some logic here if needed 
	public List<RequestType> SearchLike(RequestType requestType)
	{
		return requestTypeDb.SearchLike(requestType);
	}

}
}
