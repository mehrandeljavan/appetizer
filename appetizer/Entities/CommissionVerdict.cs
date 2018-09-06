using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class CommissionVerdict
{
	private int commissionVerdictTypeID;
	private Int64 heirID;
	private string commissionVerdictTypeIDTitle;
	private string oldRegisterInformationID;
	private string oldRegisterDate;
	private Int64? registerInformationID;
	private string verdictDate;
	private string verdictNumber;
	private string comment;

	public int CommissionVerdictTypeID
	{
		get
		{
			return commissionVerdictTypeID;
		}
		set
		{
			commissionVerdictTypeID = value;
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

	public string CommissionVerdictTypeIDTitle
	{
		get
		{
			return commissionVerdictTypeIDTitle;
		}
		set
		{
			commissionVerdictTypeIDTitle = value;
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

	public string VerdictDate
	{
		get
		{
			return verdictDate;
		}
		set
		{
			verdictDate = value;
		}
	}

	public string VerdictNumber
	{
		get
		{
			return verdictNumber;
		}
		set
		{
			verdictNumber = value;
		}
	}

	public string Comment
	{
		get
		{
			return comment;
		}
		set
		{
			comment = value;
		}
	}

}
}
