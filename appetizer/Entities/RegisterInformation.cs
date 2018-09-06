using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class RegisterInformation
{
	private Int64 registerInformationID;
	private string registerTypeIDTitle;
	private int? registerTypeID;
	private Int64? userID;
	private Int64? oldID;
	private Int64? oldRegisterInformationID;
	private string registerDate;
	private string registerTime;
	private string oldRegisterDate;
	private List<AdjustmentHeritage> adjustmentHeritageList;
	private List<Applicant> applicantList;
	private List<CommissionVerdict> commissionVerdictList;
	private List<Dead> deadList;
	private List<Declaration> declarationList;
	private List<Form19> form19List;
	private List<FormCommissionInvitation> formCommissionInvitationList;
	private List<FormDeclarationDelivery> formDeclarationDeliveryList;
	private List<FormDeclarationInputInfo> formDeclarationInputInfoList;
	private List<FormDeterministicPaper> formDeterministicPaperList;
	private List<FormDiagnosisPaper> formDiagnosisPaperList;
	private List<FormDiagnosisResult> formDiagnosisResultList;
	private List<FormFreedom> formFreedomList;
	private List<FormHeritageBill> formHeritageBillList;
	private List<FormHeritageEvaluation> formHeritageEvaluationList;
	private List<FormTaxBill> formTaxBillList;
	private List<FormTaxPaymentCertificate> formTaxPaymentCertificateList;
	private List<Heir> heirList;
	private List<InquiryResponse> inquiryResponseList;
	private List<ReDiagnosisRequest> reDiagnosisRequestList;
	private List<Reports> reportsList;
	private List<Utterer> uttererList;

	public Int64 RegisterInformationID
	{
		get
		{
			return registerInformationID;
		}
		set
		{
			registerInformationID = value;
		}
	}

	public string RegisterTypeIDTitle
	{
		get
		{
			return registerTypeIDTitle;
		}
		set
		{
			registerTypeIDTitle = value;
		}
	}

	public int? RegisterTypeID
	{
		get
		{
			return registerTypeID;
		}
		set
		{
			registerTypeID = value;
		}
	}

	public Int64? UserID
	{
		get
		{
			return userID;
		}
		set
		{
			userID = value;
		}
	}

	public Int64? OldID
	{
		get
		{
			return oldID;
		}
		set
		{
			oldID = value;
		}
	}

	public Int64? OldRegisterInformationID
	{
		get
		{
			return oldRegisterInformationID;
		}
		set
		{
			oldRegisterInformationID = value;
		}
	}

	public string RegisterDate
	{
		get
		{
			return registerDate;
		}
		set
		{
			registerDate = value;
		}
	}

	public string RegisterTime
	{
		get
		{
			return registerTime;
		}
		set
		{
			registerTime = value;
		}
	}

	public string OldRegisterDate
	{
		get
		{
			return oldRegisterDate;
		}
		set
		{
			oldRegisterDate = value;
		}
	}

	public List<AdjustmentHeritage> AdjustmentHeritageList
	{
		get
		{
			return adjustmentHeritageList;
		}
		set
		{
			adjustmentHeritageList = value;
		}
	}

	public List<Applicant> ApplicantList
	{
		get
		{
			return applicantList;
		}
		set
		{
			applicantList = value;
		}
	}

	public List<CommissionVerdict> CommissionVerdictList
	{
		get
		{
			return commissionVerdictList;
		}
		set
		{
			commissionVerdictList = value;
		}
	}

	public List<Dead> DeadList
	{
		get
		{
			return deadList;
		}
		set
		{
			deadList = value;
		}
	}

	public List<Declaration> DeclarationList
	{
		get
		{
			return declarationList;
		}
		set
		{
			declarationList = value;
		}
	}

	public List<Form19> Form19List
	{
		get
		{
			return form19List;
		}
		set
		{
			form19List = value;
		}
	}

	public List<FormCommissionInvitation> FormCommissionInvitationList
	{
		get
		{
			return formCommissionInvitationList;
		}
		set
		{
			formCommissionInvitationList = value;
		}
	}

	public List<FormDeclarationDelivery> FormDeclarationDeliveryList
	{
		get
		{
			return formDeclarationDeliveryList;
		}
		set
		{
			formDeclarationDeliveryList = value;
		}
	}

	public List<FormDeclarationInputInfo> FormDeclarationInputInfoList
	{
		get
		{
			return formDeclarationInputInfoList;
		}
		set
		{
			formDeclarationInputInfoList = value;
		}
	}

	public List<FormDeterministicPaper> FormDeterministicPaperList
	{
		get
		{
			return formDeterministicPaperList;
		}
		set
		{
			formDeterministicPaperList = value;
		}
	}

	public List<FormDiagnosisPaper> FormDiagnosisPaperList
	{
		get
		{
			return formDiagnosisPaperList;
		}
		set
		{
			formDiagnosisPaperList = value;
		}
	}

	public List<FormDiagnosisResult> FormDiagnosisResultList
	{
		get
		{
			return formDiagnosisResultList;
		}
		set
		{
			formDiagnosisResultList = value;
		}
	}

	public List<FormFreedom> FormFreedomList
	{
		get
		{
			return formFreedomList;
		}
		set
		{
			formFreedomList = value;
		}
	}

	public List<FormHeritageBill> FormHeritageBillList
	{
		get
		{
			return formHeritageBillList;
		}
		set
		{
			formHeritageBillList = value;
		}
	}

	public List<FormHeritageEvaluation> FormHeritageEvaluationList
	{
		get
		{
			return formHeritageEvaluationList;
		}
		set
		{
			formHeritageEvaluationList = value;
		}
	}

	public List<FormTaxBill> FormTaxBillList
	{
		get
		{
			return formTaxBillList;
		}
		set
		{
			formTaxBillList = value;
		}
	}

	public List<FormTaxPaymentCertificate> FormTaxPaymentCertificateList
	{
		get
		{
			return formTaxPaymentCertificateList;
		}
		set
		{
			formTaxPaymentCertificateList = value;
		}
	}

	public List<Heir> HeirList
	{
		get
		{
			return heirList;
		}
		set
		{
			heirList = value;
		}
	}

	public List<InquiryResponse> InquiryResponseList
	{
		get
		{
			return inquiryResponseList;
		}
		set
		{
			inquiryResponseList = value;
		}
	}

	public List<ReDiagnosisRequest> ReDiagnosisRequestList
	{
		get
		{
			return reDiagnosisRequestList;
		}
		set
		{
			reDiagnosisRequestList = value;
		}
	}

	public List<Reports> ReportsList
	{
		get
		{
			return reportsList;
		}
		set
		{
			reportsList = value;
		}
	}

	public List<Utterer> UttererList
	{
		get
		{
			return uttererList;
		}
		set
		{
			uttererList = value;
		}
	}

	public List<AdjustmentHeritage> GetListAdjustmentHeritage()
	{
		AdjustmentHeritageList = new RegisterInformationDBAccess().GetListAdjustmentHeritage(this.RegisterInformationID);
		return AdjustmentHeritageList;
	}

	public List<Applicant> GetListApplicant()
	{
		ApplicantList = new RegisterInformationDBAccess().GetListApplicant(this.RegisterInformationID);
		return ApplicantList;
	}

	public List<CommissionVerdict> GetListCommissionVerdict()
	{
		CommissionVerdictList = new RegisterInformationDBAccess().GetListCommissionVerdict(this.RegisterInformationID);
		return CommissionVerdictList;
	}

	public List<Dead> GetListDead()
	{
		DeadList = new RegisterInformationDBAccess().GetListDead(this.RegisterInformationID);
		return DeadList;
	}

	public List<Declaration> GetListDeclaration()
	{
		DeclarationList = new RegisterInformationDBAccess().GetListDeclaration(this.RegisterInformationID);
		return DeclarationList;
	}

	public List<Form19> GetListForm19()
	{
		Form19List = new RegisterInformationDBAccess().GetListForm19(this.RegisterInformationID);
		return Form19List;
	}

	public List<FormCommissionInvitation> GetListFormCommissionInvitation()
	{
		FormCommissionInvitationList = new RegisterInformationDBAccess().GetListFormCommissionInvitation(this.RegisterInformationID);
		return FormCommissionInvitationList;
	}

	public List<FormDeclarationDelivery> GetListFormDeclarationDelivery()
	{
		FormDeclarationDeliveryList = new RegisterInformationDBAccess().GetListFormDeclarationDelivery(this.RegisterInformationID);
		return FormDeclarationDeliveryList;
	}

	public List<FormDeclarationInputInfo> GetListFormDeclarationInputInfo()
	{
		FormDeclarationInputInfoList = new RegisterInformationDBAccess().GetListFormDeclarationInputInfo(this.RegisterInformationID);
		return FormDeclarationInputInfoList;
	}

	public List<FormDeterministicPaper> GetListFormDeterministicPaper()
	{
		FormDeterministicPaperList = new RegisterInformationDBAccess().GetListFormDeterministicPaper(this.RegisterInformationID);
		return FormDeterministicPaperList;
	}

	public List<FormDiagnosisPaper> GetListFormDiagnosisPaper()
	{
		FormDiagnosisPaperList = new RegisterInformationDBAccess().GetListFormDiagnosisPaper(this.RegisterInformationID);
		return FormDiagnosisPaperList;
	}

	public List<FormDiagnosisResult> GetListFormDiagnosisResult()
	{
		FormDiagnosisResultList = new RegisterInformationDBAccess().GetListFormDiagnosisResult(this.RegisterInformationID);
		return FormDiagnosisResultList;
	}

	public List<FormFreedom> GetListFormFreedom()
	{
		FormFreedomList = new RegisterInformationDBAccess().GetListFormFreedom(this.RegisterInformationID);
		return FormFreedomList;
	}

	public List<FormHeritageBill> GetListFormHeritageBill()
	{
		FormHeritageBillList = new RegisterInformationDBAccess().GetListFormHeritageBill(this.RegisterInformationID);
		return FormHeritageBillList;
	}

	public List<FormHeritageEvaluation> GetListFormHeritageEvaluation()
	{
		FormHeritageEvaluationList = new RegisterInformationDBAccess().GetListFormHeritageEvaluation(this.RegisterInformationID);
		return FormHeritageEvaluationList;
	}

	public List<FormTaxBill> GetListFormTaxBill()
	{
		FormTaxBillList = new RegisterInformationDBAccess().GetListFormTaxBill(this.RegisterInformationID);
		return FormTaxBillList;
	}

	public List<FormTaxPaymentCertificate> GetListFormTaxPaymentCertificate()
	{
		FormTaxPaymentCertificateList = new RegisterInformationDBAccess().GetListFormTaxPaymentCertificate(this.RegisterInformationID);
		return FormTaxPaymentCertificateList;
	}

	public List<Heir> GetListHeir()
	{
		HeirList = new RegisterInformationDBAccess().GetListHeir(this.RegisterInformationID);
		return HeirList;
	}

	public List<InquiryResponse> GetListInquiryResponse()
	{
		InquiryResponseList = new RegisterInformationDBAccess().GetListInquiryResponse(this.RegisterInformationID);
		return InquiryResponseList;
	}

	public List<ReDiagnosisRequest> GetListReDiagnosisRequest()
	{
		ReDiagnosisRequestList = new RegisterInformationDBAccess().GetListReDiagnosisRequest(this.RegisterInformationID);
		return ReDiagnosisRequestList;
	}

	public List<Reports> GetListReports()
	{
		ReportsList = new RegisterInformationDBAccess().GetListReports(this.RegisterInformationID);
		return ReportsList;
	}

	public List<Utterer> GetListUtterer()
	{
		UttererList = new RegisterInformationDBAccess().GetListUtterer(this.RegisterInformationID);
		return UttererList;
	}

	public bool AddAdjustmentHeritage(AdjustmentHeritage adjustmentHeritage)
	{
		adjustmentHeritage.RegisterInformationID = this.RegisterInformationID;
		AdjustmentHeritageDBAccess adjustmentHeritageDBAccess = new AdjustmentHeritageDBAccess();
		if (adjustmentHeritageDBAccess.Insert(adjustmentHeritage)>0)
			return (true);
		return (false);
	}

	public bool AddApplicant(Applicant applicant)
	{
		applicant.RegisterInformationID = this.RegisterInformationID;
		ApplicantDBAccess applicantDBAccess = new ApplicantDBAccess();
		if (applicantDBAccess.Insert(applicant)>0)
			return (true);
		return (false);
	}

	public bool AddCommissionVerdict(CommissionVerdict commissionVerdict)
	{
		commissionVerdict.RegisterInformationID = this.RegisterInformationID;
		CommissionVerdictDBAccess commissionVerdictDBAccess = new CommissionVerdictDBAccess();
		if (commissionVerdictDBAccess.Insert(commissionVerdict)>0)
			return (true);
		return (false);
	}

	public bool AddDead(Dead dead)
	{
		dead.RegisterInformationID = this.RegisterInformationID;
		DeadDBAccess deadDBAccess = new DeadDBAccess();
		if (deadDBAccess.Insert(dead)>0)
			return (true);
		return (false);
	}

	public bool AddDeclaration(Declaration declaration)
	{
		declaration.RegisterInformationID = this.RegisterInformationID;
		DeclarationDBAccess declarationDBAccess = new DeclarationDBAccess();
		if (declarationDBAccess.Insert(declaration)>0)
			return (true);
		return (false);
	}

	public bool AddForm19(Form19 form19)
	{
		form19.Form19RegisterInformationID = this.RegisterInformationID;
		Form19DBAccess form19DBAccess = new Form19DBAccess();
		if (form19DBAccess.Insert(form19)>0)
			return (true);
		return (false);
	}

	public bool AddFormCommissionInvitation(FormCommissionInvitation formCommissionInvitation)
	{
		formCommissionInvitation.FormCommissionInvitationRegisterInformarionID = this.RegisterInformationID;
		FormCommissionInvitationDBAccess formCommissionInvitationDBAccess = new FormCommissionInvitationDBAccess();
		if (formCommissionInvitationDBAccess.Insert(formCommissionInvitation)>0)
			return (true);
		return (false);
	}

	public bool AddFormDeclarationDelivery(FormDeclarationDelivery formDeclarationDelivery)
	{
		formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationID = this.RegisterInformationID;
		FormDeclarationDeliveryDBAccess formDeclarationDeliveryDBAccess = new FormDeclarationDeliveryDBAccess();
		if (formDeclarationDeliveryDBAccess.Insert(formDeclarationDelivery)>0)
			return (true);
		return (false);
	}

	public bool AddFormDeclarationInputInfo(FormDeclarationInputInfo formDeclarationInputInfo)
	{
		formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationID = this.RegisterInformationID;
		FormDeclarationInputInfoDBAccess formDeclarationInputInfoDBAccess = new FormDeclarationInputInfoDBAccess();
		if (formDeclarationInputInfoDBAccess.Insert(formDeclarationInputInfo)>0)
			return (true);
		return (false);
	}

	public bool AddFormDeterministicPaper(FormDeterministicPaper formDeterministicPaper)
	{
		formDeterministicPaper.FormDeterministicPaperRegisterInformationID = this.RegisterInformationID;
		FormDeterministicPaperDBAccess formDeterministicPaperDBAccess = new FormDeterministicPaperDBAccess();
		if (formDeterministicPaperDBAccess.Insert(formDeterministicPaper)>0)
			return (true);
		return (false);
	}

	public bool AddFormDiagnosisPaper(FormDiagnosisPaper formDiagnosisPaper)
	{
		formDiagnosisPaper.FormDiagnosisPaperRegisterInformationID = this.RegisterInformationID;
		FormDiagnosisPaperDBAccess formDiagnosisPaperDBAccess = new FormDiagnosisPaperDBAccess();
		if (formDiagnosisPaperDBAccess.Insert(formDiagnosisPaper)>0)
			return (true);
		return (false);
	}

	public bool AddFormDiagnosisResult(FormDiagnosisResult formDiagnosisResult)
	{
		formDiagnosisResult.FormDiagnosisResultRegisterInformationID = this.RegisterInformationID;
		FormDiagnosisResultDBAccess formDiagnosisResultDBAccess = new FormDiagnosisResultDBAccess();
		if (formDiagnosisResultDBAccess.Insert(formDiagnosisResult)>0)
			return (true);
		return (false);
	}

	public bool AddFormFreedom(FormFreedom formFreedom)
	{
		formFreedom.FormFreedomRegisterInformationID = this.RegisterInformationID;
		FormFreedomDBAccess formFreedomDBAccess = new FormFreedomDBAccess();
		if (formFreedomDBAccess.Insert(formFreedom)>0)
			return (true);
		return (false);
	}

	public bool AddFormHeritageBill(FormHeritageBill formHeritageBill)
	{
		formHeritageBill.FormHeritageBillRegisterInformationID = this.RegisterInformationID;
		FormHeritageBillDBAccess formHeritageBillDBAccess = new FormHeritageBillDBAccess();
		if (formHeritageBillDBAccess.Insert(formHeritageBill)>0)
			return (true);
		return (false);
	}

	public bool AddFormHeritageEvaluation(FormHeritageEvaluation formHeritageEvaluation)
	{
		formHeritageEvaluation.FormHeritageEvaluationRegisterInformationID = this.RegisterInformationID;
		FormHeritageEvaluationDBAccess formHeritageEvaluationDBAccess = new FormHeritageEvaluationDBAccess();
		if (formHeritageEvaluationDBAccess.Insert(formHeritageEvaluation)>0)
			return (true);
		return (false);
	}

	public bool AddFormTaxBill(FormTaxBill formTaxBill)
	{
		formTaxBill.FormTaxBillRegisterInformationID = this.RegisterInformationID;
		FormTaxBillDBAccess formTaxBillDBAccess = new FormTaxBillDBAccess();
		if (formTaxBillDBAccess.Insert(formTaxBill)>0)
			return (true);
		return (false);
	}

	public bool AddFormTaxPaymentCertificate(FormTaxPaymentCertificate formTaxPaymentCertificate)
	{
		formTaxPaymentCertificate.FormTaxPayementCertificateRegisterInformationID = this.RegisterInformationID;
		FormTaxPaymentCertificateDBAccess formTaxPaymentCertificateDBAccess = new FormTaxPaymentCertificateDBAccess();
		if (formTaxPaymentCertificateDBAccess.Insert(formTaxPaymentCertificate)>0)
			return (true);
		return (false);
	}

	public bool AddHeir(Heir heir)
	{
		heir.RegisterInformationID = this.RegisterInformationID;
		HeirDBAccess heirDBAccess = new HeirDBAccess();
		if (heirDBAccess.Insert(heir)>0)
			return (true);
		return (false);
	}

	public bool AddInquiryResponse(InquiryResponse inquiryResponse)
	{
		inquiryResponse.RegisterInformationID = this.RegisterInformationID;
		InquiryResponseDBAccess inquiryResponseDBAccess = new InquiryResponseDBAccess();
		if (inquiryResponseDBAccess.Insert(inquiryResponse)>0)
			return (true);
		return (false);
	}

	public bool AddReDiagnosisRequest(ReDiagnosisRequest reDiagnosisRequest)
	{
		reDiagnosisRequest.RegisterInformationID = this.RegisterInformationID;
		ReDiagnosisRequestDBAccess reDiagnosisRequestDBAccess = new ReDiagnosisRequestDBAccess();
		if (reDiagnosisRequestDBAccess.Insert(reDiagnosisRequest)>0)
			return (true);
		return (false);
	}

	public bool AddReports(Reports reports)
	{
		reports.RegisterInformationID = this.RegisterInformationID;
		ReportsDBAccess reportsDBAccess = new ReportsDBAccess();
		if (reportsDBAccess.Insert(reports)>0)
			return (true);
		return (false);
	}

	public bool AddUtterer(Utterer utterer)
	{
		utterer.RegisterInformationID = this.RegisterInformationID;
		UttererDBAccess uttererDBAccess = new UttererDBAccess();
		if (uttererDBAccess.Insert(utterer)>0)
			return (true);
		return (false);
	}

}
}
