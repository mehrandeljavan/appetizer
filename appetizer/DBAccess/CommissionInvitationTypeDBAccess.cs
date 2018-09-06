using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class CommissionInvitationTypeDBAccess
{

	CommissionInvitationDBAccess commissionInvitationDBAccess = new CommissionInvitationDBAccess();

	public List<CommissionInvitation> GetListCommissionInvitation(int invitationTypeID)
	{
		List<CommissionInvitation> listCommissionInvitation = new List<CommissionInvitation>() { };
		SqlParameter[] parametersCommissionInvitationType = new SqlParameter[]
		{
			new SqlParameter("@InvitationTypeID", invitationTypeID)
		};

		//Lets get the list of CommissionInvitation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionInvitation_GetList_UseInCommissionInvitationType", CommandType.StoredProcedure, parametersCommissionInvitationType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of commissionInvitation
				listCommissionInvitation = new List<CommissionInvitation>();

				//Now lets populate the CommissionInvitation details into the list of commissionInvitations
				foreach (DataRow row in table.Rows)
				{
					CommissionInvitation commissionInvitation = ConvertRowToCommissionInvitation(row);
					listCommissionInvitation.Add(commissionInvitation);
				}
			}
		}

		return listCommissionInvitation;
	}

	private CommissionInvitation ConvertRowToCommissionInvitation(DataRow row)
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
		return commissionInvitation;
	}
	public Int64 Insert(CommissionInvitationType commissionInvitationType)
	{
		SqlParameter[] parametersCommissionInvitationType = new SqlParameter[]
		{
			new SqlParameter("@Title", (commissionInvitationType.Title != null) ? commissionInvitationType.Title : (object)DBNull.Value)
		};
		commissionInvitationType.InvitationTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("CommissionInvitationType_Insert", CommandType.StoredProcedure, parametersCommissionInvitationType));
		return commissionInvitationType.InvitationTypeID;
	}

	public bool Update(CommissionInvitationType commissionInvitationType)
	{
		SqlParameter[] parametersCommissionInvitationType = new SqlParameter[]
		{
			new SqlParameter("@InvitationTypeID", commissionInvitationType.InvitationTypeID),
			new SqlParameter("@Title", (commissionInvitationType.Title != null) ? commissionInvitationType.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("CommissionInvitationType_Update", CommandType.StoredProcedure, parametersCommissionInvitationType);
	}

	public bool Delete(int invitationTypeID)
	{
		SqlParameter[] parametersCommissionInvitationType = new SqlParameter[]
		{
			new SqlParameter("@InvitationTypeID", invitationTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("CommissionInvitationType_Delete", CommandType.StoredProcedure, parametersCommissionInvitationType);
	}

	public CommissionInvitationType GetDetails(int invitationTypeID)
	{
		CommissionInvitationType commissionInvitationType = new CommissionInvitationType();

		SqlParameter[] parametersCommissionInvitationType = new SqlParameter[]
		{
			new SqlParameter("@InvitationTypeID", invitationTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionInvitationType_GetDetails", CommandType.StoredProcedure, parametersCommissionInvitationType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				commissionInvitationType.InvitationTypeID = (row["InvitationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["InvitationTypeID"]) : 0 ;
				commissionInvitationType.Title = row["Title"].ToString();
			}
		}

		return commissionInvitationType;
	}

	public List<CommissionInvitationType> GetListAll()
	{
		List<CommissionInvitationType> listCommissionInvitationType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("CommissionInvitationType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listCommissionInvitationType = new List<CommissionInvitationType>();

				foreach (DataRow row in table.Rows)
				{
					CommissionInvitationType commissionInvitationType = new CommissionInvitationType();
					commissionInvitationType.InvitationTypeID = (row["InvitationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["InvitationTypeID"]) : 0 ;
					commissionInvitationType.Title = row["Title"].ToString();
					listCommissionInvitationType.Add(commissionInvitationType);
				}
			}
		}

		return listCommissionInvitationType;
	}

	public bool Exists(int invitationTypeID)
	{
		SqlParameter[] parametersCommissionInvitationType = new SqlParameter[]
		{
			new SqlParameter("@InvitationTypeID", invitationTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("CommissionInvitationType_Exists", CommandType.StoredProcedure, parametersCommissionInvitationType)>0);
	}

	public bool Exists(CommissionInvitationType commissionInvitationType)
	{
		SqlParameter[] parametersCommissionInvitationType = new SqlParameter[]
		{
			new SqlParameter("@InvitationTypeID", commissionInvitationType.InvitationTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("CommissionInvitationType_Exists", CommandType.StoredProcedure, parametersCommissionInvitationType)>0);
	}

	public List<CommissionInvitationType> SearchLike(CommissionInvitationType commissionInvitationType)
	{
		List<CommissionInvitationType> listCommissionInvitationType = new List<CommissionInvitationType>();


		SqlParameter[] parametersCommissionInvitationType = new SqlParameter[]
		{
			new SqlParameter("@InvitationTypeID", commissionInvitationType.InvitationTypeID),
			new SqlParameter("@Title", commissionInvitationType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionInvitationType_SearchLike", CommandType.StoredProcedure, parametersCommissionInvitationType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					CommissionInvitationType tmpCommissionInvitationType = new CommissionInvitationType();
					tmpCommissionInvitationType.InvitationTypeID = (row["InvitationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["InvitationTypeID"]) : 0 ;
					tmpCommissionInvitationType.Title = row["Title"].ToString();

					listCommissionInvitationType.Add(tmpCommissionInvitationType);
				}
			}
		}

		return listCommissionInvitationType;
	}

}
}
