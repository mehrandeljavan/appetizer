using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class AdjustmentHeritageDBAccess
{


	public Int64 Insert(AdjustmentHeritage adjustmentHeritage)
	{
		SqlParameter[] parametersAdjustmentHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeirID", (adjustmentHeritage.HeirID > 0) ? adjustmentHeritage.HeirID : (object)DBNull.Value),
			new SqlParameter("@HeritageID", (adjustmentHeritage.HeritageID > 0) ? adjustmentHeritage.HeritageID : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (adjustmentHeritage.RegisterInformationID > 0) ? adjustmentHeritage.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@AdjustmentValue1", (adjustmentHeritage.AdjustmentValue1 != null) ? adjustmentHeritage.AdjustmentValue1 : (object)DBNull.Value),
			new SqlParameter("@AdjustmentValue2", (adjustmentHeritage.AdjustmentValue2 != null) ? adjustmentHeritage.AdjustmentValue2 : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("AdjustmentHeritage_Insert", CommandType.StoredProcedure, parametersAdjustmentHeritage);
	}

	public bool Update(AdjustmentHeritage adjustmentHeritage)
	{
		SqlParameter[] parametersAdjustmentHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeirID", adjustmentHeritage.HeirID),
			new SqlParameter("@HeritageID", adjustmentHeritage.HeritageID),
			new SqlParameter("@RegisterInformationID", (adjustmentHeritage.RegisterInformationID != null && adjustmentHeritage.RegisterInformationID >0 ) ? adjustmentHeritage.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@AdjustmentValue1", (adjustmentHeritage.AdjustmentValue1 != null) ? adjustmentHeritage.AdjustmentValue1 : (object)DBNull.Value),
			new SqlParameter("@AdjustmentValue2", (adjustmentHeritage.AdjustmentValue2 != null) ? adjustmentHeritage.AdjustmentValue2 : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("AdjustmentHeritage_Update", CommandType.StoredProcedure, parametersAdjustmentHeritage);
	}

	public bool Delete(Int64 heirID , Int64 heritageID)
	{
		SqlParameter[] parametersAdjustmentHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeirID", heirID),
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("AdjustmentHeritage_Delete", CommandType.StoredProcedure, parametersAdjustmentHeritage);
	}

	public AdjustmentHeritage GetDetails(Int64 heirID , Int64 heritageID)
	{
		AdjustmentHeritage adjustmentHeritage = new AdjustmentHeritage();

		SqlParameter[] parametersAdjustmentHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeirID", heirID),
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("AdjustmentHeritage_GetDetails", CommandType.StoredProcedure, parametersAdjustmentHeritage))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				adjustmentHeritage.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
				adjustmentHeritage.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				adjustmentHeritage.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
				adjustmentHeritage.OldRegisterDate = row["OldRegisterDate"].ToString();
				adjustmentHeritage.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
				adjustmentHeritage.AdjustmentValue1 = (row["AdjustmentValue1"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue1"]) : 0 ;
				adjustmentHeritage.AdjustmentValue2 = (row["AdjustmentValue2"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue2"]) : 0 ;
			}
		}

		return adjustmentHeritage;
	}

	public List<AdjustmentHeritage> GetListAll()
	{
		List<AdjustmentHeritage> listAdjustmentHeritage = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("AdjustmentHeritage_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listAdjustmentHeritage = new List<AdjustmentHeritage>();

				foreach (DataRow row in table.Rows)
				{
					AdjustmentHeritage adjustmentHeritage = new AdjustmentHeritage();
					adjustmentHeritage.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
					adjustmentHeritage.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					adjustmentHeritage.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					adjustmentHeritage.OldRegisterDate = row["OldRegisterDate"].ToString();
					adjustmentHeritage.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					adjustmentHeritage.AdjustmentValue1 = (row["AdjustmentValue1"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue1"]) : 0 ;
					adjustmentHeritage.AdjustmentValue2 = (row["AdjustmentValue2"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue2"]) : 0 ;
					listAdjustmentHeritage.Add(adjustmentHeritage);
				}
			}
		}

		return listAdjustmentHeritage;
	}

	public bool Exists(Int64 heirID , Int64 heritageID)
	{
		SqlParameter[] parametersAdjustmentHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeirID", heirID),
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("AdjustmentHeritage_Exists", CommandType.StoredProcedure, parametersAdjustmentHeritage)>0);
	}

	public bool Exists(AdjustmentHeritage adjustmentHeritage)
	{
		SqlParameter[] parametersAdjustmentHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeirID", adjustmentHeritage.HeirID),
			new SqlParameter("@HeritageID", adjustmentHeritage.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("AdjustmentHeritage_Exists", CommandType.StoredProcedure, parametersAdjustmentHeritage)>0);
	}

	public List<AdjustmentHeritage> SearchLike(AdjustmentHeritage adjustmentHeritage)
	{
		List<AdjustmentHeritage> listAdjustmentHeritage = new List<AdjustmentHeritage>();


		SqlParameter[] parametersAdjustmentHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeirID", adjustmentHeritage.HeirID),
			new SqlParameter("@HeritageID", adjustmentHeritage.HeritageID),
			new SqlParameter("@OldRegisterInformationID", adjustmentHeritage.OldRegisterInformationID),
			new SqlParameter("@OldRegisterDate", adjustmentHeritage.OldRegisterDate),
			new SqlParameter("@RegisterInformationID", adjustmentHeritage.RegisterInformationID),
			new SqlParameter("@AdjustmentValue1", adjustmentHeritage.AdjustmentValue1),
			new SqlParameter("@AdjustmentValue2", adjustmentHeritage.AdjustmentValue2),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("AdjustmentHeritage_SearchLike", CommandType.StoredProcedure, parametersAdjustmentHeritage))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					AdjustmentHeritage tmpAdjustmentHeritage = new AdjustmentHeritage();
					tmpAdjustmentHeritage.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
					tmpAdjustmentHeritage.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpAdjustmentHeritage.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					tmpAdjustmentHeritage.OldRegisterDate = row["OldRegisterDate"].ToString();
					tmpAdjustmentHeritage.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					tmpAdjustmentHeritage.AdjustmentValue1 = (row["AdjustmentValue1"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue1"]) : 0 ;
					tmpAdjustmentHeritage.AdjustmentValue2 = (row["AdjustmentValue2"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue2"]) : 0 ;

					listAdjustmentHeritage.Add(tmpAdjustmentHeritage);
				}
			}
		}

		return listAdjustmentHeritage;
	}

}
}
