using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class CalculationTypeHandler
{
	// Handle to the CalculationType DBAccess class
	CalculationTypeDBAccess calculationTypeDb = null;

	public CalculationTypeHandler()
	{
		calculationTypeDb = new CalculationTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of calculationTypes, we can put some logic here if needed 
	public List<CalculationType> GetListAll()
	{
		return calculationTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of calculationTypes, we can put some logic here if needed 
	public bool Update(CalculationType calculationType)
	{
		return calculationTypeDb.Update(calculationType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of calculationTypes, we can put some logic here if needed 
	public CalculationType GetDetails(int calculationTypeID)
	{
		return calculationTypeDb.GetDetails(calculationTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of calculationTypes, we can put some logic here if needed 
	public bool Delete(int calculationTypeID)
	{
		return calculationTypeDb.Delete(calculationTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of calculationTypes, we can put some logic here if needed 
	public Int64 Insert(CalculationType calculationType)
	{
		return calculationTypeDb.Insert(calculationType);
	}

	public bool Exists(CalculationType calculationType)
	{
		return calculationTypeDb.Exists(calculationType);
	}

	public bool Exists(int calculationTypeID)
	{
		return calculationTypeDb.Exists(calculationTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of calculationTypes, we can put some logic here if needed 
	public List<CalculationType> SearchLike(CalculationType calculationType)
	{
		return calculationTypeDb.SearchLike(calculationType);
	}

}
}
