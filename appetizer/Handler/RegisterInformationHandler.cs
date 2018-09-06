using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class RegisterInformationHandler
{
	// Handle to the RegisterInformation DBAccess class
	RegisterInformationDBAccess registerInformationDb = null;

	public RegisterInformationHandler()
	{
		registerInformationDb = new RegisterInformationDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of registerInformations, we can put some logic here if needed 
	public List<RegisterInformation> GetListAll()
	{
		return registerInformationDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of registerInformations, we can put some logic here if needed 
	public bool Update(RegisterInformation registerInformation)
	{
		return registerInformationDb.Update(registerInformation);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of registerInformations, we can put some logic here if needed 
	public RegisterInformation GetDetails(Int64 registerInformationID)
	{
		return registerInformationDb.GetDetails(registerInformationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of registerInformations, we can put some logic here if needed 
	public bool Delete(Int64 registerInformationID)
	{
		return registerInformationDb.Delete(registerInformationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of registerInformations, we can put some logic here if needed 
	public Int64 Insert(RegisterInformation registerInformation)
	{
		return registerInformationDb.Insert(registerInformation);
	}

	public bool Exists(RegisterInformation registerInformation)
	{
		return registerInformationDb.Exists(registerInformation);
	}

	public bool Exists(Int64 registerInformationID)
	{
		return registerInformationDb.Exists(registerInformationID);
	}

	public List<AdjustmentHeritage> GetListAdjustmentHeritage(Int64 registerInformationID)
	{
		return registerInformationDb.GetListAdjustmentHeritage(registerInformationID);
	}

	public List<Applicant> GetListApplicant(Int64 registerInformationID)
	{
		return registerInformationDb.GetListApplicant(registerInformationID);
	}

	public List<CommissionVerdict> GetListCommissionVerdict(Int64 registerInformationID)
	{
		return registerInformationDb.GetListCommissionVerdict(registerInformationID);
	}

	public List<Dead> GetListDead(Int64 registerInformationID)
	{
		return registerInformationDb.GetListDead(registerInformationID);
	}

	public List<Declaration> GetListDeclaration(Int64 registerInformationID)
	{
		return registerInformationDb.GetListDeclaration(registerInformationID);
	}

	public List<Form19> GetListForm19(Int64 registerInformationID)
	{
		return registerInformationDb.GetListForm19(registerInformationID);
	}

	public List<FormCommissionInvitation> GetListFormCommissionInvitation(Int64 registerInformationID)
	{
		return registerInformationDb.GetListFormCommissionInvitation(registerInformationID);
	}

	public List<FormDeclarationDelivery> GetListFormDeclarationDelivery(Int64 registerInformationID)
	{
		return registerInformationDb.GetListFormDeclarationDelivery(registerInformationID);
	}

	public List<FormDeclarationInputInfo> GetListFormDeclarationInputInfo(Int64 registerInformationID)
	{
		return registerInformationDb.GetListFormDeclarationInputInfo(registerInformationID);
	}

	public List<FormDeterministicPaper> GetListFormDeterministicPaper(Int64 registerInformationID)
	{
		return registerInformationDb.GetListFormDeterministicPaper(registerInformationID);
	}

	public List<FormDiagnosisPaper> GetListFormDiagnosisPaper(Int64 registerInformationID)
	{
		return registerInformationDb.GetListFormDiagnosisPaper(registerInformationID);
	}

	public List<FormDiagnosisResult> GetListFormDiagnosisResult(Int64 registerInformationID)
	{
		return registerInformationDb.GetListFormDiagnosisResult(registerInformationID);
	}

	public List<FormFreedom> GetListFormFreedom(Int64 registerInformationID)
	{
		return registerInformationDb.GetListFormFreedom(registerInformationID);
	}

	public List<FormHeritageBill> GetListFormHeritageBill(Int64 registerInformationID)
	{
		return registerInformationDb.GetListFormHeritageBill(registerInformationID);
	}

	public List<FormHeritageEvaluation> GetListFormHeritageEvaluation(Int64 registerInformationID)
	{
		return registerInformationDb.GetListFormHeritageEvaluation(registerInformationID);
	}

	public List<FormTaxBill> GetListFormTaxBill(Int64 registerInformationID)
	{
		return registerInformationDb.GetListFormTaxBill(registerInformationID);
	}

	public List<FormTaxPaymentCertificate> GetListFormTaxPaymentCertificate(Int64 registerInformationID)
	{
		return registerInformationDb.GetListFormTaxPaymentCertificate(registerInformationID);
	}

	public List<Heir> GetListHeir(Int64 registerInformationID)
	{
		return registerInformationDb.GetListHeir(registerInformationID);
	}

	public List<InquiryResponse> GetListInquiryResponse(Int64 registerInformationID)
	{
		return registerInformationDb.GetListInquiryResponse(registerInformationID);
	}

	public List<ReDiagnosisRequest> GetListReDiagnosisRequest(Int64 registerInformationID)
	{
		return registerInformationDb.GetListReDiagnosisRequest(registerInformationID);
	}

	public List<Reports> GetListReports(Int64 registerInformationID)
	{
		return registerInformationDb.GetListReports(registerInformationID);
	}

	public List<Utterer> GetListUtterer(Int64 registerInformationID)
	{
		return registerInformationDb.GetListUtterer(registerInformationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of registerInformations, we can put some logic here if needed 
	public List<RegisterInformation> SearchLike(RegisterInformation registerInformation)
	{
		return registerInformationDb.SearchLike(registerInformation);
	}

}
}
