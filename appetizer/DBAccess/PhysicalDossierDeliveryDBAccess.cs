using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class PhysicalDossierDeliveryDBAccess
{


	public Int64 Insert(PhysicalDossierDelivery physicalDossierDelivery)
	{
		SqlParameter[] parametersPhysicalDossierDelivery = new SqlParameter[]
		{
			new SqlParameter("@DeliveryTypeID", (physicalDossierDelivery.DeliveryTypeID > 0) ? physicalDossierDelivery.DeliveryTypeID : (object)DBNull.Value),
			new SqlParameter("@DossierID", (physicalDossierDelivery.DossierID > 0) ? physicalDossierDelivery.DossierID : (object)DBNull.Value),
			new SqlParameter("@FromUserNationalCode", physicalDossierDelivery.FromUserNationalCode),
			new SqlParameter("@ToUserNationalCode", (physicalDossierDelivery.ToUserNationalCode > 0) ? physicalDossierDelivery.ToUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@DeliveryDate", (physicalDossierDelivery.DeliveryDate != null) ? physicalDossierDelivery.DeliveryDate : (object)DBNull.Value),
			new SqlParameter("@DeliveryTime", (physicalDossierDelivery.DeliveryTime != null) ? physicalDossierDelivery.DeliveryTime : (object)DBNull.Value),
			new SqlParameter("@Description", (physicalDossierDelivery.Description != null) ? physicalDossierDelivery.Description : (object)DBNull.Value)
		};
		physicalDossierDelivery.PhysicalDossierDeliveryID = SqlDBHelper.ExecuteScalar("PhysicalDossierDelivery_Insert", CommandType.StoredProcedure, parametersPhysicalDossierDelivery);
		return physicalDossierDelivery.PhysicalDossierDeliveryID;
	}

	public bool Update(PhysicalDossierDelivery physicalDossierDelivery)
	{
		SqlParameter[] parametersPhysicalDossierDelivery = new SqlParameter[]
		{
			new SqlParameter("@PhysicalDossierDeliveryID", physicalDossierDelivery.PhysicalDossierDeliveryID),
			new SqlParameter("@DeliveryTypeID", (physicalDossierDelivery.DeliveryTypeID != null && physicalDossierDelivery.DeliveryTypeID >0 ) ? physicalDossierDelivery.DeliveryTypeID : (object)DBNull.Value),
			new SqlParameter("@DossierID", physicalDossierDelivery.DossierID),
			new SqlParameter("@FromUserNationalCode", physicalDossierDelivery.FromUserNationalCode),
			new SqlParameter("@ToUserNationalCode", physicalDossierDelivery.ToUserNationalCode),
			new SqlParameter("@DeliveryDate", (physicalDossierDelivery.DeliveryDate != null) ? physicalDossierDelivery.DeliveryDate : (object)DBNull.Value),
			new SqlParameter("@DeliveryTime", (physicalDossierDelivery.DeliveryTime != null) ? physicalDossierDelivery.DeliveryTime : (object)DBNull.Value),
			new SqlParameter("@Description", (physicalDossierDelivery.Description != null) ? physicalDossierDelivery.Description : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("PhysicalDossierDelivery_Update", CommandType.StoredProcedure, parametersPhysicalDossierDelivery);
	}

	public bool Delete(Int64 physicalDossierDeliveryID)
	{
		SqlParameter[] parametersPhysicalDossierDelivery = new SqlParameter[]
		{
			new SqlParameter("@PhysicalDossierDeliveryID", physicalDossierDeliveryID)
		};
		return SqlDBHelper.ExecuteNonQuery("PhysicalDossierDelivery_Delete", CommandType.StoredProcedure, parametersPhysicalDossierDelivery);
	}

	public PhysicalDossierDelivery GetDetails(Int64 physicalDossierDeliveryID)
	{
		PhysicalDossierDelivery physicalDossierDelivery = new PhysicalDossierDelivery();

		SqlParameter[] parametersPhysicalDossierDelivery = new SqlParameter[]
		{
			new SqlParameter("@PhysicalDossierDeliveryID", physicalDossierDeliveryID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PhysicalDossierDelivery_GetDetails", CommandType.StoredProcedure, parametersPhysicalDossierDelivery))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				physicalDossierDelivery.PhysicalDossierDeliveryID = (row["PhysicalDossierDeliveryID"] != DBNull.Value) ? Convert.ToInt64(row["PhysicalDossierDeliveryID"]) : 0 ;
				physicalDossierDelivery.FromUserFullName = row["FromUserFullName"].ToString();
				physicalDossierDelivery.ToUserFullName = row["ToUserFullName"].ToString();
				physicalDossierDelivery.DeliveryTypeIDTitle = row["DeliveryTypeIDTitle"].ToString();
				physicalDossierDelivery.DeliveryTypeID = (row["DeliveryTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeliveryTypeID"]) : 0 ;
				physicalDossierDelivery.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
				physicalDossierDelivery.FromUserNationalCode = (row["FromUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FromUserNationalCode"]) : 0 ;
				physicalDossierDelivery.ToUserNationalCode = (row["ToUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["ToUserNationalCode"]) : 0 ;
				physicalDossierDelivery.DeliveryDate = row["DeliveryDate"].ToString();
				physicalDossierDelivery.DeliveryTime = row["DeliveryTime"].ToString();
				physicalDossierDelivery.Description = row["Description"].ToString();
			}
		}

		return physicalDossierDelivery;
	}

	public List<PhysicalDossierDelivery> GetListAll()
	{
		List<PhysicalDossierDelivery> listPhysicalDossierDelivery = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("PhysicalDossierDelivery_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listPhysicalDossierDelivery = new List<PhysicalDossierDelivery>();

				foreach (DataRow row in table.Rows)
				{
					PhysicalDossierDelivery physicalDossierDelivery = new PhysicalDossierDelivery();
					physicalDossierDelivery.PhysicalDossierDeliveryID = (row["PhysicalDossierDeliveryID"] != DBNull.Value) ? Convert.ToInt64(row["PhysicalDossierDeliveryID"]) : 0 ;
					physicalDossierDelivery.FromUserFullName = row["FromUserFullName"].ToString();
					physicalDossierDelivery.ToUserFullName = row["ToUserFullName"].ToString();
					physicalDossierDelivery.DeliveryTypeIDTitle = row["DeliveryTypeIDTitle"].ToString();
					physicalDossierDelivery.DeliveryTypeID = (row["DeliveryTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeliveryTypeID"]) : 0 ;
					physicalDossierDelivery.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					physicalDossierDelivery.FromUserNationalCode = (row["FromUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FromUserNationalCode"]) : 0 ;
					physicalDossierDelivery.ToUserNationalCode = (row["ToUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["ToUserNationalCode"]) : 0 ;
					physicalDossierDelivery.DeliveryDate = row["DeliveryDate"].ToString();
					physicalDossierDelivery.DeliveryTime = row["DeliveryTime"].ToString();
					physicalDossierDelivery.Description = row["Description"].ToString();
					listPhysicalDossierDelivery.Add(physicalDossierDelivery);
				}
			}
		}

		return listPhysicalDossierDelivery;
	}

	public bool Exists(Int64 physicalDossierDeliveryID)
	{
		SqlParameter[] parametersPhysicalDossierDelivery = new SqlParameter[]
		{
			new SqlParameter("@PhysicalDossierDeliveryID", physicalDossierDeliveryID)
		};
		return (SqlDBHelper.ExecuteScalar("PhysicalDossierDelivery_Exists", CommandType.StoredProcedure, parametersPhysicalDossierDelivery)>0);
	}

	public bool Exists(PhysicalDossierDelivery physicalDossierDelivery)
	{
		SqlParameter[] parametersPhysicalDossierDelivery = new SqlParameter[]
		{
			new SqlParameter("@PhysicalDossierDeliveryID", physicalDossierDelivery.PhysicalDossierDeliveryID)
		};
		return (SqlDBHelper.ExecuteScalar("PhysicalDossierDelivery_Exists", CommandType.StoredProcedure, parametersPhysicalDossierDelivery)>0);
	}

	public List<PhysicalDossierDelivery> SearchLike(PhysicalDossierDelivery physicalDossierDelivery)
	{
		List<PhysicalDossierDelivery> listPhysicalDossierDelivery = new List<PhysicalDossierDelivery>();


		SqlParameter[] parametersPhysicalDossierDelivery = new SqlParameter[]
		{
			new SqlParameter("@PhysicalDossierDeliveryID", physicalDossierDelivery.PhysicalDossierDeliveryID),
			new SqlParameter("@FromUserFullName", physicalDossierDelivery.FromUserFullName),
			new SqlParameter("@ToUserFullName", physicalDossierDelivery.ToUserFullName),
			new SqlParameter("@DeliveryTypeIDTitle", physicalDossierDelivery.DeliveryTypeIDTitle),
			new SqlParameter("@DeliveryTypeID", physicalDossierDelivery.DeliveryTypeID),
			new SqlParameter("@DossierID", physicalDossierDelivery.DossierID),
			new SqlParameter("@FromUserNationalCode", physicalDossierDelivery.FromUserNationalCode),
			new SqlParameter("@ToUserNationalCode", physicalDossierDelivery.ToUserNationalCode),
			new SqlParameter("@DeliveryDate", physicalDossierDelivery.DeliveryDate),
			new SqlParameter("@DeliveryTime", physicalDossierDelivery.DeliveryTime),
			new SqlParameter("@Description", physicalDossierDelivery.Description),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PhysicalDossierDelivery_SearchLike", CommandType.StoredProcedure, parametersPhysicalDossierDelivery))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					PhysicalDossierDelivery tmpPhysicalDossierDelivery = new PhysicalDossierDelivery();
					tmpPhysicalDossierDelivery.PhysicalDossierDeliveryID = (row["PhysicalDossierDeliveryID"] != DBNull.Value) ? Convert.ToInt64(row["PhysicalDossierDeliveryID"]) : 0 ;
					tmpPhysicalDossierDelivery.FromUserFullName = row["FromUserFullName"].ToString();
					tmpPhysicalDossierDelivery.ToUserFullName = row["ToUserFullName"].ToString();
					tmpPhysicalDossierDelivery.DeliveryTypeIDTitle = row["DeliveryTypeIDTitle"].ToString();
					tmpPhysicalDossierDelivery.DeliveryTypeID = (row["DeliveryTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeliveryTypeID"]) : 0 ;
					tmpPhysicalDossierDelivery.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					tmpPhysicalDossierDelivery.FromUserNationalCode = (row["FromUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FromUserNationalCode"]) : 0 ;
					tmpPhysicalDossierDelivery.ToUserNationalCode = (row["ToUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["ToUserNationalCode"]) : 0 ;
					tmpPhysicalDossierDelivery.DeliveryDate = row["DeliveryDate"].ToString();
					tmpPhysicalDossierDelivery.DeliveryTime = row["DeliveryTime"].ToString();
					tmpPhysicalDossierDelivery.Description = row["Description"].ToString();

					listPhysicalDossierDelivery.Add(tmpPhysicalDossierDelivery);
				}
			}
		}

		return listPhysicalDossierDelivery;
	}

}
}
