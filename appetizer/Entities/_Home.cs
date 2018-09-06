using System;
using System.Collections.Generic;
////using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
public class TaxApplication
{
	public List<Activities> Activities { get; set; }
	public List<AdjustmentHeritage> AdjustmentHeritage { get; set; }
	public List<Annunciation> Annunciation { get; set; }
	public List<AnnunciationPaperType> AnnunciationPaperType { get; set; }
	public List<AnnunciationPlace> AnnunciationPlace { get; set; }
	public List<AnnunciationResultType> AnnunciationResultType { get; set; }
	public List<AnnunciationToOthersReason> AnnunciationToOthersReason { get; set; }
	public List<AnnunciationToType> AnnunciationToType { get; set; }
	public List<Applicant> Applicant { get; set; }
	public List<ApplicantRole> ApplicantRole { get; set; }
	public List<Applications> Applications { get; set; }
	public List<Bank> Bank { get; set; }
	public List<BankAccountType> BankAccountType { get; set; }
	public List<BankCategory> BankCategory { get; set; }
	public List<BankDeposit> BankDeposit { get; set; }
	public List<BankType> BankType { get; set; }
	public List<BoolFieldsTitle> BoolFieldsTitle { get; set; }
	public List<BourseStock> BourseStock { get; set; }
	public List<CalculationType> CalculationType { get; set; }
	public List<CapitalAndCommodityDeposit> CapitalAndCommodityDeposit { get; set; }
	public List<Car> Car { get; set; }
	public List<City> City { get; set; }
	public List<CommissionAdjustmentHeritage> CommissionAdjustmentHeritage { get; set; }
	public List<CommissionInvitation> CommissionInvitation { get; set; }
	public List<CommissionInvitationType> CommissionInvitationType { get; set; }
	public List<CommissionType> CommissionType { get; set; }
	public List<CommissionVerdict> CommissionVerdict { get; set; }
	public List<CommissionVerdictType> CommissionVerdictType { get; set; }
	public List<CompanyType> CompanyType { get; set; }
	public List<ConvertLog> ConvertLog { get; set; }
	public List<Cost> Cost { get; set; }
	public List<CostType> CostType { get; set; }
	public List<Days> Days { get; set; }
	public List<Dead> Dead { get; set; }
	public List<Debts> Debts { get; set; }
	public List<DebtsType> DebtsType { get; set; }
	public List<Declaration> Declaration { get; set; }
	public List<DeclarationType> DeclarationType { get; set; }
	public List<DemandDocument> DemandDocument { get; set; }
	public List<Demands> Demands { get; set; }
	public List<DemandsType> DemandsType { get; set; }
	public List<Dictionary> Dictionary { get; set; }
	public List<Dossier> Dossier { get; set; }
	public List<DossierCartable> DossierCartable { get; set; }
	public List<Dowry> Dowry { get; set; }
	public List<EducationState> EducationState { get; set; }
	public List<EntityRule> EntityRule { get; set; }
	public List<Estate> Estate { get; set; }
	public List<EstateType> EstateType { get; set; }
	public List<Form19> Form19 { get; set; }
	public List<FormCommissionInvitation> FormCommissionInvitation { get; set; }
	public List<FormDeclarationDelivery> FormDeclarationDelivery { get; set; }
	public List<FormDeclarationInputInfo> FormDeclarationInputInfo { get; set; }
	public List<FormDeterministicPaper> FormDeterministicPaper { get; set; }
	public List<FormDiagnosisPaper> FormDiagnosisPaper { get; set; }
	public List<FormHeirWithShare> FormHeirWithShare { get; set; }
	public List<FormHeritageBill> FormHeritageBill { get; set; }
	public List<FormHeritageList> FormHeritageList { get; set; }
	public List<FormHeritagesDescriptions> FormHeritagesDescriptions { get; set; }
	public List<FormInquiryBankDeposit> FormInquiryBankDeposit { get; set; }
	public List<FormInquiryCompany> FormInquiryCompany { get; set; }
	public List<FormInquiryEstate> FormInquiryEstate { get; set; }
	public List<FormInquiryGoodWillEvaluation> FormInquiryGoodWillEvaluation { get; set; }
	public List<FormInquiryGoodWillScore> FormInquiryGoodWillScore { get; set; }
	public List<FormInquiryOther> FormInquiryOther { get; set; }
	public List<FormTaxBill> FormTaxBill { get; set; }
	public List<Gender> Gender { get; set; }
	public List<Hajj> Hajj { get; set; }
	public List<HajjType> HajjType { get; set; }
	public List<Heir> Heir { get; set; }
	public List<HeirNumber> HeirNumber { get; set; }
	public List<Heritage> Heritage { get; set; }
	public List<HomeFurnishings> HomeFurnishings { get; set; }
	public List<InquiryResponse> InquiryResponse { get; set; }
	public List<Jewel> Jewel { get; set; }
	public List<JusticeShares> JusticeShares { get; set; }
	public List<Logging> Logging { get; set; }
	public List<LogTitles> LogTitles { get; set; }
	public List<Machinery> Machinery { get; set; }
	public List<Marriage> Marriage { get; set; }
	public List<MartyrProfReference> MartyrProfReference { get; set; }
	public List<Nationality> Nationality { get; set; }
	public List<OperatorType> OperatorType { get; set; }
	public List<OtherDeductions> OtherDeductions { get; set; }
	public List<OtherProperties> OtherProperties { get; set; }
	public List<PartnershipPapers> PartnershipPapers { get; set; }
	public List<PartnershipPaperType> PartnershipPaperType { get; set; }
	public List<PartType> PartType { get; set; }
	public List<Person> Person { get; set; }
	public List<Phone> Phone { get; set; }
	public List<PhysicalState> PhysicalState { get; set; }
	public List<ProductionUnit> ProductionUnit { get; set; }
	public List<ProductionUnitType> ProductionUnitType { get; set; }
	public List<PropertiesNumber> PropertiesNumber { get; set; }
	public List<Province> Province { get; set; }
	public List<RegisterInformation> RegisterInformation { get; set; }
	public List<RegisterTypes> RegisterTypes { get; set; }
	public List<RegularAnnunciationReason> RegularAnnunciationReason { get; set; }
	public List<RegularAnnunciationType> RegularAnnunciationType { get; set; }
	public List<Relation> Relation { get; set; }
	public List<Religion_Din> Religion_Din { get; set; }
	public List<Religion_Mazhab> Religion_Mazhab { get; set; }
	public List<ReligiousDebt> ReligiousDebt { get; set; }
	public List<Reports> Reports { get; set; }
	public List<ReportType> ReportType { get; set; }
	public List<RequestType> RequestType { get; set; }
	public List<Residence> Residence { get; set; }
	public List<RolePart> RolePart { get; set; }
	public List<RolePartActivity> RolePartActivity { get; set; }
	public List<RoleType> RoleType { get; set; }
	public List<Score> Score { get; set; }
	public List<ScoreType> ScoreType { get; set; }
	public List<StockInOtherCompanies> StockInOtherCompanies { get; set; }
	public List<TaxOffice> TaxOffice { get; set; }
	public List<TaxRatios> TaxRatios { get; set; }
	public List<Tree> Tree { get; set; }
	public List<User> User { get; set; }
	public List<UserDossier> UserDossier { get; set; }
	public List<UserTaxOfficeActivityRolePart> UserTaxOfficeActivityRolePart { get; set; }
	public List<UserTaxOfficeRolePart> UserTaxOfficeRolePart { get; set; }
	public List<Utterer> Utterer { get; set; }
	public List<UttererRole> UttererRole { get; set; }
	public List<WeddingIndex> WeddingIndex { get; set; }
	public List<Well> Well { get; set; }
	public List<WellType> WellType { get; set; }
	public List<Will> Will { get; set; }
	public List<WillType> WillType { get; set; }

