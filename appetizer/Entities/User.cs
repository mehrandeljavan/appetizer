using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class User : Person
{
	private string userFullName;
	private string provinceIDDefaultTitle;
	private string password;
	private string personalCode;
	private string startDate;
	private string endDate;
	private int? signature;
	private int provinceIDDefault;
	private bool signaturePrint;
	private bool isActive;
	private List<FormDeclarationDelivery> formDeclarationDeliveryList;
	private List<FormDeclarationInputInfo> formDeclarationInputInfoList;
	private List<FormDeterministicPaper> formDeterministicPaperList;
	private List<FormDiagnosisPaper> formDiagnosisPaperList;
	private List<FormHeritageBill> formHeritageBillList;
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
	private List<PhysicalDossierDelivery> physicalDossierDeliveryList;
	private List<Question> questionList;
	private List<QuestionScore> questionScoreList;
	private List<UserDossier> userDossierList;
	private List<UserTaxOfficeActivityRolePart> userTaxOfficeActivityRolePartList;
	private List<UserTaxOfficeRolePart> userTaxOfficeRolePartList;

	public string UserFullName
	{
		get
		{
			return userFullName;
		}
		set
		{
			userFullName = value;
		}
	}

	public string ProvinceIDDefaultTitle
	{
		get
		{
			return provinceIDDefaultTitle;
		}
		set
		{
			provinceIDDefaultTitle = value;
		}
	}

	public string Password
	{
		get
		{
			return password;
		}
		set
		{
			password = value;
		}
	}

	public string PersonalCode
	{
		get
		{
			return personalCode;
		}
		set
		{
			personalCode = value;
		}
	}

	public string StartDate
	{
		get
		{
			return startDate;
		}
		set
		{
			startDate = value;
		}
	}

	public string EndDate
	{
		get
		{
			return endDate;
		}
		set
		{
			endDate = value;
		}
	}

	public int? Signature
	{
		get
		{
			return signature;
		}
		set
		{
			signature = value;
		}
	}

	public int ProvinceIDDefault
	{
		get
		{
			return provinceIDDefault;
		}
		set
		{
			provinceIDDefault = value;
		}
	}

	public bool SignaturePrint
	{
		get
		{
			return signaturePrint;
		}
		set
		{
			signaturePrint = value;
		}
	}

	public bool IsActive
	{
		get
		{
			return isActive;
		}
		set
		{
			isActive = value;
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

	public List<PhysicalDossierDelivery> PhysicalDossierDeliveryList
	{
		get
		{
			return physicalDossierDeliveryList;
		}
		set
		{
			physicalDossierDeliveryList = value;
		}
	}

	public List<Question> QuestionList
	{
		get
		{
			return questionList;
		}
		set
		{
			questionList = value;
		}
	}

	public List<QuestionScore> QuestionScoreList
	{
		get
		{
			return questionScoreList;
		}
		set
		{
			questionScoreList = value;
		}
	}

	public List<UserDossier> UserDossierList
	{
		get
		{
			return userDossierList;
		}
		set
		{
			userDossierList = value;
		}
	}

	public List<UserTaxOfficeActivityRolePart> UserTaxOfficeActivityRolePartList
	{
		get
		{
			return userTaxOfficeActivityRolePartList;
		}
		set
		{
			userTaxOfficeActivityRolePartList = value;
		}
	}

	public List<UserTaxOfficeRolePart> UserTaxOfficeRolePartList
	{
		get
		{
			return userTaxOfficeRolePartList;
		}
		set
		{
			userTaxOfficeRolePartList = value;
		}
	}

	public List<FormDeclarationDelivery> GetListFormDeclarationDelivery()
	{
		FormDeclarationDeliveryList = new UserDBAccess().GetListFormDeclarationDelivery(this.NationalCode);
		return FormDeclarationDeliveryList;
	}

	public List<FormDeclarationInputInfo> GetListFormDeclarationInputInfo()
	{
		FormDeclarationInputInfoList = new UserDBAccess().GetListFormDeclarationInputInfo(this.NationalCode);
		return FormDeclarationInputInfoList;
	}

	public List<FormDeterministicPaper> GetListFormDeterministicPaper()
	{
		FormDeterministicPaperList = new UserDBAccess().GetListFormDeterministicPaper(this.NationalCode);
		return FormDeterministicPaperList;
	}

	public List<FormDiagnosisPaper> GetListFormDiagnosisPaper()
	{
		FormDiagnosisPaperList = new UserDBAccess().GetListFormDiagnosisPaper(this.NationalCode);
		return FormDiagnosisPaperList;
	}

	public List<FormHeritageBill> GetListFormHeritageBill()
	{
		FormHeritageBillList = new UserDBAccess().GetListFormHeritageBill(this.NationalCode);
		return FormHeritageBillList;
	}

	public List<FormHeritageList> GetListFormHeritageList()
	{
		FormHeritageListList = new UserDBAccess().GetListFormHeritageList(this.NationalCode);
		return FormHeritageListList;
	}

	public List<FormHeritagesDescriptions> GetListFormHeritagesDescriptions()
	{
		FormHeritagesDescriptionsList = new UserDBAccess().GetListFormHeritagesDescriptions(this.NationalCode);
		return FormHeritagesDescriptionsList;
	}

	public List<FormInquiryBankDeposit> GetListFormInquiryBankDeposit()
	{
		FormInquiryBankDepositList = new UserDBAccess().GetListFormInquiryBankDeposit(this.NationalCode);
		return FormInquiryBankDepositList;
	}

	public List<FormInquiryCompany> GetListFormInquiryCompany()
	{
		FormInquiryCompanyList = new UserDBAccess().GetListFormInquiryCompany(this.NationalCode);
		return FormInquiryCompanyList;
	}

	public List<FormInquiryEstate> GetListFormInquiryEstate()
	{
		FormInquiryEstateList = new UserDBAccess().GetListFormInquiryEstate(this.NationalCode);
		return FormInquiryEstateList;
	}

	public List<FormInquiryGoodWillEvaluation> GetListFormInquiryGoodWillEvaluation()
	{
		FormInquiryGoodWillEvaluationList = new UserDBAccess().GetListFormInquiryGoodWillEvaluation(this.NationalCode);
		return FormInquiryGoodWillEvaluationList;
	}

	public List<FormInquiryGoodWillScore> GetListFormInquiryGoodWillScore()
	{
		FormInquiryGoodWillScoreList = new UserDBAccess().GetListFormInquiryGoodWillScore(this.NationalCode);
		return FormInquiryGoodWillScoreList;
	}

	public List<FormInquiryOther> GetListFormInquiryOther()
	{
		FormInquiryOtherList = new UserDBAccess().GetListFormInquiryOther(this.NationalCode);
		return FormInquiryOtherList;
	}

	public List<FormInquiryTransferRightEvaluation> GetListFormInquiryTransferRightEvaluation()
	{
		FormInquiryTransferRightEvaluationList = new UserDBAccess().GetListFormInquiryTransferRightEvaluation(this.NationalCode);
		return FormInquiryTransferRightEvaluationList;
	}

	public List<FormInquiryTransferRightScore> GetListFormInquiryTransferRightScore()
	{
		FormInquiryTransferRightScoreList = new UserDBAccess().GetListFormInquiryTransferRightScore(this.NationalCode);
		return FormInquiryTransferRightScoreList;
	}

	public List<FormTaxBill> GetListFormTaxBill()
	{
		FormTaxBillList = new UserDBAccess().GetListFormTaxBill(this.NationalCode);
		return FormTaxBillList;
	}

	public List<PhysicalDossierDelivery> GetListPhysicalDossierDelivery()
	{
		PhysicalDossierDeliveryList = new UserDBAccess().GetListPhysicalDossierDelivery(this.NationalCode);
		return PhysicalDossierDeliveryList;
	}

	public List<Question> GetListQuestion()
	{
		QuestionList = new UserDBAccess().GetListQuestion(this.NationalCode);
		return QuestionList;
	}

	public List<QuestionScore> GetListQuestionScore()
	{
		QuestionScoreList = new UserDBAccess().GetListQuestionScore(this.NationalCode);
		return QuestionScoreList;
	}

	public List<UserDossier> GetListUserDossier()
	{
		UserDossierList = new UserDBAccess().GetListUserDossier(this.NationalCode);
		return UserDossierList;
	}

	public List<UserTaxOfficeActivityRolePart> GetListUserTaxOfficeActivityRolePart()
	{
		UserTaxOfficeActivityRolePartList = new UserDBAccess().GetListUserTaxOfficeActivityRolePart(this.NationalCode);
		return UserTaxOfficeActivityRolePartList;
	}

	public List<UserTaxOfficeRolePart> GetListUserTaxOfficeRolePart()
	{
		UserTaxOfficeRolePartList = new UserDBAccess().GetListUserTaxOfficeRolePart(this.NationalCode);
		return UserTaxOfficeRolePartList;
	}

	public bool AddFormDeclarationDelivery(FormDeclarationDelivery formDeclarationDelivery)
	{
		formDeclarationDelivery.FormDeclarationDeliveryRegisterarUserNationalCode = this.NationalCode;
		FormDeclarationDeliveryDBAccess formDeclarationDeliveryDBAccess = new FormDeclarationDeliveryDBAccess();
		if (formDeclarationDeliveryDBAccess.Insert(formDeclarationDelivery)>0)
			return (true);
		return (false);
	}

	public bool AddFormDeclarationInputInfo(FormDeclarationInputInfo formDeclarationInputInfo)
	{
		formDeclarationInputInfo.FormDeclarationInputInfoRegisterarUserNationalCode = this.NationalCode;
		FormDeclarationInputInfoDBAccess formDeclarationInputInfoDBAccess = new FormDeclarationInputInfoDBAccess();
		if (formDeclarationInputInfoDBAccess.Insert(formDeclarationInputInfo)>0)
			return (true);
		return (false);
	}

	public bool AddFormDeterministicPaper(FormDeterministicPaper formDeterministicPaper)
	{
		formDeterministicPaper.FormDeterministicPaperRegisterarUserNationalCode = this.NationalCode;
		FormDeterministicPaperDBAccess formDeterministicPaperDBAccess = new FormDeterministicPaperDBAccess();
		if (formDeterministicPaperDBAccess.Insert(formDeterministicPaper)>0)
			return (true);
		return (false);
	}

	public bool AddFormDiagnosisPaper(FormDiagnosisPaper formDiagnosisPaper)
	{
		formDiagnosisPaper.FormDiagnosisPaperRegisterarUserNationalCode = this.NationalCode;
		FormDiagnosisPaperDBAccess formDiagnosisPaperDBAccess = new FormDiagnosisPaperDBAccess();
		if (formDiagnosisPaperDBAccess.Insert(formDiagnosisPaper)>0)
			return (true);
		return (false);
	}

	public bool AddFormHeritageBill(FormHeritageBill formHeritageBill)
	{
		formHeritageBill.FormHeritageBillRegisterarUserNationalCode = this.NationalCode;
		FormHeritageBillDBAccess formHeritageBillDBAccess = new FormHeritageBillDBAccess();
		if (formHeritageBillDBAccess.Insert(formHeritageBill)>0)
			return (true);
		return (false);
	}

	public bool AddFormHeritageList(FormHeritageList formHeritageList)
	{
		formHeritageList.FormHeritageListRegisterarUserNationalCode = this.NationalCode;
		FormHeritageListDBAccess formHeritageListDBAccess = new FormHeritageListDBAccess();
		if (formHeritageListDBAccess.Insert(formHeritageList)>0)
			return (true);
		return (false);
	}

	public bool AddFormHeritagesDescriptions(FormHeritagesDescriptions formHeritagesDescriptions)
	{
		formHeritagesDescriptions.FormHeritagesDescriptionsRegisterarUserNationalCode = this.NationalCode;
		FormHeritagesDescriptionsDBAccess formHeritagesDescriptionsDBAccess = new FormHeritagesDescriptionsDBAccess();
		if (formHeritagesDescriptionsDBAccess.Insert(formHeritagesDescriptions)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryBankDeposit(FormInquiryBankDeposit formInquiryBankDeposit)
	{
		formInquiryBankDeposit.FormInquiryBankDepositRegisterarUserNationalCode = this.NationalCode;
		FormInquiryBankDepositDBAccess formInquiryBankDepositDBAccess = new FormInquiryBankDepositDBAccess();
		if (formInquiryBankDepositDBAccess.Insert(formInquiryBankDeposit)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryCompany(FormInquiryCompany formInquiryCompany)
	{
		formInquiryCompany.FormInquiryCompanyRegisterarUserNationalCode = this.NationalCode;
		FormInquiryCompanyDBAccess formInquiryCompanyDBAccess = new FormInquiryCompanyDBAccess();
		if (formInquiryCompanyDBAccess.Insert(formInquiryCompany)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryEstate(FormInquiryEstate formInquiryEstate)
	{
		formInquiryEstate.FormInquiryEstateRegisterarUserNationalCode = this.NationalCode;
		FormInquiryEstateDBAccess formInquiryEstateDBAccess = new FormInquiryEstateDBAccess();
		if (formInquiryEstateDBAccess.Insert(formInquiryEstate)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryGoodWillEvaluation(FormInquiryGoodWillEvaluation formInquiryGoodWillEvaluation)
	{
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterarUserNationalCode = this.NationalCode;
		FormInquiryGoodWillEvaluationDBAccess formInquiryGoodWillEvaluationDBAccess = new FormInquiryGoodWillEvaluationDBAccess();
		if (formInquiryGoodWillEvaluationDBAccess.Insert(formInquiryGoodWillEvaluation)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryGoodWillScore(FormInquiryGoodWillScore formInquiryGoodWillScore)
	{
		formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterarUserNationalCode = this.NationalCode;
		FormInquiryGoodWillScoreDBAccess formInquiryGoodWillScoreDBAccess = new FormInquiryGoodWillScoreDBAccess();
		if (formInquiryGoodWillScoreDBAccess.Insert(formInquiryGoodWillScore)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryOther(FormInquiryOther formInquiryOther)
	{
		formInquiryOther.FormInquiryOtherRegisterarUserNationalCode = this.NationalCode;
		FormInquiryOtherDBAccess formInquiryOtherDBAccess = new FormInquiryOtherDBAccess();
		if (formInquiryOtherDBAccess.Insert(formInquiryOther)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryTransferRightEvaluation(FormInquiryTransferRightEvaluation formInquiryTransferRightEvaluation)
	{
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterarUserNationalCode = this.NationalCode;
		FormInquiryTransferRightEvaluationDBAccess formInquiryTransferRightEvaluationDBAccess = new FormInquiryTransferRightEvaluationDBAccess();
		if (formInquiryTransferRightEvaluationDBAccess.Insert(formInquiryTransferRightEvaluation)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryTransferRightScore(FormInquiryTransferRightScore formInquiryTransferRightScore)
	{
		formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterarUserNationalCode = this.NationalCode;
		FormInquiryTransferRightScoreDBAccess formInquiryTransferRightScoreDBAccess = new FormInquiryTransferRightScoreDBAccess();
		if (formInquiryTransferRightScoreDBAccess.Insert(formInquiryTransferRightScore)>0)
			return (true);
		return (false);
	}

	public bool AddFormTaxBill(FormTaxBill formTaxBill)
	{
		formTaxBill.FormTaxBillRegisterarUserNationalCode = this.NationalCode;
		FormTaxBillDBAccess formTaxBillDBAccess = new FormTaxBillDBAccess();
		if (formTaxBillDBAccess.Insert(formTaxBill)>0)
			return (true);
		return (false);
	}

	public bool AddPhysicalDossierDelivery(PhysicalDossierDelivery physicalDossierDelivery)
	{
		physicalDossierDelivery.ToUserNationalCode = this.NationalCode;
		PhysicalDossierDeliveryDBAccess physicalDossierDeliveryDBAccess = new PhysicalDossierDeliveryDBAccess();
		if (physicalDossierDeliveryDBAccess.Insert(physicalDossierDelivery)>0)
			return (true);
		return (false);
	}

	public bool AddQuestion(Question question)
	{
		question.UserNationalCode = this.NationalCode;
		QuestionDBAccess questionDBAccess = new QuestionDBAccess();
		if (questionDBAccess.Insert(question)>0)
			return (true);
		return (false);
	}

	public bool AddQuestionScore(QuestionScore questionScore)
	{
		questionScore.UserNationalCode = this.NationalCode;
		QuestionScoreDBAccess questionScoreDBAccess = new QuestionScoreDBAccess();
		if (questionScoreDBAccess.Insert(questionScore)>0)
			return (true);
		return (false);
	}

	public bool AddUserDossier(UserDossier userDossier)
	{
		userDossier.UserNationalCode = this.NationalCode;
		UserDossierDBAccess userDossierDBAccess = new UserDossierDBAccess();
		if (userDossierDBAccess.Insert(userDossier)>0)
			return (true);
		return (false);
	}

	public bool AddUserTaxOfficeActivityRolePart(UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart)
	{
		userTaxOfficeActivityRolePart.UserNationalCode = this.NationalCode;
		UserTaxOfficeActivityRolePartDBAccess userTaxOfficeActivityRolePartDBAccess = new UserTaxOfficeActivityRolePartDBAccess();
		if (userTaxOfficeActivityRolePartDBAccess.Insert(userTaxOfficeActivityRolePart)>0)
			return (true);
		return (false);
	}

	public bool AddUserTaxOfficeRolePart(UserTaxOfficeRolePart userTaxOfficeRolePart)
	{
		userTaxOfficeRolePart.UserNationalCode = this.NationalCode;
		UserTaxOfficeRolePartDBAccess userTaxOfficeRolePartDBAccess = new UserTaxOfficeRolePartDBAccess();
		if (userTaxOfficeRolePartDBAccess.Insert(userTaxOfficeRolePart)>0)
			return (true);
		return (false);
	}

}
}
