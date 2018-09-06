using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class ConvertLogHandler
{
	// Handle to the ConvertLog DBAccess class
	ConvertLogDBAccess convertLogDb = null;

	public ConvertLogHandler()
	{
		convertLogDb = new ConvertLogDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of convertLogs, we can put some logic here if needed 
	public List<ConvertLog> GetListAll()
	{
		return convertLogDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of convertLogs, we can put some logic here if needed 
	public bool Update(ConvertLog convertLog)
	{
		return convertLogDb.Update(convertLog);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of convertLogs, we can put some logic here if needed 
	public ConvertLog GetDetails(Int64 convertLogID)
	{
		return convertLogDb.GetDetails(convertLogID);
	}

	public ConvertLog GetDetails(Int64 nationalCode , int taxOfficeCode)
	{
		return convertLogDb.GetDetails(nationalCode , taxOfficeCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of convertLogs, we can put some logic here if needed 
	public bool Delete(Int64 convertLogID)
	{
		return convertLogDb.Delete(convertLogID);
	}

	public bool Delete(Int64 nationalCode , int taxOfficeCode)
	{
		return convertLogDb.Delete(nationalCode , taxOfficeCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of convertLogs, we can put some logic here if needed 
	public Int64 Insert(ConvertLog convertLog)
	{
		return convertLogDb.Insert(convertLog);
	}

	public bool Exists(ConvertLog convertLog)
	{
		return convertLogDb.Exists(convertLog);
	}

	public bool Exists(Int64 convertLogID)
	{
		return convertLogDb.Exists(convertLogID);
	}

	public List<ConvertLog> GetListByConvertLogNationalCodeTaxOfficeCode(Int64 nationalCode,int taxOfficeCode)
	{
		return convertLogDb.GetListByConvertLogNationalCodeTaxOfficeCode(nationalCode,taxOfficeCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of convertLogs, we can put some logic here if needed 
	public List<ConvertLog> SearchLike(ConvertLog convertLog)
	{
		return convertLogDb.SearchLike(convertLog);
	}

}
}
