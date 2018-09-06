using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class ScoreTypeHandler
{
	// Handle to the ScoreType DBAccess class
	ScoreTypeDBAccess scoreTypeDb = null;

	public ScoreTypeHandler()
	{
		scoreTypeDb = new ScoreTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of scoreTypes, we can put some logic here if needed 
	public List<ScoreType> GetListAll()
	{
		return scoreTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of scoreTypes, we can put some logic here if needed 
	public bool Update(ScoreType scoreType)
	{
		return scoreTypeDb.Update(scoreType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of scoreTypes, we can put some logic here if needed 
	public ScoreType GetDetails(int scoreTypeID)
	{
		return scoreTypeDb.GetDetails(scoreTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of scoreTypes, we can put some logic here if needed 
	public bool Delete(int scoreTypeID)
	{
		return scoreTypeDb.Delete(scoreTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of scoreTypes, we can put some logic here if needed 
	public Int64 Insert(ScoreType scoreType)
	{
		return scoreTypeDb.Insert(scoreType);
	}

	public bool Exists(ScoreType scoreType)
	{
		return scoreTypeDb.Exists(scoreType);
	}

	public bool Exists(int scoreTypeID)
	{
		return scoreTypeDb.Exists(scoreTypeID);
	}

	public List<Score> GetListScore(int scoreTypeID)
	{
		return scoreTypeDb.GetListScore(scoreTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of scoreTypes, we can put some logic here if needed 
	public List<ScoreType> SearchLike(ScoreType scoreType)
	{
		return scoreTypeDb.SearchLike(scoreType);
	}

}
}
