using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class OperatorTypeHandler
{
	// Handle to the OperatorType DBAccess class
	OperatorTypeDBAccess operatorTypeDb = null;

	public OperatorTypeHandler()
	{
		operatorTypeDb = new OperatorTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of operatorTypes, we can put some logic here if needed 
	public List<OperatorType> GetListAll()
	{
		return operatorTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of operatorTypes, we can put some logic here if needed 
	public bool Update(OperatorType operatorType)
	{
		return operatorTypeDb.Update(operatorType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of operatorTypes, we can put some logic here if needed 
	public OperatorType GetDetails(int operatorTypeID)
	{
		return operatorTypeDb.GetDetails(operatorTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of operatorTypes, we can put some logic here if needed 
	public bool Delete(int operatorTypeID)
	{
		return operatorTypeDb.Delete(operatorTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of operatorTypes, we can put some logic here if needed 
	public Int64 Insert(OperatorType operatorType)
	{
		return operatorTypeDb.Insert(operatorType);
	}

	public bool Exists(OperatorType operatorType)
	{
		return operatorTypeDb.Exists(operatorType);
	}

	public bool Exists(int operatorTypeID)
	{
		return operatorTypeDb.Exists(operatorTypeID);
	}

	public List<Annunciation> GetListAnnunciation(int operatorTypeID)
	{
		return operatorTypeDb.GetListAnnunciation(operatorTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of operatorTypes, we can put some logic here if needed 
	public List<OperatorType> SearchLike(OperatorType operatorType)
	{
		return operatorTypeDb.SearchLike(operatorType);
	}

}
}
