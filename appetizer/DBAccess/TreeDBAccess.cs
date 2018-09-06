using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class TreeDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(Tree tree)
	{
		if (!heritageDBAccess.Exists(tree))
			tree.HeritageID = heritageDBAccess.Insert(tree);

		SqlParameter[] parametersTree = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (tree.HeritageID > 0) ? tree.HeritageID : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitID", (tree.ProductionUnitID > 0) ? tree.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@TreeType", tree.TreeType),
			new SqlParameter("@RegisterPlaque", tree.RegisterPlaque),
			new SqlParameter("@DocNumber", (tree.DocNumber != null) ? tree.DocNumber : (object)DBNull.Value),
			new SqlParameter("@Section", (tree.Section != null) ? tree.Section : (object)DBNull.Value),
			new SqlParameter("@TreeNumber", tree.TreeNumber),
			new SqlParameter("@DeclarationID", (tree.DeclarationID > 0) ? tree.DeclarationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Tree_Insert", CommandType.StoredProcedure, parametersTree);
	}

	public bool Update(Tree tree)
	{
		heritageDBAccess.Update(tree);

		SqlParameter[] parametersTree = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", tree.HeritageID),
			new SqlParameter("@ProductionUnitID", (tree.ProductionUnitID != null && tree.ProductionUnitID >0 ) ? tree.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@TreeType", tree.TreeType),
			new SqlParameter("@RegisterPlaque", tree.RegisterPlaque),
			new SqlParameter("@DocNumber", (tree.DocNumber != null) ? tree.DocNumber : (object)DBNull.Value),
			new SqlParameter("@Section", (tree.Section != null) ? tree.Section : (object)DBNull.Value),
			new SqlParameter("@TreeNumber", tree.TreeNumber),
			new SqlParameter("@DeclarationID", tree.DeclarationID)
		};
		return SqlDBHelper.ExecuteNonQuery("Tree_Update", CommandType.StoredProcedure, parametersTree);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersTree = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("Tree_Delete", CommandType.StoredProcedure, parametersTree);
	}

	public Tree GetDetails(Int64 heritageID)
	{
		Tree tree = new Tree();

		SqlParameter[] parametersTree = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Tree_GetDetails", CommandType.StoredProcedure, parametersTree))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				tree.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				tree.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
				tree.TreeType = row["TreeType"].ToString();
				tree.RegisterPlaque = row["RegisterPlaque"].ToString();
				tree.DocNumber = row["DocNumber"].ToString();
				tree.Section = row["Section"].ToString();
				tree.TreeNumber = (row["TreeNumber"] != DBNull.Value) ? Convert.ToInt32(row["TreeNumber"]) : 0 ;
				tree.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

				Heritage heritage = heritageDBAccess.GetDetails(tree.HeritageID);
				tree.HeritageID = heritage.HeritageID;
				tree.StageTitle = heritage.StageTitle;
				tree.RegisterDate = heritage.RegisterDate;
				tree.OldRegisterDate = heritage.OldRegisterDate;
				tree.OldRegisterInformationID = heritage.OldRegisterInformationID;
				tree.Sixth = heritage.Sixth;
				tree.PreviousOwner = heritage.PreviousOwner;
				tree.Comment = heritage.Comment;
				tree.RegisterInformationID = heritage.RegisterInformationID;
				tree.AdjustmentID = heritage.AdjustmentID;
				tree.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				tree.Stage = heritage.Stage;
				tree.UserOrder = heritage.UserOrder;
				tree.Value1 = heritage.Value1;
				tree.Value2 = heritage.Value2;
				tree.Value3 = heritage.Value3;
				tree.DeadIsOwner = heritage.DeadIsOwner;
				tree.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return tree;
	}

	public List<Tree> GetListAll()
	{
		List<Tree> listTree = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Tree_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listTree = new List<Tree>();

				foreach (DataRow row in table.Rows)
				{
					Tree tree = new Tree();
					tree.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tree.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tree.TreeType = row["TreeType"].ToString();
					tree.RegisterPlaque = row["RegisterPlaque"].ToString();
					tree.DocNumber = row["DocNumber"].ToString();
					tree.Section = row["Section"].ToString();
					tree.TreeNumber = (row["TreeNumber"] != DBNull.Value) ? Convert.ToInt32(row["TreeNumber"]) : 0 ;
					tree.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tree.HeritageID);
					tree.StageTitle = heritage.StageTitle;
					tree.RegisterDate = heritage.RegisterDate;
					tree.OldRegisterDate = heritage.OldRegisterDate;
					tree.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tree.Sixth = heritage.Sixth;
					tree.PreviousOwner = heritage.PreviousOwner;
					tree.Comment = heritage.Comment;
					tree.RegisterInformationID = heritage.RegisterInformationID;
					tree.AdjustmentID = heritage.AdjustmentID;
					tree.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tree.Stage = heritage.Stage;
					tree.UserOrder = heritage.UserOrder;
					tree.Value1 = heritage.Value1;
					tree.Value2 = heritage.Value2;
					tree.Value3 = heritage.Value3;
					tree.DeadIsOwner = heritage.DeadIsOwner;
					tree.IsDiagonesed = heritage.IsDiagonesed;
					listTree.Add(tree);
				}
			}
		}

		return listTree;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersTree = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Tree_Exists", CommandType.StoredProcedure, parametersTree)>0);
	}

	public bool Exists(Tree tree)
	{
		SqlParameter[] parametersTree = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", tree.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Tree_Exists", CommandType.StoredProcedure, parametersTree)>0);
	}

	public List<Tree> SearchLike(Tree tree)
	{
		List<Tree> listTree = new List<Tree>();


		SqlParameter[] parametersTree = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", tree.HeritageID),
			new SqlParameter("@ProductionUnitID", tree.ProductionUnitID),
			new SqlParameter("@TreeType", tree.TreeType),
			new SqlParameter("@RegisterPlaque", tree.RegisterPlaque),
			new SqlParameter("@DocNumber", tree.DocNumber),
			new SqlParameter("@Section", tree.Section),
			new SqlParameter("@TreeNumber", tree.TreeNumber),
			new SqlParameter("@DeclarationID", tree.DeclarationID),

			new SqlParameter("@StageTitle", tree.StageTitle),
			new SqlParameter("@RegisterDate", tree.RegisterDate),
			new SqlParameter("@OldRegisterDate", tree.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", tree.OldRegisterInformationID),
			new SqlParameter("@Sixth", tree.Sixth),
			new SqlParameter("@PreviousOwner", tree.PreviousOwner),
			new SqlParameter("@Comment", tree.Comment),
			new SqlParameter("@RegisterInformationID", tree.RegisterInformationID),
			new SqlParameter("@AdjustmentID", tree.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", tree.CommissionAdjustmentID),
			new SqlParameter("@Stage", tree.Stage),
			new SqlParameter("@UserOrder", tree.UserOrder),
			new SqlParameter("@Value1", tree.Value1),
			new SqlParameter("@Value2", tree.Value2),
			new SqlParameter("@Value3", tree.Value3),
			new SqlParameter("@DeadIsOwner", tree.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", tree.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Tree_SearchLike", CommandType.StoredProcedure, parametersTree))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Tree tmpTree = new Tree();
					tmpTree.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpTree.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tmpTree.TreeType = row["TreeType"].ToString();
					tmpTree.RegisterPlaque = row["RegisterPlaque"].ToString();
					tmpTree.DocNumber = row["DocNumber"].ToString();
					tmpTree.Section = row["Section"].ToString();
					tmpTree.TreeNumber = (row["TreeNumber"] != DBNull.Value) ? Convert.ToInt32(row["TreeNumber"]) : 0 ;
					tmpTree.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpTree.HeritageID);
					tmpTree.HeritageID = heritage.HeritageID;
					tmpTree.StageTitle = heritage.StageTitle;
					tmpTree.RegisterDate = heritage.RegisterDate;
					tmpTree.OldRegisterDate = heritage.OldRegisterDate;
					tmpTree.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpTree.Sixth = heritage.Sixth;
					tmpTree.PreviousOwner = heritage.PreviousOwner;
					tmpTree.Comment = heritage.Comment;
					tmpTree.RegisterInformationID = heritage.RegisterInformationID;
					tmpTree.AdjustmentID = heritage.AdjustmentID;
					tmpTree.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpTree.Stage = heritage.Stage;
					tmpTree.UserOrder = heritage.UserOrder;
					tmpTree.Value1 = heritage.Value1;
					tmpTree.Value2 = heritage.Value2;
					tmpTree.Value3 = heritage.Value3;
					tmpTree.DeadIsOwner = heritage.DeadIsOwner;
					tmpTree.IsDiagonesed = heritage.IsDiagonesed;

					listTree.Add(tmpTree);
				}
			}
		}

		return listTree;
	}

}
}
