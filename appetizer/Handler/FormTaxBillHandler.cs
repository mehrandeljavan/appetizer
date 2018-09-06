using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormTaxBillHandler
{
	// Handle to the FormTaxBill DBAccess class
	FormTaxBillDBAccess formTaxBillDb = null;

	public FormTaxBillHandler()
	{
		formTaxBillDb = new FormTaxBillDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formTaxBills, we can put some logic here if needed 
	public List<FormTaxBill> GetListAll()
	{
		return formTaxBillDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formTaxBills, we can put some logic here if needed 
	public bool Update(FormTaxBill formTaxBill)
	{
		return formTaxBillDb.Update(formTaxBill);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formTaxBills, we can put some logic here if needed 
	public FormTaxBill GetDetails(Int64 formTaxBillID)
	{
		return formTaxBillDb.GetDetails(formTaxBillID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formTaxBills, we can put some logic here if needed 
	public bool Delete(Int64 formTaxBillID)
	{
		return formTaxBillDb.Delete(formTaxBillID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formTaxBills, we can put some logic here if needed 
	public Int64 Insert(FormTaxBill formTaxBill)
	{
		return formTaxBillDb.Insert(formTaxBill);
	}

	public bool Exists(FormTaxBill formTaxBill)
	{
		return formTaxBillDb.Exists(formTaxBill);
	}

	public bool Exists(Int64 formTaxBillID)
	{
		return formTaxBillDb.Exists(formTaxBillID);
	}

	public List<FormHeirWithShare> GetListFormHeirWithShare(Int64 formTaxBillID)
	{
		return formTaxBillDb.GetListFormHeirWithShare(formTaxBillID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formTaxBills, we can put some logic here if needed 
	public List<FormTaxBill> SearchLike(FormTaxBill formTaxBill)
	{
		return formTaxBillDb.SearchLike(formTaxBill);
	}

}
}
