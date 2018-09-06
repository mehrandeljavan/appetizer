using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class WeddingIndexDBAccess
{

	DowryDBAccess dowryDBAccess = new DowryDBAccess();

	public List<Dowry> GetListDowry(int weddingYear)
	{
		List<Dowry> listDowry = new List<Dowry>() { };
		SqlParameter[] parametersWeddingIndex = new SqlParameter[]
		{
			new SqlParameter("@WeddingYear", weddingYear)
		};

		//Lets get the list of Dowry records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dowry_GetList_UseInWeddingIndex", CommandType.StoredProcedure, parametersWeddingIndex))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of dowry
				listDowry = new List<Dowry>();

				//Now lets populate the Dowry details into the list of dowrys
				foreach (DataRow row in table.Rows)
				{
					Dowry dowry = ConvertRowToDowry(row);
					listDowry.Add(dowry);
				}
			}
		}

		return listDowry;
	}

	private Dowry ConvertRowToDowry(DataRow row)
	{
		Dowry dowry = new Dowry();
		dowry.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		dowry.WeddingYearTitle = row["WeddingYearTitle"].ToString();
		dowry.ValueInCentralBank = (row["ValueInCentralBank"] != DBNull.Value) ? Convert.ToSingle(row["ValueInCentralBank"]) : 0 ;
		dowry.NonCashValue = (row["NonCashValue"] != DBNull.Value) ? Convert.ToSingle(row["NonCashValue"]) : 0 ;
		dowry.Alimony = (row["Alimony"] != DBNull.Value) ? Convert.ToSingle(row["Alimony"]) : 0 ;
		dowry.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		dowry.WeddingYear = (row["WeddingYear"] != DBNull.Value) ? Convert.ToInt32(row["WeddingYear"]) : 0 ;
		dowry.Amount = (row["Amount"] != DBNull.Value) ? Convert.ToSingle(row["Amount"]) : 0 ;

		dowry.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		dowry.StageTitle = row["StageTitle"].ToString();
		dowry.RegisterDate = row["RegisterDate"].ToString();
		dowry.OldRegisterDate = row["OldRegisterDate"].ToString();
		dowry.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		dowry.Sixth = row["Sixth"].ToString();
		dowry.PreviousOwner = row["PreviousOwner"].ToString();
		dowry.Comment = row["Comment"].ToString();
		dowry.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		dowry.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		dowry.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		dowry.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		dowry.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		dowry.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		dowry.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		dowry.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		dowry.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		dowry.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return dowry;
	}
	public Int64 Insert(WeddingIndex weddingIndex)
	{
		SqlParameter[] parametersWeddingIndex = new SqlParameter[]
		{
			new SqlParameter("@WeddingYear", weddingIndex.WeddingYear),
			new SqlParameter("@IndexValue", weddingIndex.IndexValue)
		};
		return SqlDBHelper.ExecuteScalar("WeddingIndex_Insert", CommandType.StoredProcedure, parametersWeddingIndex);
	}

	public bool Update(WeddingIndex weddingIndex)
	{
		SqlParameter[] parametersWeddingIndex = new SqlParameter[]
		{
			new SqlParameter("@WeddingYear", weddingIndex.WeddingYear),
			new SqlParameter("@IndexValue", weddingIndex.IndexValue)
		};
		return SqlDBHelper.ExecuteNonQuery("WeddingIndex_Update", CommandType.StoredProcedure, parametersWeddingIndex);
	}

	public bool Delete(int weddingYear)
	{
		SqlParameter[] parametersWeddingIndex = new SqlParameter[]
		{
			new SqlParameter("@WeddingYear", weddingYear)
		};
		return SqlDBHelper.ExecuteNonQuery("WeddingIndex_Delete", CommandType.StoredProcedure, parametersWeddingIndex);
	}

	public WeddingIndex GetDetails(int weddingYear)
	{
		WeddingIndex weddingIndex = new WeddingIndex();

		SqlParameter[] parametersWeddingIndex = new SqlParameter[]
		{
			new SqlParameter("@WeddingYear", weddingYear)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("WeddingIndex_GetDetails", CommandType.StoredProcedure, parametersWeddingIndex))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				weddingIndex.WeddingYear = (row["WeddingYear"] != DBNull.Value) ? Convert.ToInt32(row["WeddingYear"]) : 0 ;
				weddingIndex.Title = (row["Title"] != DBNull.Value) ? Convert.ToInt32(row["Title"]) : 0 ;
				weddingIndex.IndexValue = (row["IndexValue"] != DBNull.Value) ? Convert.ToSingle(row["IndexValue"]) : 0 ;
			}
		}

		return weddingIndex;
	}

	public List<WeddingIndex> GetListAll()
	{
		List<WeddingIndex> listWeddingIndex = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("WeddingIndex_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listWeddingIndex = new List<WeddingIndex>();

				foreach (DataRow row in table.Rows)
				{
					WeddingIndex weddingIndex = new WeddingIndex();
					weddingIndex.WeddingYear = (row["WeddingYear"] != DBNull.Value) ? Convert.ToInt32(row["WeddingYear"]) : 0 ;
					weddingIndex.Title = (row["Title"] != DBNull.Value) ? Convert.ToInt32(row["Title"]) : 0 ;
					weddingIndex.IndexValue = (row["IndexValue"] != DBNull.Value) ? Convert.ToSingle(row["IndexValue"]) : 0 ;
					listWeddingIndex.Add(weddingIndex);
				}
			}
		}

		return listWeddingIndex;
	}

	public bool Exists(int weddingYear)
	{
		SqlParameter[] parametersWeddingIndex = new SqlParameter[]
		{
			new SqlParameter("@WeddingYear", weddingYear)
		};
		return (SqlDBHelper.ExecuteScalar("WeddingIndex_Exists", CommandType.StoredProcedure, parametersWeddingIndex)>0);
	}

	public bool Exists(WeddingIndex weddingIndex)
	{
		SqlParameter[] parametersWeddingIndex = new SqlParameter[]
		{
			new SqlParameter("@WeddingYear", weddingIndex.WeddingYear)
		};
		return (SqlDBHelper.ExecuteScalar("WeddingIndex_Exists", CommandType.StoredProcedure, parametersWeddingIndex)>0);
	}

	public List<WeddingIndex> SearchLike(WeddingIndex weddingIndex)
	{
		List<WeddingIndex> listWeddingIndex = new List<WeddingIndex>();


		SqlParameter[] parametersWeddingIndex = new SqlParameter[]
		{
			new SqlParameter("@WeddingYear", weddingIndex.WeddingYear),
			new SqlParameter("@Title", weddingIndex.Title),
			new SqlParameter("@IndexValue", weddingIndex.IndexValue),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("WeddingIndex_SearchLike", CommandType.StoredProcedure, parametersWeddingIndex))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					WeddingIndex tmpWeddingIndex = new WeddingIndex();
					tmpWeddingIndex.WeddingYear = (row["WeddingYear"] != DBNull.Value) ? Convert.ToInt32(row["WeddingYear"]) : 0 ;
					tmpWeddingIndex.Title = (row["Title"] != DBNull.Value) ? Convert.ToInt32(row["Title"]) : 0 ;
					tmpWeddingIndex.IndexValue = (row["IndexValue"] != DBNull.Value) ? Convert.ToSingle(row["IndexValue"]) : 0 ;

					listWeddingIndex.Add(tmpWeddingIndex);
				}
			}
		}

		return listWeddingIndex;
	}

}
}
