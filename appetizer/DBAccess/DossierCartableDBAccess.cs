using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class DossierCartableDBAccess
{


	public Int64 Insert(DossierCartable dossierCartable)
	{
		SqlParameter[] parametersDossierCartable = new SqlParameter[]
		{
			new SqlParameter("@DossierID", (dossierCartable.DossierID > 0) ? dossierCartable.DossierID : (object)DBNull.Value),
			new SqlParameter("@FromTaxOffice", (dossierCartable.FromTaxOffice != null) ? dossierCartable.FromTaxOffice : (object)DBNull.Value),
			new SqlParameter("@ToTaxOffice", (dossierCartable.ToTaxOffice != null) ? dossierCartable.ToTaxOffice : (object)DBNull.Value),
			new SqlParameter("@OldTaxUnitCode", (dossierCartable.OldTaxUnitCode != null) ? dossierCartable.OldTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@OldOrderNumber", (dossierCartable.OldOrderNumber != null) ? dossierCartable.OldOrderNumber : (object)DBNull.Value),
			new SqlParameter("@SendDate", (dossierCartable.SendDate != null) ? dossierCartable.SendDate : (object)DBNull.Value),
			new SqlParameter("@ReciveDate", (dossierCartable.ReciveDate != null) ? dossierCartable.ReciveDate : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("DossierCartable_Insert", CommandType.StoredProcedure, parametersDossierCartable);
	}

	public bool Update(DossierCartable dossierCartable)
	{
		SqlParameter[] parametersDossierCartable = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierCartable.DossierID),
			new SqlParameter("@FromTaxOffice", (dossierCartable.FromTaxOffice != null) ? dossierCartable.FromTaxOffice : (object)DBNull.Value),
			new SqlParameter("@ToTaxOffice", (dossierCartable.ToTaxOffice != null) ? dossierCartable.ToTaxOffice : (object)DBNull.Value),
			new SqlParameter("@OldTaxUnitCode", (dossierCartable.OldTaxUnitCode != null) ? dossierCartable.OldTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@OldOrderNumber", (dossierCartable.OldOrderNumber != null) ? dossierCartable.OldOrderNumber : (object)DBNull.Value),
			new SqlParameter("@SendDate", (dossierCartable.SendDate != null) ? dossierCartable.SendDate : (object)DBNull.Value),
			new SqlParameter("@ReciveDate", (dossierCartable.ReciveDate != null) ? dossierCartable.ReciveDate : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("DossierCartable_Update", CommandType.StoredProcedure, parametersDossierCartable);
	}

	public bool Delete(Int64 dossierID)
	{
		SqlParameter[] parametersDossierCartable = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierID)
		};
		return SqlDBHelper.ExecuteNonQuery("DossierCartable_Delete", CommandType.StoredProcedure, parametersDossierCartable);
	}

	public bool Delete(int fromTaxOffice)
	{
		SqlParameter[] parametersDossierCartable = new SqlParameter[]
		{
			new SqlParameter("@FromTaxOffice", fromTaxOffice)
		};
		return SqlDBHelper.ExecuteNonQuery("DossierCartable_DeleteBy_FromTaxOffice", CommandType.StoredProcedure, parametersDossierCartable);

	}

	public DossierCartable GetDetails(Int64 dossierID)
	{
		DossierCartable dossierCartable = new DossierCartable();

		SqlParameter[] parametersDossierCartable = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DossierCartable_GetDetails", CommandType.StoredProcedure, parametersDossierCartable))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				dossierCartable.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
				dossierCartable.OldClasses = row["OldClasses"].ToString();
				dossierCartable.FromTaxOffice = (row["FromTaxOffice"] != DBNull.Value) ? Convert.ToInt32(row["FromTaxOffice"]) : 0 ;
				dossierCartable.ToTaxOffice = (row["ToTaxOffice"] != DBNull.Value) ? Convert.ToInt32(row["ToTaxOffice"]) : 0 ;
				dossierCartable.OldTaxUnitCode = (row["OldTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["OldTaxUnitCode"]) : 0 ;
				dossierCartable.OldOrderNumber = (row["OldOrderNumber"] != DBNull.Value) ? Convert.ToInt64(row["OldOrderNumber"]) : 0 ;
				dossierCartable.SendDate = row["SendDate"].ToString();
				dossierCartable.ReciveDate = row["ReciveDate"].ToString();
			}
		}

		return dossierCartable;
	}

	public DossierCartable GetDetails(int fromTaxOffice)
	{
		DossierCartable dossierCartable = new DossierCartable();

		SqlParameter[] parametersDossierCartable = new SqlParameter[]
		{
			new SqlParameter("@FromTaxOffice", fromTaxOffice)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DossierCartable_GetDetailsBy_FromTaxOffice", CommandType.StoredProcedure, parametersDossierCartable))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				dossierCartable.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
				dossierCartable.OldClasses = row["OldClasses"].ToString();
				dossierCartable.FromTaxOffice = (row["FromTaxOffice"] != DBNull.Value) ? Convert.ToInt32(row["FromTaxOffice"]) : 0 ;
				dossierCartable.ToTaxOffice = (row["ToTaxOffice"] != DBNull.Value) ? Convert.ToInt32(row["ToTaxOffice"]) : 0 ;
				dossierCartable.OldTaxUnitCode = (row["OldTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["OldTaxUnitCode"]) : 0 ;
				dossierCartable.OldOrderNumber = (row["OldOrderNumber"] != DBNull.Value) ? Convert.ToInt64(row["OldOrderNumber"]) : 0 ;
				dossierCartable.SendDate = row["SendDate"].ToString();
				dossierCartable.ReciveDate = row["ReciveDate"].ToString();
			}
		}

		return dossierCartable;
	}

	public List<DossierCartable> GetListAll()
	{
		List<DossierCartable> listDossierCartable = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("DossierCartable_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDossierCartable = new List<DossierCartable>();

				foreach (DataRow row in table.Rows)
				{
					DossierCartable dossierCartable = new DossierCartable();
					dossierCartable.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					dossierCartable.OldClasses = row["OldClasses"].ToString();
					dossierCartable.FromTaxOffice = (row["FromTaxOffice"] != DBNull.Value) ? Convert.ToInt32(row["FromTaxOffice"]) : 0 ;
					dossierCartable.ToTaxOffice = (row["ToTaxOffice"] != DBNull.Value) ? Convert.ToInt32(row["ToTaxOffice"]) : 0 ;
					dossierCartable.OldTaxUnitCode = (row["OldTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["OldTaxUnitCode"]) : 0 ;
					dossierCartable.OldOrderNumber = (row["OldOrderNumber"] != DBNull.Value) ? Convert.ToInt64(row["OldOrderNumber"]) : 0 ;
					dossierCartable.SendDate = row["SendDate"].ToString();
					dossierCartable.ReciveDate = row["ReciveDate"].ToString();
					listDossierCartable.Add(dossierCartable);
				}
			}
		}

		return listDossierCartable;
	}

	public bool Exists(Int64 dossierID)
	{
		SqlParameter[] parametersDossierCartable = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierID)
		};
		return (SqlDBHelper.ExecuteScalar("DossierCartable_Exists", CommandType.StoredProcedure, parametersDossierCartable)>0);
	}

	public bool Exists(DossierCartable dossierCartable)
	{
		SqlParameter[] parametersDossierCartable = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierCartable.DossierID)
		};
		return (SqlDBHelper.ExecuteScalar("DossierCartable_Exists", CommandType.StoredProcedure, parametersDossierCartable)>0);
	}

	public List<DossierCartable> GetListByDossierCartableFromTaxOffice(int fromTaxOffice)
	{
		List<DossierCartable> listDossierCartable = new List<DossierCartable>();

		//Lets get the list of all DossierCartable records from database using FromTaxOffice
		SqlParameter[] parametersDossierCartable = new SqlParameter[]
		{
			new SqlParameter("@fromTaxOffice", fromTaxOffice)
		};
		//Lets get the list of DossierCartable records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DossierCartable_GetListByFromTaxOffice", CommandType.StoredProcedure, parametersDossierCartable))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of dossierCartable
				listDossierCartable = new List<DossierCartable>();

				//Now lets populate the dossierCartable details into the list of dossierCartables
				foreach (DataRow row in table.Rows)
				{
					DossierCartable dossierCartable = new DossierCartable();
					dossierCartable.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					dossierCartable.OldClasses = row["OldClasses"].ToString();
					dossierCartable.FromTaxOffice = (row["FromTaxOffice"] != DBNull.Value) ? Convert.ToInt32(row["FromTaxOffice"]) : 0 ;
					dossierCartable.ToTaxOffice = (row["ToTaxOffice"] != DBNull.Value) ? Convert.ToInt32(row["ToTaxOffice"]) : 0 ;
					dossierCartable.OldTaxUnitCode = (row["OldTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["OldTaxUnitCode"]) : 0 ;
					dossierCartable.OldOrderNumber = (row["OldOrderNumber"] != DBNull.Value) ? Convert.ToInt64(row["OldOrderNumber"]) : 0 ;
					dossierCartable.SendDate = row["SendDate"].ToString();
					dossierCartable.ReciveDate = row["ReciveDate"].ToString();
					listDossierCartable.Add(dossierCartable);
				}
			}
		}

		return listDossierCartable;
	}

	public List<DossierCartable> GetListByDossierCartableToTaxOffice(int toTaxOffice)
	{
		List<DossierCartable> listDossierCartable = new List<DossierCartable>();

		//Lets get the list of all DossierCartable records from database using ToTaxOffice
		SqlParameter[] parametersDossierCartable = new SqlParameter[]
		{
			new SqlParameter("@toTaxOffice", toTaxOffice)
		};
		//Lets get the list of DossierCartable records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DossierCartable_GetListByToTaxOffice", CommandType.StoredProcedure, parametersDossierCartable))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of dossierCartable
				listDossierCartable = new List<DossierCartable>();

				//Now lets populate the dossierCartable details into the list of dossierCartables
				foreach (DataRow row in table.Rows)
				{
					DossierCartable dossierCartable = new DossierCartable();
					dossierCartable.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					dossierCartable.OldClasses = row["OldClasses"].ToString();
					dossierCartable.FromTaxOffice = (row["FromTaxOffice"] != DBNull.Value) ? Convert.ToInt32(row["FromTaxOffice"]) : 0 ;
					dossierCartable.ToTaxOffice = (row["ToTaxOffice"] != DBNull.Value) ? Convert.ToInt32(row["ToTaxOffice"]) : 0 ;
					dossierCartable.OldTaxUnitCode = (row["OldTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["OldTaxUnitCode"]) : 0 ;
					dossierCartable.OldOrderNumber = (row["OldOrderNumber"] != DBNull.Value) ? Convert.ToInt64(row["OldOrderNumber"]) : 0 ;
					dossierCartable.SendDate = row["SendDate"].ToString();
					dossierCartable.ReciveDate = row["ReciveDate"].ToString();
					listDossierCartable.Add(dossierCartable);
				}
			}
		}

		return listDossierCartable;
	}

	public List<DossierCartable> SearchLike(DossierCartable dossierCartable)
	{
		List<DossierCartable> listDossierCartable = new List<DossierCartable>();


		SqlParameter[] parametersDossierCartable = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierCartable.DossierID),
			new SqlParameter("@OldClasses", dossierCartable.OldClasses),
			new SqlParameter("@FromTaxOffice", dossierCartable.FromTaxOffice),
			new SqlParameter("@ToTaxOffice", dossierCartable.ToTaxOffice),
			new SqlParameter("@OldTaxUnitCode", dossierCartable.OldTaxUnitCode),
			new SqlParameter("@OldOrderNumber", dossierCartable.OldOrderNumber),
			new SqlParameter("@SendDate", dossierCartable.SendDate),
			new SqlParameter("@ReciveDate", dossierCartable.ReciveDate),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DossierCartable_SearchLike", CommandType.StoredProcedure, parametersDossierCartable))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					DossierCartable tmpDossierCartable = new DossierCartable();
					tmpDossierCartable.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					tmpDossierCartable.OldClasses = row["OldClasses"].ToString();
					tmpDossierCartable.FromTaxOffice = (row["FromTaxOffice"] != DBNull.Value) ? Convert.ToInt32(row["FromTaxOffice"]) : 0 ;
					tmpDossierCartable.ToTaxOffice = (row["ToTaxOffice"] != DBNull.Value) ? Convert.ToInt32(row["ToTaxOffice"]) : 0 ;
					tmpDossierCartable.OldTaxUnitCode = (row["OldTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["OldTaxUnitCode"]) : 0 ;
					tmpDossierCartable.OldOrderNumber = (row["OldOrderNumber"] != DBNull.Value) ? Convert.ToInt64(row["OldOrderNumber"]) : 0 ;
					tmpDossierCartable.SendDate = row["SendDate"].ToString();
					tmpDossierCartable.ReciveDate = row["ReciveDate"].ToString();

					listDossierCartable.Add(tmpDossierCartable);
				}
			}
		}

		return listDossierCartable;
	}

}
}
