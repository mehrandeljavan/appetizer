using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormDeclarationDeliveryHandler
{
	// Handle to the FormDeclarationDelivery DBAccess class
	FormDeclarationDeliveryDBAccess formDeclarationDeliveryDb = null;

	public FormDeclarationDeliveryHandler()
	{
		formDeclarationDeliveryDb = new FormDeclarationDeliveryDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeclarationDeliverys, we can put some logic here if needed 
	public List<FormDeclarationDelivery> GetListAll()
	{
		return formDeclarationDeliveryDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeclarationDeliverys, we can put some logic here if needed 
	public bool Update(FormDeclarationDelivery formDeclarationDelivery)
	{
		return formDeclarationDeliveryDb.Update(formDeclarationDelivery);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeclarationDeliverys, we can put some logic here if needed 
	public FormDeclarationDelivery GetDetails(Int64 formDeclarationDeliveryID)
	{
		return formDeclarationDeliveryDb.GetDetails(formDeclarationDeliveryID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeclarationDeliverys, we can put some logic here if needed 
	public bool Delete(Int64 formDeclarationDeliveryID)
	{
		return formDeclarationDeliveryDb.Delete(formDeclarationDeliveryID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeclarationDeliverys, we can put some logic here if needed 
	public Int64 Insert(FormDeclarationDelivery formDeclarationDelivery)
	{
		return formDeclarationDeliveryDb.Insert(formDeclarationDelivery);
	}

	public bool Exists(FormDeclarationDelivery formDeclarationDelivery)
	{
		return formDeclarationDeliveryDb.Exists(formDeclarationDelivery);
	}

	public bool Exists(Int64 formDeclarationDeliveryID)
	{
		return formDeclarationDeliveryDb.Exists(formDeclarationDeliveryID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formDeclarationDeliverys, we can put some logic here if needed 
	public List<FormDeclarationDelivery> SearchLike(FormDeclarationDelivery formDeclarationDelivery)
	{
		return formDeclarationDeliveryDb.SearchLike(formDeclarationDelivery);
	}

}
}
