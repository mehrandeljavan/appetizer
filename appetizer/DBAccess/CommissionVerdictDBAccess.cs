using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class CommissionVerdictDBAccess
{


	public Int64 Insert(CommissionVerdict commissionVerdict)
	{
		SqlParameter[] parametersCommissionVerdict = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", (commissionVerdict.CommissionVerdictTypeID > 0) ? commissionVerdict.CommissionVerdictTypeID : (object)DBNull.Value),
			new SqlParameter("@HeirID", (commissionVerdict.HeirID > 0) ? commissionVerdict.HeirID : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (commissionVerdict.RegisterInformationID > 0) ? commissionVerdict.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@VerdictDate", (commissionVerdict.VerdictDate != null) ? commissionVerdict.VerdictDate : (object)DBNull.Value),
			new SqlParameter("@VerdictNumber", (commissionVerdict.VerdictNumber != null) ? commissionVerdict.VerdictNumber : (object)DBNull.Value),
			new SqlParameter("@Comment", (commissionVerdict.Comment != null) ? commissionVerdict.Comment : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("CommissionVerdict_Insert", CommandType.StoredProcedure, parametersCommissionVerdict);
	}

	public bool Update(CommissionVerdict commissionVerdict)
	{
		SqlParameter[] parametersCommissionVerdict = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdict.CommissionVerdictTypeID),
			new SqlParameter("@HeirID", commissionVerdict.HeirID),
			new SqlParameter("@RegisterInformationID", (commissionVerdict.RegisterInformationID != null && commissionVerdict.RegisterInformationID >0 ) ? commissionVerdict.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@VerdictDate", (commissionVerdict.VerdictDate != null) ? commissionVerdict.VerdictDate : (object)DBNull.Value),
			new SqlParameter("@VerdictNumber", (commissionVerdict.VerdictNumber != null) ? commissionVerdict.VerdictNumber : (object)DBNull.Value),
			new SqlParameter("@Comment", (commissionVerdict.Comment != null) ? commissionVerdict.Comment : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("CommissionVerdict_Update", CommandType.StoredProcedure, parametersCommissionVerdict);
	}

	public bool Delete(int commissionVerdictTypeID , Int64 heirID)
	{
		SqlParameter[] parametersCommissionVerdict = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdictTypeID),
			new SqlParameter("@HeirID", heirID)
		};
		return SqlDBHelper.ExecuteNonQuery("CommissionVerdict_Delete", CommandType.StoredProcedure, parametersCommissionVerdict);
	}

	public CommissionVerdict GetDetails(int commissionVerdictTypeID , Int64 heirID)
	{
		CommissionVerdict commissionVerdict = new CommissionVerdict();

		SqlParameter[] parametersCommissionVerdict = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdictTypeID),
			new SqlParameter("@HeirID", heirID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionVerdict_GetDetails", CommandType.StoredProcedure, parametersCommissionVerdict))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				commissionVerdict.CommissionVerdictTypeID = (row["CommissionVerdictTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionVerdictTypeID"]) : 0 ;
				commissionVerdict.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
				commissionVerdict.CommissionVerdictTypeIDTitle = row["CommissionVerdictTypeIDTitle"].ToString();
				commissionVerdict.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
				commissionVerdict.OldRegisterDate = row["OldRegisterDate"].ToString();
				commissionVerdict.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
				commissionVerdict.VerdictDate = row["VerdictDate"].ToString();
				commissionVerdict.VerdictNumber = row["VerdictNumber"].ToString();
				commissionVerdict.Comment = row["Comment"].ToString();
			}
		}

		return commissionVerdict;
	}

	public List<CommissionVerdict> GetListAll()
	{
		List<CommissionVerdict> listCommissionVerdict = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("CommissionVerdict_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listCommissionVerdict = new List<CommissionVerdict>();

				foreach (DataRow row in table.Rows)
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
					listCommissionVerdict.Add(commissionVerdict);
				}
			}
		}

		return listCommissionVerdict;
	}

	public bool Exists(int commissionVerdictTypeID , Int64 heirID)
	{
		SqlParameter[] parametersCommissionVerdict = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdictTypeID),
			new SqlParameter("@HeirID", heirID)
		};
		return (SqlDBHelper.ExecuteScalar("CommissionVerdict_Exists", CommandType.StoredProcedure, parametersCommissionVerdict)>0);
	}

	public bool Exists(CommissionVerdict commissionVerdict)
	{
		SqlParameter[] parametersCommissionVerdict = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdict.CommissionVerdictTypeID),
			new SqlParameter("@HeirID", commissionVerdict.HeirID)
		};
		return (SqlDBHelper.ExecuteScalar("CommissionVerdict_Exists", CommandType.StoredProcedure, parametersCommissionVerdict)>0);
	}

	public List<CommissionVerdict> SearchLike(CommissionVerdict commissionVerdict)
	{
		List<CommissionVerdict> listCommissionVerdict = new List<CommissionVerdict>();


		SqlParameter[] parametersCommissionVerdict = new SqlParameter[]
		{
			new SqlParameter("@CommissionVerdictTypeID", commissionVerdict.CommissionVerdictTypeID),
			new SqlParameter("@HeirID", commissionVerdict.HeirID),
			new SqlParameter("@CommissionVerdictTypeIDTitle", commissionVerdict.CommissionVerdictTypeIDTitle),
			new SqlParameter("@OldRegisterInformationID", commissionVerdict.OldRegisterInformationID),
			new SqlParameter("@OldRegisterDate", commissionVerdict.OldRegisterDate),
			new SqlParameter("@RegisterInformationID", commissionVerdict.RegisterInformationID),
			new SqlParameter("@VerdictDate", commissionVerdict.VerdictDate),
			new SqlParameter("@VerdictNumber", commissionVerdict.VerdictNumber),
			new SqlParameter("@Comment", commissionVerdict.Comment),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionVerdict_SearchLike", CommandType.StoredProcedure, parametersCommissionVerdict))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					CommissionVerdict tmpCommissionVerdict = new CommissionVerdict();
					tmpCommissionVerdict.CommissionVerdictTypeID = (row["CommissionVerdictTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionVerdictTypeID"]) : 0 ;
					tmpCommissionVerdict.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
					tmpCommissionVerdict.CommissionVerdictTypeIDTitle = row["CommissionVerdictTypeIDTitle"].ToString();
					tmpCommissionVerdict.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					tmpCommissionVerdict.OldRegisterDate = row["OldRegisterDate"].ToString();
					tmpCommissionVerdict.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					tmpCommissionVerdict.VerdictDate = row["VerdictDate"].ToString();
					tmpCommissionVerdict.VerdictNumber = row["VerdictNumber"].ToString();
					tmpCommissionVerdict.Comment = row["Comment"].ToString();

					listCommissionVerdict.Add(tmpCommissionVerdict);
				}
			}
		}

		return listCommissionVerdict;
	}

}
}
