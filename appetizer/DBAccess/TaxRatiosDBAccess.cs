using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class TaxRatiosDBAccess
{


	public Int64 Insert(TaxRatios taxRatios)
	{
		SqlParameter[] parametersTaxRatios = new SqlParameter[]
		{
			new SqlParameter("@OrderNumber", (taxRatios.OrderNumber != null) ? taxRatios.OrderNumber : (object)DBNull.Value),
			new SqlParameter("@ExemptionPercentLevel1", taxRatios.ExemptionPercentLevel1),
			new SqlParameter("@ExemptionPercentLevel2", taxRatios.ExemptionPercentLevel2),
			new SqlParameter("@ExemptionPercentLevel3", taxRatios.ExemptionPercentLevel3),
			new SqlParameter("@ValueUpperBound", taxRatios.ValueUpperBound),
			new SqlParameter("@RangeStartDate", taxRatios.RangeStartDate),
			new SqlParameter("@RangeEndDate", taxRatios.RangeEndDate)
		};
		taxRatios.TaxRatiiosID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("TaxRatios_Insert", CommandType.StoredProcedure, parametersTaxRatios));
		return taxRatios.TaxRatiiosID;
	}

	public bool Update(TaxRatios taxRatios)
	{
		SqlParameter[] parametersTaxRatios = new SqlParameter[]
		{
			new SqlParameter("@TaxRatiiosID", taxRatios.TaxRatiiosID),
			new SqlParameter("@OrderNumber", (taxRatios.OrderNumber != null) ? taxRatios.OrderNumber : (object)DBNull.Value),
			new SqlParameter("@ExemptionPercentLevel1", taxRatios.ExemptionPercentLevel1),
			new SqlParameter("@ExemptionPercentLevel2", taxRatios.ExemptionPercentLevel2),
			new SqlParameter("@ExemptionPercentLevel3", taxRatios.ExemptionPercentLevel3),
			new SqlParameter("@ValueUpperBound", taxRatios.ValueUpperBound),
			new SqlParameter("@RangeStartDate", taxRatios.RangeStartDate),
			new SqlParameter("@RangeEndDate", taxRatios.RangeEndDate)
		};
		return SqlDBHelper.ExecuteNonQuery("TaxRatios_Update", CommandType.StoredProcedure, parametersTaxRatios);
	}

	public bool Delete(int taxRatiiosID)
	{
		SqlParameter[] parametersTaxRatios = new SqlParameter[]
		{
			new SqlParameter("@TaxRatiiosID", taxRatiiosID)
		};
		return SqlDBHelper.ExecuteNonQuery("TaxRatios_Delete", CommandType.StoredProcedure, parametersTaxRatios);
	}

	public TaxRatios GetDetails(int taxRatiiosID)
	{
		TaxRatios taxRatios = new TaxRatios();

		SqlParameter[] parametersTaxRatios = new SqlParameter[]
		{
			new SqlParameter("@TaxRatiiosID", taxRatiiosID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TaxRatios_GetDetails", CommandType.StoredProcedure, parametersTaxRatios))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				taxRatios.TaxRatiiosID = (row["TaxRatiiosID"] != DBNull.Value) ? Convert.ToInt32(row["TaxRatiiosID"]) : 0 ;
				taxRatios.OrderNumber = (row["OrderNumber"] != DBNull.Value) ? Convert.ToInt32(row["OrderNumber"]) : 0 ;
				taxRatios.ExemptionPercentLevel1 = (row["ExemptionPercentLevel1"] != DBNull.Value) ? Convert.ToSingle(row["ExemptionPercentLevel1"]) : 0 ;
				taxRatios.ExemptionPercentLevel2 = (row["ExemptionPercentLevel2"] != DBNull.Value) ? Convert.ToSingle(row["ExemptionPercentLevel2"]) : 0 ;
				taxRatios.ExemptionPercentLevel3 = (row["ExemptionPercentLevel3"] != DBNull.Value) ? Convert.ToSingle(row["ExemptionPercentLevel3"]) : 0 ;
				taxRatios.ValueUpperBound = (row["ValueUpperBound"] != DBNull.Value) ? Convert.ToInt64(row["ValueUpperBound"]) : 0 ;
				taxRatios.RangeStartDate = row["RangeStartDate"].ToString();
				taxRatios.RangeEndDate = row["RangeEndDate"].ToString();
			}
		}

		return taxRatios;
	}

	public List<TaxRatios> GetListAll()
	{
		List<TaxRatios> listTaxRatios = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("TaxRatios_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listTaxRatios = new List<TaxRatios>();

				foreach (DataRow row in table.Rows)
				{
					TaxRatios taxRatios = new TaxRatios();
					taxRatios.TaxRatiiosID = (row["TaxRatiiosID"] != DBNull.Value) ? Convert.ToInt32(row["TaxRatiiosID"]) : 0 ;
					taxRatios.OrderNumber = (row["OrderNumber"] != DBNull.Value) ? Convert.ToInt32(row["OrderNumber"]) : 0 ;
					taxRatios.ExemptionPercentLevel1 = (row["ExemptionPercentLevel1"] != DBNull.Value) ? Convert.ToSingle(row["ExemptionPercentLevel1"]) : 0 ;
					taxRatios.ExemptionPercentLevel2 = (row["ExemptionPercentLevel2"] != DBNull.Value) ? Convert.ToSingle(row["ExemptionPercentLevel2"]) : 0 ;
					taxRatios.ExemptionPercentLevel3 = (row["ExemptionPercentLevel3"] != DBNull.Value) ? Convert.ToSingle(row["ExemptionPercentLevel3"]) : 0 ;
					taxRatios.ValueUpperBound = (row["ValueUpperBound"] != DBNull.Value) ? Convert.ToInt64(row["ValueUpperBound"]) : 0 ;
					taxRatios.RangeStartDate = row["RangeStartDate"].ToString();
					taxRatios.RangeEndDate = row["RangeEndDate"].ToString();
					listTaxRatios.Add(taxRatios);
				}
			}
		}

		return listTaxRatios;
	}

	public bool Exists(int taxRatiiosID)
	{
		SqlParameter[] parametersTaxRatios = new SqlParameter[]
		{
			new SqlParameter("@TaxRatiiosID", taxRatiiosID)
		};
		return (SqlDBHelper.ExecuteScalar("TaxRatios_Exists", CommandType.StoredProcedure, parametersTaxRatios)>0);
	}

	public bool Exists(TaxRatios taxRatios)
	{
		SqlParameter[] parametersTaxRatios = new SqlParameter[]
		{
			new SqlParameter("@TaxRatiiosID", taxRatios.TaxRatiiosID)
		};
		return (SqlDBHelper.ExecuteScalar("TaxRatios_Exists", CommandType.StoredProcedure, parametersTaxRatios)>0);
	}

	public List<TaxRatios> SearchLike(TaxRatios taxRatios)
	{
		List<TaxRatios> listTaxRatios = new List<TaxRatios>();


		SqlParameter[] parametersTaxRatios = new SqlParameter[]
		{
			new SqlParameter("@TaxRatiiosID", taxRatios.TaxRatiiosID),
			new SqlParameter("@OrderNumber", taxRatios.OrderNumber),
			new SqlParameter("@ExemptionPercentLevel1", taxRatios.ExemptionPercentLevel1),
			new SqlParameter("@ExemptionPercentLevel2", taxRatios.ExemptionPercentLevel2),
			new SqlParameter("@ExemptionPercentLevel3", taxRatios.ExemptionPercentLevel3),
			new SqlParameter("@ValueUpperBound", taxRatios.ValueUpperBound),
			new SqlParameter("@RangeStartDate", taxRatios.RangeStartDate),
			new SqlParameter("@RangeEndDate", taxRatios.RangeEndDate),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TaxRatios_SearchLike", CommandType.StoredProcedure, parametersTaxRatios))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					TaxRatios tmpTaxRatios = new TaxRatios();
					tmpTaxRatios.TaxRatiiosID = (row["TaxRatiiosID"] != DBNull.Value) ? Convert.ToInt32(row["TaxRatiiosID"]) : 0 ;
					tmpTaxRatios.OrderNumber = (row["OrderNumber"] != DBNull.Value) ? Convert.ToInt32(row["OrderNumber"]) : 0 ;
					tmpTaxRatios.ExemptionPercentLevel1 = (row["ExemptionPercentLevel1"] != DBNull.Value) ? Convert.ToSingle(row["ExemptionPercentLevel1"]) : 0 ;
					tmpTaxRatios.ExemptionPercentLevel2 = (row["ExemptionPercentLevel2"] != DBNull.Value) ? Convert.ToSingle(row["ExemptionPercentLevel2"]) : 0 ;
					tmpTaxRatios.ExemptionPercentLevel3 = (row["ExemptionPercentLevel3"] != DBNull.Value) ? Convert.ToSingle(row["ExemptionPercentLevel3"]) : 0 ;
					tmpTaxRatios.ValueUpperBound = (row["ValueUpperBound"] != DBNull.Value) ? Convert.ToInt64(row["ValueUpperBound"]) : 0 ;
					tmpTaxRatios.RangeStartDate = row["RangeStartDate"].ToString();
					tmpTaxRatios.RangeEndDate = row["RangeEndDate"].ToString();

					listTaxRatios.Add(tmpTaxRatios);
				}
			}
		}

		return listTaxRatios;
	}

}
}
