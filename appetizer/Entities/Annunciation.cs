using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Annunciation
{
	private int annunciationPaperTypeID;
	private Int64 heirID;
	private string registerDate1;
	private string annunciationPlaceIDTitle;
	private string annunciationResultTypeIDTitle;
	private string annunciationToOthersReasonIDTitle;
	private string annunciationToTypeIDTitle;
	private string regularAnnunciationReasonIDTitle;
	private string regularAnnunciationTypeIDTitle;
	private string oldRegisterInformationID;
	private string oldRegisterDate;
	private string registerDate2;
	private string paperRegisterDate;
	private string operatorName;
	private string reciver;
	private string relationToHeir;
	private string annuncier;
	private string rejectOther;
	private Int64? registerInformationID2;
	private Int64 paperRegisterInformationID;
	private string annunciationDate;
	private string paperDate;
	private int? annunciationToTypeID;
	private int? annunciationPlaceID;
	private int? annunciationToOthersReasonID;
	private int? registerInformationID;
	private int? regularAnnunciationReasonID;
	private int? regularAnnunciationTypeID;
	private int? annunciationResultTypeID;
	private int? operatorTypeID;
	private bool? reject1;
	private bool? reject2;
	private bool? reject3;
	private bool? reject4;
	private bool? reject5;

	public int AnnunciationPaperTypeID
	{
		get
		{
			return annunciationPaperTypeID;
		}
		set
		{
			annunciationPaperTypeID = value;
		}
	}

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

	public string RegisterDate1
	{
		get
		{
			return registerDate1;
		}
		set
		{
			registerDate1 = value;
		}
	}

	public string AnnunciationPlaceIDTitle
	{
		get
		{
			return annunciationPlaceIDTitle;
		}
		set
		{
			annunciationPlaceIDTitle = value;
		}
	}

	public string AnnunciationResultTypeIDTitle
	{
		get
		{
			return annunciationResultTypeIDTitle;
		}
		set
		{
			annunciationResultTypeIDTitle = value;
		}
	}

	public string AnnunciationToOthersReasonIDTitle
	{
		get
		{
			return annunciationToOthersReasonIDTitle;
		}
		set
		{
			annunciationToOthersReasonIDTitle = value;
		}
	}

	public string AnnunciationToTypeIDTitle
	{
		get
		{
			return annunciationToTypeIDTitle;
		}
		set
		{
			annunciationToTypeIDTitle = value;
		}
	}

	public string RegularAnnunciationReasonIDTitle
	{
		get
		{
			return regularAnnunciationReasonIDTitle;
		}
		set
		{
			regularAnnunciationReasonIDTitle = value;
		}
	}

	public string RegularAnnunciationTypeIDTitle
	{
		get
		{
			return regularAnnunciationTypeIDTitle;
		}
		set
		{
			regularAnnunciationTypeIDTitle = value;
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

	public string RegisterDate2
	{
		get
		{
			return registerDate2;
		}
		set
		{
			registerDate2 = value;
		}
	}

	public string PaperRegisterDate
	{
		get
		{
			return paperRegisterDate;
		}
		set
		{
			paperRegisterDate = value;
		}
	}

	public string OperatorName
	{
		get
		{
			return operatorName;
		}
		set
		{
			operatorName = value;
		}
	}

	public string Reciver
	{
		get
		{
			return reciver;
		}
		set
		{
			reciver = value;
		}
	}

	public string RelationToHeir
	{
		get
		{
			return relationToHeir;
		}
		set
		{
			relationToHeir = value;
		}
	}

	public string Annuncier
	{
		get
		{
			return annuncier;
		}
		set
		{
			annuncier = value;
		}
	}

	public string RejectOther
	{
		get
		{
			return rejectOther;
		}
		set
		{
			rejectOther = value;
		}
	}

	public Int64? RegisterInformationID2
	{
		get
		{
			return registerInformationID2;
		}
		set
		{
			registerInformationID2 = value;
		}
	}

	public Int64 PaperRegisterInformationID
	{
		get
		{
			return paperRegisterInformationID;
		}
		set
		{
			paperRegisterInformationID = value;
		}
	}

	public string AnnunciationDate
	{
		get
		{
			return annunciationDate;
		}
		set
		{
			annunciationDate = value;
		}
	}

	public string PaperDate
	{
		get
		{
			return paperDate;
		}
		set
		{
			paperDate = value;
		}
	}

	public int? AnnunciationToTypeID
	{
		get
		{
			return annunciationToTypeID;
		}
		set
		{
			annunciationToTypeID = value;
		}
	}

	public int? AnnunciationPlaceID
	{
		get
		{
			return annunciationPlaceID;
		}
		set
		{
			annunciationPlaceID = value;
		}
	}

	public int? AnnunciationToOthersReasonID
	{
		get
		{
			return annunciationToOthersReasonID;
		}
		set
		{
			annunciationToOthersReasonID = value;
		}
	}

	public int? RegisterInformationID
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

	public int? RegularAnnunciationReasonID
	{
		get
		{
			return regularAnnunciationReasonID;
		}
		set
		{
			regularAnnunciationReasonID = value;
		}
	}

	public int? RegularAnnunciationTypeID
	{
		get
		{
			return regularAnnunciationTypeID;
		}
		set
		{
			regularAnnunciationTypeID = value;
		}
	}

	public int? AnnunciationResultTypeID
	{
		get
		{
			return annunciationResultTypeID;
		}
		set
		{
			annunciationResultTypeID = value;
		}
	}

	public int? OperatorTypeID
	{
		get
		{
			return operatorTypeID;
		}
		set
		{
			operatorTypeID = value;
		}
	}

	public bool? Reject1
	{
		get
		{
			return reject1;
		}
		set
		{
			reject1 = value;
		}
	}

	public bool? Reject2
	{
		get
		{
			return reject2;
		}
		set
		{
			reject2 = value;
		}
	}

	public bool? Reject3
	{
		get
		{
			return reject3;
		}
		set
		{
			reject3 = value;
		}
	}

	public bool? Reject4
	{
		get
		{
			return reject4;
		}
		set
		{
			reject4 = value;
		}
	}

	public bool? Reject5
	{
		get
		{
			return reject5;
		}
		set
		{
			reject5 = value;
		}
	}

}
}
