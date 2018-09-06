using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class PaymentHandler
{
	// Handle to the Payment DBAccess class
	PaymentDBAccess paymentDb = null;

	public PaymentHandler()
	{
		paymentDb = new PaymentDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of payments, we can put some logic here if needed 
	public List<Payment> GetListAll()
	{
		return paymentDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of payments, we can put some logic here if needed 
	public bool Update(Payment payment)
	{
		return paymentDb.Update(payment);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of payments, we can put some logic here if needed 
	public Payment GetDetails(Int64 paymentID)
	{
		return paymentDb.GetDetails(paymentID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of payments, we can put some logic here if needed 
	public bool Delete(Int64 paymentID)
	{
		return paymentDb.Delete(paymentID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of payments, we can put some logic here if needed 
	public Int64 Insert(Payment payment)
	{
		return paymentDb.Insert(payment);
	}

	public bool Exists(Payment payment)
	{
		return paymentDb.Exists(payment);
	}

	public bool Exists(Int64 paymentID)
	{
		return paymentDb.Exists(paymentID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of payments, we can put some logic here if needed 
	public List<Payment> SearchLike(Payment payment)
	{
		return paymentDb.SearchLike(payment);
	}

}
}
