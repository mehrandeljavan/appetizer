using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class PropertyInOtherCountryHandler
{
	// Handle to the PropertyInOtherCountry DBAccess class
	PropertyInOtherCountryDBAccess propertyInOtherCountryDb = null;

	public PropertyInOtherCountryHandler()
	{
		propertyInOtherCountryDb = new PropertyInOtherCountryDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of propertyInOtherCountrys, we can put some logic here if needed 
	public List<PropertyInOtherCountry> GetListAll()
	{
		return propertyInOtherCountryDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of propertyInOtherCountrys, we can put some logic here if needed 
	public bool Update(PropertyInOtherCountry propertyInOtherCountry)
	{
		return propertyInOtherCountryDb.Update(propertyInOtherCountry);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of propertyInOtherCountrys, we can put some logic here if needed 
	public PropertyInOtherCountry GetDetails(Int64 heritageID)
	{
		return propertyInOtherCountryDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of propertyInOtherCountrys, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return propertyInOtherCountryDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of propertyInOtherCountrys, we can put some logic here if needed 
	public Int64 Insert(PropertyInOtherCountry propertyInOtherCountry)
	{
		return propertyInOtherCountryDb.Insert(propertyInOtherCountry);
	}

	public bool Exists(PropertyInOtherCountry propertyInOtherCountry)
	{
		return propertyInOtherCountryDb.Exists(propertyInOtherCountry);
	}

	public bool Exists(Int64 heritageID)
	{
		return propertyInOtherCountryDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of propertyInOtherCountrys, we can put some logic here if needed 
	public List<PropertyInOtherCountry> SearchLike(PropertyInOtherCountry propertyInOtherCountry)
	{
		return propertyInOtherCountryDb.SearchLike(propertyInOtherCountry);
	}

}
}
