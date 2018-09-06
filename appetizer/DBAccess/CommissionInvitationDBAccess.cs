using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class CommissionInvitationDBAccess
{


	public Int64 Insert(CommissionInvitation commissionInvitation)
	{
		SqlParameter[] parametersCommissionInvitation = new SqlParameter[]
		{
			new SqlParameter("@InvitationTypeID", (commissionInvitation.InvitationTypeID > 0) ? commissionInvitation.InvitationTypeID : (object)DBNull.Value),
			new SqlParameter("@CommissionTypeID", (commissionInvitation.CommissionTypeID > 0) ? commissionInvitation.CommissionTypeID : (object)DBNull.Value),
			new SqlParameter("@CommissionDayID", (commissionInvitation.CommissionDayID > 0) ? commissionInvitation.CommissionDayID : (object)DBNull.Value),
			new SqlParameter("@HeirID", (commissionInvitation.HeirID > 0) ? commissionInvitation.HeirID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (commissionInvitation.DeclarationID > 0) ? commissionInvitation.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@CommissionHour", (commissionInvitation.CommissionHour != null) ? commissionInvitation.CommissionHour : (object)DBNull.Value),
			new SqlParameter("@CommssionDate", (commissionInvitation.CommssionDate != null) ? commissionInvitation.CommssionDate : (object)DBNull.Value),
			new SqlParameter("@CommissionAddress", (commissionInvitation.CommissionAddress != null) ? commissionInvitation.CommissionAddress : (object)DBNull.Value)
		};
		commissionInvitation.CommissionInvitationID = SqlDBHelper.ExecuteScalar("CommissionInvitation_Insert", CommandType.StoredProcedure, parametersCommissionInvitation);
		return commissionInvitation.CommissionInvitationID;
	}

	public bool Update(CommissionInvitation commissionInvitation)
	{
		SqlParameter[] parametersCommissionInvitation = new SqlParameter[]
		{
			new SqlParameter("@CommissionInvitationID", commissionInvitation.CommissionInvitationID),
			new SqlParameter("@InvitationTypeID", (commissionInvitation.InvitationTypeID != null && commissionInvitation.InvitationTypeID >0 ) ? commissionInvitation.InvitationTypeID : (object)DBNull.Value),
			new SqlParameter("@CommissionTypeID", (commissionInvitation.CommissionTypeID != null && commissionInvitation.CommissionTypeID >0 ) ? commissionInvitation.CommissionTypeID : (object)DBNull.Value),
			new SqlParameter("@CommissionDayID", (commissionInvitation.CommissionDayID != null && commissionInvitation.CommissionDayID >0 ) ? commissionInvitation.CommissionDayID : (object)DBNull.Value),
			new SqlParameter("@HeirID", commissionInvitation.HeirID),
			new SqlParameter("@DeclarationID", commissionInvitation.DeclarationID),
			new SqlParameter("@CommissionHour", (commissionInvitation.CommissionHour != null) ? commissionInvitation.CommissionHour : (object)DBNull.Value),
			new SqlParameter("@CommssionDate", (commissionInvitation.CommssionDate != null) ? commissionInvitation.CommssionDate : (object)DBNull.Value),
			new SqlParameter("@CommissionAddress", (commissionInvitation.CommissionAddress != null) ? commissionInvitation.CommissionAddress : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("CommissionInvitation_Update", CommandType.StoredProcedure, parametersCommissionInvitation);
	}

	public bool Delete(Int64 commissionInvitationID)
	{
		SqlParameter[] parametersCommissionInvitation = new SqlParameter[]
		{
			new SqlParameter("@CommissionInvitationID", commissionInvitationID)
		};
		return SqlDBHelper.ExecuteNonQuery("CommissionInvitation_Delete", CommandType.StoredProcedure, parametersCommissionInvitation);
	}

	public CommissionInvitation GetDetails(Int64 commissionInvitationID)
	{
		CommissionInvitation commissionInvitation = new CommissionInvitation();

		SqlParameter[] parametersCommissionInvitation = new SqlParameter[]
		{
			new SqlParameter("@CommissionInvitationID", commissionInvitationID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionInvitation_GetDetails", CommandType.StoredProcedure, parametersCommissionInvitation))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				commissionInvitation.CommissionInvitationID = (row["CommissionInvitationID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionInvitationID"]) : 0 ;
				commissionInvitation.InvitationTypeIDTitle = row["InvitationTypeIDTitle"].ToString();
				commissionInvitation.CommissionTypeIDTitle = row["CommissionTypeIDTitle"].ToString();
				commissionInvitation.CommissionDayIDTitle = row["CommissionDayIDTitle"].ToString();
				commissionInvitation.InvitationTypeID = (row["InvitationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["InvitationTypeID"]) : 0 ;
				commissionInvitation.CommissionTypeID = (row["CommissionTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionTypeID"]) : 0 ;
				commissionInvitation.CommissionDayID = (row["CommissionDayID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionDayID"]) : 0 ;
				commissionInvitation.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
				commissionInvitation.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				commissionInvitation.CommissionHour = row["CommissionHour"].ToString();
				commissionInvitation.CommssionDate = row["CommssionDate"].ToString();
				commissionInvitation.CommissionAddress = row["CommissionAddress"].ToString();
			}
		}

		return commissionInvitation;
	}

	public List<CommissionInvitation> GetListAll()
	{
		List<CommissionInvitation> listCommissionInvitation = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("CommissionInvitation_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listCommissionInvitation = new List<CommissionInvitation>();

				foreach (DataRow row in table.Rows)
				{
					CommissionInvitation commissionInvitation = new CommissionInvitation();
					commissionInvitation.CommissionInvitationID = (row["CommissionInvitationID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionInvitationID"]) : 0 ;
					commissionInvitation.InvitationTypeIDTitle = row["InvitationTypeIDTitle"].ToString();
					commissionInvitation.CommissionTypeIDTitle = row["CommissionTypeIDTitle"].ToString();
					commissionInvitation.CommissionDayIDTitle = row["CommissionDayIDTitle"].ToString();
					commissionInvitation.InvitationTypeID = (row["InvitationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["InvitationTypeID"]) : 0 ;
					commissionInvitation.CommissionTypeID = (row["CommissionTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionTypeID"]) : 0 ;
					commissionInvitation.CommissionDayID = (row["CommissionDayID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionDayID"]) : 0 ;
					commissionInvitation.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
					commissionInvitation.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					commissionInvitation.CommissionHour = row["CommissionHour"].ToString();
					commissionInvitation.CommssionDate = row["CommssionDate"].ToString();
					commissionInvitation.CommissionAddress = row["CommissionAddress"].ToString();
					listCommissionInvitation.Add(commissionInvitation);
				}
			}
		}

		return listCommissionInvitation;
	}

	public bool Exists(Int64 commissionInvitationID)
	{
		SqlParameter[] parametersCommissionInvitation = new SqlParameter[]
		{
			new SqlParameter("@CommissionInvitationID", commissionInvitationID)
		};
		return (SqlDBHelper.ExecuteScalar("CommissionInvitation_Exists", CommandType.StoredProcedure, parametersCommissionInvitation)>0);
	}

	public bool Exists(CommissionInvitation commissionInvitation)
	{
		SqlParameter[] parametersCommissionInvitation = new SqlParameter[]
		{
			new SqlParameter("@CommissionInvitationID", commissionInvitation.CommissionInvitationID)
		};
		return (SqlDBHelper.ExecuteScalar("CommissionInvitation_Exists", CommandType.StoredProcedure, parametersCommissionInvitation)>0);
	}

	public List<CommissionInvitation> SearchLike(CommissionInvitation commissionInvitation)
	{
		List<CommissionInvitation> listCommissionInvitation = new List<CommissionInvitation>();


		SqlParameter[] parametersCommissionInvitation = new SqlParameter[]
		{
			new SqlParameter("@CommissionInvitationID", commissionInvitation.CommissionInvitationID),
			new SqlParameter("@InvitationTypeIDTitle", commissionInvitation.InvitationTypeIDTitle),
			new SqlParameter("@CommissionTypeIDTitle", commissionInvitation.CommissionTypeIDTitle),
			new SqlParameter("@CommissionDayIDTitle", commissionInvitation.CommissionDayIDTitle),
			new SqlParameter("@InvitationTypeID", commissionInvitation.InvitationTypeID),
			new SqlParameter("@CommissionTypeID", commissionInvitation.CommissionTypeID),
			new SqlParameter("@CommissionDayID", commissionInvitation.CommissionDayID),
			new SqlParameter("@HeirID", commissionInvitation.HeirID),
			new SqlParameter("@DeclarationID", commissionInvitation.DeclarationID),
			new SqlParameter("@CommissionHour", commissionInvitation.CommissionHour),
			new SqlParameter("@CommssionDate", commissionInvitation.CommssionDate),
			new SqlParameter("@CommissionAddress", commissionInvitation.CommissionAddress),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionInvitation_SearchLike", CommandType.StoredProcedure, parametersCommissionInvitation))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					CommissionInvitation tmpCommissionInvitation = new CommissionInvitation();
					tmpCommissionInvitation.CommissionInvitationID = (row["CommissionInvitationID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionInvitationID"]) : 0 ;
					tmpCommissionInvitation.InvitationTypeIDTitle = row["InvitationTypeIDTitle"].ToString();
					tmpCommissionInvitation.CommissionTypeIDTitle = row["CommissionTypeIDTitle"].ToString();
					tmpCommissionInvitation.CommissionDayIDTitle = row["CommissionDayIDTitle"].ToString();
					tmpCommissionInvitation.InvitationTypeID = (row["InvitationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["InvitationTypeID"]) : 0 ;
					tmpCommissionInvitation.CommissionTypeID = (row["CommissionTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionTypeID"]) : 0 ;
					tmpCommissionInvitation.CommissionDayID = (row["CommissionDayID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionDayID"]) : 0 ;
					tmpCommissionInvitation.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
					tmpCommissionInvitation.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpCommissionInvitation.CommissionHour = row["CommissionHour"].ToString();
					tmpCommissionInvitation.CommssionDate = row["CommssionDate"].ToString();
					tmpCommissionInvitation.CommissionAddress = row["CommissionAddress"].ToString();

					listCommissionInvitation.Add(tmpCommissionInvitation);
				}
			}
		}

		return listCommissionInvitation;
	}

}
}
