using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class BankInquiryHajjHandler
{
	// Handle to the BankInquiryHajj DBAccess class
	BankInquiryHajjDBAccess bankInquiryHajjDb = null;

	public BankInquiryHajjHandler()
	{
		bankInquiryHajjDb = new BankInquiryHajjDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankInquiryHajjs, we can put some logic here if needed 
	public List<BankInquiryHajj> GetListAll()
	{
		return bankInquiryHajjDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankInquiryHajjs, we can put some logic here if needed 
	public bool Update(BankInquiryHajj bankInquiryHajj)
	{
		return bankInquiryHajjDb.Update(bankInquiryHajj);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankInquiryHajjs, we can put some logic here if needed 
	public BankInquiryHajj GetDetails(int bankInquiryHajjID)
	{
		return bankInquiryHajjDb.GetDetails(bankInquiryHajjID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankInquiryHajjs, we can put some logic here if needed 
	public bool Delete(int bankInquiryHajjID)
	{
		return bankInquiryHajjDb.Delete(bankInquiryHajjID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankInquiryHajjs, we can put some logic here if needed 
	public Int64 Insert(BankInquiryHajj bankInquiryHajj)
	{
		return bankInquiryHajjDb.Insert(bankInquiryHajj);
	}

	public bool Exists(BankInquiryHajj bankInquiryHajj)
	{
		return bankInquiryHajjDb.Exists(bankInquiryHajj);
	}

	public bool Exists(int bankInquiryHajjID)
	{
		return bankInquiryHajjDb.Exists(bankInquiryHajjID);
	}

	public List<Hajj> GetListHajj(int bankInquiryHajjID)
	{
		return bankInquiryHajjDb.GetListHajj(bankInquiryHajjID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of bankInquiryHajjs, we can put some logic here if needed 
	public List<BankInquiryHajj> SearchLike(BankInquiryHajj bankInquiryHajj)
	{
		return bankInquiryHajjDb.SearchLike(bankInquiryHajj);
	}

}
}
