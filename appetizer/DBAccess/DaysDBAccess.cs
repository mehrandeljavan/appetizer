using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class DaysDBAccess
{

	CommissionInvitationDBAccess commissionInvitationDBAccess = new CommissionInvitationDBAccess();

	public List<CommissionInvitation> GetListCommissionInvitation(int dayID)
	{
		List<CommissionInvitation> listCommissionInvitation = new List<CommissionInvitation>() { };
		SqlParameter[] parametersDays = new SqlParameter[]
		{
			new SqlParameter("@CommissionDayID", dayID)
		};

		//Lets get the list of CommissionInvitation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionInvitation_GetList_UseInDays", CommandType.StoredProcedure, parametersDays))
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
	public Int64 Insert(Days days)
	{
		SqlParameter[] parametersDays = new SqlParameter[]
		{
			new SqlParameter("@Title", days.Title)
		};
		days.DayID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("Days_Insert", CommandType.StoredProcedure, parametersDays));
		return days.DayID;
	}

	public bool Update(Days days)
	{
		SqlParameter[] parametersDays = new SqlParameter[]
		{
			new SqlParameter("@DayID", days.DayID),
			new SqlParameter("@Title", days.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("Days_Update", CommandType.StoredProcedure, parametersDays);
	}

	public bool Delete(int dayID)
	{
		SqlParameter[] parametersDays = new SqlParameter[]
		{
			new SqlParameter("@DayID", dayID)
		};
		return SqlDBHelper.ExecuteNonQuery("Days_Delete", CommandType.StoredProcedure, parametersDays);
	}

	public Days GetDetails(int dayID)
	{
		Days days = new Days();

		SqlParameter[] parametersDays = new SqlParameter[]
		{
			new SqlParameter("@DayID", dayID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Days_GetDetails", CommandType.StoredProcedure, parametersDays))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				days.DayID = (row["DayID"] != DBNull.Value) ? Convert.ToInt32(row["DayID"]) : 0 ;
				days.Title = row["Title"].ToString();
			}
		}

		return days;
	}

	public List<Days> GetListAll()
	{
		List<Days> listDays = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Days_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDays = new List<Days>();

				foreach (DataRow row in table.Rows)
				{
					Days days = new Days();
					days.DayID = (row["DayID"] != DBNull.Value) ? Convert.ToInt32(row["DayID"]) : 0 ;
					days.Title = row["Title"].ToString();
					listDays.Add(days);
				}
			}
		}

		return listDays;
	}

	public bool Exists(int dayID)
	{
		SqlParameter[] parametersDays = new SqlParameter[]
		{
			new SqlParameter("@DayID", dayID)
		};
		return (SqlDBHelper.ExecuteScalar("Days_Exists", CommandType.StoredProcedure, parametersDays)>0);
	}

	public bool Exists(Days days)
	{
		SqlParameter[] parametersDays = new SqlParameter[]
		{
			new SqlParameter("@DayID", days.DayID)
		};
		return (SqlDBHelper.ExecuteScalar("Days_Exists", CommandType.StoredProcedure, parametersDays)>0);
	}

	public List<Days> SearchLike(Days days)
	{
		List<Days> listDays = new List<Days>();


		SqlParameter[] parametersDays = new SqlParameter[]
		{
			new SqlParameter("@DayID", days.DayID),
			new SqlParameter("@Title", days.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Days_SearchLike", CommandType.StoredProcedure, parametersDays))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Days tmpDays = new Days();
					tmpDays.DayID = (row["DayID"] != DBNull.Value) ? Convert.ToInt32(row["DayID"]) : 0 ;
					tmpDays.Title = row["Title"].ToString();

					listDays.Add(tmpDays);
				}
			}
		}

		return listDays;
	}

}
}
