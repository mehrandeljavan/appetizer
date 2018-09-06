using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class TransferRightHandler
{
	// Handle to the TransferRight DBAccess class
	TransferRightDBAccess transferRightDb = null;

	public TransferRightHandler()
	{
		transferRightDb = new TransferRightDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of transferRights, we can put some logic here if needed 
	public List<TransferRight> GetListAll()
	{
		return transferRightDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of transferRights, we can put some logic here if needed 
	public bool Update(TransferRight transferRight)
	{
		return transferRightDb.Update(transferRight);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of transferRights, we can put some logic here if needed 
	public TransferRight GetDetails(Int64 heritageID)
	{
		return transferRightDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of transferRights, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return transferRightDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of transferRights, we can put some logic here if needed 
	public Int64 Insert(TransferRight transferRight)
	{
		return transferRightDb.Insert(transferRight);
	}

	public bool Exists(TransferRight transferRight)
	{
		return transferRightDb.Exists(transferRight);
	}

	public bool Exists(Int64 heritageID)
	{
		return transferRightDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of transferRights, we can put some logic here if needed 
	public List<TransferRight> SearchLike(TransferRight transferRight)
	{
		return transferRightDb.SearchLike(transferRight);
	}

}
}
