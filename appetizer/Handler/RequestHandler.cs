using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class RequestHandler
{
	// Handle to the Request DBAccess class
	RequestDBAccess requestDb = null;

	public RequestHandler()
	{
		requestDb = new RequestDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of requests, we can put some logic here if needed 
	public List<Request> GetListAll()
	{
		return requestDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of requests, we can put some logic here if needed 
	public bool Update(Request request)
	{
		return requestDb.Update(request);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of requests, we can put some logic here if needed 
	public Request GetDetails(Int64 requestID)
	{
		return requestDb.GetDetails(requestID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of requests, we can put some logic here if needed 
	public bool Delete(Int64 requestID)
	{
		return requestDb.Delete(requestID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of requests, we can put some logic here if needed 
	public Int64 Insert(Request request)
	{
		return requestDb.Insert(request);
	}

	public bool Exists(Request request)
	{
		return requestDb.Exists(request);
	}

	public bool Exists(Int64 requestID)
	{
		return requestDb.Exists(requestID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of requests, we can put some logic here if needed 
	public List<Request> SearchLike(Request request)
	{
		return requestDb.SearchLike(request);
	}

}
}
