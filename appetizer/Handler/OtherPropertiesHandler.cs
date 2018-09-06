using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class OtherPropertiesHandler
{
	// Handle to the OtherProperties DBAccess class
	OtherPropertiesDBAccess otherPropertiesDb = null;

	public OtherPropertiesHandler()
	{
		otherPropertiesDb = new OtherPropertiesDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of otherPropertiess, we can put some logic here if needed 
	public List<OtherProperties> GetListAll()
	{
		return otherPropertiesDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of otherPropertiess, we can put some logic here if needed 
	public bool Update(OtherProperties otherProperties)
	{
		return otherPropertiesDb.Update(otherProperties);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of otherPropertiess, we can put some logic here if needed 
	public OtherProperties GetDetails(Int64 heritageID)
	{
		return otherPropertiesDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of otherPropertiess, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return otherPropertiesDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of otherPropertiess, we can put some logic here if needed 
	public Int64 Insert(OtherProperties otherProperties)
	{
		return otherPropertiesDb.Insert(otherProperties);
	}

	public bool Exists(OtherProperties otherProperties)
	{
		return otherPropertiesDb.Exists(otherProperties);
	}

	public bool Exists(Int64 heritageID)
	{
		return otherPropertiesDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of otherPropertiess, we can put some logic here if needed 
	public List<OtherProperties> SearchLike(OtherProperties otherProperties)
	{
		return otherPropertiesDb.SearchLike(otherProperties);
	}

}
}
