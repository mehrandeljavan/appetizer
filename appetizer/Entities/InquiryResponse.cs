using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class InquiryResponse
{
	private Int64 inquiryResponseID;
	private string registerDate;
	private string oldRegisterDate;
	private string oldRegisterInformationID;
	private string owner;
	private string number;
	private string comments;
	private Int64 registerInformationID;
	private Int64 declarationID;
	private string responseDate;
	private List<FormInquiryBankDeposit> formInquiryBankDepositList;
	private List<FormInquiryCompany> formInquiryCompanyList;
	private List<FormInquiryEstate> formInquiryEstateList;
	private List<FormInquiryGoodWillEvaluation> formInquiryGoodWillEvaluationList;
	private List<FormInquiryGoodWillScore> formInquiryGoodWillScoreList;
	private List<FormInquiryOther> formInquiryOtherList;
	private List<FormInquiryTransferRightEvaluation> formInquiryTransferRightEvaluationList;
	private List<FormInquiryTransferRightScore> formInquiryTransferRightScoreList;

	public Int64 InquiryResponseID
	{
		get
		{
			return inquiryResponseID;
		}
		set
		{
			inquiryResponseID = value;
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

	public string Owner
	{
		get
		{
			return owner;
		}
		set
		{
			owner = value;
		}
	}

	public string Number
	{
		get
		{
			return number;
		}
		set
		{
			number = value;
		}
	}

	public string Comments
	{
		get
		{
			return comments;
		}
		set
		{
			comments = value;
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

	public string ResponseDate
	{
		get
		{
			return responseDate;
		}
		set
		{
			responseDate = value;
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

	public List<FormInquiryBankDeposit> GetListFormInquiryBankDeposit()
	{
		FormInquiryBankDepositList = new InquiryResponseDBAccess().GetListFormInquiryBankDeposit(this.InquiryResponseID);
		return FormInquiryBankDepositList;
	}

	public List<FormInquiryCompany> GetListFormInquiryCompany()
	{
		FormInquiryCompanyList = new InquiryResponseDBAccess().GetListFormInquiryCompany(this.InquiryResponseID);
		return FormInquiryCompanyList;
	}

	public List<FormInquiryEstate> GetListFormInquiryEstate()
	{
		FormInquiryEstateList = new InquiryResponseDBAccess().GetListFormInquiryEstate(this.InquiryResponseID);
		return FormInquiryEstateList;
	}

	public List<FormInquiryGoodWillEvaluation> GetListFormInquiryGoodWillEvaluation()
	{
		FormInquiryGoodWillEvaluationList = new InquiryResponseDBAccess().GetListFormInquiryGoodWillEvaluation(this.InquiryResponseID);
		return FormInquiryGoodWillEvaluationList;
	}

	public List<FormInquiryGoodWillScore> GetListFormInquiryGoodWillScore()
	{
		FormInquiryGoodWillScoreList = new InquiryResponseDBAccess().GetListFormInquiryGoodWillScore(this.InquiryResponseID);
		return FormInquiryGoodWillScoreList;
	}

	public List<FormInquiryOther> GetListFormInquiryOther()
	{
		FormInquiryOtherList = new InquiryResponseDBAccess().GetListFormInquiryOther(this.InquiryResponseID);
		return FormInquiryOtherList;
	}

	public List<FormInquiryTransferRightEvaluation> GetListFormInquiryTransferRightEvaluation()
	{
		FormInquiryTransferRightEvaluationList = new InquiryResponseDBAccess().GetListFormInquiryTransferRightEvaluation(this.InquiryResponseID);
		return FormInquiryTransferRightEvaluationList;
	}

	public List<FormInquiryTransferRightScore> GetListFormInquiryTransferRightScore()
	{
		FormInquiryTransferRightScoreList = new InquiryResponseDBAccess().GetListFormInquiryTransferRightScore(this.InquiryResponseID);
		return FormInquiryTransferRightScoreList;
	}

	public bool AddFormInquiryBankDeposit(FormInquiryBankDeposit formInquiryBankDeposit)
	{
		formInquiryBankDeposit.FormInquiryBankDepositFormInquiryResponseID = this.InquiryResponseID;
		FormInquiryBankDepositDBAccess formInquiryBankDepositDBAccess = new FormInquiryBankDepositDBAccess();
		if (formInquiryBankDepositDBAccess.Insert(formInquiryBankDeposit)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryCompany(FormInquiryCompany formInquiryCompany)
	{
		formInquiryCompany.FormInquiryCompanyFormInquiryResponseID = this.InquiryResponseID;
		FormInquiryCompanyDBAccess formInquiryCompanyDBAccess = new FormInquiryCompanyDBAccess();
		if (formInquiryCompanyDBAccess.Insert(formInquiryCompany)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryEstate(FormInquiryEstate formInquiryEstate)
	{
		formInquiryEstate.FormInquiryEstateFormInquiryResponseID = this.InquiryResponseID;
		FormInquiryEstateDBAccess formInquiryEstateDBAccess = new FormInquiryEstateDBAccess();
		if (formInquiryEstateDBAccess.Insert(formInquiryEstate)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryGoodWillEvaluation(FormInquiryGoodWillEvaluation formInquiryGoodWillEvaluation)
	{
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFormInquiryResponseID = this.InquiryResponseID;
		FormInquiryGoodWillEvaluationDBAccess formInquiryGoodWillEvaluationDBAccess = new FormInquiryGoodWillEvaluationDBAccess();
		if (formInquiryGoodWillEvaluationDBAccess.Insert(formInquiryGoodWillEvaluation)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryGoodWillScore(FormInquiryGoodWillScore formInquiryGoodWillScore)
	{
		formInquiryGoodWillScore.FormInquiryGoodWillScoreFormInquiryResponseID = this.InquiryResponseID;
		FormInquiryGoodWillScoreDBAccess formInquiryGoodWillScoreDBAccess = new FormInquiryGoodWillScoreDBAccess();
		if (formInquiryGoodWillScoreDBAccess.Insert(formInquiryGoodWillScore)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryOther(FormInquiryOther formInquiryOther)
	{
		formInquiryOther.FormInquiryOtherFormInquiryResponseID = this.InquiryResponseID;
		FormInquiryOtherDBAccess formInquiryOtherDBAccess = new FormInquiryOtherDBAccess();
		if (formInquiryOtherDBAccess.Insert(formInquiryOther)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryTransferRightEvaluation(FormInquiryTransferRightEvaluation formInquiryTransferRightEvaluation)
	{
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFormInquiryResponseID = this.InquiryResponseID;
		FormInquiryTransferRightEvaluationDBAccess formInquiryTransferRightEvaluationDBAccess = new FormInquiryTransferRightEvaluationDBAccess();
		if (formInquiryTransferRightEvaluationDBAccess.Insert(formInquiryTransferRightEvaluation)>0)
			return (true);
		return (false);
	}

	public bool AddFormInquiryTransferRightScore(FormInquiryTransferRightScore formInquiryTransferRightScore)
	{
		formInquiryTransferRightScore.FormInquiryTransferRightScoreFormInquiryResponseID = this.InquiryResponseID;
		FormInquiryTransferRightScoreDBAccess formInquiryTransferRightScoreDBAccess = new FormInquiryTransferRightScoreDBAccess();
		if (formInquiryTransferRightScoreDBAccess.Insert(formInquiryTransferRightScore)>0)
			return (true);
		return (false);
	}

}
}
