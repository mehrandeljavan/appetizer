using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class ProductionUnitTypeDBAccess
{

	ProductionUnitDBAccess productionUnitDBAccess = new ProductionUnitDBAccess();

	public List<ProductionUnit> GetListProductionUnit(int productionUnitTypeID)
	{
		List<ProductionUnit> listProductionUnit = new List<ProductionUnit>() { };
		SqlParameter[] parametersProductionUnitType = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitTypeID", productionUnitTypeID)
		};

		//Lets get the list of ProductionUnit records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ProductionUnit_GetList_UseInProductionUnitType", CommandType.StoredProcedure, parametersProductionUnitType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of productionUnit
				listProductionUnit = new List<ProductionUnit>();

				//Now lets populate the ProductionUnit details into the list of productionUnits
				foreach (DataRow row in table.Rows)
				{
					ProductionUnit productionUnit = ConvertRowToProductionUnit(row);
					listProductionUnit.Add(productionUnit);
				}
			}
		}

		return listProductionUnit;
	}

	private ProductionUnit ConvertRowToProductionUnit(DataRow row)
	{
		ProductionUnit productionUnit = new ProductionUnit();
		productionUnit.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		productionUnit.ProductionUnitTypeIDTitle = row["ProductionUnitTypeIDTitle"].ToString();
		productionUnit.ProductionUnitTypeID = (row["ProductionUnitTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ProductionUnitTypeID"]) : 0 ;
		productionUnit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		productionUnit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		productionUnit.DocumentDate = row["DocumentDate"].ToString();
		productionUnit.UnitName = row["UnitName"].ToString();
		productionUnit.DocumentNumber = row["DocumentNumber"].ToString();

		productionUnit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		productionUnit.StageTitle = row["StageTitle"].ToString();
		productionUnit.RegisterDate = row["RegisterDate"].ToString();
		productionUnit.OldRegisterDate = row["OldRegisterDate"].ToString();
		productionUnit.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		productionUnit.Sixth = row["Sixth"].ToString();
		productionUnit.PreviousOwner = row["PreviousOwner"].ToString();
		productionUnit.Comment = row["Comment"].ToString();
		productionUnit.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		productionUnit.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		productionUnit.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		productionUnit.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		productionUnit.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		productionUnit.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		productionUnit.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		productionUnit.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		productionUnit.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		productionUnit.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return productionUnit;
	}
	public Int64 Insert(ProductionUnitType productionUnitType)
	{
		SqlParameter[] parametersProductionUnitType = new SqlParameter[]
		{
			new SqlParameter("@Category", (productionUnitType.Category != null) ? productionUnitType.Category : (object)DBNull.Value),
			new SqlParameter("@Title", productionUnitType.Title)
		};
		productionUnitType.ProductionUnitTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("ProductionUnitType_Insert", CommandType.StoredProcedure, parametersProductionUnitType));
		return productionUnitType.ProductionUnitTypeID;
	}

	public bool Update(ProductionUnitType productionUnitType)
	{
		SqlParameter[] parametersProductionUnitType = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitTypeID", productionUnitType.ProductionUnitTypeID),
			new SqlParameter("@Category", (productionUnitType.Category != null) ? productionUnitType.Category : (object)DBNull.Value),
			new SqlParameter("@Title", productionUnitType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("ProductionUnitType_Update", CommandType.StoredProcedure, parametersProductionUnitType);
	}

	public bool Delete(int productionUnitTypeID)
	{
		SqlParameter[] parametersProductionUnitType = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitTypeID", productionUnitTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("ProductionUnitType_Delete", CommandType.StoredProcedure, parametersProductionUnitType);
	}

	public ProductionUnitType GetDetails(int productionUnitTypeID)
	{
		ProductionUnitType productionUnitType = new ProductionUnitType();

		SqlParameter[] parametersProductionUnitType = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitTypeID", productionUnitTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ProductionUnitType_GetDetails", CommandType.StoredProcedure, parametersProductionUnitType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				productionUnitType.ProductionUnitTypeID = (row["ProductionUnitTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ProductionUnitTypeID"]) : 0 ;
				productionUnitType.Category = (row["Category"] != DBNull.Value) ? Convert.ToInt32(row["Category"]) : 0 ;
				productionUnitType.Title = row["Title"].ToString();
			}
		}

		return productionUnitType;
	}

	public List<ProductionUnitType> GetListAll()
	{
		List<ProductionUnitType> listProductionUnitType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("ProductionUnitType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listProductionUnitType = new List<ProductionUnitType>();

				foreach (DataRow row in table.Rows)
				{
					ProductionUnitType productionUnitType = new ProductionUnitType();
					productionUnitType.ProductionUnitTypeID = (row["ProductionUnitTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ProductionUnitTypeID"]) : 0 ;
					productionUnitType.Category = (row["Category"] != DBNull.Value) ? Convert.ToInt32(row["Category"]) : 0 ;
					productionUnitType.Title = row["Title"].ToString();
					listProductionUnitType.Add(productionUnitType);
				}
			}
		}

		return listProductionUnitType;
	}

	public bool Exists(int productionUnitTypeID)
	{
		SqlParameter[] parametersProductionUnitType = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitTypeID", productionUnitTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("ProductionUnitType_Exists", CommandType.StoredProcedure, parametersProductionUnitType)>0);
	}

	public bool Exists(ProductionUnitType productionUnitType)
	{
		SqlParameter[] parametersProductionUnitType = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitTypeID", productionUnitType.ProductionUnitTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("ProductionUnitType_Exists", CommandType.StoredProcedure, parametersProductionUnitType)>0);
	}

	public List<ProductionUnitType> SearchLike(ProductionUnitType productionUnitType)
	{
		List<ProductionUnitType> listProductionUnitType = new List<ProductionUnitType>();


		SqlParameter[] parametersProductionUnitType = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitTypeID", productionUnitType.ProductionUnitTypeID),
			new SqlParameter("@Category", productionUnitType.Category),
			new SqlParameter("@Title", productionUnitType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ProductionUnitType_SearchLike", CommandType.StoredProcedure, parametersProductionUnitType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					ProductionUnitType tmpProductionUnitType = new ProductionUnitType();
					tmpProductionUnitType.ProductionUnitTypeID = (row["ProductionUnitTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ProductionUnitTypeID"]) : 0 ;
					tmpProductionUnitType.Category = (row["Category"] != DBNull.Value) ? Convert.ToInt32(row["Category"]) : 0 ;
					tmpProductionUnitType.Title = row["Title"].ToString();

					listProductionUnitType.Add(tmpProductionUnitType);
				}
			}
		}

		return listProductionUnitType;
	}

}
}
