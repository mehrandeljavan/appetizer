using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class CommissionVerdictTypeDBAccess
{

	CommissionAdjustmentHeritageDBAccess commissionAdjustmentHeritageDBAccess = new CommissionAdjustmentHeritageDBAccess();
	CommissionVerdictDBAccess commissionVerdictDBAccess = new CommissionVerdictDBAccess();

	public List<CommissionAdjustmentHeritage> GetListCommissionAdjustmentHeritage(int commissionVerdictTypeID)
	{
		List<CommissionAdjustmentHeritage> listCommissionAdjustmentHeritage = new List<CommissionAdjustmentHeritage>() { };
		SqlParameter[] parametersCommissionVerdictType = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdictTypeID)
		};

		//Lets get the list of CommissionAdjustmentHeritage records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionAdjustmentHeritage_GetList_UseInCommissionVerdictType", CommandType.StoredProcedure, parametersCommissionVerdictType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of commissionAdjustmentHeritage
				listCommissionAdjustmentHeritage = new List<CommissionAdjustmentHeritage>();

				//Now lets populate the CommissionAdjustmentHeritage details into the list of commissionAdjustmentHeritages
				foreach (DataRow row in table.Rows)
				{
					CommissionAdjustmentHeritage commissionAdjustmentHeritage = ConvertRowToCommissionAdjustmentHeritage(row);
					listCommissionAdjustmentHeritage.Add(commissionAdjustmentHeritage);
				}
			}
		}

		return listCommissionAdjustmentHeritage;
	}

	private CommissionAdjustmentHeritage ConvertRowToCommissionAdjustmentHeritage(DataRow row)
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
		return commissionAdjustmentHeritage;
	}
	public List<CommissionVerdict> GetListCommissionVerdict(int commissionVerdictTypeID)
	{
		List<CommissionVerdict> listCommissionVerdict = new List<CommissionVerdict>() { };
		SqlParameter[] parametersCommissionVerdictType = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdictTypeID)
		};

		//Lets get the list of CommissionVerdict records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionVerdict_GetList_UseInCommissionVerdictType", CommandType.StoredProcedure, parametersCommissionVerdictType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of commissionVerdict
				listCommissionVerdict = new List<CommissionVerdict>();

				//Now lets populate the CommissionVerdict details into the list of commissionVerdicts
				foreach (DataRow row in table.Rows)
				{
					CommissionVerdict commissionVerdict = ConvertRowToCommissionVerdict(row);
					listCommissionVerdict.Add(commissionVerdict);
				}
			}
		}

		return listCommissionVerdict;
	}

	private CommissionVerdict ConvertRowToCommissionVerdict(DataRow row)
	{
		CommissionVerdict commissionVerdict = new CommissionVerdict();
		commissionVerdict.CommissionVerdictTypeID = (row["CommissionVerdictTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionVerdictTypeID"]) : 0 ;
		commissionVerdict.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
		commissionVerdict.CommissionVerdictTypeIDTitle = row["CommissionVerdictTypeIDTitle"].ToString();
		commissionVerdict.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		commissionVerdict.OldRegisterDate = row["OldRegisterDate"].ToString();
		commissionVerdict.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		commissionVerdict.VerdictDate = row["VerdictDate"].ToString();
		commissionVerdict.VerdictNumber = row["VerdictNumber"].ToString();
		commissionVerdict.Comment = row["Comment"].ToString();
		return commissionVerdict;
	}
	public Int64 Insert(CommissionVerdictType commissionVerdictType)
	{
		SqlParameter[] parametersCommissionVerdictType = new SqlParameter[]
		{
			new SqlParameter("@Title", (commissionVerdictType.Title != null) ? commissionVerdictType.Title : (object)DBNull.Value)
		};
		commissionVerdictType.CommissionVerdictTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("CommissionVerdictType_Insert", CommandType.StoredProcedure, parametersCommissionVerdictType));
		return commissionVerdictType.CommissionVerdictTypeID;
	}

	public bool Update(CommissionVerdictType commissionVerdictType)
	{
		SqlParameter[] parametersCommissionVerdictType = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdictType.CommissionVerdictTypeID),
			new SqlParameter("@Title", (commissionVerdictType.Title != null) ? commissionVerdictType.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("CommissionVerdictType_Update", CommandType.StoredProcedure, parametersCommissionVerdictType);
	}

	public bool Delete(int commissionVerdictTypeID)
	{
		SqlParameter[] parametersCommissionVerdictType = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdictTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("CommissionVerdictType_Delete", CommandType.StoredProcedure, parametersCommissionVerdictType);
	}

	public CommissionVerdictType GetDetails(int commissionVerdictTypeID)
	{
		CommissionVerdictType commissionVerdictType = new CommissionVerdictType();

		SqlParameter[] parametersCommissionVerdictType = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdictTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionVerdictType_GetDetails", CommandType.StoredProcedure, parametersCommissionVerdictType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				commissionVerdictType.CommissionVerdictTypeID = (row["CommissionVerdictTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionVerdictTypeID"]) : 0 ;
				commissionVerdictType.Title = row["Title"].ToString();
			}
		}

		return commissionVerdictType;
	}

	public List<CommissionVerdictType> GetListAll()
	{
		List<CommissionVerdictType> listCommissionVerdictType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("CommissionVerdictType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listCommissionVerdictType = new List<CommissionVerdictType>();

				foreach (DataRow row in table.Rows)
				{
					CommissionVerdictType commissionVerdictType = new CommissionVerdictType();
					commissionVerdictType.CommissionVerdictTypeID = (row["CommissionVerdictTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionVerdictTypeID"]) : 0 ;
					commissionVerdictType.Title = row["Title"].ToString();
					listCommissionVerdictType.Add(commissionVerdictType);
				}
			}
		}

		return listCommissionVerdictType;
	}

	public bool Exists(int commissionVerdictTypeID)
	{
		SqlParameter[] parametersCommissionVerdictType = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdictTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("CommissionVerdictType_Exists", CommandType.StoredProcedure, parametersCommissionVerdictType)>0);
	}

	public bool Exists(CommissionVerdictType commissionVerdictType)
	{
		SqlParameter[] parametersCommissionVerdictType = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdictType.CommissionVerdictTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("CommissionVerdictType_Exists", CommandType.StoredProcedure, parametersCommissionVerdictType)>0);
	}

	public List<CommissionVerdictType> SearchLike(CommissionVerdictType commissionVerdictType)
	{
		List<CommissionVerdictType> listCommissionVerdictType = new List<CommissionVerdictType>();


		SqlParameter[] parametersCommissionVerdictType = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdictType.CommissionVerdictTypeID),
			new SqlParameter("@Title", commissionVerdictType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionVerdictType_SearchLike", CommandType.StoredProcedure, parametersCommissionVerdictType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					CommissionVerdictType tmpCommissionVerdictType = new CommissionVerdictType();
					tmpCommissionVerdictType.CommissionVerdictTypeID = (row["CommissionVerdictTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionVerdictTypeID"]) : 0 ;
					tmpCommissionVerdictType.Title = row["Title"].ToString();

					listCommissionVerdictType.Add(tmpCommissionVerdictType);
				}
			}
		}

		return listCommissionVerdictType;
	}

}
}
