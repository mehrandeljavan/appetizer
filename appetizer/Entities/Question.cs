using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Question
{
	private Int64 questionID;
	private string userFullName;
	private Int64? totalMark;
	private string questionDate;
	private string questionText;
	private string answer;
	private bool visible;
	private Int64 userNationalCode;
	private List<QuestionScore> questionScoreList;

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

	public Int64? TotalMark
	{
		get
		{
			return totalMark;
		}
		set
		{
			totalMark = value;
		}
	}

	public string QuestionDate
	{
		get
		{
			return questionDate;
		}
		set
		{
			questionDate = value;
		}
	}

	public string QuestionText
	{
		get
		{
			return questionText;
		}
		set
		{
			questionText = value;
		}
	}

	public string Answer
	{
		get
		{
			return answer;
		}
		set
		{
			answer = value;
		}
	}

	public bool Visible
	{
		get
		{
			return visible;
		}
		set
		{
			visible = value;
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

	public List<QuestionScore> GetListQuestionScore()
	{
		QuestionScoreList = new QuestionDBAccess().GetListQuestionScore(this.QuestionID);
		return QuestionScoreList;
	}

	public bool AddQuestionScore(QuestionScore questionScore)
	{
		questionScore.QuestionID = this.QuestionID;
		QuestionScoreDBAccess questionScoreDBAccess = new QuestionScoreDBAccess();
		if (questionScoreDBAccess.Insert(questionScore)>0)
			return (true);
		return (false);
	}

}
}
