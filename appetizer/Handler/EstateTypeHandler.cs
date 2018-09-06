using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class EstateTypeHandler
{
	// Handle to the EstateType DBAccess class
	EstateTypeDBAccess estateTypeDb = null;

	public EstateTypeHandler()
	{
		estateTypeDb = new EstateTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of estateTypes, we can put some logic here if needed 
	public List<EstateType> GetListAll()
	{
		return estateTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of estateTypes, we can put some logic here if needed 
	public bool Update(EstateType estateType)
	{
		return estateTypeDb.Update(estateType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of estateTypes, we can put some logic here if needed 
	public EstateType GetDetails(int estateTypeID)
	{
		return estateTypeDb.GetDetails(estateTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of estateTypes, we can put some logic here if needed 
	public bool Delete(int estateTypeID)
	{
		return estateTypeDb.Delete(estateTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of estateTypes, we can put some logic here if needed 
	public Int64 Insert(EstateType estateType)
	{
		return estateTypeDb.Insert(estateType);
	}

	public bool Exists(EstateType estateType)
	{
		return estateTypeDb.Exists(estateType);
	}

	public bool Exists(int estateTypeID)
	{
		return estateTypeDb.Exists(estateTypeID);
	}

	public List<Estate> GetListEstate(int estateTypeID)
	{
		return estateTypeDb.GetListEstate(estateTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of estateTypes, we can put some logic here if needed 
	public List<EstateType> SearchLike(EstateType estateType)
	{
		return estateTypeDb.SearchLike(estateType);
	}

}
}
