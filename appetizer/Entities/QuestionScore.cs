using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class QuestionScore
{
	private Int64 questionID;
	private Int64 userNationalCode;
	private string userFullName;
	private int scoreMark;
	private string scoreDate;

	public Int64 QuestionID
	{
		get
		{
			return questionID;
		}
		set
		{
			questionID = value;
		}
	}

	public Int64 UserNationalCode
	{
		get
		{
			return userNationalCode;
		}
		set
		{
			userNationalCode = value;
		}
	}

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

	public int ScoreMark
	{
		get
		{
			return scoreMark;
		}
		set
		{
			scoreMark = value;
		}
	}

	public string ScoreDate
	{
		get
		{
			return scoreDate;
		}
		set
		{
			scoreDate = value;
		}
	}

}
}
