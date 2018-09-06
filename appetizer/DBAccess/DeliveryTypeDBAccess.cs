using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class DeliveryTypeDBAccess
{

	PhysicalDossierDeliveryDBAccess physicalDossierDeliveryDBAccess = new PhysicalDossierDeliveryDBAccess();

	public List<PhysicalDossierDelivery> GetListPhysicalDossierDelivery(int deliveryTypeID)
	{
		List<PhysicalDossierDelivery> listPhysicalDossierDelivery = new List<PhysicalDossierDelivery>() { };
		SqlParameter[] parametersDeliveryType = new SqlParameter[]
		{
			new SqlParameter("@DeliveryTypeID", deliveryTypeID)
		};

		//Lets get the list of PhysicalDossierDelivery records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PhysicalDossierDelivery_GetList_UseInDeliveryType", CommandType.StoredProcedure, parametersDeliveryType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of physicalDossierDelivery
				listPhysicalDossierDelivery = new List<PhysicalDossierDelivery>();

				//Now lets populate the PhysicalDossierDelivery details into the list of physicalDossierDeliverys
				foreach (DataRow row in table.Rows)
				{
					PhysicalDossierDelivery physicalDossierDelivery = ConvertRowToPhysicalDossierDelivery(row);
					listPhysicalDossierDelivery.Add(physicalDossierDelivery);
				}
			}
		}

		return listPhysicalDossierDelivery;
	}

	private PhysicalDossierDelivery ConvertRowToPhysicalDossierDelivery(DataRow row)
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
		return physicalDossierDelivery;
	}
	public Int64 Insert(DeliveryType deliveryType)
	{
		SqlParameter[] parametersDeliveryType = new SqlParameter[]
		{
			new SqlParameter("@Title", deliveryType.Title)
		};
		deliveryType.DeliveryTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("DeliveryType_Insert", CommandType.StoredProcedure, parametersDeliveryType));
		return deliveryType.DeliveryTypeID;
	}

	public bool Update(DeliveryType deliveryType)
	{
		SqlParameter[] parametersDeliveryType = new SqlParameter[]
		{
			new SqlParameter("@DeliveryTypeID", deliveryType.DeliveryTypeID),
			new SqlParameter("@Title", deliveryType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("DeliveryType_Update", CommandType.StoredProcedure, parametersDeliveryType);
	}

	public bool Delete(int deliveryTypeID)
	{
		SqlParameter[] parametersDeliveryType = new SqlParameter[]
		{
			new SqlParameter("@DeliveryTypeID", deliveryTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("DeliveryType_Delete", CommandType.StoredProcedure, parametersDeliveryType);
	}

	public DeliveryType GetDetails(int deliveryTypeID)
	{
		DeliveryType deliveryType = new DeliveryType();

		SqlParameter[] parametersDeliveryType = new SqlParameter[]
		{
			new SqlParameter("@DeliveryTypeID", deliveryTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DeliveryType_GetDetails", CommandType.StoredProcedure, parametersDeliveryType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				deliveryType.DeliveryTypeID = (row["DeliveryTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeliveryTypeID"]) : 0 ;
				deliveryType.Title = row["Title"].ToString();
			}
		}

		return deliveryType;
	}

	public List<DeliveryType> GetListAll()
	{
		List<DeliveryType> listDeliveryType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("DeliveryType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDeliveryType = new List<DeliveryType>();

				foreach (DataRow row in table.Rows)
				{
					DeliveryType deliveryType = new DeliveryType();
					deliveryType.DeliveryTypeID = (row["DeliveryTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeliveryTypeID"]) : 0 ;
					deliveryType.Title = row["Title"].ToString();
					listDeliveryType.Add(deliveryType);
				}
			}
		}

		return listDeliveryType;
	}

	public bool Exists(int deliveryTypeID)
	{
		SqlParameter[] parametersDeliveryType = new SqlParameter[]
		{
			new SqlParameter("@DeliveryTypeID", deliveryTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("DeliveryType_Exists", CommandType.StoredProcedure, parametersDeliveryType)>0);
	}

	public bool Exists(DeliveryType deliveryType)
	{
		SqlParameter[] parametersDeliveryType = new SqlParameter[]
		{
			new SqlParameter("@DeliveryTypeID", deliveryType.DeliveryTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("DeliveryType_Exists", CommandType.StoredProcedure, parametersDeliveryType)>0);
	}

	public List<DeliveryType> SearchLike(DeliveryType deliveryType)
	{
		List<DeliveryType> listDeliveryType = new List<DeliveryType>();


		SqlParameter[] parametersDeliveryType = new SqlParameter[]
		{
			new SqlParameter("@DeliveryTypeID", deliveryType.DeliveryTypeID),
			new SqlParameter("@Title", deliveryType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DeliveryType_SearchLike", CommandType.StoredProcedure, parametersDeliveryType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					DeliveryType tmpDeliveryType = new DeliveryType();
					tmpDeliveryType.DeliveryTypeID = (row["DeliveryTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeliveryTypeID"]) : 0 ;
					tmpDeliveryType.Title = row["Title"].ToString();

					listDeliveryType.Add(tmpDeliveryType);
				}
			}
		}

		return listDeliveryType;
	}

}
}
