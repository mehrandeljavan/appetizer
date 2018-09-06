using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Will
{
	private Int64 willID;
	private string willTypeIDTitle;
	private int willTypeID;
	private Int64? declerationID;
	private string willDate;
	private string voteDate;
	private string willNumber;
	private string scriptoriumNumber;
	private string voteNumber;
	private string voteBranchDescription;
	private string city;

	public Int64 WillID
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

	public string WillTypeIDTitle
	{
		get
		{
			return willTypeIDTitle;
		}
		set
		{
			willTypeIDTitle = value;
		}
	}

	public int WillTypeID
	{
		get
		{
			return willTypeID;
		}
		set
		{
			willTypeID = value;
		}
	}

	public Int64? DeclerationID
	{
		get
		{
			return declerationID;
		}
		set
		{
			declerationID = value;
		}
	}

	public string WillDate
	{
		get
		{
			return willDate;
		}
		set
		{
			willDate = value;
		}
	}

	public string VoteDate
	{
		get
		{
			return voteDate;
		}
		set
		{
			voteDate = value;
		}
	}

	public string WillNumber
	{
		get
		{
			return willNumber;
		}
		set
		{
			willNumber = value;
		}
	}

	public string ScriptoriumNumber
	{
		get
		{
			return scriptoriumNumber;
		}
		set
		{
			scriptoriumNumber = value;
		}
	}

	public string VoteNumber
	{
		get
		{
			return voteNumber;
		}
		set
		{
			voteNumber = value;
		}
	}

	public string VoteBranchDescription
	{
		get
		{
			return voteBranchDescription;
		}
		set
		{
			voteBranchDescription = value;
		}
	}

	public string City
	{
		get
		{
			return city;
		}
		set
		{
			city = value;
		}
	}

}
}
