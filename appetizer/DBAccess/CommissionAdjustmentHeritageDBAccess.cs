using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class CommissionAdjustmentHeritageDBAccess
{


	public Int64 Insert(CommissionAdjustmentHeritage commissionAdjustmentHeritage)
	{
		SqlParameter[] parametersCommissionAdjustmentHeritage = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", (commissionAdjustmentHeritage.CommissionVerdictTypeID > 0) ? commissionAdjustmentHeritage.CommissionVerdictTypeID : (object)DBNull.Value),
			new SqlParameter("@HeirID", (commissionAdjustmentHeritage.HeirID > 0) ? commissionAdjustmentHeritage.HeirID : (object)DBNull.Value),
			new SqlParameter("@HeritageID", (commissionAdjustmentHeritage.HeritageID > 0) ? commissionAdjustmentHeritage.HeritageID : (object)DBNull.Value),
			new SqlParameter("@AdjustmentValue1", (commissionAdjustmentHeritage.AdjustmentValue1 != null) ? commissionAdjustmentHeritage.AdjustmentValue1 : (object)DBNull.Value),
			new SqlParameter("@AdjustmentValue2", (commissionAdjustmentHeritage.AdjustmentValue2 != null) ? commissionAdjustmentHeritage.AdjustmentValue2 : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (commissionAdjustmentHeritage.RegisterInformationID != null) ? commissionAdjustmentHeritage.RegisterInformationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("CommissionAdjustmentHeritage_Insert", CommandType.StoredProcedure, parametersCommissionAdjustmentHeritage);
	}

	public bool Update(CommissionAdjustmentHeritage commissionAdjustmentHeritage)
	{
		SqlParameter[] parametersCommissionAdjustmentHeritage = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionAdjustmentHeritage.CommissionVerdictTypeID),
			new SqlParameter("@HeirID", commissionAdjustmentHeritage.HeirID),
			new SqlParameter("@HeritageID", commissionAdjustmentHeritage.HeritageID),
			new SqlParameter("@AdjustmentValue1", (commissionAdjustmentHeritage.AdjustmentValue1 != null) ? commissionAdjustmentHeritage.AdjustmentValue1 : (object)DBNull.Value),
			new SqlParameter("@AdjustmentValue2", (commissionAdjustmentHeritage.AdjustmentValue2 != null) ? commissionAdjustmentHeritage.AdjustmentValue2 : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (commissionAdjustmentHeritage.RegisterInformationID != null) ? commissionAdjustmentHeritage.RegisterInformationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("CommissionAdjustmentHeritage_Update", CommandType.StoredProcedure, parametersCommissionAdjustmentHeritage);
	}

	public bool Delete(int commissionVerdictTypeID , Int64 heirID , Int64 heritageID)
	{
		SqlParameter[] parametersCommissionAdjustmentHeritage = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdictTypeID),
			new SqlParameter("@HeirID", heirID),
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("CommissionAdjustmentHeritage_Delete", CommandType.StoredProcedure, parametersCommissionAdjustmentHeritage);
	}

	public CommissionAdjustmentHeritage GetDetails(int commissionVerdictTypeID , Int64 heirID , Int64 heritageID)
	{
		CommissionAdjustmentHeritage commissionAdjustmentHeritage = new CommissionAdjustmentHeritage();

		SqlParameter[] parametersCommissionAdjustmentHeritage = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdictTypeID),
			new SqlParameter("@HeirID", heirID),
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionAdjustmentHeritage_GetDetails", CommandType.StoredProcedure, parametersCommissionAdjustmentHeritage))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				commissionAdjustmentHeritage.CommissionVerdictTypeID = (row["CommissionVerdictTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionVerdictTypeID"]) : 0 ;
				commissionAdjustmentHeritage.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
				commissionAdjustmentHeritage.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				commissionAdjustmentHeritage.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
				commissionAdjustmentHeritage.OldRegisterDate = row["OldRegisterDate"].ToString();
				commissionAdjustmentHeritage.AdjustmentValue1 = (row["AdjustmentValue1"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue1"]) : 0 ;
				commissionAdjustmentHeritage.AdjustmentValue2 = (row["AdjustmentValue2"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue2"]) : 0 ;
				commissionAdjustmentHeritage.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
			}
		}

		return commissionAdjustmentHeritage;
	}

	public List<CommissionAdjustmentHeritage> GetListAll()
	{
		List<CommissionAdjustmentHeritage> listCommissionAdjustmentHeritage = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("CommissionAdjustmentHeritage_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listCommissionAdjustmentHeritage = new List<CommissionAdjustmentHeritage>();

				foreach (DataRow row in table.Rows)
				{
					CommissionAdjustmentHeritage commissionAdjustmentHeritage = new CommissionAdjustmentHeritage();
					commissionAdjustmentHeritage.CommissionVerdictTypeID = (row["CommissionVerdictTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionVerdictTypeID"]) : 0 ;
					commissionAdjustmentHeritage.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
					commissionAdjustmentHeritage.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					commissionAdjustmentHeritage.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					commissionAdjustmentHeritage.OldRegisterDate = row["OldRegisterDate"].ToString();
					commissionAdjustmentHeritage.AdjustmentValue1 = (row["AdjustmentValue1"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue1"]) : 0 ;
					commissionAdjustmentHeritage.AdjustmentValue2 = (row["AdjustmentValue2"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue2"]) : 0 ;
					commissionAdjustmentHeritage.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					listCommissionAdjustmentHeritage.Add(commissionAdjustmentHeritage);
				}
			}
		}

		return listCommissionAdjustmentHeritage;
	}

	public bool Exists(int commissionVerdictTypeID , Int64 heirID , Int64 heritageID)
	{
		SqlParameter[] parametersCommissionAdjustmentHeritage = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdictTypeID),
			new SqlParameter("@HeirID", heirID),
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("CommissionAdjustmentHeritage_Exists", CommandType.StoredProcedure, parametersCommissionAdjustmentHeritage)>0);
	}

	public bool Exists(CommissionAdjustmentHeritage commissionAdjustmentHeritage)
	{
		SqlParameter[] parametersCommissionAdjustmentHeritage = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionAdjustmentHeritage.CommissionVerdictTypeID),
			new SqlParameter("@HeirID", commissionAdjustmentHeritage.HeirID),
			new SqlParameter("@HeritageID", commissionAdjustmentHeritage.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("CommissionAdjustmentHeritage_Exists", CommandType.StoredProcedure, parametersCommissionAdjustmentHeritage)>0);
	}

	public List<CommissionAdjustmentHeritage> SearchLike(CommissionAdjustmentHeritage commissionAdjustmentHeritage)
	{
		List<CommissionAdjustmentHeritage> listCommissionAdjustmentHeritage = new List<CommissionAdjustmentHeritage>();


		SqlParameter[] parametersCommissionAdjustmentHeritage = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionAdjustmentHeritage.CommissionVerdictTypeID),
			new SqlParameter("@HeirID", commissionAdjustmentHeritage.HeirID),
			new SqlParameter("@HeritageID", commissionAdjustmentHeritage.HeritageID),
			new SqlParameter("@OldRegisterInformationID", commissionAdjustmentHeritage.OldRegisterInformationID),
			new SqlParameter("@OldRegisterDate", commissionAdjustmentHeritage.OldRegisterDate),
			new SqlParameter("@AdjustmentValue1", commissionAdjustmentHeritage.AdjustmentValue1),
			new SqlParameter("@AdjustmentValue2", commissionAdjustmentHeritage.AdjustmentValue2),
			new SqlParameter("@RegisterInformationID", commissionAdjustmentHeritage.RegisterInformationID),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionAdjustmentHeritage_SearchLike", CommandType.StoredProcedure, parametersCommissionAdjustmentHeritage))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					CommissionAdjustmentHeritage tmpCommissionAdjustmentHeritage = new CommissionAdjustmentHeritage();
					tmpCommissionAdjustmentHeritage.CommissionVerdictTypeID = (row["CommissionVerdictTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionVerdictTypeID"]) : 0 ;
					tmpCommissionAdjustmentHeritage.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
					tmpCommissionAdjustmentHeritage.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpCommissionAdjustmentHeritage.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					tmpCommissionAdjustmentHeritage.OldRegisterDate = row["OldRegisterDate"].ToString();
					tmpCommissionAdjustmentHeritage.AdjustmentValue1 = (row["AdjustmentValue1"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue1"]) : 0 ;
					tmpCommissionAdjustmentHeritage.AdjustmentValue2 = (row["AdjustmentValue2"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue2"]) : 0 ;
					tmpCommissionAdjustmentHeritage.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;

					listCommissionAdjustmentHeritage.Add(tmpCommissionAdjustmentHeritage);
				}
			}
		}

		return listCommissionAdjustmentHeritage;
	}

}
}
