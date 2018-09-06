using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormInquiryBankDepositHandler
{
	// Handle to the FormInquiryBankDeposit DBAccess class
	FormInquiryBankDepositDBAccess formInquiryBankDepositDb = null;

	public FormInquiryBankDepositHandler()
	{
		formInquiryBankDepositDb = new FormInquiryBankDepositDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryBankDeposits, we can put some logic here if needed 
	public List<FormInquiryBankDeposit> GetListAll()
	{
		return formInquiryBankDepositDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryBankDeposits, we can put some logic here if needed 
	public bool Update(FormInquiryBankDeposit formInquiryBankDeposit)
	{
		return formInquiryBankDepositDb.Update(formInquiryBankDeposit);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryBankDeposits, we can put some logic here if needed 
	public FormInquiryBankDeposit GetDetails(Int64 formInquiryBankDepositID)
	{
		return formInquiryBankDepositDb.GetDetails(formInquiryBankDepositID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryBankDeposits, we can put some logic here if needed 
	public bool Delete(Int64 formInquiryBankDepositID)
	{
		return formInquiryBankDepositDb.Delete(formInquiryBankDepositID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryBankDeposits, we can put some logic here if needed 
	public Int64 Insert(FormInquiryBankDeposit formInquiryBankDeposit)
	{
		return formInquiryBankDepositDb.Insert(formInquiryBankDeposit);
	}

	public bool Exists(FormInquiryBankDeposit formInquiryBankDeposit)
	{
		return formInquiryBankDepositDb.Exists(formInquiryBankDeposit);
	}

	public bool Exists(Int64 formInquiryBankDepositID)
	{
		return formInquiryBankDepositDb.Exists(formInquiryBankDepositID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryBankDeposits, we can put some logic here if needed 
	public List<FormInquiryBankDeposit> SearchLike(FormInquiryBankDeposit formInquiryBankDeposit)
	{
		return formInquiryBankDepositDb.SearchLike(formInquiryBankDeposit);
	}

}
}
