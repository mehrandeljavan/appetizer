using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class ScoreHandler
{
	// Handle to the Score DBAccess class
	ScoreDBAccess scoreDb = null;

	public ScoreHandler()
	{
		scoreDb = new ScoreDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of scores, we can put some logic here if needed 
	public List<Score> GetListAll()
	{
		return scoreDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of scores, we can put some logic here if needed 
	public bool Update(Score score)
	{
		return scoreDb.Update(score);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of scores, we can put some logic here if needed 
	public Score GetDetails(Int64 heritageID)
	{
		return scoreDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of scores, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return scoreDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of scores, we can put some logic here if needed 
	public Int64 Insert(Score score)
	{
		return scoreDb.Insert(score);
	}

	public bool Exists(Score score)
	{
		return scoreDb.Exists(score);
	}

	public bool Exists(Int64 heritageID)
	{
		return scoreDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of scores, we can put some logic here if needed 
	public List<Score> SearchLike(Score score)
	{
		return scoreDb.SearchLike(score);
	}

}
}
