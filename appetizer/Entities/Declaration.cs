using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Declaration
{
	private Int64 declarationID;
	private string stageTitle;
	private string declarationTypeIDTitle;
	private string finalizerUserNationalCode1FullName;
	private string finalizerUserNationalCode2FullName;
	private string diagnosisFinalizerUserNationalCode1FullName;
	private string diagnosisFinalizerUserNationalCode2FullName;
	private string printRegisterDate;
	private string registerDate;
	private string registerInformationDate;
	private string oldRegisterInformationID;
	private string oldRegisterDate;
	private string printRegisterInformationID;
	private int stage;
	private int declarationTypeID;
	private bool? automaticShareCalculation1;
	private bool? automaticShareCalculation2;
	private string requestResource;
	private string requestNumber;
	private string declarationTitle;
	private Int64 dossierID;
	private Int64 registerInformationID;
	private Int64? willID;
	private Int64? finalizerUserNationalCode1;
	private Int64? finalizerUserNationalCode2;
	private Int64? diagnosisFinalizerUserNationalCode1;
	private Int64? diagnosisFinalizerUserNationalCode2;
	private Int64? diagnosisRegisterInformationID;
	private string declarationRegisterNumberInCentral;
	private string finalDate1;
	private string finalDate2;
	private string finalDateDiagnosis1;
	private string finalDateDiagnosis2;
	private string finalDateAdjustment;
	private string finalDateCommisionAdjustment;
	private string deliveryDate;
	private string declarationRegisterDateInCentral;
	private string requestDate;
	private string diagnosisRegisterDate;
	private List<Applicant> applicantList;
	private List<BankDeposit> bankDepositList;
	private List<BankDepositProfit> bankDepositProfitList;
	private List<BourseStock> bourseStockList;
	private List<CapitalAndCommodityDeposit> capitalAndCommodityDepositList;
	private List<Car> carList;
	private List<CommissionInvitation> commissionInvitationList;
	private List<Cost> costList;
	private List<Debts> debtsList;
	private List<Demands> demandsList;
	private List<Dowry> dowryList;
	private List<Estate> estateList;
	private List<FinancialRights> financialRightsList;
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
	private List<FormHeritageList> formHeritageListList;
	private List<FormHeritagesDescriptions> formHeritagesDescriptionsList;
	private List<FormInquiryBankDeposit> formInquiryBankDepositList;
	private List<FormInquiryCompany> formInquiryCompanyList;
	private List<FormInquiryEstate> formInquiryEstateList;
	private List<FormInquiryGoodWillEvaluation> formInquiryGoodWillEvaluationList;
	private List<FormInquiryGoodWillScore> formInquiryGoodWillScoreList;
	private List<FormInquiryOther> formInquiryOtherList;
	private List<FormInquiryTransferRightEvaluation> formInquiryTransferRightEvaluationList;
	private List<FormInquiryTransferRightScore> formInquiryTransferRightScoreList;
	private List<FormTaxBill> formTaxBillList;
	private List<FormTaxPaymentCertificate> formTaxPaymentCertificateList;
	private List<Hajj> hajjList;
	private List<Heir> heirList;
	private List<HeirNumber> heirNumberList;
	private List<HomeFurnishings> homeFurnishingsList;
	private List<InquiryResponse> inquiryResponseList;
	private List<Jewel> jewelList;
	private List<JusticeShares> justiceSharesList;
	private List<Machinery> machineryList;
	private List<OtherDeductions> otherDeductionsList;
	private List<OtherProperties> otherPropertiesList;
	private List<PartnershipPapers> partnershipPapersList;
	private List<Permit> permitList;
	private List<Phone> phoneList;
	private List<ProductionUnit> productionUnitList;
	private List<PropertiesNumber> propertiesNumberList;
	private List<ReDiagnosisRequest> reDiagnosisRequestList;
	private List<ReligiousDebt> religiousDebtList;
	private List<Request> requestList;
	private List<SafeBox> safeBoxList;
	private List<Score> scoreList;
	private List<StockInOtherCompanies> stockInOtherCompaniesList;
	private List<StockProfit> stockProfitList;
	private List<TransferRight> transferRightList;
	private List<Tree> treeList;
	private List<Utterer> uttererList;
	private List<Well> wellList;
	private List<Will> willList;

	public Int64 DeclarationID
	{
		get
		{
			return declarationID;
		}
		set
		{
			declarationID = value;
		}
	}

	public string StageTitle
	{
		get
		{
			return stageTitle;
		}
		set
		{
			stageTitle = value;
		}
	}

	public string DeclarationTypeIDTitle
	{
		get
		{
			return declarationTypeIDTitle;
		}
		set
		{
			declarationTypeIDTitle = value;
		}
	}

	public string FinalizerUserNationalCode1FullName
	{
		get
		{
			return finalizerUserNationalCode1FullName;
		}
		set
		{
			finalizerUserNationalCode1FullName = value;
		}
	}

	public string FinalizerUserNationalCode2FullName
	{
		get
		{
			return finalizerUserNationalCode2FullName;
		}
		set
		{
			finalizerUserNationalCode2FullName = value;
		}
	}

	public string DiagnosisFinalizerUserNationalCode1FullName
	{
		get
		{
			return diagnosisFinalizerUserNationalCode1FullName;
		}
		set
		{
			diagnosisFinalizerUserNationalCode1FullName = value;
		}
	}

	public string DiagnosisFinalizerUserNationalCode2FullName
	{
		get
		{
			return diagnosisFinalizerUserNationalCode2FullName;
		}
		set
		{
			diagnosisFinalizerUserNationalCode2FullName = value;
		}
	}

	public string PrintRegisterDate
	{
		get
		{
			return printRegisterDate;
		}
		set
		{
			printRegisterDate = value;
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

	public string RegisterInformationDate
	{
		get
		{
			return registerInformationDate;
		}
		set
		{
			registerInformationDate = value;
		}
	}

	public string OldRegisterInformationID
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

	public string PrintRegisterInformationID
	{
		get
		{
			return printRegisterInformationID;
		}
		set
		{
			printRegisterInformationID = value;
		}
	}

	public int Stage
	{
		get
		{
			return stage;
		}
		set
		{
			stage = value;
		}
	}

	public int DeclarationTypeID
	{
		get
		{
			return declarationTypeID;
		}
		set
		{
			declarationTypeID = value;
		}
	}

	public bool? AutomaticShareCalculation1
	{
		get
		{
			return automaticShareCalculation1;
		}
		set
		{
			automaticShareCalculation1 = value;
		}
	}

	public bool? AutomaticShareCalculation2
	{
		get
		{
			return automaticShareCalculation2;
		}
		set
		{
			automaticShareCalculation2 = value;
		}
	}

	public string RequestResource
	{
		get
		{
			return requestResource;
		}
		set
		{
			requestResource = value;
		}
	}

	public string RequestNumber
	{
		get
		{
			return requestNumber;
		}
		set
		{
			requestNumber = value;
		}
	}

	public string DeclarationTitle
	{
		get
		{
			return declarationTitle;
		}
		set
		{
			declarationTitle = value;
		}
	}

	public Int64 DossierID
	{
		get
		{
			return dossierID;
		}
		set
		{
			dossierID = value;
		}
	}

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

	public Int64? WillID
	{
		get
		{
			return willID;
		}
		set
		{
			willID = value;
		}
	}

	public Int64? FinalizerUserNationalCode1
	{
		get
		{
			return finalizerUserNationalCode1;
		}
		set
		{
			finalizerUserNationalCode1 = value;
		}
	}

	public Int64? FinalizerUserNationalCode2
	{
		get
		{
			return finalizerUserNationalCode2;
		}
		set
		{
			finalizerUserNationalCode2 = value;
		}
	}

	public Int64? DiagnosisFinalizerUserNationalCode1
	{
		get
		{
			return diagnosisFinalizerUserNationalCode1;
		}
		set
		{
			diagnosisFinalizerUserNationalCode1 = value;
		}
	}

	public Int64? DiagnosisFinalizerUserNationalCode2
	{
		get
		{
			return diagnosisFinalizerUserNationalCode2;
		}
		set
		{
			diagnosisFinalizerUserNationalCode2 = value;
		}
	}

	public Int64? DiagnosisRegisterInformationID
	{
		get
		{
			return diagnosisRegisterInformationID;
		}
		set
		{
			diagnosisRegisterInformationID = value;
		}
	}

	public string DeclarationRegisterNumberInCentral
	{
		get
		{
			return declarationRegisterNumberInCentral;
		}
		set
		{
			declarationRegisterNumberInCentral = value;
		}
	}

	public string FinalDate1
	{
		get
		{
			return finalDate1;
		}
		set
		{
			finalDate1 = value;
		}
	}

	public string FinalDate2
	{
		get
		{
			return finalDate2;
		}
		set
		{
			finalDate2 = value;
		}
	}

	public string FinalDateDiagnosis1
	{
		get
		{
			return finalDateDiagnosis1;
		}
		set
		{
			finalDateDiagnosis1 = value;
		}
	}

	public string FinalDateDiagnosis2
	{
		get
		{
			return finalDateDiagnosis2;
		}
		set
		{
			finalDateDiagnosis2 = value;
		}
	}

	public string FinalDateAdjustment
	{
		get
		{
			return finalDateAdjustment;
		}
		set
		{
			finalDateAdjustment = value;
		}
	}

	public string FinalDateCommisionAdjustment
	{
		get
		{
			return finalDateCommisionAdjustment;
		}
		set
		{
			finalDateCommisionAdjustment = value;
		}
	}

	public string DeliveryDate
	{
		get
		{
			return deliveryDate;
		}
		set
		{
			deliveryDate = value;
		}
	}

	public string DeclarationRegisterDateInCentral
	{
		get
		{
			return declarationRegisterDateInCentral;
		}
		set
		{
			declarationRegisterDateInCentral = value;
		}
	}

	public string RequestDate
	{
		get
		{
			return requestDate;
		}
		set
		{
			requestDate = value;
		}
	}

	public string DiagnosisRegisterDate
	{
		get
		{
			return diagnosisRegisterDate;
		}
		set
		{
			diagnosisRegisterDate = value;
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

	public List<BankDeposit> BankDepositList
	{
		get
		{
			return bankDepositList;
		}
		set
		{
			bankDepositList = value;
		}
	}

	public List<BankDepositProfit> BankDepositProfitList
	{
		get
		{
			return bankDepositProfitList;
		}
		set
		{
			bankDepositProfitList = value;
		}
	}

	public List<BourseStock> BourseStockList
	{
		get
		{
			return bourseStockList;
		}
		set
		{
			bourseStockList = value;
		}
	}

	public List<CapitalAndCommodityDeposit> CapitalAndCommodityDepositList
	{
		get
		{
			return capitalAndCommodityDepositList;
		}
		set
		{
			capitalAndCommodityDepositList = value;
		}
	}

	public List<Car> CarList
	{
		get
		{
			return carList;
		}
		set
		{
			carList = value;
		}
	}

	public List<CommissionInvitation> CommissionInvitationList
	{
		get
		{
			return commissionInvitationList;
		}
		set
		{
			commissionInvitationList = value;
		}
	}

	public List<Cost> CostList
	{
		get
		{
			return costList;
		}
		set
		{
			costList = value;
		}
	}

	public List<Debts> DebtsList
	{
		get
		{
			return debtsList;
		}
		set
		{
			debtsList = value;
		}
	}

	public List<Demands> DemandsList
	{
		get
		{
			return demandsList;
		}
		set
		{
			demandsList = value;
		}
	}

	public List<Dowry> DowryList
	{
		get
		{
			return dowryList;
		}
		set
		{
			dowryList = value;
		}
	}

	public List<Estate> EstateList
	{
		get
		{
			return estateList;
		}
		set
		{
			estateList = value;
		}
	}

	public List<FinancialRights> FinancialRightsList
	{
		get
		{
			return financialRightsList;
		}
		set
		{
			financialRightsList = value;
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

	public List<FormHeritageList> FormHeritageListList
	{
		get
		{
			return formHeritageListList;
		}
		set
		{
			formHeritageListList = value;
		}
	}

	public List<FormHeritagesDescriptions> FormHeritagesDescriptionsList
	{
		get
		{
			return formHeritagesDescriptionsList;
		}
		set
		{
			formHeritagesDescriptionsList = value;
		}
	}

	public List<FormInquiryBankDeposit> FormInquiryBankDepositList
	{
		get
		{
			return formInquiryBankDepositList;
		}
		set
		{
			formInquiryBankDepositList = value;
		}
	}

	public List<FormInquiryCompany> FormInquiryCompanyList
	{
		get
		{
			return formInquiryCompanyList;
		}
		set
		{
			formInquiryCompanyList = value;
		}
	}

	public List<FormInquiryEstate> FormInquiryEstateList
	{
		get
		{
			return formInquiryEstateList;
		}
		set
		{
			formInquiryEstateList = value;
		}
	}

	public List<FormInquiryGoodWillEvaluation> FormInquiryGoodWillEvaluationList
	{
		get
		{
			return formInquiryGoodWillEvaluationList;
		}
		set
		{
			formInquiryGoodWillEvaluationList = value;
		}
	}

	public List<FormInquiryGoodWillScore> FormInquiryGoodWillScoreList
	{
		get
		{
			return formInquiryGoodWillScoreList;
		}
		set
		{
			formInquiryGoodWillScoreList = value;
		}
	}

	public List<FormInquiryOther> FormInquiryOtherList
	{
		get
		{
			return formInquiryOtherList;
		}
		set
		{
			formInquiryOtherList = value;
		}
	}

	public List<FormInquiryTransferRightEvaluation> FormInquiryTransferRightEvaluationList
	{
		get
		{
			return formInquiryTransferRightEvaluationList;
		}
		set
		{
			formInquiryTransferRightEvaluationList = value;
		}
	}

	public List<FormInquiryTransferRightScore> FormInquiryTransferRightScoreList
	{
		get
		{
			return formInquiryTransferRightScoreList;
		}
		set
		{
			formInquiryTransferRightScoreList = value;
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

	public List<Hajj> HajjList
	{
		get
		{
			return hajjList;
		}
		set
		{
			hajjList = value;
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

	public List<HeirNumber> HeirNumberList
	{
		get
		{
			return heirNumberList;
		}
		set
		{
			heirNumberList = value;
		}
	}

	public List<HomeFurnishings> HomeFurnishingsList
	{
		get
		{
			return homeFurnishingsList;
		}
		set
		{
			homeFurnishingsList = value;
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

	public List<Jewel> JewelList
	{
		get
		{
			return jewelList;
		}
		set
		{
			jewelList = value;
		}
	}

	public List<JusticeShares> JusticeSharesList
	{
		get
		{
			return justiceSharesList;
		}
		set
		{
			justiceSharesList = value;
		}
	}

	public List<Machinery> MachineryList
	{
		get
		{
			return machineryList;
		}
		set
		{
			machineryList = value;
		}
	}

	public List<OtherDeductions> OtherDeductionsList
	{
		get
		{
			return otherDeductionsList;
		}
		set
		{
			otherDeductionsList = value;
		}
	}

	public List<OtherProperties> OtherPropertiesList
	{
		get
		{
			return otherPropertiesList;
		}
		set
		{
			otherPropertiesList = value;
		}
	}

	public List<PartnershipPapers> PartnershipPapersList
	{
		get
		{
			return partnershipPapersList;
		}
		set
		{
			partnershipPapersList = value;
		}
	}

	public List<Permit> PermitList
	{
		get
		{
			return permitList;
		}
		set
		{
			permitList = value;
		}
	}

	public List<Phone> PhoneList
	{
		get
		{
			return phoneList;
		}
		set
		{
			phoneList = value;
		}
	}

	public List<ProductionUnit> ProductionUnitList
	{
		get
		{
			return productionUnitList;
		}
		set
		{
			productionUnitList = value;
		}
	}

	public List<PropertiesNumber> PropertiesNumberList
	{
		get
		{
			return propertiesNumberList;
		}
		set
		{
			propertiesNumberList = value;
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

	public List<ReligiousDebt> ReligiousDebtList
	{
		get
		{
			return religiousDebtList;
		}
		set
		{
			religiousDebtList = value;
		}
	}

	public List<Request> RequestList
	{
		get
		{
			return requestList;
		}
		set
		{
			requestList = value;
		}
	}

	public List<SafeBox> SafeBoxList
	{
		get
		{
			return safeBoxList;
		}
		set
		{
			safeBoxList = value;
		}
	}

	public List<Score> ScoreList
	{
		get
		{
			return scoreList;
		}
		set
		{
			scoreList = value;
		}
	}

	public List<StockInOtherCompanies> StockInOtherCompaniesList
	{
		get
		{
			return stockInOtherCompaniesList;
		}
		set
		{
			stockInOtherCompaniesList = value;
		}
	}

	public List<StockProfit> StockProfitList
	{
		get
		{
			return stockProfitList;
		}
		set
		{
			stockProfitList = value;
		}
	}

	public List<TransferRight> TransferRightList
	{
		get
		{
			return transferRightList;
		}
		set
		{
			transferRightList = value;
		}
	}

	public List<Tree> TreeList
	{
		get
		{
			return treeList;
		}
		set
		{
			treeList = value;
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

	public List<Well> WellList
	{
		get
		{
			return wellList;
		}
		set
		{
			wellList = value;
		}
	}

	public List<Will> WillList
	{
		get
		{
			return willList;
		}
		set
		{
			willList = value;
		}
	}

	public List<Applicant> GetListApplicant()
	{
		ApplicantList = new DeclarationDBAccess().GetListApplicant(this.DeclarationID);
		return ApplicantList;
	}

	public List<BankDeposit> GetListBankDeposit()
	{
		BankDepositList = new DeclarationDBAccess().GetListBankDeposit(this.DeclarationID);
		return BankDepositList;
	}

	public List<BankDepositProfit> GetListBankDepositProfit()
	{
		BankDepositProfitList = new DeclarationDBAccess().GetListBankDepositProfit(this.DeclarationID);
		return BankDepositProfitList;
	}

	public List<BourseStock> GetListBourseStock()
	{
		BourseStockList = new DeclarationDBAccess().GetListBourseStock(this.DeclarationID);
		return BourseStockList;
	}

	public List<CapitalAndCommodityDeposit> GetListCapitalAndCommodityDeposit()
	{
		CapitalAndCommodityDepositList = new DeclarationDBAccess().GetListCapitalAndCommodityDeposit(this.DeclarationID);
		return CapitalAndCommodityDepositList;
	}

	public List<Car> GetListCar()
	{
		CarList = new DeclarationDBAccess().GetListCar(this.DeclarationID);
		return CarList;
	}

	public List<CommissionInvitation> GetListCommissionInvitation()
	{
		CommissionInvitationList = new DeclarationDBAccess().GetListCommissionInvitation(this.DeclarationID);
		return CommissionInvitationList;
	}

	public List<Cost> GetListCost()
	{
		CostList = new DeclarationDBAccess().GetListCost(this.DeclarationID);
		return CostList;
	}

	public List<Debts> GetListDebts()
	{
		DebtsList = new DeclarationDBAccess().GetListDebts(this.DeclarationID);
		return DebtsList;
	}

	public List<Demands> GetListDemands()
	{
		DemandsList = new DeclarationDBAccess().GetListDemands(this.DeclarationID);
		return DemandsList;
	}

	public List<Dowry> GetListDowry()
	{
		DowryList = new DeclarationDBAccess().GetListDowry(this.DeclarationID);
		return DowryList;
	}

	public List<Estate> GetListEstate()
	{
		EstateList = new DeclarationDBAccess().GetListEstate(this.DeclarationID);
		return EstateList;
	}

	public List<FinancialRights> GetListFinancialRights()
	{
		FinancialRightsList = new DeclarationDBAccess().GetListFinancialRights(this.DeclarationID);
		return FinancialRightsList;
	}

	public List<Form19> GetListForm19()
	{
		Form19List = new DeclarationDBAccess().GetListForm19(this.DeclarationID);
		return Form19List;
	}

	public List<FormCommissionInvitation> GetListFormCommissionInvitation()
	{
		FormCommissionInvitationList = new DeclarationDBAccess().GetListFormCommissionInvitation(this.DeclarationID);
		return FormCommissionInvitationList;
	}

	public List<FormDeclarationDelivery> GetListFormDeclarationDelivery()
	{
		FormDeclarationDeliveryList = new DeclarationDBAccess().GetListFormDeclarationDelivery(this.DeclarationID);
		return FormDeclarationDeliveryList;
	}

	public List<FormDeclarationInputInfo> GetListFormDeclarationInputInfo()
	{
		FormDeclarationInputInfoList = new DeclarationDBAccess().GetListFormDeclarationInputInfo(this.DeclarationID);
		return FormDeclarationInputInfoList;
	}

	public List<FormDeterministicPaper> GetListFormDeterministicPaper()
	{
		FormDeterministicPaperList = new DeclarationDBAccess().GetListFormDeterministicPaper(this.DeclarationID);
		return FormDeterministicPaperList;
	}

	public List<FormDiagnosisPaper> GetListFormDiagnosisPaper()
	{
		FormDiagnosisPaperList = new DeclarationDBAccess().GetListFormDiagnosisPaper(this.DeclarationID);
		return FormDiagnosisPaperList;
	}

	public List<FormDiagnosisResult> GetListFormDiagnosisResult()
	{
		FormDiagnosisResultList = new DeclarationDBAccess().GetListFormDiagnosisResult(this.DeclarationID);
		return FormDiagnosisResultList;
	}

	public List<FormFreedom> GetListFormFreedom()
	{
		FormFreedomList = new DeclarationDBAccess().GetListFormFreedom(this.DeclarationID);
		return FormFreedomList;
	}

	public List<FormHeritageBill> GetListFormHeritageBill()
	{
		FormHeritageBillList = new DeclarationDBAccess().GetListFormHeritageBill(this.DeclarationID);
		return FormHeritageBillList;
	}

	public List<FormHeritageEvaluation> GetListFormHeritageEvaluation()
	{
		FormHeritageEvaluationList = new DeclarationDBAccess().GetListFormHeritageEvaluation(this.DeclarationID);
		return FormHeritageEvaluationList;
	}

	public List<FormHeritageList> GetListFormHeritageList()
	{
		FormHeritageListList = new DeclarationDBAccess().GetListFormHeritageList(this.DeclarationID);
		return FormHeritageListList;
	}

	public List<FormHeritagesDescriptions> GetListFormHeritagesDescriptions()
	{
		FormHeritagesDescriptionsList = new DeclarationDBAccess().GetListFormHeritagesDescriptions(this.DeclarationID);
		return FormHeritagesDescriptionsList;
	}

	public List<FormInquiryBankDeposit> GetListFormInquiryBankDeposit()
	{
		FormInquiryBankDepositList = new DeclarationDBAccess().GetListFormInquiryBankDeposit(this.DeclarationID);
		return FormInquiryBankDepositList;
	}

	public List<FormInquiryCompany> GetListFormInquiryCompany()
	{
		FormInquiryCompanyList = new DeclarationDBAccess().GetListFormInquiryCompany(this.DeclarationID);
		return FormInquiryCompanyList;
	}

	public List<FormInquiryEstate> GetListFormInquiryEstate()
	{
		FormInquiryEstateList = new DeclarationDBAccess().GetListFormInquiryEstate(this.DeclarationID);
		return FormInquiryEstateList;
	}

	public List<FormInquiryGoodWillEvaluation> GetListFormInquiryGoodWillEvaluation()
	{
		FormInquiryGoodWillEvaluationList = new DeclarationDBAccess().GetListFormInquiryGoodWillEvaluation(this.DeclarationID);
		return FormInquiryGoodWillEvaluationList;
	}

	public List<FormInquiryGoodWillScore> GetListFormInquiryGoodWillScore()
	{
		FormInquiryGoodWillScoreList = new DeclarationDBAccess().GetListFormInquiryGoodWillScore(this.DeclarationID);
		return FormInquiryGoodWillScoreList;
	}

	public List<FormInquiryOther> GetListFormInquiryOther()
	{
		FormInquiryOtherList = new DeclarationDBAccess().GetListFormInquiryOther(this.DeclarationID);
		return FormInquiryOtherList;
	}

	public List<FormInquiryTransferRightEvaluation> GetListFormInquiryTransferRightEvaluation()
	{
		FormInquiryTransferRightEvaluationList = new DeclarationDBAccess().GetListFormInquiryTransferRightEvaluation(this.DeclarationID);
		return FormInquiryTransferRightEvaluationList;
	}

	public List<FormInquiryTransferRightScore> GetListFormInquiryTransferRightScore()
	{
		FormInquiryTransferRightScoreList = new DeclarationDBAccess().GetListFormInquiryTransferRightScore(this.DeclarationID);
		return FormInquiryTransferRightScoreList;
	}

	public List<FormTaxBill> GetListFormTaxBill()
	{
		FormTaxBillList = new DeclarationDBAccess().GetListFormTaxBill(this.DeclarationID);
		return FormTaxBillList;
	}

	public List<FormTaxPaymentCertificate> GetListFormTaxPaymentCertificate()
	{
		FormTaxPaymentCertificateList = new DeclarationDBAccess().GetListFormTaxPaymentCertificate(this.DeclarationID);
		return FormTaxPaymentCertificateList;
	}

	public List<Hajj> GetListHajj()
	{
		HajjList = new DeclarationDBAccess().GetListHajj(this.DeclarationID);
		return HajjList;
	}

	public List<Heir> GetListHeir()
	{
		HeirList = new DeclarationDBAccess().GetListHeir(this.DeclarationID);
		return HeirList;
	}

	public List<HeirNumber> GetListHeirNumber()
	{
		HeirNumberList = new DeclarationDBAccess().GetListHeirNumber(this.DeclarationID);
		return HeirNumberList;
	}

	public List<HomeFurnishings> GetListHomeFurnishings()
	{
		HomeFurnishingsList = new DeclarationDBAccess().GetListHomeFurnishings(this.DeclarationID);
		return HomeFurnishingsList;
	}

	public List<InquiryResponse> GetListInquiryResponse()
	{
		InquiryResponseList = new DeclarationDBAccess().GetListInquiryResponse(this.DeclarationID);
		return InquiryResponseList;
	}

	public List<Jewel> GetListJewel()
	{
		JewelList = new DeclarationDBAccess().GetListJewel(this.DeclarationID);
		return JewelList;
	}

	public List<JusticeShares> GetListJusticeShares()
	{
		JusticeSharesList = new DeclarationDBAccess().GetListJusticeShares(this.DeclarationID);
		return JusticeSharesList;
	}

	public List<Machinery> GetListMachinery()
	{
		MachineryList = new DeclarationDBAccess().GetListMachinery(this.DeclarationID);
		return MachineryList;
	}

	public List<OtherDeductions> GetListOtherDeductions()
	{
		OtherDeductionsList = new DeclarationDBAccess().GetListOtherDeductions(this.DeclarationID);
		return OtherDeductionsList;
	}

	public List<OtherProperties> GetListOtherProperties()
	{
		OtherPropertiesList = new DeclarationDBAccess().GetListOtherProperties(this.DeclarationID);
		return OtherPropertiesList;
	}

	public List<PartnershipPapers> GetListPartnershipPapers()
	{
		PartnershipPapersList = new DeclarationDBAccess().GetListPartnershipPapers(this.DeclarationID);
		return PartnershipPapersList;
	}

	public List<Permit> GetListPermit()
	{
		PermitList = new DeclarationDBAccess().GetListPermit(this.DeclarationID);
		return PermitList;
	}

	public List<Phone> GetListPhone()
	{
		PhoneList = new DeclarationDBAccess().GetListPhone(this.DeclarationID);
		return PhoneList;
	}

	public List<ProductionUnit> GetListProductionUnit()
	{
		ProductionUnitList = new DeclarationDBAccess().GetListProductionUnit(this.DeclarationID);
		return ProductionUnitList;
	}

	public List<PropertiesNumber> GetListPropertiesNumber()
	{
		PropertiesNumberList = new DeclarationDBAccess().GetListPropertiesNumber(this.DeclarationID);
		return PropertiesNumberList;
	}

	public List<ReDiagnosisRequest> GetListReDiagnosisRequest()
	{
		ReDiagnosisRequestList = new DeclarationDBAccess().GetListReDiagnosisRequest(this.DeclarationID);
		return ReDiagnosisRequestList;
	}

	public List<ReligiousDebt> GetListReligiousDebt()
	{
		ReligiousDebtList = new DeclarationDBAccess().GetListReligiousDebt(this.DeclarationID);
		return ReligiousDebtList;
	}

	public List<Request> GetListRequest()
	{
		RequestList = new DeclarationDBAccess().GetListRequest(this.DeclarationID);
		return RequestList;
	}

	public List<SafeBox> GetListSafeBox()
	{
		SafeBoxList = new DeclarationDBAccess().GetListSafeBox(this.DeclarationID);
		return SafeBoxList;
	}

	public List<Score> GetListScore()
	{
		ScoreList = new DeclarationDBAccess().GetListScore(this.DeclarationID);
		return ScoreList;
	}

	public List<StockInOtherCompanies> GetListStockInOtherCompanies()
	{
		StockInOtherCompaniesList = new DeclarationDBAccess().GetListStockInOtherCompanies(this.DeclarationID);
		return StockInOtherCompaniesList;
	}

	public List<StockProfit> GetListStockProfit()
	{
		StockProfitList = new DeclarationDBAccess().GetListStockProfit(this.DeclarationID);
		return StockProfitList;
	}

	public List<TransferRight> GetListTransferRight()
	{
		TransferRightList = new DeclarationDBAccess().GetListTransferRight(this.DeclarationID);
		return TransferRightList;
	}

	public List<Tree> GetListTree()
	{
		TreeList = new DeclarationDBAccess().GetListTree(this.DeclarationID);
		return TreeList;
	}

	public List<Utterer> GetListUtterer()
	{
		UttererList = new DeclarationDBAccess().GetListUtterer(this.DeclarationID);
		return UttererList;
	}

	public List<Well> GetListWell()
	{
		WellList = new DeclarationDBAccess().GetListWell(this.DeclarationID);
		return WellList;
	}

	public List<Will> GetListWill()
	{
		WillList = new DeclarationDBAccess().GetListWill(this.DeclarationID);
		return WillList;
	}

	public bool AddApplicant(Applicant applicant)
	{
		applicant.DeclarationID = this.DeclarationID;
		ApplicantDBAccess applicantDBAccess = new ApplicantDBAccess();
		if (applicantDBAccess.Insert(applicant)>0)
			return (true);
		return (false);
	}

	public bool AddBankDeposit(BankDeposit bankDeposit)
	{
		bankDeposit.DeclarationID = this.DeclarationID;
		BankDepositDBAccess bankDepositDBAccess = new BankDepositDBAccess();
		if (bankDepositDBAccess.Insert(bankDeposit)>0)
			return (true);
		return (false);
	}

	public bool AddBankDepositProfit(BankDepositProfit bankDepositProfit)
	{
		bankDepositProfit.DeclarationID = this.DeclarationID;
		BankDepositProfitDBAccess bankDepositProfitDBAccess = new BankDepositProfitDBAccess();
		if (bankDepositProfitDBAccess.Insert(bankDepositProfit)>0)
			return (true);
		return (false);
	}

	public bool AddBourseStock(BourseStock bourseStock)
	{
		bourseStock.DeclarationID = this.DeclarationID;
		BourseStockDBAccess bourseStockDBAccess = new BourseStockDBAccess();
		if (bourseStockDBAccess.Insert(bourseStock)>0)
			return (true);
		return (false);
	}

	public bool AddCapitalAndCommodityDeposit(CapitalAndCommodityDeposit capitalAndCommodityDeposit)
	{
		capitalAndCommodityDeposit.DeclarationID = this.DeclarationID;
		CapitalAndCommodityDepositDBAccess capitalAndCommodityDepositDBAccess = new CapitalAndCommodityDepositDBAccess();
		if (capitalAndCommodityDepositDBAccess.Insert(capitalAndCommodityDeposit)>0)
			return (true);
		return (false);
	}

	public bool AddCar(Car car)
	{
		car.DeclarationID = this.DeclarationID;
		CarDBAccess carDBAccess = new CarDBAccess();
		if (carDBAccess.Insert(car)>0)
			return (true);
		return (false);
	}

	public bool AddCommissionInvitation(CommissionInvitation commissionInvitation)
	{
		commissionInvitation.DeclarationID = this.DeclarationID;
		CommissionInvitationDBAccess commissionInvitationDBAccess = new CommissionInvitationDBAccess();
		if (commissionInvitationDBAccess.Insert(commissionInvitation)>0)
			return (true);
		return (false);
	}

	public bool AddCost(Cost cost)
	{
		cost.DeclarationID = this.DeclarationID;
		CostDBAccess costDBAccess = new CostDBAccess();
		if (costDBAccess.Insert(cost)>0)
			return (true);
		return (false);
	}

	public bool AddDebts(Debts debts)
	{
		debts.DeclarationID = this.DeclarationID;
		DebtsDBAccess debtsDBAccess = new DebtsDBAccess();
		if (debtsDBAccess.Insert(debts)>0)
			return (true);
		return (false);
	}

	public bool AddDemands(Demands demands)
	{
		demands.DeclarationID = this.DeclarationID;
		DemandsDBAccess demandsDBAccess = new DemandsDBAccess();
		if (demandsDBAccess.Insert(demands)>0)
			return (true);
		return (false);
	}

	public bool AddDowry(Dowry dowry)
	{
		dowry.DeclarationID = this.DeclarationID;
		DowryDBAccess dowryDBAccess = new DowryDBAccess();
		if (dowryDBAccess.Insert(dowry)>0)
			return (true);
		return (false);
	}

	public bool AddEstate(Estate estate)
	{
		estate.DeclarationID = this.DeclarationID;
		EstateDBAccess estateDBAccess = new EstateDBAccess();
		if (estateDBAccess.Insert(estate)>0)
			return (true);
		return (false);
	}

	public bool AddFinancialRights(FinancialRights financialRights)
	{
		financialRights.DeclarationID = this.DeclarationID;
		FinancialRightsDBAccess financialRightsDBAccess = new FinancialRightsDBAccess();
		if (financialRightsDBAccess.Insert(financialRights)>0)
			return (true);
		return (false);
	}

	public bool AddForm19(Form19 form19)
	{
		form19.Form19DeclarationID = this.DeclarationID;
		Form19DBAccess form19DBAccess = new Form19DBAccess();
		if (form19DBAccess.Insert(form19)>0)
			return (true);
		return (false);
	}

	public bool AddFormCommissionInvitation(FormCommissionInvitation formCommissionInvitation)
	{
		formCommissionInvitation.FormCommissionInvitationDeclarationID = this.DeclarationID;
		FormCommissionInvitationDBAccess formCommissionInvitationDBAccess = new FormCommissionInvitationDBAccess();
		if (formCommissionInvitationDBAccess.Insert(formCommissionInvitation)>0)
			return (true);
		return (false);
	}

	public bool AddFormDeclarationDelivery(FormDeclarationDelivery formDeclarationDelivery)
	{
		formDeclarationDelivery.FormDeclarationDeliveryDeclarationID = this.DeclarationID;
		FormDeclarationDeliveryDBAccess formDeclarationDeliveryDBAccess = new FormDeclarationDeliveryDBAccess();
		if (formDeclarationDeliveryDBAccess.Insert(formDeclarationDelivery)>0)
			return (true);
		return (false);
	}

	public bool AddFormDeclarationInputInfo(FormDeclarationInputInfo formDeclarationInputInfo)
	{
		formDeclarationInputInfo.FormDeclarationInputInfoDeclarationID = this.DeclarationID;
		FormDeclarationInputInfoDBAccess formDeclarationInputInfoDBAccess = new FormDeclarationInputInfoDBAccess();
		if (formDeclarationInputInfoDBAccess.Insert(formDeclarationInputInfo)>0)
			return (true);
		return (false);
	}

	public bool AddFormDeterministicPaper(FormDeterministicPaper formDeterministicPaper)
	{
		formDeterministicPaper.FormDeterministicPaperDeclarationID = this.DeclarationID;
		FormDeterministicPaperDBAccess formDeterministicPaperDBAccess = new FormDeterministicPaperDBAccess();
		if (formDeterministicPaperDBAccess.Insert(formDeterministicPaper)>0)
			return (true);
		return (false);
	}

	public bool AddFormDiagnosisPaper(FormDiagnosisPaper formDiagnosisPaper)
	{
		formDiagnosisPaper.FormDiagnosisPaperDeclarationID = this.DeclarationID;
		FormDiagnosisPaperDBAccess formDiagnosisPaperDBAccess = new FormDiagnosisPaperDBAccess();
		if (formDiagnosisPaperDBAccess.Insert(formDiagnosisPaper)>0)
			return (true);
		return (false);
	}

	public bool AddFormDiagnosisResult(FormDiagnosisResult formDiagnosisResult)
	{
		formDiagnosisResult.FormDiagnosisResultDeclarationID = this.DeclarationID;
		FormDiagnosisResultDBAccess formDiagnosisResultDBAccess = new FormDiagnosisResultDBAccess();
		if (formDiagnosisResultDBAccess.Insert(formDiagnosisResult)>0)
			return (true);
		return (false);
	}

	public bool AddFormFreedom(FormFreedom formFreedom)
	{
		formFreedom.FormFreedomDeclarationID = this.DeclarationID;
		FormFreedomDBAccess formFreedomDBAccess = new FormFreedomDBAccess();
		if (formFreedomDBAccess.Insert(formFreedom)>0)
			return (true);
		return (false);
	}

	public bool AddFormHeritageBill(FormHeritageBill formHeritageBill)
	{
		formHeritageBill.FormHeritageBillDeclarationID = this.DeclarationID;
		FormHeritageBillDBAccess formHeritageBillDBAccess = new FormHeritageBillDBAccess();
		if (formHeritageBillDBAccess.Insert(formHeritageBill)>0)
			return (true);
		return (false);
	}

	public bool AddFormHeritageEvaluation(FormHeritageEvaluation formHeritageEvaluation)
	{
		formHeritageEvaluation.FormHeritageEvaluationDeclarationID = this.DeclarationID;
		FormHeritageEvaluationDBAccess formHeritageEvaluationDBAccess = new FormHeritageEvaluationDBAccess();
		if (formHeritageEvaluationDBAccess.Insert(formHeritageEvaluation)>0)
			return (true);
		return (false);
	}

	public bool AddFormHeritageList(FormHeritageList formHeritageList)
	{
		formHeritageList.FormHeritageListDeclarationID = this.DeclarationID;
		FormHeritageListDBAccess formHeritageListDBAccess = new FormHeritageListDBAccess();
		if (formHeritageListDBAccess.Insert(formHeritageList)>0)
			return (true);
		return (false);
	}

	public bool AddFormHeritagesDescriptions(FormHeritagesDescriptions formHeritagesDescriptions)
	{
		formHeritagesDescriptions.FormHeritagesDescriptionsDeclarationID = this.DeclarationID;
		FormHeritagesDescriptionsDBAccess formHeritagesDescriptionsDBAccess = new FormHeritagesDescriptionsDBAccess();
		if (formHeritagesDescriptionsDBAccess.Insert(formHeritagesDescriptions)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryBankDeposit(FormInquiryBankDeposit formInquiryBankDeposit)
	{
		formInquiryBankDeposit.FormInquiryBankDepositDeclarationID = this.DeclarationID;
		FormInquiryBankDepositDBAccess formInquiryBankDepositDBAccess = new FormInquiryBankDepositDBAccess();
		if (formInquiryBankDepositDBAccess.Insert(formInquiryBankDeposit)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryCompany(FormInquiryCompany formInquiryCompany)
	{
		formInquiryCompany.FormInquiryCompanyDeclarationID = this.DeclarationID;
		FormInquiryCompanyDBAccess formInquiryCompanyDBAccess = new FormInquiryCompanyDBAccess();
		if (formInquiryCompanyDBAccess.Insert(formInquiryCompany)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryEstate(FormInquiryEstate formInquiryEstate)
	{
		formInquiryEstate.FormInquiryEstateDeclarationID = this.DeclarationID;
		FormInquiryEstateDBAccess formInquiryEstateDBAccess = new FormInquiryEstateDBAccess();
		if (formInquiryEstateDBAccess.Insert(formInquiryEstate)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryGoodWillEvaluation(FormInquiryGoodWillEvaluation formInquiryGoodWillEvaluation)
	{
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationlDeclarationID = this.DeclarationID;
		FormInquiryGoodWillEvaluationDBAccess formInquiryGoodWillEvaluationDBAccess = new FormInquiryGoodWillEvaluationDBAccess();
		if (formInquiryGoodWillEvaluationDBAccess.Insert(formInquiryGoodWillEvaluation)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryGoodWillScore(FormInquiryGoodWillScore formInquiryGoodWillScore)
	{
		formInquiryGoodWillScore.FormInquiryGoodWillScoreDeclarationID = this.DeclarationID;
		FormInquiryGoodWillScoreDBAccess formInquiryGoodWillScoreDBAccess = new FormInquiryGoodWillScoreDBAccess();
		if (formInquiryGoodWillScoreDBAccess.Insert(formInquiryGoodWillScore)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryOther(FormInquiryOther formInquiryOther)
	{
		formInquiryOther.FormInquiryOtherDeclarationID = this.DeclarationID;
		FormInquiryOtherDBAccess formInquiryOtherDBAccess = new FormInquiryOtherDBAccess();
		if (formInquiryOtherDBAccess.Insert(formInquiryOther)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryTransferRightEvaluation(FormInquiryTransferRightEvaluation formInquiryTransferRightEvaluation)
	{
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationlDeclarationID = this.DeclarationID;
		FormInquiryTransferRightEvaluationDBAccess formInquiryTransferRightEvaluationDBAccess = new FormInquiryTransferRightEvaluationDBAccess();
		if (formInquiryTransferRightEvaluationDBAccess.Insert(formInquiryTransferRightEvaluation)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryTransferRightScore(FormInquiryTransferRightScore formInquiryTransferRightScore)
	{
		formInquiryTransferRightScore.FormInquiryTransferRightScoreDeclarationID = this.DeclarationID;
		FormInquiryTransferRightScoreDBAccess formInquiryTransferRightScoreDBAccess = new FormInquiryTransferRightScoreDBAccess();
		if (formInquiryTransferRightScoreDBAccess.Insert(formInquiryTransferRightScore)>0)
			return (true);
		return (false);
	}

	public bool AddFormTaxBill(FormTaxBill formTaxBill)
	{
		formTaxBill.FormTaxBillDeclarationID = this.DeclarationID;
		FormTaxBillDBAccess formTaxBillDBAccess = new FormTaxBillDBAccess();
		if (formTaxBillDBAccess.Insert(formTaxBill)>0)
			return (true);
		return (false);
	}

	public bool AddFormTaxPaymentCertificate(FormTaxPaymentCertificate formTaxPaymentCertificate)
	{
		formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationID = this.DeclarationID;
		FormTaxPaymentCertificateDBAccess formTaxPaymentCertificateDBAccess = new FormTaxPaymentCertificateDBAccess();
		if (formTaxPaymentCertificateDBAccess.Insert(formTaxPaymentCertificate)>0)
			return (true);
		return (false);
	}

	public bool AddHajj(Hajj hajj)
	{
		hajj.DeclarationID = this.DeclarationID;
		HajjDBAccess hajjDBAccess = new HajjDBAccess();
		if (hajjDBAccess.Insert(hajj)>0)
			return (true);
		return (false);
	}

	public bool AddHeir(Heir heir)
	{
		heir.DeclarationID = this.DeclarationID;
		HeirDBAccess heirDBAccess = new HeirDBAccess();
		if (heirDBAccess.Insert(heir)>0)
			return (true);
		return (false);
	}

	public bool AddHeirNumber(HeirNumber heirNumber)
	{
		heirNumber.DeclarationID = this.DeclarationID;
		HeirNumberDBAccess heirNumberDBAccess = new HeirNumberDBAccess();
		if (heirNumberDBAccess.Insert(heirNumber)>0)
			return (true);
		return (false);
	}

	public bool AddHomeFurnishings(HomeFurnishings homeFurnishings)
	{
		homeFurnishings.DeclarationID = this.DeclarationID;
		HomeFurnishingsDBAccess homeFurnishingsDBAccess = new HomeFurnishingsDBAccess();
		if (homeFurnishingsDBAccess.Insert(homeFurnishings)>0)
			return (true);
		return (false);
	}

	public bool AddInquiryResponse(InquiryResponse inquiryResponse)
	{
		inquiryResponse.DeclarationID = this.DeclarationID;
		InquiryResponseDBAccess inquiryResponseDBAccess = new InquiryResponseDBAccess();
		if (inquiryResponseDBAccess.Insert(inquiryResponse)>0)
			return (true);
		return (false);
	}

	public bool AddJewel(Jewel jewel)
	{
		jewel.DeclarationID = this.DeclarationID;
		JewelDBAccess jewelDBAccess = new JewelDBAccess();
		if (jewelDBAccess.Insert(jewel)>0)
			return (true);
		return (false);
	}

	public bool AddJusticeShares(JusticeShares justiceShares)
	{
		justiceShares.DeclarationID = this.DeclarationID;
		JusticeSharesDBAccess justiceSharesDBAccess = new JusticeSharesDBAccess();
		if (justiceSharesDBAccess.Insert(justiceShares)>0)
			return (true);
		return (false);
	}

	public bool AddMachinery(Machinery machinery)
	{
		machinery.DeclarationID = this.DeclarationID;
		MachineryDBAccess machineryDBAccess = new MachineryDBAccess();
		if (machineryDBAccess.Insert(machinery)>0)
			return (true);
		return (false);
	}

	public bool AddOtherDeductions(OtherDeductions otherDeductions)
	{
		otherDeductions.DeclarationID = this.DeclarationID;
		OtherDeductionsDBAccess otherDeductionsDBAccess = new OtherDeductionsDBAccess();
		if (otherDeductionsDBAccess.Insert(otherDeductions)>0)
			return (true);
		return (false);
	}

	public bool AddOtherProperties(OtherProperties otherProperties)
	{
		otherProperties.DeclarationID = this.DeclarationID;
		OtherPropertiesDBAccess otherPropertiesDBAccess = new OtherPropertiesDBAccess();
		if (otherPropertiesDBAccess.Insert(otherProperties)>0)
			return (true);
		return (false);
	}

	public bool AddPartnershipPapers(PartnershipPapers partnershipPapers)
	{
		partnershipPapers.DeclarationID = this.DeclarationID;
		PartnershipPapersDBAccess partnershipPapersDBAccess = new PartnershipPapersDBAccess();
		if (partnershipPapersDBAccess.Insert(partnershipPapers)>0)
			return (true);
		return (false);
	}

	public bool AddPermit(Permit permit)
	{
		permit.DeclarationID = this.DeclarationID;
		PermitDBAccess permitDBAccess = new PermitDBAccess();
		if (permitDBAccess.Insert(permit)>0)
			return (true);
		return (false);
	}

	public bool AddPhone(Phone phone)
	{
		phone.DeclarationID = this.DeclarationID;
		PhoneDBAccess phoneDBAccess = new PhoneDBAccess();
		if (phoneDBAccess.Insert(phone)>0)
			return (true);
		return (false);
	}

	public bool AddProductionUnit(ProductionUnit productionUnit)
	{
		productionUnit.DeclarationID = this.DeclarationID;
		ProductionUnitDBAccess productionUnitDBAccess = new ProductionUnitDBAccess();
		if (productionUnitDBAccess.Insert(productionUnit)>0)
			return (true);
		return (false);
	}

	public bool AddPropertiesNumber(PropertiesNumber propertiesNumber)
	{
		propertiesNumber.DeclarationID = this.DeclarationID;
		PropertiesNumberDBAccess propertiesNumberDBAccess = new PropertiesNumberDBAccess();
		if (propertiesNumberDBAccess.Insert(propertiesNumber)>0)
			return (true);
		return (false);
	}

	public bool AddReDiagnosisRequest(ReDiagnosisRequest reDiagnosisRequest)
	{
		reDiagnosisRequest.DeclarationID = this.DeclarationID;
		ReDiagnosisRequestDBAccess reDiagnosisRequestDBAccess = new ReDiagnosisRequestDBAccess();
		if (reDiagnosisRequestDBAccess.Insert(reDiagnosisRequest)>0)
			return (true);
		return (false);
	}

	public bool AddReligiousDebt(ReligiousDebt religiousDebt)
	{
		religiousDebt.DeclarationID = this.DeclarationID;
		ReligiousDebtDBAccess religiousDebtDBAccess = new ReligiousDebtDBAccess();
		if (religiousDebtDBAccess.Insert(religiousDebt)>0)
			return (true);
		return (false);
	}

	public bool AddRequest(Request request)
	{
		request.DeclarationID = this.DeclarationID;
		RequestDBAccess requestDBAccess = new RequestDBAccess();
		if (requestDBAccess.Insert(request)>0)
			return (true);
		return (false);
	}

	public bool AddSafeBox(SafeBox safeBox)
	{
		safeBox.DeclarationID = this.DeclarationID;
		SafeBoxDBAccess safeBoxDBAccess = new SafeBoxDBAccess();
		if (safeBoxDBAccess.Insert(safeBox)>0)
			return (true);
		return (false);
	}

	public bool AddScore(Score score)
	{
		score.DeclarationID = this.DeclarationID;
		ScoreDBAccess scoreDBAccess = new ScoreDBAccess();
		if (scoreDBAccess.Insert(score)>0)
			return (true);
		return (false);
	}

	public bool AddStockInOtherCompanies(StockInOtherCompanies stockInOtherCompanies)
	{
		stockInOtherCompanies.DeclarationID = this.DeclarationID;
		StockInOtherCompaniesDBAccess stockInOtherCompaniesDBAccess = new StockInOtherCompaniesDBAccess();
		if (stockInOtherCompaniesDBAccess.Insert(stockInOtherCompanies)>0)
			return (true);
		return (false);
	}

	public bool AddStockProfit(StockProfit stockProfit)
	{
		stockProfit.DeclarationID = this.DeclarationID;
		StockProfitDBAccess stockProfitDBAccess = new StockProfitDBAccess();
		if (stockProfitDBAccess.Insert(stockProfit)>0)
			return (true);
		return (false);
	}

	public bool AddTransferRight(TransferRight transferRight)
	{
		transferRight.DeclarationID = this.DeclarationID;
		TransferRightDBAccess transferRightDBAccess = new TransferRightDBAccess();
		if (transferRightDBAccess.Insert(transferRight)>0)
			return (true);
		return (false);
	}

	public bool AddTree(Tree tree)
	{
		tree.DeclarationID = this.DeclarationID;
		TreeDBAccess treeDBAccess = new TreeDBAccess();
		if (treeDBAccess.Insert(tree)>0)
			return (true);
		return (false);
	}

	public bool AddUtterer(Utterer utterer)
	{
		utterer.DeclarationID = this.DeclarationID;
		UttererDBAccess uttererDBAccess = new UttererDBAccess();
		if (uttererDBAccess.Insert(utterer)>0)
			return (true);
		return (false);
	}

	public bool AddWell(Well well)
	{
		well.DeclarationID = this.DeclarationID;
		WellDBAccess wellDBAccess = new WellDBAccess();
		if (wellDBAccess.Insert(well)>0)
			return (true);
		return (false);
	}

	public bool AddWill(Will will)
	{
		will.DeclerationID = this.DeclarationID;
		WillDBAccess willDBAccess = new WillDBAccess();
		if (willDBAccess.Insert(will)>0)
			return (true);
		return (false);
	}

}
}
