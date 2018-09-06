using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class CalculationTypeDBAccess
{


	public Int64 Insert(CalculationType calculationType)
	{
		SqlParameter[] parametersCalculationType = new SqlParameter[]
		{
			new SqlParameter("@Title", (calculationType.Title != null) ? calculationType.Title : (object)DBNull.Value)
		};
		calculationType.CalculationTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("CalculationType_Insert", CommandType.StoredProcedure, parametersCalculationType));
		return calculationType.CalculationTypeID;
	}

	public bool Update(CalculationType calculationType)
	{
		SqlParameter[] parametersCalculationType = new SqlParameter[]
		{
			new SqlParameter("@CalculationTypeID", calculationType.CalculationTypeID),
			new SqlParameter("@Title", (calculationType.Title != null) ? calculationType.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("CalculationType_Update", CommandType.StoredProcedure, parametersCalculationType);
	}

	public bool Delete(int calculationTypeID)
	{
		SqlParameter[] parametersCalculationType = new SqlParameter[]
		{
			new SqlParameter("@CalculationTypeID", calculationTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("CalculationType_Delete", CommandType.StoredProcedure, parametersCalculationType);
	}

	public CalculationType GetDetails(int calculationTypeID)
	{
		CalculationType calculationType = new CalculationType();

		SqlParameter[] parametersCalculationType = new SqlParameter[]
		{
			new SqlParameter("@CalculationTypeID", calculationTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CalculationType_GetDetails", CommandType.StoredProcedure, parametersCalculationType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				calculationType.CalculationTypeID = (row["CalculationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CalculationTypeID"]) : 0 ;
				calculationType.Title = row["Title"].ToString();
			}
		}

		return calculationType;
	}

	public List<CalculationType> GetListAll()
	{
		List<CalculationType> listCalculationType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("CalculationType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listCalculationType = new List<CalculationType>();

				foreach (DataRow row in table.Rows)
				{
					CalculationType calculationType = new CalculationType();
					calculationType.CalculationTypeID = (row["CalculationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CalculationTypeID"]) : 0 ;
					calculationType.Title = row["Title"].ToString();
					listCalculationType.Add(calculationType);
				}
			}
		}

		return listCalculationType;
	}

	public bool Exists(int calculationTypeID)
	{
		SqlParameter[] parametersCalculationType = new SqlParameter[]
		{
			new SqlParameter("@CalculationTypeID", calculationTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("CalculationType_Exists", CommandType.StoredProcedure, parametersCalculationType)>0);
	}

	public bool Exists(CalculationType calculationType)
	{
		SqlParameter[] parametersCalculationType = new SqlParameter[]
		{
			new SqlParameter("@CalculationTypeID", calculationType.CalculationTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("CalculationType_Exists", CommandType.StoredProcedure, parametersCalculationType)>0);
	}

	public List<CalculationType> SearchLike(CalculationType calculationType)
	{
		List<CalculationType> listCalculationType = new List<CalculationType>();


		SqlParameter[] parametersCalculationType = new SqlParameter[]
		{
			new SqlParameter("@CalculationTypeID", calculationType.CalculationTypeID),
			new SqlParameter("@Title", calculationType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CalculationType_SearchLike", CommandType.StoredProcedure, parametersCalculationType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					CalculationType tmpCalculationType = new CalculationType();
					tmpCalculationType.CalculationTypeID = (row["CalculationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CalculationTypeID"]) : 0 ;
					tmpCalculationType.Title = row["Title"].ToString();

					listCalculationType.Add(tmpCalculationType);
				}
			}
		}

		return listCalculationType;
	}

}
}
