using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class DeclarationHandler
{
	// Handle to the Declaration DBAccess class
	DeclarationDBAccess declarationDb = null;

	public DeclarationHandler()
	{
		declarationDb = new DeclarationDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of declarations, we can put some logic here if needed 
	public List<Declaration> GetListAll()
	{
		return declarationDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of declarations, we can put some logic here if needed 
	public bool Update(Declaration declaration)
	{
		return declarationDb.Update(declaration);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of declarations, we can put some logic here if needed 
	public Declaration GetDetails(Int64 declarationID)
	{
		return declarationDb.GetDetails(declarationID);
	}

	public Declaration GetDetails(Int64 declarationID , int stage)
	{
		return declarationDb.GetDetails(declarationID , stage);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of declarations, we can put some logic here if needed 
	public bool Delete(Int64 declarationID)
	{
		return declarationDb.Delete(declarationID);
	}

	public bool Delete(Int64 declarationID , int stage)
	{
		return declarationDb.Delete(declarationID , stage);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of declarations, we can put some logic here if needed 
	public Int64 Insert(Declaration declaration)
	{
		return declarationDb.Insert(declaration);
	}

	public bool Exists(Declaration declaration)
	{
		return declarationDb.Exists(declaration);
	}

	public bool Exists(Int64 declarationID)
	{
		return declarationDb.Exists(declarationID);
	}

	public List<Declaration> GetListByDeclarationDeclarationIDStage(Int64 declarationID,int stage)
	{
		return declarationDb.GetListByDeclarationDeclarationIDStage(declarationID,stage);
	}

	public List<Applicant> GetListApplicant(Int64 declarationID)
	{
		return declarationDb.GetListApplicant(declarationID);
	}

	public List<BankDeposit> GetListBankDeposit(Int64 declarationID)
	{
		return declarationDb.GetListBankDeposit(declarationID);
	}

	public List<BankDepositProfit> GetListBankDepositProfit(Int64 declarationID)
	{
		return declarationDb.GetListBankDepositProfit(declarationID);
	}

	public List<BourseStock> GetListBourseStock(Int64 declarationID)
	{
		return declarationDb.GetListBourseStock(declarationID);
	}

	public List<CapitalAndCommodityDeposit> GetListCapitalAndCommodityDeposit(Int64 declarationID)
	{
		return declarationDb.GetListCapitalAndCommodityDeposit(declarationID);
	}

	public List<Car> GetListCar(Int64 declarationID)
	{
		return declarationDb.GetListCar(declarationID);
	}

	public List<CommissionInvitation> GetListCommissionInvitation(Int64 declarationID)
	{
		return declarationDb.GetListCommissionInvitation(declarationID);
	}

	public List<Cost> GetListCost(Int64 declarationID)
	{
		return declarationDb.GetListCost(declarationID);
	}

	public List<Debts> GetListDebts(Int64 declarationID)
	{
		return declarationDb.GetListDebts(declarationID);
	}

	public List<Demands> GetListDemands(Int64 declarationID)
	{
		return declarationDb.GetListDemands(declarationID);
	}

	public List<Dowry> GetListDowry(Int64 declarationID)
	{
		return declarationDb.GetListDowry(declarationID);
	}

	public List<Estate> GetListEstate(Int64 declarationID)
	{
		return declarationDb.GetListEstate(declarationID);
	}

	public List<FinancialRights> GetListFinancialRights(Int64 declarationID)
	{
		return declarationDb.GetListFinancialRights(declarationID);
	}

	public List<Form19> GetListForm19(Int64 declarationID)
	{
		return declarationDb.GetListForm19(declarationID);
	}

	public List<FormCommissionInvitation> GetListFormCommissionInvitation(Int64 declarationID)
	{
		return declarationDb.GetListFormCommissionInvitation(declarationID);
	}

	public List<FormDeclarationDelivery> GetListFormDeclarationDelivery(Int64 declarationID)
	{
		return declarationDb.GetListFormDeclarationDelivery(declarationID);
	}

	public List<FormDeclarationInputInfo> GetListFormDeclarationInputInfo(Int64 declarationID)
	{
		return declarationDb.GetListFormDeclarationInputInfo(declarationID);
	}

	public List<FormDeterministicPaper> GetListFormDeterministicPaper(Int64 declarationID)
	{
		return declarationDb.GetListFormDeterministicPaper(declarationID);
	}

	public List<FormDiagnosisPaper> GetListFormDiagnosisPaper(Int64 declarationID)
	{
		return declarationDb.GetListFormDiagnosisPaper(declarationID);
	}

	public List<FormDiagnosisResult> GetListFormDiagnosisResult(Int64 declarationID)
	{
		return declarationDb.GetListFormDiagnosisResult(declarationID);
	}

	public List<FormFreedom> GetListFormFreedom(Int64 declarationID)
	{
		return declarationDb.GetListFormFreedom(declarationID);
	}

	public List<FormHeritageBill> GetListFormHeritageBill(Int64 declarationID)
	{
		return declarationDb.GetListFormHeritageBill(declarationID);
	}

	public List<FormHeritageEvaluation> GetListFormHeritageEvaluation(Int64 declarationID)
	{
		return declarationDb.GetListFormHeritageEvaluation(declarationID);
	}

	public List<FormHeritageList> GetListFormHeritageList(Int64 declarationID)
	{
		return declarationDb.GetListFormHeritageList(declarationID);
	}

	public List<FormHeritagesDescriptions> GetListFormHeritagesDescriptions(Int64 declarationID)
	{
		return declarationDb.GetListFormHeritagesDescriptions(declarationID);
	}

	public List<FormInquiryBankDeposit> GetListFormInquiryBankDeposit(Int64 declarationID)
	{
		return declarationDb.GetListFormInquiryBankDeposit(declarationID);
	}

	public List<FormInquiryCompany> GetListFormInquiryCompany(Int64 declarationID)
	{
		return declarationDb.GetListFormInquiryCompany(declarationID);
	}

	public List<FormInquiryEstate> GetListFormInquiryEstate(Int64 declarationID)
	{
		return declarationDb.GetListFormInquiryEstate(declarationID);
	}

	public List<FormInquiryGoodWillEvaluation> GetListFormInquiryGoodWillEvaluation(Int64 declarationID)
	{
		return declarationDb.GetListFormInquiryGoodWillEvaluation(declarationID);
	}

	public List<FormInquiryGoodWillScore> GetListFormInquiryGoodWillScore(Int64 declarationID)
	{
		return declarationDb.GetListFormInquiryGoodWillScore(declarationID);
	}

	public List<FormInquiryOther> GetListFormInquiryOther(Int64 declarationID)
	{
		return declarationDb.GetListFormInquiryOther(declarationID);
	}

	public List<FormInquiryTransferRightEvaluation> GetListFormInquiryTransferRightEvaluation(Int64 declarationID)
	{
		return declarationDb.GetListFormInquiryTransferRightEvaluation(declarationID);
	}

	public List<FormInquiryTransferRightScore> GetListFormInquiryTransferRightScore(Int64 declarationID)
	{
		return declarationDb.GetListFormInquiryTransferRightScore(declarationID);
	}

	public List<FormTaxBill> GetListFormTaxBill(Int64 declarationID)
	{
		return declarationDb.GetListFormTaxBill(declarationID);
	}

	public List<FormTaxPaymentCertificate> GetListFormTaxPaymentCertificate(Int64 declarationID)
	{
		return declarationDb.GetListFormTaxPaymentCertificate(declarationID);
	}

	public List<Hajj> GetListHajj(Int64 declarationID)
	{
		return declarationDb.GetListHajj(declarationID);
	}

	public List<Heir> GetListHeir(Int64 declarationID)
	{
		return declarationDb.GetListHeir(declarationID);
	}

	public List<HeirNumber> GetListHeirNumber(Int64 declarationID)
	{
		return declarationDb.GetListHeirNumber(declarationID);
	}

	public List<HomeFurnishings> GetListHomeFurnishings(Int64 declarationID)
	{
		return declarationDb.GetListHomeFurnishings(declarationID);
	}

	public List<InquiryResponse> GetListInquiryResponse(Int64 declarationID)
	{
		return declarationDb.GetListInquiryResponse(declarationID);
	}

	public List<Jewel> GetListJewel(Int64 declarationID)
	{
		return declarationDb.GetListJewel(declarationID);
	}

	public List<JusticeShares> GetListJusticeShares(Int64 declarationID)
	{
		return declarationDb.GetListJusticeShares(declarationID);
	}

	public List<Machinery> GetListMachinery(Int64 declarationID)
	{
		return declarationDb.GetListMachinery(declarationID);
	}

	public List<OtherDeductions> GetListOtherDeductions(Int64 declarationID)
	{
		return declarationDb.GetListOtherDeductions(declarationID);
	}

	public List<OtherProperties> GetListOtherProperties(Int64 declarationID)
	{
		return declarationDb.GetListOtherProperties(declarationID);
	}

	public List<PartnershipPapers> GetListPartnershipPapers(Int64 declarationID)
	{
		return declarationDb.GetListPartnershipPapers(declarationID);
	}

	public List<Permit> GetListPermit(Int64 declarationID)
	{
		return declarationDb.GetListPermit(declarationID);
	}

	public List<Phone> GetListPhone(Int64 declarationID)
	{
		return declarationDb.GetListPhone(declarationID);
	}

	public List<ProductionUnit> GetListProductionUnit(Int64 declarationID)
	{
		return declarationDb.GetListProductionUnit(declarationID);
	}

	public List<PropertiesNumber> GetListPropertiesNumber(Int64 declarationID)
	{
		return declarationDb.GetListPropertiesNumber(declarationID);
	}

	public List<ReDiagnosisRequest> GetListReDiagnosisRequest(Int64 declarationID)
	{
		return declarationDb.GetListReDiagnosisRequest(declarationID);
	}

	public List<ReligiousDebt> GetListReligiousDebt(Int64 declarationID)
	{
		return declarationDb.GetListReligiousDebt(declarationID);
	}

	public List<Request> GetListRequest(Int64 declarationID)
	{
		return declarationDb.GetListRequest(declarationID);
	}

	public List<SafeBox> GetListSafeBox(Int64 declarationID)
	{
		return declarationDb.GetListSafeBox(declarationID);
	}

	public List<Score> GetListScore(Int64 declarationID)
	{
		return declarationDb.GetListScore(declarationID);
	}

	public List<StockInOtherCompanies> GetListStockInOtherCompanies(Int64 declarationID)
	{
		return declarationDb.GetListStockInOtherCompanies(declarationID);
	}

	public List<StockProfit> GetListStockProfit(Int64 declarationID)
	{
		return declarationDb.GetListStockProfit(declarationID);
	}

	public List<TransferRight> GetListTransferRight(Int64 declarationID)
	{
		return declarationDb.GetListTransferRight(declarationID);
	}

	public List<Tree> GetListTree(Int64 declarationID)
	{
		return declarationDb.GetListTree(declarationID);
	}

	public List<Utterer> GetListUtterer(Int64 declarationID)
	{
		return declarationDb.GetListUtterer(declarationID);
	}

	public List<Well> GetListWell(Int64 declarationID)
	{
		return declarationDb.GetListWell(declarationID);
	}

	public List<Will> GetListWill(Int64 declarationID)
	{
		return declarationDb.GetListWill(declarationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of declarations, we can put some logic here if needed 
	public List<Declaration> SearchLike(Declaration declaration)
	{
		return declarationDb.SearchLike(declaration);
	}

}
}
