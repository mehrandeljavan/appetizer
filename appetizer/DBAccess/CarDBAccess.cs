using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class CarDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(Car car)
	{
		if (!heritageDBAccess.Exists(car))
			car.HeritageID = heritageDBAccess.Insert(car);

		SqlParameter[] parametersCar = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (car.HeritageID > 0) ? car.HeritageID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (car.DeclarationID > 0) ? car.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitID", (car.ProductionUnitID > 0) ? car.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@Title", car.Title),
			new SqlParameter("@PlaqueNumber", (car.PlaqueNumber != null) ? car.PlaqueNumber : (object)DBNull.Value),
			new SqlParameter("@Color", (car.Color != null) ? car.Color : (object)DBNull.Value),
			new SqlParameter("@MotorNumber", car.MotorNumber),
			new SqlParameter("@ChassisNumber", (car.ChassisNumber != null) ? car.ChassisNumber : (object)DBNull.Value),
			new SqlParameter("@ProductionYear", car.ProductionYear)
		};
		return SqlDBHelper.ExecuteScalar("Car_Insert", CommandType.StoredProcedure, parametersCar);
	}

	public bool Update(Car car)
	{
		heritageDBAccess.Update(car);

		SqlParameter[] parametersCar = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", car.HeritageID),
			new SqlParameter("@DeclarationID", car.DeclarationID),
			new SqlParameter("@ProductionUnitID", (car.ProductionUnitID != null && car.ProductionUnitID >0 ) ? car.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@Title", car.Title),
			new SqlParameter("@PlaqueNumber", (car.PlaqueNumber != null) ? car.PlaqueNumber : (object)DBNull.Value),
			new SqlParameter("@Color", (car.Color != null) ? car.Color : (object)DBNull.Value),
			new SqlParameter("@MotorNumber", car.MotorNumber),
			new SqlParameter("@ChassisNumber", (car.ChassisNumber != null) ? car.ChassisNumber : (object)DBNull.Value),
			new SqlParameter("@ProductionYear", car.ProductionYear)
		};
		return SqlDBHelper.ExecuteNonQuery("Car_Update", CommandType.StoredProcedure, parametersCar);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersCar = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("Car_Delete", CommandType.StoredProcedure, parametersCar);
	}

	public Car GetDetails(Int64 heritageID)
	{
		Car car = new Car();

		SqlParameter[] parametersCar = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Car_GetDetails", CommandType.StoredProcedure, parametersCar))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				car.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				car.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				car.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
				car.Title = row["Title"].ToString();
				car.PlaqueNumber = row["PlaqueNumber"].ToString();
				car.Color = row["Color"].ToString();
				car.MotorNumber = row["MotorNumber"].ToString();
				car.ChassisNumber = row["ChassisNumber"].ToString();
				car.ProductionYear = (row["ProductionYear"] != DBNull.Value) ? Convert.ToInt32(row["ProductionYear"]) : 0 ;

				Heritage heritage = heritageDBAccess.GetDetails(car.HeritageID);
				car.HeritageID = heritage.HeritageID;
				car.StageTitle = heritage.StageTitle;
				car.RegisterDate = heritage.RegisterDate;
				car.OldRegisterDate = heritage.OldRegisterDate;
				car.OldRegisterInformationID = heritage.OldRegisterInformationID;
				car.Sixth = heritage.Sixth;
				car.PreviousOwner = heritage.PreviousOwner;
				car.Comment = heritage.Comment;
				car.RegisterInformationID = heritage.RegisterInformationID;
				car.AdjustmentID = heritage.AdjustmentID;
				car.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				car.Stage = heritage.Stage;
				car.UserOrder = heritage.UserOrder;
				car.Value1 = heritage.Value1;
				car.Value2 = heritage.Value2;
				car.Value3 = heritage.Value3;
				car.DeadIsOwner = heritage.DeadIsOwner;
				car.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return car;
	}

	public List<Car> GetListAll()
	{
		List<Car> listCar = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Car_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listCar = new List<Car>();

				foreach (DataRow row in table.Rows)
				{
					Car car = new Car();
					car.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					car.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					car.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					car.Title = row["Title"].ToString();
					car.PlaqueNumber = row["PlaqueNumber"].ToString();
					car.Color = row["Color"].ToString();
					car.MotorNumber = row["MotorNumber"].ToString();
					car.ChassisNumber = row["ChassisNumber"].ToString();
					car.ProductionYear = (row["ProductionYear"] != DBNull.Value) ? Convert.ToInt32(row["ProductionYear"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(car.HeritageID);
					car.StageTitle = heritage.StageTitle;
					car.RegisterDate = heritage.RegisterDate;
					car.OldRegisterDate = heritage.OldRegisterDate;
					car.OldRegisterInformationID = heritage.OldRegisterInformationID;
					car.Sixth = heritage.Sixth;
					car.PreviousOwner = heritage.PreviousOwner;
					car.Comment = heritage.Comment;
					car.RegisterInformationID = heritage.RegisterInformationID;
					car.AdjustmentID = heritage.AdjustmentID;
					car.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					car.Stage = heritage.Stage;
					car.UserOrder = heritage.UserOrder;
					car.Value1 = heritage.Value1;
					car.Value2 = heritage.Value2;
					car.Value3 = heritage.Value3;
					car.DeadIsOwner = heritage.DeadIsOwner;
					car.IsDiagonesed = heritage.IsDiagonesed;
					listCar.Add(car);
				}
			}
		}

		return listCar;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersCar = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Car_Exists", CommandType.StoredProcedure, parametersCar)>0);
	}

	public bool Exists(Car car)
	{
		SqlParameter[] parametersCar = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", car.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Car_Exists", CommandType.StoredProcedure, parametersCar)>0);
	}

	public List<Car> SearchLike(Car car)
	{
		List<Car> listCar = new List<Car>();


		SqlParameter[] parametersCar = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", car.HeritageID),
			new SqlParameter("@DeclarationID", car.DeclarationID),
			new SqlParameter("@ProductionUnitID", car.ProductionUnitID),
			new SqlParameter("@Title", car.Title),
			new SqlParameter("@PlaqueNumber", car.PlaqueNumber),
			new SqlParameter("@Color", car.Color),
			new SqlParameter("@MotorNumber", car.MotorNumber),
			new SqlParameter("@ChassisNumber", car.ChassisNumber),
			new SqlParameter("@ProductionYear", car.ProductionYear),

			new SqlParameter("@StageTitle", car.StageTitle),
			new SqlParameter("@RegisterDate", car.RegisterDate),
			new SqlParameter("@OldRegisterDate", car.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", car.OldRegisterInformationID),
			new SqlParameter("@Sixth", car.Sixth),
			new SqlParameter("@PreviousOwner", car.PreviousOwner),
			new SqlParameter("@Comment", car.Comment),
			new SqlParameter("@RegisterInformationID", car.RegisterInformationID),
			new SqlParameter("@AdjustmentID", car.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", car.CommissionAdjustmentID),
			new SqlParameter("@Stage", car.Stage),
			new SqlParameter("@UserOrder", car.UserOrder),
			new SqlParameter("@Value1", car.Value1),
			new SqlParameter("@Value2", car.Value2),
			new SqlParameter("@Value3", car.Value3),
			new SqlParameter("@DeadIsOwner", car.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", car.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Car_SearchLike", CommandType.StoredProcedure, parametersCar))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Car tmpCar = new Car();
					tmpCar.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpCar.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpCar.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tmpCar.Title = row["Title"].ToString();
					tmpCar.PlaqueNumber = row["PlaqueNumber"].ToString();
					tmpCar.Color = row["Color"].ToString();
					tmpCar.MotorNumber = row["MotorNumber"].ToString();
					tmpCar.ChassisNumber = row["ChassisNumber"].ToString();
					tmpCar.ProductionYear = (row["ProductionYear"] != DBNull.Value) ? Convert.ToInt32(row["ProductionYear"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpCar.HeritageID);
					tmpCar.HeritageID = heritage.HeritageID;
					tmpCar.StageTitle = heritage.StageTitle;
					tmpCar.RegisterDate = heritage.RegisterDate;
					tmpCar.OldRegisterDate = heritage.OldRegisterDate;
					tmpCar.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpCar.Sixth = heritage.Sixth;
					tmpCar.PreviousOwner = heritage.PreviousOwner;
					tmpCar.Comment = heritage.Comment;
					tmpCar.RegisterInformationID = heritage.RegisterInformationID;
					tmpCar.AdjustmentID = heritage.AdjustmentID;
					tmpCar.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpCar.Stage = heritage.Stage;
					tmpCar.UserOrder = heritage.UserOrder;
					tmpCar.Value1 = heritage.Value1;
					tmpCar.Value2 = heritage.Value2;
					tmpCar.Value3 = heritage.Value3;
					tmpCar.DeadIsOwner = heritage.DeadIsOwner;
					tmpCar.IsDiagonesed = heritage.IsDiagonesed;

					listCar.Add(tmpCar);
				}
			}
		}

		return listCar;
	}

}
}
