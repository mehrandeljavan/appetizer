using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class UserHandler
{
	// Handle to the User DBAccess class
	UserDBAccess userDb = null;

	public UserHandler()
	{
		userDb = new UserDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of users, we can put some logic here if needed 
	public List<User> GetListAll()
	{
		return userDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of users, we can put some logic here if needed 
	public bool Update(User user)
	{
		return userDb.Update(user);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of users, we can put some logic here if needed 
	public User GetDetails(Int64 nationalCode)
	{
		return userDb.GetDetails(nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of users, we can put some logic here if needed 
	public bool Delete(Int64 nationalCode)
	{
		return userDb.Delete(nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of users, we can put some logic here if needed 
	public Int64 Insert(User user)
	{
		return userDb.Insert(user);
	}

	public bool Exists(User user)
	{
		return userDb.Exists(user);
	}

	public bool Exists(Int64 nationalCode)
	{
		return userDb.Exists(nationalCode);
	}

	public List<FormDeclarationDelivery> GetListFormDeclarationDelivery(Int64 nationalCode)
	{
		return userDb.GetListFormDeclarationDelivery(nationalCode);
	}

	public List<FormDeclarationInputInfo> GetListFormDeclarationInputInfo(Int64 nationalCode)
	{
		return userDb.GetListFormDeclarationInputInfo(nationalCode);
	}

	public List<FormDeterministicPaper> GetListFormDeterministicPaper(Int64 nationalCode)
	{
		return userDb.GetListFormDeterministicPaper(nationalCode);
	}

	public List<FormDiagnosisPaper> GetListFormDiagnosisPaper(Int64 nationalCode)
	{
		return userDb.GetListFormDiagnosisPaper(nationalCode);
	}

	public List<FormHeritageBill> GetListFormHeritageBill(Int64 nationalCode)
	{
		return userDb.GetListFormHeritageBill(nationalCode);
	}

	public List<FormHeritageList> GetListFormHeritageList(Int64 nationalCode)
	{
		return userDb.GetListFormHeritageList(nationalCode);
	}

	public List<FormHeritagesDescriptions> GetListFormHeritagesDescriptions(Int64 nationalCode)
	{
		return userDb.GetListFormHeritagesDescriptions(nationalCode);
	}

	public List<FormInquiryBankDeposit> GetListFormInquiryBankDeposit(Int64 nationalCode)
	{
		return userDb.GetListFormInquiryBankDeposit(nationalCode);
	}

	public List<FormInquiryCompany> GetListFormInquiryCompany(Int64 nationalCode)
	{
		return userDb.GetListFormInquiryCompany(nationalCode);
	}

	public List<FormInquiryEstate> GetListFormInquiryEstate(Int64 nationalCode)
	{
		return userDb.GetListFormInquiryEstate(nationalCode);
	}

	public List<FormInquiryGoodWillEvaluation> GetListFormInquiryGoodWillEvaluation(Int64 nationalCode)
	{
		return userDb.GetListFormInquiryGoodWillEvaluation(nationalCode);
	}

	public List<FormInquiryGoodWillScore> GetListFormInquiryGoodWillScore(Int64 nationalCode)
	{
		return userDb.GetListFormInquiryGoodWillScore(nationalCode);
	}

	public List<FormInquiryOther> GetListFormInquiryOther(Int64 nationalCode)
	{
		return userDb.GetListFormInquiryOther(nationalCode);
	}

	public List<FormInquiryTransferRightEvaluation> GetListFormInquiryTransferRightEvaluation(Int64 nationalCode)
	{
		return userDb.GetListFormInquiryTransferRightEvaluation(nationalCode);
	}

	public List<FormInquiryTransferRightScore> GetListFormInquiryTransferRightScore(Int64 nationalCode)
	{
		return userDb.GetListFormInquiryTransferRightScore(nationalCode);
	}

	public List<FormTaxBill> GetListFormTaxBill(Int64 nationalCode)
	{
		return userDb.GetListFormTaxBill(nationalCode);
	}

	public List<PhysicalDossierDelivery> GetListPhysicalDossierDelivery(Int64 nationalCode)
	{
		return userDb.GetListPhysicalDossierDelivery(nationalCode);
	}

	public List<Question> GetListQuestion(Int64 nationalCode)
	{
		return userDb.GetListQuestion(nationalCode);
	}

	public List<QuestionScore> GetListQuestionScore(Int64 nationalCode)
	{
		return userDb.GetListQuestionScore(nationalCode);
	}

	public List<UserDossier> GetListUserDossier(Int64 nationalCode)
	{
		return userDb.GetListUserDossier(nationalCode);
	}

	public List<UserTaxOfficeActivityRolePart> GetListUserTaxOfficeActivityRolePart(Int64 nationalCode)
	{
		return userDb.GetListUserTaxOfficeActivityRolePart(nationalCode);
	}

	public List<UserTaxOfficeRolePart> GetListUserTaxOfficeRolePart(Int64 nationalCode)
	{
		return userDb.GetListUserTaxOfficeRolePart(nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of users, we can put some logic here if needed 
	public List<User> SearchLike(User user)
	{
		return userDb.SearchLike(user);
	}

}
}
