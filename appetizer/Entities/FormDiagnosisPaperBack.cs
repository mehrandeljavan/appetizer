using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormDiagnosisPaperBack
{
	private Int64 formDiagnosisPaperBackID;
	private Int64? formDiagnosisPaperBackAnnunciationNumber;
	private Int64? formDiagnosisPaperBackAdjustmentNumber;
	private string formDiagnosisPaperBackCurrentDate;
	private string formDiagnosisPaperBackAnnunciationDate;
	private string formDiagnosisPaperBackAdjustmentDate;
	private string formDiagnosisPaperBackOperatorFullName1;
	private string formDiagnosisPaperBackOperatorType;
	private string formDiagnosisPaperBackAnnunciationResponseTypeIDTitle;
	private string formDiagnosisPaperBackPaidBillPrice;
	private string formDiagnosisPaperBackPaidBillNumber;
	private string formDiagnosisPaperBackOperatorFullName2;
	private float? formDiagnosisPaperBackAdjustedShare;

	public Int64 FormDiagnosisPaperBackID
	{
		get
		{
			return formDiagnosisPaperBackID;
		}
		set
		{
			formDiagnosisPaperBackID = value;
		}
	}

	public Int64? FormDiagnosisPaperBackAnnunciationNumber
	{
		get
		{
			return formDiagnosisPaperBackAnnunciationNumber;
		}
		set
		{
			formDiagnosisPaperBackAnnunciationNumber = value;
		}
	}

	public Int64? FormDiagnosisPaperBackAdjustmentNumber
	{
		get
		{
			return formDiagnosisPaperBackAdjustmentNumber;
		}
		set
		{
			formDiagnosisPaperBackAdjustmentNumber = value;
		}
	}

	public string FormDiagnosisPaperBackCurrentDate
	{
		get
		{
			return formDiagnosisPaperBackCurrentDate;
		}
		set
		{
			formDiagnosisPaperBackCurrentDate = value;
		}
	}

	public string FormDiagnosisPaperBackAnnunciationDate
	{
		get
		{
			return formDiagnosisPaperBackAnnunciationDate;
		}
		set
		{
			formDiagnosisPaperBackAnnunciationDate = value;
		}
	}

	public string FormDiagnosisPaperBackAdjustmentDate
	{
		get
		{
			return formDiagnosisPaperBackAdjustmentDate;
		}
		set
		{
			formDiagnosisPaperBackAdjustmentDate = value;
		}
	}

	public string FormDiagnosisPaperBackOperatorFullName1
	{
		get
		{
			return formDiagnosisPaperBackOperatorFullName1;
		}
		set
		{
			formDiagnosisPaperBackOperatorFullName1 = value;
		}
	}

	public string FormDiagnosisPaperBackOperatorType
	{
		get
		{
			return formDiagnosisPaperBackOperatorType;
		}
		set
		{
			formDiagnosisPaperBackOperatorType = value;
		}
	}

	public string FormDiagnosisPaperBackAnnunciationResponseTypeIDTitle
	{
		get
		{
			return formDiagnosisPaperBackAnnunciationResponseTypeIDTitle;
		}
		set
		{
			formDiagnosisPaperBackAnnunciationResponseTypeIDTitle = value;
		}
	}

	public string FormDiagnosisPaperBackPaidBillPrice
	{
		get
		{
			return formDiagnosisPaperBackPaidBillPrice;
		}
		set
		{
			formDiagnosisPaperBackPaidBillPrice = value;
		}
	}

	public string FormDiagnosisPaperBackPaidBillNumber
	{
		get
		{
			return formDiagnosisPaperBackPaidBillNumber;
		}
		set
		{
			formDiagnosisPaperBackPaidBillNumber = value;
		}
	}

	public string FormDiagnosisPaperBackOperatorFullName2
	{
		get
		{
			return formDiagnosisPaperBackOperatorFullName2;
		}
		set
		{
			formDiagnosisPaperBackOperatorFullName2 = value;
		}
	}

	public float? FormDiagnosisPaperBackAdjustedShare
	{
		get
		{
			return formDiagnosisPaperBackAdjustedShare;
		}
		set
		{
			formDiagnosisPaperBackAdjustedShare = value;
		}
	}

}
}
