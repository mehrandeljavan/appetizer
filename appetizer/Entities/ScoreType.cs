using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class ScoreType
{
	private int scoreTypeID;
	private string title;
	private List<Score> scoreList;

	public int ScoreTypeID
	{
		get
		{
			return scoreTypeID;
		}
		set
		{
			scoreTypeID = value;
		}
	}

	public string Title
	{
		get
		{
			return title;
		}
		set
		{
			title = value;
		}
	}

	public List<Score> ScoreList
	{
		get
		{
			return scoreList;
		}
		set
		{
			scoreList = value;
		}
	}

	public List<Score> GetListScore()
	{
		ScoreList = new ScoreTypeDBAccess().GetListScore(this.ScoreTypeID);
		return ScoreList;
	}

	public bool AddScore(Score score)
	{
		score.ScoreTypeID = this.ScoreTypeID;
		ScoreDBAccess scoreDBAccess = new ScoreDBAccess();
		if (scoreDBAccess.Insert(score)>0)
			return (true);
		return (false);
	}

}
}
