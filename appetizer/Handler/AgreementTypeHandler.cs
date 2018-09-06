using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class AgreementTypeHandler
{
	// Handle to the AgreementType DBAccess class
	AgreementTypeDBAccess agreementTypeDb = null;

	public AgreementTypeHandler()
	{
		agreementTypeDb = new AgreementTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of agreementTypes, we can put some logic here if needed 
	public List<AgreementType> GetListAll()
	{
		return agreementTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of agreementTypes, we can put some logic here if needed 
	public bool Update(AgreementType agreementType)
	{
		return agreementTypeDb.Update(agreementType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of agreementTypes, we can put some logic here if needed 
	public AgreementType GetDetails(int agreementTypeID)
	{
		return agreementTypeDb.GetDetails(agreementTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of agreementTypes, we can put some logic here if needed 
	public bool Delete(int agreementTypeID)
	{
		return agreementTypeDb.Delete(agreementTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of agreementTypes, we can put some logic here if needed 
	public Int64 Insert(AgreementType agreementType)
	{
		return agreementTypeDb.Insert(agreementType);
	}

	public bool Exists(AgreementType agreementType)
	{
		return agreementTypeDb.Exists(agreementType);
	}

	public bool Exists(int agreementTypeID)
	{
		return agreementTypeDb.Exists(agreementTypeID);
	}

	public List<Heir> GetListHeir(int agreementTypeID)
	{
		return agreementTypeDb.GetListHeir(agreementTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of agreementTypes, we can put some logic here if needed 
	public List<AgreementType> SearchLike(AgreementType agreementType)
	{
		return agreementTypeDb.SearchLike(agreementType);
	}

}
}