	public List<Activities> GetListActivities() { return new ActivitiesHandler().GetListAll(); }
	public List<AdjustmentHeritage> GetListAdjustmentHeritage() { return new AdjustmentHeritageHandler().GetListAll(); }
	public List<Annunciation> GetListAnnunciation() { return new AnnunciationHandler().GetListAll(); }
	public List<AnnunciationPaperType> GetListAnnunciationPaperType() { return new AnnunciationPaperTypeHandler().GetListAll(); }
	public List<AnnunciationPlace> GetListAnnunciationPlace() { return new AnnunciationPlaceHandler().GetListAll(); }
	public List<AnnunciationResultType> GetListAnnunciationResultType() { return new AnnunciationResultTypeHandler().GetListAll(); }
	public List<AnnunciationToOthersReason> GetListAnnunciationToOthersReason() { return new AnnunciationToOthersReasonHandler().GetListAll(); }
	public List<AnnunciationToType> GetListAnnunciationToType() { return new AnnunciationToTypeHandler().GetListAll(); }
	public List<Applicant> GetListApplicant() { return new ApplicantHandler().GetListAll(); }
	public List<ApplicantRole> GetListApplicantRole() { return new ApplicantRoleHandler().GetListAll(); }
	public List<Applications> GetListApplications() { return new ApplicationsHandler().GetListAll(); }
	public List<Bank> GetListBank() { return new BankHandler().GetListAll(); }
	public List<BankAccountType> GetListBankAccountType() { return new BankAccountTypeHandler().GetListAll(); }
	public List<BankCategory> GetListBankCategory() { return new BankCategoryHandler().GetListAll(); }
	public List<BankDeposit> GetListBankDeposit() { return new BankDepositHandler().GetListAll(); }
	public List<BankType> GetListBankType() { return new BankTypeHandler().GetListAll(); }
	public List<BoolFieldsTitle> GetListBoolFieldsTitle() { return new BoolFieldsTitleHandler().GetListAll(); }
	public List<BourseStock> GetListBourseStock() { return new BourseStockHandler().GetListAll(); }
	public List<CalculationType> GetListCalculationType() { return new CalculationTypeHandler().GetListAll(); }
	public List<CapitalAndCommodityDeposit> GetListCapitalAndCommodityDeposit() { return new CapitalAndCommodityDepositHandler().GetListAll(); }
	public List<Car> GetListCar() { return new CarHandler().GetListAll(); }
	public List<City> GetListCity() { return new CityHandler().GetListAll(); }
	public List<CommissionAdjustmentHeritage> GetListCommissionAdjustmentHeritage() { return new CommissionAdjustmentHeritageHandler().GetListAll(); }
	public List<CommissionInvitation> GetListCommissionInvitation() { return new CommissionInvitationHandler().GetListAll(); }
	public List<CommissionInvitationType> GetListCommissionInvitationType() { return new CommissionInvitationTypeHandler().GetListAll(); }
	public List<CommissionType> GetListCommissionType() { return new CommissionTypeHandler().GetListAll(); }
	public List<CommissionVerdict> GetListCommissionVerdict() { return new CommissionVerdictHandler().GetListAll(); }
	public List<CommissionVerdictType> GetListCommissionVerdictType() { return new CommissionVerdictTypeHandler().GetListAll(); }
	public List<CompanyType> GetListCompanyType() { return new CompanyTypeHandler().GetListAll(); }
	public List<ConvertLog> GetListConvertLog() { return new ConvertLogHandler().GetListAll(); }
	public List<Cost> GetListCost() { return new CostHandler().GetListAll(); }
	public List<CostType> GetListCostType() { return new CostTypeHandler().GetListAll(); }
	public List<Days> GetListDays() { return new DaysHandler().GetListAll(); }
	public List<Dead> GetListDead() { return new DeadHandler().GetListAll(); }
	public List<Debts> GetListDebts() { return new DebtsHandler().GetListAll(); }
	public List<DebtsType> GetListDebtsType() { return new DebtsTypeHandler().GetListAll(); }
	public List<Declaration> GetListDeclaration() { return new DeclarationHandler().GetListAll(); }
	public List<DeclarationType> GetListDeclarationType() { return new DeclarationTypeHandler().GetListAll(); }
	public List<DemandDocument> GetListDemandDocument() { return new DemandDocumentHandler().GetListAll(); }
	public List<Demands> GetListDemands() { return new DemandsHandler().GetListAll(); }
	public List<DemandsType> GetListDemandsType() { return new DemandsTypeHandler().GetListAll(); }
	public List<Dictionary> GetListDictionary() { return new DictionaryHandler().GetListAll(); }
	public List<Dossier> GetListDossier() { return new DossierHandler().GetListAll(); }
	public List<DossierCartable> GetListDossierCartable() { return new DossierCartableHandler().GetListAll(); }
	public List<Dowry> GetListDowry() { return new DowryHandler().GetListAll(); }
	public List<EducationState> GetListEducationState() { return new EducationStateHandler().GetListAll(); }
	public List<EntityRule> GetListEntityRule() { return new EntityRuleHandler().GetListAll(); }
	public List<Estate> GetListEstate() { return new EstateHandler().GetListAll(); }
	public List<EstateType> GetListEstateType() { return new EstateTypeHandler().GetListAll(); }
	public List<Form19> GetListForm19() { return new Form19Handler().GetListAll(); }
	public List<FormCommissionInvitation> GetListFormCommissionInvitation() { return new FormCommissionInvitationHandler().GetListAll(); }
	public List<FormDeclarationDelivery> GetListFormDeclarationDelivery() { return new FormDeclarationDeliveryHandler().GetListAll(); }
	public List<FormDeclarationInputInfo> GetListFormDeclarationInputInfo() { return new FormDeclarationInputInfoHandler().GetListAll(); }
	public List<FormDeterministicPaper> GetListFormDeterministicPaper() { return new FormDeterministicPaperHandler().GetListAll(); }
	public List<FormDiagnosisPaper> GetListFormDiagnosisPaper() { return new FormDiagnosisPaperHandler().GetListAll(); }
	public List<FormHeirWithShare> GetListFormHeirWithShare() { return new FormHeirWithShareHandler().GetListAll(); }
	public List<FormHeritageBill> GetListFormHeritageBill() { return new FormHeritageBillHandler().GetListAll(); }
	public List<FormHeritageList> GetListFormHeritageList() { return new FormHeritageListHandler().GetListAll(); }
	public List<FormHeritagesDescriptions> GetListFormHeritagesDescriptions() { return new FormHeritagesDescriptionsHandler().GetListAll(); }
	public List<FormInquiryBankDeposit> GetListFormInquiryBankDeposit() { return new FormInquiryBankDepositHandler().GetListAll(); }
	public List<FormInquiryCompany> GetListFormInquiryCompany() { return new FormInquiryCompanyHandler().GetListAll(); }
	public List<FormInquiryEstate> GetListFormInquiryEstate() { return new FormInquiryEstateHandler().GetListAll(); }
	public List<FormInquiryGoodWillEvaluation> GetListFormInquiryGoodWillEvaluation() { return new FormInquiryGoodWillEvaluationHandler().GetListAll(); }
	public List<FormInquiryGoodWillScore> GetListFormInquiryGoodWillScore() { return new FormInquiryGoodWillScoreHandler().GetListAll(); }
	public List<FormInquiryOther> GetListFormInquiryOther() { return new FormInquiryOtherHandler().GetListAll(); }
	public List<FormTaxBill> GetListFormTaxBill() { return new FormTaxBillHandler().GetListAll(); }
	public List<Gender> GetListGender() { return new GenderHandler().GetListAll(); }
	public List<Hajj> GetListHajj() { return new HajjHandler().GetListAll(); }
	public List<HajjType> GetListHajjType() { return new HajjTypeHandler().GetListAll(); }
	public List<Heir> GetListHeir() { return new HeirHandler().GetListAll(); }
	public List<HeirNumber> GetListHeirNumber() { return new HeirNumberHandler().GetListAll(); }
	public List<Heritage> GetListHeritage() { return new HeritageHandler().GetListAll(); }
	public List<HomeFurnishings> GetListHomeFurnishings() { return new HomeFurnishingsHandler().GetListAll(); }
	public List<InquiryResponse> GetListInquiryResponse() { return new InquiryResponseHandler().GetListAll(); }
	public List<Jewel> GetListJewel() { return new JewelHandler().GetListAll(); }
	public List<JusticeShares> GetListJusticeShares() { return new JusticeSharesHandler().GetListAll(); }
	public List<Logging> GetListLogging() { return new LoggingHandler().GetListAll(); }
	public List<LogTitles> GetListLogTitles() { return new LogTitlesHandler().GetListAll(); }
	public List<Machinery> GetListMachinery() { return new MachineryHandler().GetListAll(); }
	public List<Marriage> GetListMarriage() { return new MarriageHandler().GetListAll(); }
	public List<MartyrProfReference> GetListMartyrProfReference() { return new MartyrProfReferenceHandler().GetListAll(); }
	public List<Nationality> GetListNationality() { return new NationalityHandler().GetListAll(); }
	public List<OperatorType> GetListOperatorType() { return new OperatorTypeHandler().GetListAll(); }
	public List<OtherDeductions> GetListOtherDeductions() { return new OtherDeductionsHandler().GetListAll(); }
	public List<OtherProperties> GetListOtherProperties() { return new OtherPropertiesHandler().GetListAll(); }
	public List<PartnershipPapers> GetListPartnershipPapers() { return new PartnershipPapersHandler().GetListAll(); }
	public List<PartnershipPaperType> GetListPartnershipPaperType() { return new PartnershipPaperTypeHandler().GetListAll(); }
	public List<PartType> GetListPartType() { return new PartTypeHandler().GetListAll(); }
	public List<Person> GetListPerson() { return new PersonHandler().GetListAll(); }
	public List<Phone> GetListPhone() { return new PhoneHandler().GetListAll(); }
	public List<PhysicalState> GetListPhysicalState() { return new PhysicalStateHandler().GetListAll(); }
	public List<ProductionUnit> GetListProductionUnit() { return new ProductionUnitHandler().GetListAll(); }
	public List<ProductionUnitType> GetListProductionUnitType() { return new ProductionUnitTypeHandler().GetListAll(); }
	public List<PropertiesNumber> GetListPropertiesNumber() { return new PropertiesNumberHandler().GetListAll(); }
	public List<Province> GetListProvince() { return new ProvinceHandler().GetListAll(); }
	public List<RegisterInformation> GetListRegisterInformation() { return new RegisterInformationHandler().GetListAll(); }
	public List<RegisterTypes> GetListRegisterTypes() { return new RegisterTypesHandler().GetListAll(); }
	public List<RegularAnnunciationReason> GetListRegularAnnunciationReason() { return new RegularAnnunciationReasonHandler().GetListAll(); }
	public List<RegularAnnunciationType> GetListRegularAnnunciationType() { return new RegularAnnunciationTypeHandler().GetListAll(); }
	public List<Relation> GetListRelation() { return new RelationHandler().GetListAll(); }
	public List<Religion_Din> GetListReligion_Din() { return new Religion_DinHandler().GetListAll(); }
	public List<Religion_Mazhab> GetListReligion_Mazhab() { return new Religion_MazhabHandler().GetListAll(); }
	public List<ReligiousDebt> GetListReligiousDebt() { return new ReligiousDebtHandler().GetListAll(); }
	public List<Reports> GetListReports() { return new ReportsHandler().GetListAll(); }
	public List<ReportType> GetListReportType() { return new ReportTypeHandler().GetListAll(); }
	public List<RequestType> GetListRequestType() { return new RequestTypeHandler().GetListAll(); }
	public List<Residence> GetListResidence() { return new ResidenceHandler().GetListAll(); }
	public List<RolePart> GetListRolePart() { return new RolePartHandler().GetListAll(); }
	public List<RolePartActivity> GetListRolePartActivity() { return new RolePartActivityHandler().GetListAll(); }
	public List<RoleType> GetListRoleType() { return new RoleTypeHandler().GetListAll(); }
	public List<Score> GetListScore() { return new ScoreHandler().GetListAll(); }
	public List<ScoreType> GetListScoreType() { return new ScoreTypeHandler().GetListAll(); }
	public List<StockInOtherCompanies> GetListStockInOtherCompanies() { return new StockInOtherCompaniesHandler().GetListAll(); }
	public List<TaxOffice> GetListTaxOffice() { return new TaxOfficeHandler().GetListAll(); }
	public List<TaxRatios> GetListTaxRatios() { return new TaxRatiosHandler().GetListAll(); }
	public List<Tree> GetListTree() { return new TreeHandler().GetListAll(); }
	public List<User> GetListUser() { return new UserHandler().GetListAll(); }
	public List<UserDossier> GetListUserDossier() { return new UserDossierHandler().GetListAll(); }
	public List<UserTaxOfficeActivityRolePart> GetListUserTaxOfficeActivityRolePart() { return new UserTaxOfficeActivityRolePartHandler().GetListAll(); }
	public List<UserTaxOfficeRolePart> GetListUserTaxOfficeRolePart() { return new UserTaxOfficeRolePartHandler().GetListAll(); }
	public List<Utterer> GetListUtterer() { return new UttererHandler().GetListAll(); }
	public List<UttererRole> GetListUttererRole() { return new UttererRoleHandler().GetListAll(); }
	public List<WeddingIndex> GetListWeddingIndex() { return new WeddingIndexHandler().GetListAll(); }
	public List<Well> GetListWell() { return new WellHandler().GetListAll(); }
	public List<WellType> GetListWellType() { return new WellTypeHandler().GetListAll(); }
	public List<Will> GetListWill() { return new WillHandler().GetListAll(); }
	public List<WillType> GetListWillType() { return new WillTypeHandler().GetListAll(); }
}
}
