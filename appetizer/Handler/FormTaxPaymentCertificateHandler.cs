using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormTaxPaymentCertificateHandler
{
	// Handle to the FormTaxPaymentCertificate DBAccess class
	FormTaxPaymentCertificateDBAccess formTaxPaymentCertificateDb = null;

	public FormTaxPaymentCertificateHandler()
	{
		formTaxPaymentCertificateDb = new FormTaxPaymentCertificateDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formTaxPaymentCertificates, we can put some logic here if needed 
	public List<FormTaxPaymentCertificate> GetListAll()
	{
		return formTaxPaymentCertificateDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formTaxPaymentCertificates, we can put some logic here if needed 
	public bool Update(FormTaxPaymentCertificate formTaxPaymentCertificate)
	{
		return formTaxPaymentCertificateDb.Update(formTaxPaymentCertificate);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formTaxPaymentCertificates, we can put some logic here if needed 
	public FormTaxPaymentCertificate GetDetails(Int64 formTaxPayementCertificateID)
	{
		return formTaxPaymentCertificateDb.GetDetails(formTaxPayementCertificateID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formTaxPaymentCertificates, we can put some logic here if needed 
	public bool Delete(Int64 formTaxPayementCertificateID)
	{
		return formTaxPaymentCertificateDb.Delete(formTaxPayementCertificateID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formTaxPaymentCertificates, we can put some logic here if needed 
	public Int64 Insert(FormTaxPaymentCertificate formTaxPaymentCertificate)
	{
		return formTaxPaymentCertificateDb.Insert(formTaxPaymentCertificate);
	}

	public bool Exists(FormTaxPaymentCertificate formTaxPaymentCertificate)
	{
		return formTaxPaymentCertificateDb.Exists(formTaxPaymentCertificate);
	}

	public bool Exists(Int64 formTaxPayementCertificateID)
	{
		return formTaxPaymentCertificateDb.Exists(formTaxPayementCertificateID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formTaxPaymentCertificates, we can put some logic here if needed 
	public List<FormTaxPaymentCertificate> SearchLike(FormTaxPaymentCertificate formTaxPaymentCertificate)
	{
		return formTaxPaymentCertificateDb.SearchLike(formTaxPaymentCertificate);
	}

}
}
