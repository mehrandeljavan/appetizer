using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class TransferRightTypeHandler
{
	// Handle to the TransferRightType DBAccess class
	TransferRightTypeDBAccess transferRightTypeDb = null;

	public TransferRightTypeHandler()
	{
		transferRightTypeDb = new TransferRightTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of transferRightTypes, we can put some logic here if needed 
	public List<TransferRightType> GetListAll()
	{
		return transferRightTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of transferRightTypes, we can put some logic here if needed 
	public bool Update(TransferRightType transferRightType)
	{
		return transferRightTypeDb.Update(transferRightType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of transferRightTypes, we can put some logic here if needed 
	public TransferRightType GetDetails(int transferRightTypeID)
	{
		return transferRightTypeDb.GetDetails(transferRightTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of transferRightTypes, we can put some logic here if needed 
	public bool Delete(int transferRightTypeID)
	{
		return transferRightTypeDb.Delete(transferRightTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of transferRightTypes, we can put some logic here if needed 
	public Int64 Insert(TransferRightType transferRightType)
	{
		return transferRightTypeDb.Insert(transferRightType);
	}

	public bool Exists(TransferRightType transferRightType)
	{
		return transferRightTypeDb.Exists(transferRightType);
	}

	public bool Exists(int transferRightTypeID)
	{
		return transferRightTypeDb.Exists(transferRightTypeID);
	}

	public List<TransferRight> GetListTransferRight(int transferRightTypeID)
	{
		return transferRightTypeDb.GetListTransferRight(transferRightTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of transferRightTypes, we can put some logic here if needed 
	public List<TransferRightType> SearchLike(TransferRightType transferRightType)
	{
		return transferRightTypeDb.SearchLike(transferRightType);
	}

}
}
