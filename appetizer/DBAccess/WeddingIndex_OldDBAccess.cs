using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class WeddingIndex_OldDBAccess
{


	public Int64 Insert(WeddingIndex_Old weddingIndex_Old)
	{
		SqlParameter[] parametersWeddingIndex_Old = new SqlParameter[]
		{
			new SqlParameter("@WeddingYear", weddingIndex_Old.WeddingYear),
			new SqlParameter("@IndexValue", weddingIndex_Old.IndexValue)
		};
		return SqlDBHelper.ExecuteScalar("WeddingIndex_Old_Insert", CommandType.StoredProcedure, parametersWeddingIndex_Old);
	}

	public bool Update(WeddingIndex_Old weddingIndex_Old)
	{
		SqlParameter[] parametersWeddingIndex_Old = new SqlParameter[]
		{
			new SqlParameter("@WeddingYear", weddingIndex_Old.WeddingYear),
			new SqlParameter("@IndexValue", weddingIndex_Old.IndexValue)
		};
		return SqlDBHelper.ExecuteNonQuery("WeddingIndex_Old_Update", CommandType.StoredProcedure, parametersWeddingIndex_Old);
	}

	public bool Delete(int weddingYear)
	{
		SqlParameter[] parametersWeddingIndex_Old = new SqlParameter[]
		{
			new SqlParameter("@WeddingYear", weddingYear)
		};
		return SqlDBHelper.ExecuteNonQuery("WeddingIndex_Old_Delete", CommandType.StoredProcedure, parametersWeddingIndex_Old);
	}

	public WeddingIndex_Old GetDetails(int weddingYear)
	{
		WeddingIndex_Old weddingIndex_Old = new WeddingIndex_Old();

		SqlParameter[] parametersWeddingIndex_Old = new SqlParameter[]
		{
			new SqlParameter("@WeddingYear", weddingYear)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("WeddingIndex_Old_GetDetails", CommandType.StoredProcedure, parametersWeddingIndex_Old))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				weddingIndex_Old.WeddingYear = (row["WeddingYear"] != DBNull.Value) ? Convert.ToInt32(row["WeddingYear"]) : 0 ;
				weddingIndex_Old.Title = (row["Title"] != DBNull.Value) ? Convert.ToInt32(row["Title"]) : 0 ;
				weddingIndex_Old.IndexValue = (row["IndexValue"] != DBNull.Value) ? Convert.ToSingle(row["IndexValue"]) : 0 ;
			}
		}

		return weddingIndex_Old;
	}

	public List<WeddingIndex_Old> GetListAll()
	{
		List<WeddingIndex_Old> listWeddingIndex_Old = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("WeddingIndex_Old_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listWeddingIndex_Old = new List<WeddingIndex_Old>();

				foreach (DataRow row in table.Rows)
				{
					WeddingIndex_Old weddingIndex_Old = new WeddingIndex_Old();
					weddingIndex_Old.WeddingYear = (row["WeddingYear"] != DBNull.Value) ? Convert.ToInt32(row["WeddingYear"]) : 0 ;
					weddingIndex_Old.Title = (row["Title"] != DBNull.Value) ? Convert.ToInt32(row["Title"]) : 0 ;
					weddingIndex_Old.IndexValue = (row["IndexValue"] != DBNull.Value) ? Convert.ToSingle(row["IndexValue"]) : 0 ;
					listWeddingIndex_Old.Add(weddingIndex_Old);
				}
			}
		}

		return listWeddingIndex_Old;
	}

	public bool Exists(int weddingYear)
	{
		SqlParameter[] parametersWeddingIndex_Old = new SqlParameter[]
		{
			new SqlParameter("@WeddingYear", weddingYear)
		};
		return (SqlDBHelper.ExecuteScalar("WeddingIndex_Old_Exists", CommandType.StoredProcedure, parametersWeddingIndex_Old)>0);
	}

	public bool Exists(WeddingIndex_Old weddingIndex_Old)
	{
		SqlParameter[] parametersWeddingIndex_Old = new SqlParameter[]
		{
			new SqlParameter("@WeddingYear", weddingIndex_Old.WeddingYear)
		};
		return (SqlDBHelper.ExecuteScalar("WeddingIndex_Old_Exists", CommandType.StoredProcedure, parametersWeddingIndex_Old)>0);
	}

	public List<WeddingIndex_Old> SearchLike(WeddingIndex_Old weddingIndex_Old)
	{
		List<WeddingIndex_Old> listWeddingIndex_Old = new List<WeddingIndex_Old>();


		SqlParameter[] parametersWeddingIndex_Old = new SqlParameter[]
		{
			new SqlParameter("@WeddingYear", weddingIndex_Old.WeddingYear),
			new SqlParameter("@Title", weddingIndex_Old.Title),
			new SqlParameter("@IndexValue", weddingIndex_Old.IndexValue),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("WeddingIndex_Old_SearchLike", CommandType.StoredProcedure, parametersWeddingIndex_Old))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					WeddingIndex_Old tmpWeddingIndex_Old = new WeddingIndex_Old();
					tmpWeddingIndex_Old.WeddingYear = (row["WeddingYear"] != DBNull.Value) ? Convert.ToInt32(row["WeddingYear"]) : 0 ;
					tmpWeddingIndex_Old.Title = (row["Title"] != DBNull.Value) ? Convert.ToInt32(row["Title"]) : 0 ;
					tmpWeddingIndex_Old.IndexValue = (row["IndexValue"] != DBNull.Value) ? Convert.ToSingle(row["IndexValue"]) : 0 ;

					listWeddingIndex_Old.Add(tmpWeddingIndex_Old);
				}
			}
		}

		return listWeddingIndex_Old;
	}

}
}
