using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Heir : Person
{
	private Int64 heirID;
	private string relationIDTitle;
	private string educationStateIDTitle;
	private string marriageIDTitle;
	private string nationalityIDTitle;
	private string physicalStateIDTitle;
	private string residenceIDTitle;
	private string oldRegisterInformationID;
	private string oldRegisterDate;
	private int relationID;
	private int? nationalityID;
	private int? residenceID;
	private int physicalStateID;
	private int educationStateID;
	private int marriageID;
	private int? stage;
	private int? agreementTypeID;
	private float? declerativeShare;
	private float? diagnosisShare;
	private float handShare;
	private float? adjustmentTaxValue;
	private float? adjustmentIncomeValue;
	private float? commissionAdjustmentShareValue1;
	private float? commissionAdjustmentIncomeValue4;
	private float? commissionAdjustmentShareValue5;
	private float? commissionAdjustmentIncomeValue5;
	private float? commissionAdjustmentShareValue6;
	private float? commissionAdjustmentIncomeValue6;
	private float? commissionAdjustmentIncomeValue1;
	private float? commissionAdjustmentShareValue2;
	private float? commissionAdjustmentIncomeValue2;
	private float? commissionAdjustmentShareValue3;
	private float? commissionAdjustmentIncomeValue3;
	private float? commissionAdjustmentShareValue4;
	private bool? isDiagonesed;
	private Int64? parentHeirID;
	private Int64 declarationID;
	private Int64? registerInformationID;
	private Int64? adjustmentTaxRegisterInformationID;
	private Int64? commissionAdjustmentIncomeRegisterInformationID5;
	private Int64? commissionAdjustmentShareRegisterInformationID6;
	private Int64? commissionAdjustmentIncomeRegisterInformationID6;
	private Int64? commissionAdjustmentIncomeRegisterInformationID2;
	private Int64? commissionAdjustmentShareRegisterInformationID3;
	private Int64? commissionAdjustmentIncomeRegisterInformationID3;
	private Int64? commissionAdjustmentShareRegisterInformationID4;
	private Int64? commissionAdjustmentIncomeRegisterInformationID4;
	private Int64? commissionAdjustmentShareRegisterInformationID5;
	private Int64? adjustmentIncomeRegisterInformationID;
	private Int64? commissionAdjustmentShareRegisterInformationID1;
	private Int64? commissionAdjustmentIncomeRegisterInformationID1;
	private Int64? adjustmentHeritageRegisterInformationID;
	private Int64? commissionAdjustmentHeritageRegisterInformationID;
	private Int64? commissionAdjustmentShareRegisterInformationID2;
	private string adjustmentTaxDate;
	private string adjustmentIncomeDate;
	private string commissionAdjustmentShareDate1;
	private string commissionAdjustmentIncomeDate1;
	private string adjustmentHeritageDate;
	private string commissionAdjustmentHeritageDate;
	private string commissionAdjustmentIncomeDate4;
	private string commissionAdjustmentShareDate5;
	private string commissionAdjustmentIncomeDate5;
	private string commissionAdjustmentShareDate6;
	private string commissionAdjustmentIncomeDate6;
	private string adjustmentFinalizationDate;
	private string commissionAdjustmentShareDate2;
	private string commissionAdjustmentIncomeDate2;
	private string commissionAdjustmentShareDate3;
	private string commissionAdjustmentIncomeDate3;
	private string commissionAdjustmentShareDate4;
	private List<AdjustmentHeritage> adjustmentHeritageList;
	private List<Annunciation> annunciationList;
	private List<CommissionAdjustmentHeritage> commissionAdjustmentHeritageList;
	private List<CommissionInvitation> commissionInvitationList;
	private List<CommissionVerdict> commissionVerdictList;

	public Int64 HeirID
	{
		get
		{
			return heirID;
		}
		set
		{
			heirID = value;
		}
	}

	public string RelationIDTitle
	{
		get
		{
			return relationIDTitle;
		}
		set
		{
			relationIDTitle = value;
		}
	}

	public string EducationStateIDTitle
	{
		get
		{
			return educationStateIDTitle;
		}
		set
		{
			educationStateIDTitle = value;
		}
	}

	public string MarriageIDTitle
	{
		get
		{
			return marriageIDTitle;
		}
		set
		{
			marriageIDTitle = value;
		}
	}

	public string NationalityIDTitle
	{
		get
		{
			return nationalityIDTitle;
		}
		set
		{
			nationalityIDTitle = value;
		}
	}

	public string PhysicalStateIDTitle
	{
		get
		{
			return physicalStateIDTitle;
		}
		set
		{
			physicalStateIDTitle = value;
		}
	}

	public string ResidenceIDTitle
	{
		get
		{
			return residenceIDTitle;
		}
		set
		{
			residenceIDTitle = value;
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

	public int RelationID
	{
		get
		{
			return relationID;
		}
		set
		{
			relationID = value;
		}
	}

	public int? NationalityID
	{
		get
		{
			return nationalityID;
		}
		set
		{
			nationalityID = value;
		}
	}

	public int? ResidenceID
	{
		get
		{
			return residenceID;
		}
		set
		{
			residenceID = value;
		}
	}

	public int PhysicalStateID
	{
		get
		{
			return physicalStateID;
		}
		set
		{
			physicalStateID = value;
		}
	}

	public int EducationStateID
	{
		get
		{
			return educationStateID;
		}
		set
		{
			educationStateID = value;
		}
	}

	public int MarriageID
	{
		get
		{
			return marriageID;
		}
		set
		{
			marriageID = value;
		}
	}

	public int? Stage
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

	public int? AgreementTypeID
	{
		get
		{
			return agreementTypeID;
		}
		set
		{
			agreementTypeID = value;
		}
	}

	public float? DeclerativeShare
	{
		get
		{
			return declerativeShare;
		}
		set
		{
			declerativeShare = value;
		}
	}

	public float? DiagnosisShare
	{
		get
		{
			return diagnosisShare;
		}
		set
		{
			diagnosisShare = value;
		}
	}

	public float HandShare
	{
		get
		{
			return handShare;
		}
		set
		{
			handShare = value;
		}
	}

	public float? AdjustmentTaxValue
	{
		get
		{
			return adjustmentTaxValue;
		}
		set
		{
			adjustmentTaxValue = value;
		}
	}

	public float? AdjustmentIncomeValue
	{
		get
		{
			return adjustmentIncomeValue;
		}
		set
		{
			adjustmentIncomeValue = value;
		}
	}

	public float? CommissionAdjustmentShareValue1
	{
		get
		{
			return commissionAdjustmentShareValue1;
		}
		set
		{
			commissionAdjustmentShareValue1 = value;
		}
	}

	public float? CommissionAdjustmentIncomeValue4
	{
		get
		{
			return commissionAdjustmentIncomeValue4;
		}
		set
		{
			commissionAdjustmentIncomeValue4 = value;
		}
	}

	public float? CommissionAdjustmentShareValue5
	{
		get
		{
			return commissionAdjustmentShareValue5;
		}
		set
		{
			commissionAdjustmentShareValue5 = value;
		}
	}

	public float? CommissionAdjustmentIncomeValue5
	{
		get
		{
			return commissionAdjustmentIncomeValue5;
		}
		set
		{
			commissionAdjustmentIncomeValue5 = value;
		}
	}

	public float? CommissionAdjustmentShareValue6
	{
		get
		{
			return commissionAdjustmentShareValue6;
		}
		set
		{
			commissionAdjustmentShareValue6 = value;
		}
	}

	public float? CommissionAdjustmentIncomeValue6
	{
		get
		{
			return commissionAdjustmentIncomeValue6;
		}
		set
		{
			commissionAdjustmentIncomeValue6 = value;
		}
	}

	public float? CommissionAdjustmentIncomeValue1
	{
		get
		{
			return commissionAdjustmentIncomeValue1;
		}
		set
		{
			commissionAdjustmentIncomeValue1 = value;
		}
	}

	public float? CommissionAdjustmentShareValue2
	{
		get
		{
			return commissionAdjustmentShareValue2;
		}
		set
		{
			commissionAdjustmentShareValue2 = value;
		}
	}

	public float? CommissionAdjustmentIncomeValue2
	{
		get
		{
			return commissionAdjustmentIncomeValue2;
		}
		set
		{
			commissionAdjustmentIncomeValue2 = value;
		}
	}

	public float? CommissionAdjustmentShareValue3
	{
		get
		{
			return commissionAdjustmentShareValue3;
		}
		set
		{
			commissionAdjustmentShareValue3 = value;
		}
	}

	public float? CommissionAdjustmentIncomeValue3
	{
		get
		{
			return commissionAdjustmentIncomeValue3;
		}
		set
		{
			commissionAdjustmentIncomeValue3 = value;
		}
	}

	public float? CommissionAdjustmentShareValue4
	{
		get
		{
			return commissionAdjustmentShareValue4;
		}
		set
		{
			commissionAdjustmentShareValue4 = value;
		}
	}

	public bool? IsDiagonesed
	{
		get
		{
			return isDiagonesed;
		}
		set
		{
			isDiagonesed = value;
		}
	}

	public Int64? ParentHeirID
	{
		get
		{
			return parentHeirID;
		}
		set
		{
			parentHeirID = value;
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

	public Int64? RegisterInformationID
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

	public Int64? AdjustmentTaxRegisterInformationID
	{
		get
		{
			return adjustmentTaxRegisterInformationID;
		}
		set
		{
			adjustmentTaxRegisterInformationID = value;
		}
	}

	public Int64? CommissionAdjustmentIncomeRegisterInformationID5
	{
		get
		{
			return commissionAdjustmentIncomeRegisterInformationID5;
		}
		set
		{
			commissionAdjustmentIncomeRegisterInformationID5 = value;
		}
	}

	public Int64? CommissionAdjustmentShareRegisterInformationID6
	{
		get
		{
			return commissionAdjustmentShareRegisterInformationID6;
		}
		set
		{
			commissionAdjustmentShareRegisterInformationID6 = value;
		}
	}

	public Int64? CommissionAdjustmentIncomeRegisterInformationID6
	{
		get
		{
			return commissionAdjustmentIncomeRegisterInformationID6;
		}
		set
		{
			commissionAdjustmentIncomeRegisterInformationID6 = value;
		}
	}

	public Int64? CommissionAdjustmentIncomeRegisterInformationID2
	{
		get
		{
			return commissionAdjustmentIncomeRegisterInformationID2;
		}
		set
		{
			commissionAdjustmentIncomeRegisterInformationID2 = value;
		}
	}

	public Int64? CommissionAdjustmentShareRegisterInformationID3
	{
		get
		{
			return commissionAdjustmentShareRegisterInformationID3;
		}
		set
		{
			commissionAdjustmentShareRegisterInformationID3 = value;
		}
	}

	public Int64? CommissionAdjustmentIncomeRegisterInformationID3
	{
		get
		{
			return commissionAdjustmentIncomeRegisterInformationID3;
		}
		set
		{
			commissionAdjustmentIncomeRegisterInformationID3 = value;
		}
	}

	public Int64? CommissionAdjustmentShareRegisterInformationID4
	{
		get
		{
			return commissionAdjustmentShareRegisterInformationID4;
		}
		set
		{
			commissionAdjustmentShareRegisterInformationID4 = value;
		}
	}

	public Int64? CommissionAdjustmentIncomeRegisterInformationID4
	{
		get
		{
			return commissionAdjustmentIncomeRegisterInformationID4;
		}
		set
		{
			commissionAdjustmentIncomeRegisterInformationID4 = value;
		}
	}

	public Int64? CommissionAdjustmentShareRegisterInformationID5
	{
		get
		{
			return commissionAdjustmentShareRegisterInformationID5;
		}
		set
		{
			commissionAdjustmentShareRegisterInformationID5 = value;
		}
	}

	public Int64? AdjustmentIncomeRegisterInformationID
	{
		get
		{
			return adjustmentIncomeRegisterInformationID;
		}
		set
		{
			adjustmentIncomeRegisterInformationID = value;
		}
	}

	public Int64? CommissionAdjustmentShareRegisterInformationID1
	{
		get
		{
			return commissionAdjustmentShareRegisterInformationID1;
		}
		set
		{
			commissionAdjustmentShareRegisterInformationID1 = value;
		}
	}

	public Int64? CommissionAdjustmentIncomeRegisterInformationID1
	{
		get
		{
			return commissionAdjustmentIncomeRegisterInformationID1;
		}
		set
		{
			commissionAdjustmentIncomeRegisterInformationID1 = value;
		}
	}

	public Int64? AdjustmentHeritageRegisterInformationID
	{
		get
		{
			return adjustmentHeritageRegisterInformationID;
		}
		set
		{
			adjustmentHeritageRegisterInformationID = value;
		}
	}

	public Int64? CommissionAdjustmentHeritageRegisterInformationID
	{
		get
		{
			return commissionAdjustmentHeritageRegisterInformationID;
		}
		set
		{
			commissionAdjustmentHeritageRegisterInformationID = value;
		}
	}

	public Int64? CommissionAdjustmentShareRegisterInformationID2
	{
		get
		{
			return commissionAdjustmentShareRegisterInformationID2;
		}
		set
		{
			commissionAdjustmentShareRegisterInformationID2 = value;
		}
	}

	public string AdjustmentTaxDate
	{
		get
		{
			return adjustmentTaxDate;
		}
		set
		{
			adjustmentTaxDate = value;
		}
	}

	public string AdjustmentIncomeDate
	{
		get
		{
			return adjustmentIncomeDate;
		}
		set
		{
			adjustmentIncomeDate = value;
		}
	}

	public string CommissionAdjustmentShareDate1
	{
		get
		{
			return commissionAdjustmentShareDate1;
		}
		set
		{
			commissionAdjustmentShareDate1 = value;
		}
	}

	public string CommissionAdjustmentIncomeDate1
	{
		get
		{
			return commissionAdjustmentIncomeDate1;
		}
		set
		{
			commissionAdjustmentIncomeDate1 = value;
		}
	}

	public string AdjustmentHeritageDate
	{
		get
		{
			return adjustmentHeritageDate;
		}
		set
		{
			adjustmentHeritageDate = value;
		}
	}

	public string CommissionAdjustmentHeritageDate
	{
		get
		{
			return commissionAdjustmentHeritageDate;
		}
		set
		{
			commissionAdjustmentHeritageDate = value;
		}
	}

	public string CommissionAdjustmentIncomeDate4
	{
		get
		{
			return commissionAdjustmentIncomeDate4;
		}
		set
		{
			commissionAdjustmentIncomeDate4 = value;
		}
	}

	public string CommissionAdjustmentShareDate5
	{
		get
		{
			return commissionAdjustmentShareDate5;
		}
		set
		{
			commissionAdjustmentShareDate5 = value;
		}
	}

	public string CommissionAdjustmentIncomeDate5
	{
		get
		{
			return commissionAdjustmentIncomeDate5;
		}
		set
		{
			commissionAdjustmentIncomeDate5 = value;
		}
	}

	public string CommissionAdjustmentShareDate6
	{
		get
		{
			return commissionAdjustmentShareDate6;
		}
		set
		{
			commissionAdjustmentShareDate6 = value;
		}
	}

	public string CommissionAdjustmentIncomeDate6
	{
		get
		{
			return commissionAdjustmentIncomeDate6;
		}
		set
		{
			commissionAdjustmentIncomeDate6 = value;
		}
	}

	public string AdjustmentFinalizationDate
	{
		get
		{
			return adjustmentFinalizationDate;
		}
		set
		{
			adjustmentFinalizationDate = value;
		}
	}

	public string CommissionAdjustmentShareDate2
	{
		get
		{
			return commissionAdjustmentShareDate2;
		}
		set
		{
			commissionAdjustmentShareDate2 = value;
		}
	}

	public string CommissionAdjustmentIncomeDate2
	{
		get
		{
			return commissionAdjustmentIncomeDate2;
		}
		set
		{
			commissionAdjustmentIncomeDate2 = value;
		}
	}

	public string CommissionAdjustmentShareDate3
	{
		get
		{
			return commissionAdjustmentShareDate3;
		}
		set
		{
			commissionAdjustmentShareDate3 = value;
		}
	}

	public string CommissionAdjustmentIncomeDate3
	{
		get
		{
			return commissionAdjustmentIncomeDate3;
		}
		set
		{
			commissionAdjustmentIncomeDate3 = value;
		}
	}

	public string CommissionAdjustmentShareDate4
	{
		get
		{
			return commissionAdjustmentShareDate4;
		}
		set
		{
			commissionAdjustmentShareDate4 = value;
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

	public List<Annunciation> AnnunciationList
	{
		get
		{
			return annunciationList;
		}
		set
		{
			annunciationList = value;
		}
	}

	public List<CommissionAdjustmentHeritage> CommissionAdjustmentHeritageList
	{
		get
		{
			return commissionAdjustmentHeritageList;
		}
		set
		{
			commissionAdjustmentHeritageList = value;
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

	public List<AdjustmentHeritage> GetListAdjustmentHeritage()
	{
		AdjustmentHeritageList = new HeirDBAccess().GetListAdjustmentHeritage(this.HeirID);
		return AdjustmentHeritageList;
	}

	public List<Annunciation> GetListAnnunciation()
	{
		AnnunciationList = new HeirDBAccess().GetListAnnunciation(this.HeirID);
		return AnnunciationList;
	}

	public List<CommissionAdjustmentHeritage> GetListCommissionAdjustmentHeritage()
	{
		CommissionAdjustmentHeritageList = new HeirDBAccess().GetListCommissionAdjustmentHeritage(this.HeirID);
		return CommissionAdjustmentHeritageList;
	}

	public List<CommissionInvitation> GetListCommissionInvitation()
	{
		CommissionInvitationList = new HeirDBAccess().GetListCommissionInvitation(this.HeirID);
		return CommissionInvitationList;
	}

	public List<CommissionVerdict> GetListCommissionVerdict()
	{
		CommissionVerdictList = new HeirDBAccess().GetListCommissionVerdict(this.HeirID);
		return CommissionVerdictList;
	}

	public bool AddAdjustmentHeritage(AdjustmentHeritage adjustmentHeritage)
	{
		adjustmentHeritage.HeirID = this.HeirID;
		AdjustmentHeritageDBAccess adjustmentHeritageDBAccess = new AdjustmentHeritageDBAccess();
		if (adjustmentHeritageDBAccess.Insert(adjustmentHeritage)>0)
			return (true);
		return (false);
	}

	public bool AddAnnunciation(Annunciation annunciation)
	{
		annunciation.HeirID = this.HeirID;
		AnnunciationDBAccess annunciationDBAccess = new AnnunciationDBAccess();
		if (annunciationDBAccess.Insert(annunciation)>0)
			return (true);
		return (false);
	}

	public bool AddCommissionAdjustmentHeritage(CommissionAdjustmentHeritage commissionAdjustmentHeritage)
	{
		commissionAdjustmentHeritage.HeirID = this.HeirID;
		CommissionAdjustmentHeritageDBAccess commissionAdjustmentHeritageDBAccess = new CommissionAdjustmentHeritageDBAccess();
		if (commissionAdjustmentHeritageDBAccess.Insert(commissionAdjustmentHeritage)>0)
			return (true);
		return (false);
	}

	public bool AddCommissionInvitation(CommissionInvitation commissionInvitation)
	{
		commissionInvitation.HeirID = this.HeirID;
		CommissionInvitationDBAccess commissionInvitationDBAccess = new CommissionInvitationDBAccess();
		if (commissionInvitationDBAccess.Insert(commissionInvitation)>0)
			return (true);
		return (false);
	}

	public bool AddCommissionVerdict(CommissionVerdict commissionVerdict)
	{
		commissionVerdict.HeirID = this.HeirID;
		CommissionVerdictDBAccess commissionVerdictDBAccess = new CommissionVerdictDBAccess();
		if (commissionVerdictDBAccess.Insert(commissionVerdict)>0)
			return (true);
		return (false);
	}

}
}
