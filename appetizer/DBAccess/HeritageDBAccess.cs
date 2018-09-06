using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class HeritageDBAccess
{

	AdjustmentHeritageDBAccess adjustmentHeritageDBAccess = new AdjustmentHeritageDBAccess();
	CommissionAdjustmentHeritageDBAccess commissionAdjustmentHeritageDBAccess = new CommissionAdjustmentHeritageDBAccess();
	PropertyInOtherCountryDBAccess propertyInOtherCountryDBAccess = new PropertyInOtherCountryDBAccess();

	public List<AdjustmentHeritage> GetListAdjustmentHeritage(Int64 heritageID)
	{
		List<AdjustmentHeritage> listAdjustmentHeritage = new List<AdjustmentHeritage>() { };
		SqlParameter[] parametersHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};

		//Lets get the list of AdjustmentHeritage records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("AdjustmentHeritage_GetList_UseInHeritage", CommandType.StoredProcedure, parametersHeritage))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of adjustmentHeritage
				listAdjustmentHeritage = new List<AdjustmentHeritage>();

				//Now lets populate the AdjustmentHeritage details into the list of adjustmentHeritages
				foreach (DataRow row in table.Rows)
				{
					AdjustmentHeritage adjustmentHeritage = ConvertRowToAdjustmentHeritage(row);
					listAdjustmentHeritage.Add(adjustmentHeritage);
				}
			}
		}

		return listAdjustmentHeritage;
	}

	private AdjustmentHeritage ConvertRowToAdjustmentHeritage(DataRow row)
	{
		AdjustmentHeritage adjustmentHeritage = new AdjustmentHeritage();
		adjustmentHeritage.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
		adjustmentHeritage.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		adjustmentHeritage.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		adjustmentHeritage.OldRegisterDate = row["OldRegisterDate"].ToString();
		adjustmentHeritage.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		adjustmentHeritage.AdjustmentValue1 = (row["AdjustmentValue1"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue1"]) : 0 ;
		adjustmentHeritage.AdjustmentValue2 = (row["AdjustmentValue2"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue2"]) : 0 ;
		return adjustmentHeritage;
	}
	public List<CommissionAdjustmentHeritage> GetListCommissionAdjustmentHeritage(Int64 heritageID)
	{
		List<CommissionAdjustmentHeritage> listCommissionAdjustmentHeritage = new List<CommissionAdjustmentHeritage>() { };
		SqlParameter[] parametersHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};

		//Lets get the list of CommissionAdjustmentHeritage records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionAdjustmentHeritage_GetList_UseInHeritage", CommandType.StoredProcedure, parametersHeritage))
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
	public List<PropertyInOtherCountry> GetListPropertyInOtherCountry(Int64 heritageID)
	{
		List<PropertyInOtherCountry> listPropertyInOtherCountry = new List<PropertyInOtherCountry>() { };
		SqlParameter[] parametersHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};

		//Lets get the list of PropertyInOtherCountry records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PropertyInOtherCountry_GetList_UseInHeritage", CommandType.StoredProcedure, parametersHeritage))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of propertyInOtherCountry
				listPropertyInOtherCountry = new List<PropertyInOtherCountry>();

				//Now lets populate the PropertyInOtherCountry details into the list of propertyInOtherCountrys
				foreach (DataRow row in table.Rows)
				{
					PropertyInOtherCountry propertyInOtherCountry = ConvertRowToPropertyInOtherCountry(row);
					listPropertyInOtherCountry.Add(propertyInOtherCountry);
				}
			}
		}

		return listPropertyInOtherCountry;
	}

	private PropertyInOtherCountry ConvertRowToPropertyInOtherCountry(DataRow row)
	{
		PropertyInOtherCountry propertyInOtherCountry = new PropertyInOtherCountry();
		propertyInOtherCountry.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		propertyInOtherCountry.Name = row["Name"].ToString();
		propertyInOtherCountry.HostCountry = row["HostCountry"].ToString();
		propertyInOtherCountry.PayedTaxInHostCountry = (row["PayedTaxInHostCountry"] != DBNull.Value) ? Convert.ToSingle(row["PayedTaxInHostCountry"]) : 0 ;
		return propertyInOtherCountry;
	}
	public Int64 Insert(Heritage heritage)
	{
		SqlParameter[] parametersHeritage = new SqlParameter[]
		{
			new SqlParameter("@Sixth", (heritage.Sixth != null) ? heritage.Sixth : (object)DBNull.Value),
			new SqlParameter("@PreviousOwner", (heritage.PreviousOwner != null) ? heritage.PreviousOwner : (object)DBNull.Value),
			new SqlParameter("@Comment", (heritage.Comment != null) ? heritage.Comment : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (heritage.RegisterInformationID != null) ? heritage.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@AdjustmentID", (heritage.AdjustmentID != null) ? heritage.AdjustmentID : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentID", (heritage.CommissionAdjustmentID != null) ? heritage.CommissionAdjustmentID : (object)DBNull.Value),
			new SqlParameter("@Stage", heritage.Stage),
			new SqlParameter("@UserOrder", heritage.UserOrder),
			new SqlParameter("@Value1", (heritage.Value1 != null) ? heritage.Value1 : (object)DBNull.Value),
			new SqlParameter("@Value2", (heritage.Value2 != null) ? heritage.Value2 : (object)DBNull.Value),
			new SqlParameter("@Value3", (heritage.Value3 != null) ? heritage.Value3 : (object)DBNull.Value),
			new SqlParameter("@DeadIsOwner", heritage.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", (heritage.IsDiagonesed != null) ? heritage.IsDiagonesed : (object)DBNull.Value)
		};
		heritage.HeritageID = SqlDBHelper.ExecuteScalar("Heritage_Insert", CommandType.StoredProcedure, parametersHeritage);
		return heritage.HeritageID;
	}

	public bool Update(Heritage heritage)
	{
		SqlParameter[] parametersHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritage.HeritageID),
			new SqlParameter("@Sixth", (heritage.Sixth != null) ? heritage.Sixth : (object)DBNull.Value),
			new SqlParameter("@PreviousOwner", (heritage.PreviousOwner != null) ? heritage.PreviousOwner : (object)DBNull.Value),
			new SqlParameter("@Comment", (heritage.Comment != null) ? heritage.Comment : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (heritage.RegisterInformationID != null) ? heritage.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@AdjustmentID", (heritage.AdjustmentID != null) ? heritage.AdjustmentID : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentID", (heritage.CommissionAdjustmentID != null) ? heritage.CommissionAdjustmentID : (object)DBNull.Value),
			new SqlParameter("@Stage", heritage.Stage),
			new SqlParameter("@UserOrder", heritage.UserOrder),
			new SqlParameter("@Value1", (heritage.Value1 != null) ? heritage.Value1 : (object)DBNull.Value),
			new SqlParameter("@Value2", (heritage.Value2 != null) ? heritage.Value2 : (object)DBNull.Value),
			new SqlParameter("@Value3", (heritage.Value3 != null) ? heritage.Value3 : (object)DBNull.Value),
			new SqlParameter("@DeadIsOwner", heritage.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", (heritage.IsDiagonesed != null) ? heritage.IsDiagonesed : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Heritage_Update", CommandType.StoredProcedure, parametersHeritage);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("Heritage_Delete", CommandType.StoredProcedure, parametersHeritage);
	}

	public Heritage GetDetails(Int64 heritageID)
	{
		Heritage heritage = new Heritage();

		SqlParameter[] parametersHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Heritage_GetDetails", CommandType.StoredProcedure, parametersHeritage))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				heritage.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				heritage.StageTitle = row["StageTitle"].ToString();
				heritage.RegisterDate = row["RegisterDate"].ToString();
				heritage.OldRegisterDate = row["OldRegisterDate"].ToString();
				heritage.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
				heritage.Sixth = row["Sixth"].ToString();
				heritage.PreviousOwner = row["PreviousOwner"].ToString();
				heritage.Comment = row["Comment"].ToString();
				heritage.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
				heritage.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
				heritage.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
				heritage.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
				heritage.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
				heritage.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
				heritage.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
				heritage.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
				heritage.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
				heritage.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
			}
		}

		return heritage;
	}

	public List<Heritage> GetListAll()
	{
		List<Heritage> listHeritage = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Heritage_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listHeritage = new List<Heritage>();

				foreach (DataRow row in table.Rows)
				{
					Heritage heritage = new Heritage();
					heritage.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					heritage.StageTitle = row["StageTitle"].ToString();
					heritage.RegisterDate = row["RegisterDate"].ToString();
					heritage.OldRegisterDate = row["OldRegisterDate"].ToString();
					heritage.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					heritage.Sixth = row["Sixth"].ToString();
					heritage.PreviousOwner = row["PreviousOwner"].ToString();
					heritage.Comment = row["Comment"].ToString();
					heritage.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					heritage.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
					heritage.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
					heritage.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
					heritage.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
					heritage.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
					heritage.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
					heritage.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
				heritage.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
				heritage.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
					listHeritage.Add(heritage);
				}
			}
		}

		return listHeritage;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Heritage_Exists", CommandType.StoredProcedure, parametersHeritage)>0);
	}

	public bool Exists(Heritage heritage)
	{
		SqlParameter[] parametersHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritage.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Heritage_Exists", CommandType.StoredProcedure, parametersHeritage)>0);
	}

	public List<Heritage> SearchLike(Heritage heritage)
	{
		List<Heritage> listHeritage = new List<Heritage>();


		SqlParameter[] parametersHeritage = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritage.HeritageID),
			new SqlParameter("@StageTitle", heritage.StageTitle),
			new SqlParameter("@RegisterDate", heritage.RegisterDate),
			new SqlParameter("@OldRegisterDate", heritage.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", heritage.OldRegisterInformationID),
			new SqlParameter("@Sixth", heritage.Sixth),
			new SqlParameter("@PreviousOwner", heritage.PreviousOwner),
			new SqlParameter("@Comment", heritage.Comment),
			new SqlParameter("@RegisterInformationID", heritage.RegisterInformationID),
			new SqlParameter("@AdjustmentID", heritage.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", heritage.CommissionAdjustmentID),
			new SqlParameter("@Stage", heritage.Stage),
			new SqlParameter("@UserOrder", heritage.UserOrder),
			new SqlParameter("@Value1", heritage.Value1),
			new SqlParameter("@Value2", heritage.Value2),
			new SqlParameter("@Value3", heritage.Value3),
			new SqlParameter("@DeadIsOwner", heritage.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", heritage.IsDiagonesed),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Heritage_SearchLike", CommandType.StoredProcedure, parametersHeritage))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Heritage tmpHeritage = new Heritage();
					tmpHeritage.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpHeritage.StageTitle = row["StageTitle"].ToString();
					tmpHeritage.RegisterDate = row["RegisterDate"].ToString();
					tmpHeritage.OldRegisterDate = row["OldRegisterDate"].ToString();
					tmpHeritage.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					tmpHeritage.Sixth = row["Sixth"].ToString();
					tmpHeritage.PreviousOwner = row["PreviousOwner"].ToString();
					tmpHeritage.Comment = row["Comment"].ToString();
					tmpHeritage.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					tmpHeritage.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
					tmpHeritage.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
					tmpHeritage.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
					tmpHeritage.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
					tmpHeritage.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
					tmpHeritage.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
					tmpHeritage.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
					tmpHeritage.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpHeritage.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;

					listHeritage.Add(tmpHeritage);
				}
			}
		}

		return listHeritage;
	}

}
}
