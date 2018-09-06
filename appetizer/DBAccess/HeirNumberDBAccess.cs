using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class HeirNumberDBAccess
{


	public Int64 Insert(HeirNumber heirNumber)
	{
		SqlParameter[] parametersHeirNumber = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", (heirNumber.DeclarationID > 0) ? heirNumber.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@HeirNumber2", (heirNumber.HeirNumber2 != null) ? heirNumber.HeirNumber2 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber5", (heirNumber.HeirNumber5 != null) ? heirNumber.HeirNumber5 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber6", (heirNumber.HeirNumber6 != null) ? heirNumber.HeirNumber6 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber7", (heirNumber.HeirNumber7 != null) ? heirNumber.HeirNumber7 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber8", (heirNumber.HeirNumber8 != null) ? heirNumber.HeirNumber8 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber9", (heirNumber.HeirNumber9 != null) ? heirNumber.HeirNumber9 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber68", (heirNumber.HeirNumber68 != null) ? heirNumber.HeirNumber68 : (object)DBNull.Value),
			new SqlParameter("@Stage", (heirNumber.Stage != null) ? heirNumber.Stage : (object)DBNull.Value),
			new SqlParameter("@HeirNumber62", (heirNumber.HeirNumber62 != null) ? heirNumber.HeirNumber62 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber63", (heirNumber.HeirNumber63 != null) ? heirNumber.HeirNumber63 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber64", (heirNumber.HeirNumber64 != null) ? heirNumber.HeirNumber64 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber65", (heirNumber.HeirNumber65 != null) ? heirNumber.HeirNumber65 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber66", (heirNumber.HeirNumber66 != null) ? heirNumber.HeirNumber66 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber67", (heirNumber.HeirNumber67 != null) ? heirNumber.HeirNumber67 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber56", (heirNumber.HeirNumber56 != null) ? heirNumber.HeirNumber56 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber57", (heirNumber.HeirNumber57 != null) ? heirNumber.HeirNumber57 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber58", (heirNumber.HeirNumber58 != null) ? heirNumber.HeirNumber58 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber59", (heirNumber.HeirNumber59 != null) ? heirNumber.HeirNumber59 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber60", (heirNumber.HeirNumber60 != null) ? heirNumber.HeirNumber60 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber61", (heirNumber.HeirNumber61 != null) ? heirNumber.HeirNumber61 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber50", (heirNumber.HeirNumber50 != null) ? heirNumber.HeirNumber50 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber51", (heirNumber.HeirNumber51 != null) ? heirNumber.HeirNumber51 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber52", (heirNumber.HeirNumber52 != null) ? heirNumber.HeirNumber52 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber53", (heirNumber.HeirNumber53 != null) ? heirNumber.HeirNumber53 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber54", (heirNumber.HeirNumber54 != null) ? heirNumber.HeirNumber54 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber55", (heirNumber.HeirNumber55 != null) ? heirNumber.HeirNumber55 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber44", (heirNumber.HeirNumber44 != null) ? heirNumber.HeirNumber44 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber45", (heirNumber.HeirNumber45 != null) ? heirNumber.HeirNumber45 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber46", (heirNumber.HeirNumber46 != null) ? heirNumber.HeirNumber46 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber47", (heirNumber.HeirNumber47 != null) ? heirNumber.HeirNumber47 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber48", (heirNumber.HeirNumber48 != null) ? heirNumber.HeirNumber48 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber49", (heirNumber.HeirNumber49 != null) ? heirNumber.HeirNumber49 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber38", (heirNumber.HeirNumber38 != null) ? heirNumber.HeirNumber38 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber39", (heirNumber.HeirNumber39 != null) ? heirNumber.HeirNumber39 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber40", (heirNumber.HeirNumber40 != null) ? heirNumber.HeirNumber40 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber41", (heirNumber.HeirNumber41 != null) ? heirNumber.HeirNumber41 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber42", (heirNumber.HeirNumber42 != null) ? heirNumber.HeirNumber42 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber43", (heirNumber.HeirNumber43 != null) ? heirNumber.HeirNumber43 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber32", (heirNumber.HeirNumber32 != null) ? heirNumber.HeirNumber32 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber33", (heirNumber.HeirNumber33 != null) ? heirNumber.HeirNumber33 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber34", (heirNumber.HeirNumber34 != null) ? heirNumber.HeirNumber34 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber35", (heirNumber.HeirNumber35 != null) ? heirNumber.HeirNumber35 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber36", (heirNumber.HeirNumber36 != null) ? heirNumber.HeirNumber36 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber37", (heirNumber.HeirNumber37 != null) ? heirNumber.HeirNumber37 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber26", (heirNumber.HeirNumber26 != null) ? heirNumber.HeirNumber26 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber27", (heirNumber.HeirNumber27 != null) ? heirNumber.HeirNumber27 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber28", (heirNumber.HeirNumber28 != null) ? heirNumber.HeirNumber28 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber29", (heirNumber.HeirNumber29 != null) ? heirNumber.HeirNumber29 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber30", (heirNumber.HeirNumber30 != null) ? heirNumber.HeirNumber30 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber31", (heirNumber.HeirNumber31 != null) ? heirNumber.HeirNumber31 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber20", (heirNumber.HeirNumber20 != null) ? heirNumber.HeirNumber20 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber21", (heirNumber.HeirNumber21 != null) ? heirNumber.HeirNumber21 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber22", (heirNumber.HeirNumber22 != null) ? heirNumber.HeirNumber22 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber23", (heirNumber.HeirNumber23 != null) ? heirNumber.HeirNumber23 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber24", (heirNumber.HeirNumber24 != null) ? heirNumber.HeirNumber24 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber25", (heirNumber.HeirNumber25 != null) ? heirNumber.HeirNumber25 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber10", (heirNumber.HeirNumber10 != null) ? heirNumber.HeirNumber10 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber15", (heirNumber.HeirNumber15 != null) ? heirNumber.HeirNumber15 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber16", (heirNumber.HeirNumber16 != null) ? heirNumber.HeirNumber16 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber17", (heirNumber.HeirNumber17 != null) ? heirNumber.HeirNumber17 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber18", (heirNumber.HeirNumber18 != null) ? heirNumber.HeirNumber18 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber19", (heirNumber.HeirNumber19 != null) ? heirNumber.HeirNumber19 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber1", (heirNumber.HeirNumber1 != null) ? heirNumber.HeirNumber1 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber3", (heirNumber.HeirNumber3 != null) ? heirNumber.HeirNumber3 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber4", (heirNumber.HeirNumber4 != null) ? heirNumber.HeirNumber4 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber11", (heirNumber.HeirNumber11 != null) ? heirNumber.HeirNumber11 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber12", (heirNumber.HeirNumber12 != null) ? heirNumber.HeirNumber12 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber13", (heirNumber.HeirNumber13 != null) ? heirNumber.HeirNumber13 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber14", (heirNumber.HeirNumber14 != null) ? heirNumber.HeirNumber14 : (object)DBNull.Value)
		};
		heirNumber.HeirNumberID = SqlDBHelper.ExecuteScalar("HeirNumber_Insert", CommandType.StoredProcedure, parametersHeirNumber);
		return heirNumber.HeirNumberID;
	}

	public bool Update(HeirNumber heirNumber)
	{
		SqlParameter[] parametersHeirNumber = new SqlParameter[]
		{
			new SqlParameter("@HeirNumberID", heirNumber.HeirNumberID),
			new SqlParameter("@DeclarationID", heirNumber.DeclarationID),
			new SqlParameter("@HeirNumber2", (heirNumber.HeirNumber2 != null) ? heirNumber.HeirNumber2 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber5", (heirNumber.HeirNumber5 != null) ? heirNumber.HeirNumber5 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber6", (heirNumber.HeirNumber6 != null) ? heirNumber.HeirNumber6 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber7", (heirNumber.HeirNumber7 != null) ? heirNumber.HeirNumber7 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber8", (heirNumber.HeirNumber8 != null) ? heirNumber.HeirNumber8 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber9", (heirNumber.HeirNumber9 != null) ? heirNumber.HeirNumber9 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber68", (heirNumber.HeirNumber68 != null) ? heirNumber.HeirNumber68 : (object)DBNull.Value),
			new SqlParameter("@Stage", (heirNumber.Stage != null) ? heirNumber.Stage : (object)DBNull.Value),
			new SqlParameter("@HeirNumber62", (heirNumber.HeirNumber62 != null) ? heirNumber.HeirNumber62 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber63", (heirNumber.HeirNumber63 != null) ? heirNumber.HeirNumber63 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber64", (heirNumber.HeirNumber64 != null) ? heirNumber.HeirNumber64 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber65", (heirNumber.HeirNumber65 != null) ? heirNumber.HeirNumber65 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber66", (heirNumber.HeirNumber66 != null) ? heirNumber.HeirNumber66 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber67", (heirNumber.HeirNumber67 != null) ? heirNumber.HeirNumber67 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber56", (heirNumber.HeirNumber56 != null) ? heirNumber.HeirNumber56 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber57", (heirNumber.HeirNumber57 != null) ? heirNumber.HeirNumber57 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber58", (heirNumber.HeirNumber58 != null) ? heirNumber.HeirNumber58 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber59", (heirNumber.HeirNumber59 != null) ? heirNumber.HeirNumber59 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber60", (heirNumber.HeirNumber60 != null) ? heirNumber.HeirNumber60 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber61", (heirNumber.HeirNumber61 != null) ? heirNumber.HeirNumber61 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber50", (heirNumber.HeirNumber50 != null) ? heirNumber.HeirNumber50 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber51", (heirNumber.HeirNumber51 != null) ? heirNumber.HeirNumber51 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber52", (heirNumber.HeirNumber52 != null) ? heirNumber.HeirNumber52 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber53", (heirNumber.HeirNumber53 != null) ? heirNumber.HeirNumber53 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber54", (heirNumber.HeirNumber54 != null) ? heirNumber.HeirNumber54 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber55", (heirNumber.HeirNumber55 != null) ? heirNumber.HeirNumber55 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber44", (heirNumber.HeirNumber44 != null) ? heirNumber.HeirNumber44 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber45", (heirNumber.HeirNumber45 != null) ? heirNumber.HeirNumber45 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber46", (heirNumber.HeirNumber46 != null) ? heirNumber.HeirNumber46 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber47", (heirNumber.HeirNumber47 != null) ? heirNumber.HeirNumber47 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber48", (heirNumber.HeirNumber48 != null) ? heirNumber.HeirNumber48 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber49", (heirNumber.HeirNumber49 != null) ? heirNumber.HeirNumber49 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber38", (heirNumber.HeirNumber38 != null) ? heirNumber.HeirNumber38 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber39", (heirNumber.HeirNumber39 != null) ? heirNumber.HeirNumber39 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber40", (heirNumber.HeirNumber40 != null) ? heirNumber.HeirNumber40 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber41", (heirNumber.HeirNumber41 != null) ? heirNumber.HeirNumber41 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber42", (heirNumber.HeirNumber42 != null) ? heirNumber.HeirNumber42 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber43", (heirNumber.HeirNumber43 != null) ? heirNumber.HeirNumber43 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber32", (heirNumber.HeirNumber32 != null) ? heirNumber.HeirNumber32 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber33", (heirNumber.HeirNumber33 != null) ? heirNumber.HeirNumber33 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber34", (heirNumber.HeirNumber34 != null) ? heirNumber.HeirNumber34 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber35", (heirNumber.HeirNumber35 != null) ? heirNumber.HeirNumber35 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber36", (heirNumber.HeirNumber36 != null) ? heirNumber.HeirNumber36 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber37", (heirNumber.HeirNumber37 != null) ? heirNumber.HeirNumber37 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber26", (heirNumber.HeirNumber26 != null) ? heirNumber.HeirNumber26 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber27", (heirNumber.HeirNumber27 != null) ? heirNumber.HeirNumber27 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber28", (heirNumber.HeirNumber28 != null) ? heirNumber.HeirNumber28 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber29", (heirNumber.HeirNumber29 != null) ? heirNumber.HeirNumber29 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber30", (heirNumber.HeirNumber30 != null) ? heirNumber.HeirNumber30 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber31", (heirNumber.HeirNumber31 != null) ? heirNumber.HeirNumber31 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber20", (heirNumber.HeirNumber20 != null) ? heirNumber.HeirNumber20 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber21", (heirNumber.HeirNumber21 != null) ? heirNumber.HeirNumber21 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber22", (heirNumber.HeirNumber22 != null) ? heirNumber.HeirNumber22 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber23", (heirNumber.HeirNumber23 != null) ? heirNumber.HeirNumber23 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber24", (heirNumber.HeirNumber24 != null) ? heirNumber.HeirNumber24 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber25", (heirNumber.HeirNumber25 != null) ? heirNumber.HeirNumber25 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber10", (heirNumber.HeirNumber10 != null) ? heirNumber.HeirNumber10 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber15", (heirNumber.HeirNumber15 != null) ? heirNumber.HeirNumber15 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber16", (heirNumber.HeirNumber16 != null) ? heirNumber.HeirNumber16 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber17", (heirNumber.HeirNumber17 != null) ? heirNumber.HeirNumber17 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber18", (heirNumber.HeirNumber18 != null) ? heirNumber.HeirNumber18 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber19", (heirNumber.HeirNumber19 != null) ? heirNumber.HeirNumber19 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber1", (heirNumber.HeirNumber1 != null) ? heirNumber.HeirNumber1 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber3", (heirNumber.HeirNumber3 != null) ? heirNumber.HeirNumber3 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber4", (heirNumber.HeirNumber4 != null) ? heirNumber.HeirNumber4 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber11", (heirNumber.HeirNumber11 != null) ? heirNumber.HeirNumber11 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber12", (heirNumber.HeirNumber12 != null) ? heirNumber.HeirNumber12 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber13", (heirNumber.HeirNumber13 != null) ? heirNumber.HeirNumber13 : (object)DBNull.Value),
			new SqlParameter("@HeirNumber14", (heirNumber.HeirNumber14 != null) ? heirNumber.HeirNumber14 : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("HeirNumber_Update", CommandType.StoredProcedure, parametersHeirNumber);
	}

	public bool Delete(Int64 heirNumberID)
	{
		SqlParameter[] parametersHeirNumber = new SqlParameter[]
		{
			new SqlParameter("@HeirNumberID", heirNumberID)
		};
		return SqlDBHelper.ExecuteNonQuery("HeirNumber_Delete", CommandType.StoredProcedure, parametersHeirNumber);
	}

	public HeirNumber GetDetails(Int64 heirNumberID)
	{
		HeirNumber heirNumber = new HeirNumber();

		SqlParameter[] parametersHeirNumber = new SqlParameter[]
		{
			new SqlParameter("@HeirNumberID", heirNumberID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("HeirNumber_GetDetails", CommandType.StoredProcedure, parametersHeirNumber))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				heirNumber.HeirNumberID = (row["HeirNumberID"] != DBNull.Value) ? Convert.ToInt64(row["HeirNumberID"]) : 0 ;
				heirNumber.StageTitle = row["StageTitle"].ToString();
				heirNumber.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				heirNumber.HeirNumber2 = (row["HeirNumber2"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber2"]) : 0 ;
				heirNumber.HeirNumber5 = (row["HeirNumber5"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber5"]) : 0 ;
				heirNumber.HeirNumber6 = (row["HeirNumber6"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber6"]) : 0 ;
				heirNumber.HeirNumber7 = (row["HeirNumber7"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber7"]) : 0 ;
				heirNumber.HeirNumber8 = (row["HeirNumber8"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber8"]) : 0 ;
				heirNumber.HeirNumber9 = (row["HeirNumber9"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber9"]) : 0 ;
				heirNumber.HeirNumber68 = (row["HeirNumber68"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber68"]) : 0 ;
				heirNumber.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
				heirNumber.HeirNumber62 = (row["HeirNumber62"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber62"]) : 0 ;
				heirNumber.HeirNumber63 = (row["HeirNumber63"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber63"]) : 0 ;
				heirNumber.HeirNumber64 = (row["HeirNumber64"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber64"]) : 0 ;
				heirNumber.HeirNumber65 = (row["HeirNumber65"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber65"]) : 0 ;
				heirNumber.HeirNumber66 = (row["HeirNumber66"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber66"]) : 0 ;
				heirNumber.HeirNumber67 = (row["HeirNumber67"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber67"]) : 0 ;
				heirNumber.HeirNumber56 = (row["HeirNumber56"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber56"]) : 0 ;
				heirNumber.HeirNumber57 = (row["HeirNumber57"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber57"]) : 0 ;
				heirNumber.HeirNumber58 = (row["HeirNumber58"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber58"]) : 0 ;
				heirNumber.HeirNumber59 = (row["HeirNumber59"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber59"]) : 0 ;
				heirNumber.HeirNumber60 = (row["HeirNumber60"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber60"]) : 0 ;
				heirNumber.HeirNumber61 = (row["HeirNumber61"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber61"]) : 0 ;
				heirNumber.HeirNumber50 = (row["HeirNumber50"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber50"]) : 0 ;
				heirNumber.HeirNumber51 = (row["HeirNumber51"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber51"]) : 0 ;
				heirNumber.HeirNumber52 = (row["HeirNumber52"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber52"]) : 0 ;
				heirNumber.HeirNumber53 = (row["HeirNumber53"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber53"]) : 0 ;
				heirNumber.HeirNumber54 = (row["HeirNumber54"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber54"]) : 0 ;
				heirNumber.HeirNumber55 = (row["HeirNumber55"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber55"]) : 0 ;
				heirNumber.HeirNumber44 = (row["HeirNumber44"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber44"]) : 0 ;
				heirNumber.HeirNumber45 = (row["HeirNumber45"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber45"]) : 0 ;
				heirNumber.HeirNumber46 = (row["HeirNumber46"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber46"]) : 0 ;
				heirNumber.HeirNumber47 = (row["HeirNumber47"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber47"]) : 0 ;
				heirNumber.HeirNumber48 = (row["HeirNumber48"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber48"]) : 0 ;
				heirNumber.HeirNumber49 = (row["HeirNumber49"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber49"]) : 0 ;
				heirNumber.HeirNumber38 = (row["HeirNumber38"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber38"]) : 0 ;
				heirNumber.HeirNumber39 = (row["HeirNumber39"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber39"]) : 0 ;
				heirNumber.HeirNumber40 = (row["HeirNumber40"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber40"]) : 0 ;
				heirNumber.HeirNumber41 = (row["HeirNumber41"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber41"]) : 0 ;
				heirNumber.HeirNumber42 = (row["HeirNumber42"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber42"]) : 0 ;
				heirNumber.HeirNumber43 = (row["HeirNumber43"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber43"]) : 0 ;
				heirNumber.HeirNumber32 = (row["HeirNumber32"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber32"]) : 0 ;
				heirNumber.HeirNumber33 = (row["HeirNumber33"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber33"]) : 0 ;
				heirNumber.HeirNumber34 = (row["HeirNumber34"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber34"]) : 0 ;
				heirNumber.HeirNumber35 = (row["HeirNumber35"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber35"]) : 0 ;
				heirNumber.HeirNumber36 = (row["HeirNumber36"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber36"]) : 0 ;
				heirNumber.HeirNumber37 = (row["HeirNumber37"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber37"]) : 0 ;
				heirNumber.HeirNumber26 = (row["HeirNumber26"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber26"]) : 0 ;
				heirNumber.HeirNumber27 = (row["HeirNumber27"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber27"]) : 0 ;
				heirNumber.HeirNumber28 = (row["HeirNumber28"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber28"]) : 0 ;
				heirNumber.HeirNumber29 = (row["HeirNumber29"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber29"]) : 0 ;
				heirNumber.HeirNumber30 = (row["HeirNumber30"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber30"]) : 0 ;
				heirNumber.HeirNumber31 = (row["HeirNumber31"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber31"]) : 0 ;
				heirNumber.HeirNumber20 = (row["HeirNumber20"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber20"]) : 0 ;
				heirNumber.HeirNumber21 = (row["HeirNumber21"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber21"]) : 0 ;
				heirNumber.HeirNumber22 = (row["HeirNumber22"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber22"]) : 0 ;
				heirNumber.HeirNumber23 = (row["HeirNumber23"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber23"]) : 0 ;
				heirNumber.HeirNumber24 = (row["HeirNumber24"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber24"]) : 0 ;
				heirNumber.HeirNumber25 = (row["HeirNumber25"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber25"]) : 0 ;
				heirNumber.HeirNumber10 = (row["HeirNumber10"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber10"]) : 0 ;
				heirNumber.HeirNumber15 = (row["HeirNumber15"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber15"]) : 0 ;
				heirNumber.HeirNumber16 = (row["HeirNumber16"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber16"]) : 0 ;
				heirNumber.HeirNumber17 = (row["HeirNumber17"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber17"]) : 0 ;
				heirNumber.HeirNumber18 = (row["HeirNumber18"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber18"]) : 0 ;
				heirNumber.HeirNumber19 = (row["HeirNumber19"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber19"]) : 0 ;
				heirNumber.HeirNumber1 = (row["HeirNumber1"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber1"].ToString() == "1" || row["HeirNumber1"].ToString().ToLower() == "true" ) ? true : false) : false ;
				heirNumber.HeirNumber3 = (row["HeirNumber3"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber3"].ToString() == "1" || row["HeirNumber3"].ToString().ToLower() == "true" ) ? true : false) : false ;
				heirNumber.HeirNumber4 = (row["HeirNumber4"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber4"].ToString() == "1" || row["HeirNumber4"].ToString().ToLower() == "true" ) ? true : false) : false ;
				heirNumber.HeirNumber11 = (row["HeirNumber11"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber11"].ToString() == "1" || row["HeirNumber11"].ToString().ToLower() == "true" ) ? true : false) : false ;
				heirNumber.HeirNumber12 = (row["HeirNumber12"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber12"].ToString() == "1" || row["HeirNumber12"].ToString().ToLower() == "true" ) ? true : false) : false ;
				heirNumber.HeirNumber13 = (row["HeirNumber13"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber13"].ToString() == "1" || row["HeirNumber13"].ToString().ToLower() == "true" ) ? true : false) : false ;
				heirNumber.HeirNumber14 = (row["HeirNumber14"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber14"].ToString() == "1" || row["HeirNumber14"].ToString().ToLower() == "true" ) ? true : false) : false ;
			}
		}

		return heirNumber;
	}

	public List<HeirNumber> GetListAll()
	{
		List<HeirNumber> listHeirNumber = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("HeirNumber_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listHeirNumber = new List<HeirNumber>();

				foreach (DataRow row in table.Rows)
				{
					HeirNumber heirNumber = new HeirNumber();
					heirNumber.HeirNumberID = (row["HeirNumberID"] != DBNull.Value) ? Convert.ToInt64(row["HeirNumberID"]) : 0 ;
					heirNumber.StageTitle = row["StageTitle"].ToString();
					heirNumber.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					heirNumber.HeirNumber2 = (row["HeirNumber2"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber2"]) : 0 ;
					heirNumber.HeirNumber5 = (row["HeirNumber5"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber5"]) : 0 ;
					heirNumber.HeirNumber6 = (row["HeirNumber6"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber6"]) : 0 ;
					heirNumber.HeirNumber7 = (row["HeirNumber7"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber7"]) : 0 ;
					heirNumber.HeirNumber8 = (row["HeirNumber8"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber8"]) : 0 ;
					heirNumber.HeirNumber9 = (row["HeirNumber9"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber9"]) : 0 ;
					heirNumber.HeirNumber68 = (row["HeirNumber68"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber68"]) : 0 ;
					heirNumber.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
					heirNumber.HeirNumber62 = (row["HeirNumber62"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber62"]) : 0 ;
					heirNumber.HeirNumber63 = (row["HeirNumber63"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber63"]) : 0 ;
					heirNumber.HeirNumber64 = (row["HeirNumber64"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber64"]) : 0 ;
					heirNumber.HeirNumber65 = (row["HeirNumber65"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber65"]) : 0 ;
					heirNumber.HeirNumber66 = (row["HeirNumber66"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber66"]) : 0 ;
					heirNumber.HeirNumber67 = (row["HeirNumber67"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber67"]) : 0 ;
					heirNumber.HeirNumber56 = (row["HeirNumber56"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber56"]) : 0 ;
					heirNumber.HeirNumber57 = (row["HeirNumber57"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber57"]) : 0 ;
					heirNumber.HeirNumber58 = (row["HeirNumber58"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber58"]) : 0 ;
					heirNumber.HeirNumber59 = (row["HeirNumber59"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber59"]) : 0 ;
					heirNumber.HeirNumber60 = (row["HeirNumber60"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber60"]) : 0 ;
					heirNumber.HeirNumber61 = (row["HeirNumber61"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber61"]) : 0 ;
					heirNumber.HeirNumber50 = (row["HeirNumber50"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber50"]) : 0 ;
					heirNumber.HeirNumber51 = (row["HeirNumber51"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber51"]) : 0 ;
					heirNumber.HeirNumber52 = (row["HeirNumber52"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber52"]) : 0 ;
					heirNumber.HeirNumber53 = (row["HeirNumber53"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber53"]) : 0 ;
					heirNumber.HeirNumber54 = (row["HeirNumber54"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber54"]) : 0 ;
					heirNumber.HeirNumber55 = (row["HeirNumber55"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber55"]) : 0 ;
					heirNumber.HeirNumber44 = (row["HeirNumber44"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber44"]) : 0 ;
					heirNumber.HeirNumber45 = (row["HeirNumber45"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber45"]) : 0 ;
					heirNumber.HeirNumber46 = (row["HeirNumber46"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber46"]) : 0 ;
					heirNumber.HeirNumber47 = (row["HeirNumber47"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber47"]) : 0 ;
					heirNumber.HeirNumber48 = (row["HeirNumber48"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber48"]) : 0 ;
					heirNumber.HeirNumber49 = (row["HeirNumber49"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber49"]) : 0 ;
					heirNumber.HeirNumber38 = (row["HeirNumber38"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber38"]) : 0 ;
					heirNumber.HeirNumber39 = (row["HeirNumber39"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber39"]) : 0 ;
					heirNumber.HeirNumber40 = (row["HeirNumber40"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber40"]) : 0 ;
					heirNumber.HeirNumber41 = (row["HeirNumber41"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber41"]) : 0 ;
					heirNumber.HeirNumber42 = (row["HeirNumber42"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber42"]) : 0 ;
					heirNumber.HeirNumber43 = (row["HeirNumber43"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber43"]) : 0 ;
					heirNumber.HeirNumber32 = (row["HeirNumber32"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber32"]) : 0 ;
					heirNumber.HeirNumber33 = (row["HeirNumber33"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber33"]) : 0 ;
					heirNumber.HeirNumber34 = (row["HeirNumber34"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber34"]) : 0 ;
					heirNumber.HeirNumber35 = (row["HeirNumber35"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber35"]) : 0 ;
					heirNumber.HeirNumber36 = (row["HeirNumber36"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber36"]) : 0 ;
					heirNumber.HeirNumber37 = (row["HeirNumber37"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber37"]) : 0 ;
					heirNumber.HeirNumber26 = (row["HeirNumber26"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber26"]) : 0 ;
					heirNumber.HeirNumber27 = (row["HeirNumber27"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber27"]) : 0 ;
					heirNumber.HeirNumber28 = (row["HeirNumber28"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber28"]) : 0 ;
					heirNumber.HeirNumber29 = (row["HeirNumber29"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber29"]) : 0 ;
					heirNumber.HeirNumber30 = (row["HeirNumber30"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber30"]) : 0 ;
					heirNumber.HeirNumber31 = (row["HeirNumber31"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber31"]) : 0 ;
					heirNumber.HeirNumber20 = (row["HeirNumber20"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber20"]) : 0 ;
					heirNumber.HeirNumber21 = (row["HeirNumber21"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber21"]) : 0 ;
					heirNumber.HeirNumber22 = (row["HeirNumber22"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber22"]) : 0 ;
					heirNumber.HeirNumber23 = (row["HeirNumber23"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber23"]) : 0 ;
					heirNumber.HeirNumber24 = (row["HeirNumber24"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber24"]) : 0 ;
					heirNumber.HeirNumber25 = (row["HeirNumber25"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber25"]) : 0 ;
					heirNumber.HeirNumber10 = (row["HeirNumber10"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber10"]) : 0 ;
					heirNumber.HeirNumber15 = (row["HeirNumber15"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber15"]) : 0 ;
					heirNumber.HeirNumber16 = (row["HeirNumber16"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber16"]) : 0 ;
					heirNumber.HeirNumber17 = (row["HeirNumber17"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber17"]) : 0 ;
					heirNumber.HeirNumber18 = (row["HeirNumber18"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber18"]) : 0 ;
					heirNumber.HeirNumber19 = (row["HeirNumber19"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber19"]) : 0 ;
				heirNumber.HeirNumber1 = (row["HeirNumber1"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber1"].ToString() == "1" || row["HeirNumber1"].ToString().ToLower() == "true" ) ? true : false) : false ;
				heirNumber.HeirNumber3 = (row["HeirNumber3"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber3"].ToString() == "1" || row["HeirNumber3"].ToString().ToLower() == "true" ) ? true : false) : false ;
				heirNumber.HeirNumber4 = (row["HeirNumber4"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber4"].ToString() == "1" || row["HeirNumber4"].ToString().ToLower() == "true" ) ? true : false) : false ;
				heirNumber.HeirNumber11 = (row["HeirNumber11"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber11"].ToString() == "1" || row["HeirNumber11"].ToString().ToLower() == "true" ) ? true : false) : false ;
				heirNumber.HeirNumber12 = (row["HeirNumber12"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber12"].ToString() == "1" || row["HeirNumber12"].ToString().ToLower() == "true" ) ? true : false) : false ;
				heirNumber.HeirNumber13 = (row["HeirNumber13"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber13"].ToString() == "1" || row["HeirNumber13"].ToString().ToLower() == "true" ) ? true : false) : false ;
				heirNumber.HeirNumber14 = (row["HeirNumber14"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber14"].ToString() == "1" || row["HeirNumber14"].ToString().ToLower() == "true" ) ? true : false) : false ;
					listHeirNumber.Add(heirNumber);
				}
			}
		}

		return listHeirNumber;
	}

	public bool Exists(Int64 heirNumberID)
	{
		SqlParameter[] parametersHeirNumber = new SqlParameter[]
		{
			new SqlParameter("@HeirNumberID", heirNumberID)
		};
		return (SqlDBHelper.ExecuteScalar("HeirNumber_Exists", CommandType.StoredProcedure, parametersHeirNumber)>0);
	}

	public bool Exists(HeirNumber heirNumber)
	{
		SqlParameter[] parametersHeirNumber = new SqlParameter[]
		{
			new SqlParameter("@HeirNumberID", heirNumber.HeirNumberID)
		};
		return (SqlDBHelper.ExecuteScalar("HeirNumber_Exists", CommandType.StoredProcedure, parametersHeirNumber)>0);
	}

	public List<HeirNumber> SearchLike(HeirNumber heirNumber)
	{
		List<HeirNumber> listHeirNumber = new List<HeirNumber>();


		SqlParameter[] parametersHeirNumber = new SqlParameter[]
		{
			new SqlParameter("@HeirNumberID", heirNumber.HeirNumberID),
			new SqlParameter("@StageTitle", heirNumber.StageTitle),
			new SqlParameter("@DeclarationID", heirNumber.DeclarationID),
			new SqlParameter("@HeirNumber2", heirNumber.HeirNumber2),
			new SqlParameter("@HeirNumber5", heirNumber.HeirNumber5),
			new SqlParameter("@HeirNumber6", heirNumber.HeirNumber6),
			new SqlParameter("@HeirNumber7", heirNumber.HeirNumber7),
			new SqlParameter("@HeirNumber8", heirNumber.HeirNumber8),
			new SqlParameter("@HeirNumber9", heirNumber.HeirNumber9),
			new SqlParameter("@HeirNumber68", heirNumber.HeirNumber68),
			new SqlParameter("@Stage", heirNumber.Stage),
			new SqlParameter("@HeirNumber62", heirNumber.HeirNumber62),
			new SqlParameter("@HeirNumber63", heirNumber.HeirNumber63),
			new SqlParameter("@HeirNumber64", heirNumber.HeirNumber64),
			new SqlParameter("@HeirNumber65", heirNumber.HeirNumber65),
			new SqlParameter("@HeirNumber66", heirNumber.HeirNumber66),
			new SqlParameter("@HeirNumber67", heirNumber.HeirNumber67),
			new SqlParameter("@HeirNumber56", heirNumber.HeirNumber56),
			new SqlParameter("@HeirNumber57", heirNumber.HeirNumber57),
			new SqlParameter("@HeirNumber58", heirNumber.HeirNumber58),
			new SqlParameter("@HeirNumber59", heirNumber.HeirNumber59),
			new SqlParameter("@HeirNumber60", heirNumber.HeirNumber60),
			new SqlParameter("@HeirNumber61", heirNumber.HeirNumber61),
			new SqlParameter("@HeirNumber50", heirNumber.HeirNumber50),
			new SqlParameter("@HeirNumber51", heirNumber.HeirNumber51),
			new SqlParameter("@HeirNumber52", heirNumber.HeirNumber52),
			new SqlParameter("@HeirNumber53", heirNumber.HeirNumber53),
			new SqlParameter("@HeirNumber54", heirNumber.HeirNumber54),
			new SqlParameter("@HeirNumber55", heirNumber.HeirNumber55),
			new SqlParameter("@HeirNumber44", heirNumber.HeirNumber44),
			new SqlParameter("@HeirNumber45", heirNumber.HeirNumber45),
			new SqlParameter("@HeirNumber46", heirNumber.HeirNumber46),
			new SqlParameter("@HeirNumber47", heirNumber.HeirNumber47),
			new SqlParameter("@HeirNumber48", heirNumber.HeirNumber48),
			new SqlParameter("@HeirNumber49", heirNumber.HeirNumber49),
			new SqlParameter("@HeirNumber38", heirNumber.HeirNumber38),
			new SqlParameter("@HeirNumber39", heirNumber.HeirNumber39),
			new SqlParameter("@HeirNumber40", heirNumber.HeirNumber40),
			new SqlParameter("@HeirNumber41", heirNumber.HeirNumber41),
			new SqlParameter("@HeirNumber42", heirNumber.HeirNumber42),
			new SqlParameter("@HeirNumber43", heirNumber.HeirNumber43),
			new SqlParameter("@HeirNumber32", heirNumber.HeirNumber32),
			new SqlParameter("@HeirNumber33", heirNumber.HeirNumber33),
			new SqlParameter("@HeirNumber34", heirNumber.HeirNumber34),
			new SqlParameter("@HeirNumber35", heirNumber.HeirNumber35),
			new SqlParameter("@HeirNumber36", heirNumber.HeirNumber36),
			new SqlParameter("@HeirNumber37", heirNumber.HeirNumber37),
			new SqlParameter("@HeirNumber26", heirNumber.HeirNumber26),
			new SqlParameter("@HeirNumber27", heirNumber.HeirNumber27),
			new SqlParameter("@HeirNumber28", heirNumber.HeirNumber28),
			new SqlParameter("@HeirNumber29", heirNumber.HeirNumber29),
			new SqlParameter("@HeirNumber30", heirNumber.HeirNumber30),
			new SqlParameter("@HeirNumber31", heirNumber.HeirNumber31),
			new SqlParameter("@HeirNumber20", heirNumber.HeirNumber20),
			new SqlParameter("@HeirNumber21", heirNumber.HeirNumber21),
			new SqlParameter("@HeirNumber22", heirNumber.HeirNumber22),
			new SqlParameter("@HeirNumber23", heirNumber.HeirNumber23),
			new SqlParameter("@HeirNumber24", heirNumber.HeirNumber24),
			new SqlParameter("@HeirNumber25", heirNumber.HeirNumber25),
			new SqlParameter("@HeirNumber10", heirNumber.HeirNumber10),
			new SqlParameter("@HeirNumber15", heirNumber.HeirNumber15),
			new SqlParameter("@HeirNumber16", heirNumber.HeirNumber16),
			new SqlParameter("@HeirNumber17", heirNumber.HeirNumber17),
			new SqlParameter("@HeirNumber18", heirNumber.HeirNumber18),
			new SqlParameter("@HeirNumber19", heirNumber.HeirNumber19),
			new SqlParameter("@HeirNumber1", heirNumber.HeirNumber1),
			new SqlParameter("@HeirNumber3", heirNumber.HeirNumber3),
			new SqlParameter("@HeirNumber4", heirNumber.HeirNumber4),
			new SqlParameter("@HeirNumber11", heirNumber.HeirNumber11),
			new SqlParameter("@HeirNumber12", heirNumber.HeirNumber12),
			new SqlParameter("@HeirNumber13", heirNumber.HeirNumber13),
			new SqlParameter("@HeirNumber14", heirNumber.HeirNumber14),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("HeirNumber_SearchLike", CommandType.StoredProcedure, parametersHeirNumber))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					HeirNumber tmpHeirNumber = new HeirNumber();
					tmpHeirNumber.HeirNumberID = (row["HeirNumberID"] != DBNull.Value) ? Convert.ToInt64(row["HeirNumberID"]) : 0 ;
					tmpHeirNumber.StageTitle = row["StageTitle"].ToString();
					tmpHeirNumber.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpHeirNumber.HeirNumber2 = (row["HeirNumber2"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber2"]) : 0 ;
					tmpHeirNumber.HeirNumber5 = (row["HeirNumber5"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber5"]) : 0 ;
					tmpHeirNumber.HeirNumber6 = (row["HeirNumber6"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber6"]) : 0 ;
					tmpHeirNumber.HeirNumber7 = (row["HeirNumber7"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber7"]) : 0 ;
					tmpHeirNumber.HeirNumber8 = (row["HeirNumber8"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber8"]) : 0 ;
					tmpHeirNumber.HeirNumber9 = (row["HeirNumber9"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber9"]) : 0 ;
					tmpHeirNumber.HeirNumber68 = (row["HeirNumber68"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber68"]) : 0 ;
					tmpHeirNumber.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
					tmpHeirNumber.HeirNumber62 = (row["HeirNumber62"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber62"]) : 0 ;
					tmpHeirNumber.HeirNumber63 = (row["HeirNumber63"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber63"]) : 0 ;
					tmpHeirNumber.HeirNumber64 = (row["HeirNumber64"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber64"]) : 0 ;
					tmpHeirNumber.HeirNumber65 = (row["HeirNumber65"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber65"]) : 0 ;
					tmpHeirNumber.HeirNumber66 = (row["HeirNumber66"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber66"]) : 0 ;
					tmpHeirNumber.HeirNumber67 = (row["HeirNumber67"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber67"]) : 0 ;
					tmpHeirNumber.HeirNumber56 = (row["HeirNumber56"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber56"]) : 0 ;
					tmpHeirNumber.HeirNumber57 = (row["HeirNumber57"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber57"]) : 0 ;
					tmpHeirNumber.HeirNumber58 = (row["HeirNumber58"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber58"]) : 0 ;
					tmpHeirNumber.HeirNumber59 = (row["HeirNumber59"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber59"]) : 0 ;
					tmpHeirNumber.HeirNumber60 = (row["HeirNumber60"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber60"]) : 0 ;
					tmpHeirNumber.HeirNumber61 = (row["HeirNumber61"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber61"]) : 0 ;
					tmpHeirNumber.HeirNumber50 = (row["HeirNumber50"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber50"]) : 0 ;
					tmpHeirNumber.HeirNumber51 = (row["HeirNumber51"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber51"]) : 0 ;
					tmpHeirNumber.HeirNumber52 = (row["HeirNumber52"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber52"]) : 0 ;
					tmpHeirNumber.HeirNumber53 = (row["HeirNumber53"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber53"]) : 0 ;
					tmpHeirNumber.HeirNumber54 = (row["HeirNumber54"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber54"]) : 0 ;
					tmpHeirNumber.HeirNumber55 = (row["HeirNumber55"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber55"]) : 0 ;
					tmpHeirNumber.HeirNumber44 = (row["HeirNumber44"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber44"]) : 0 ;
					tmpHeirNumber.HeirNumber45 = (row["HeirNumber45"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber45"]) : 0 ;
					tmpHeirNumber.HeirNumber46 = (row["HeirNumber46"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber46"]) : 0 ;
					tmpHeirNumber.HeirNumber47 = (row["HeirNumber47"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber47"]) : 0 ;
					tmpHeirNumber.HeirNumber48 = (row["HeirNumber48"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber48"]) : 0 ;
					tmpHeirNumber.HeirNumber49 = (row["HeirNumber49"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber49"]) : 0 ;
					tmpHeirNumber.HeirNumber38 = (row["HeirNumber38"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber38"]) : 0 ;
					tmpHeirNumber.HeirNumber39 = (row["HeirNumber39"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber39"]) : 0 ;
					tmpHeirNumber.HeirNumber40 = (row["HeirNumber40"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber40"]) : 0 ;
					tmpHeirNumber.HeirNumber41 = (row["HeirNumber41"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber41"]) : 0 ;
					tmpHeirNumber.HeirNumber42 = (row["HeirNumber42"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber42"]) : 0 ;
					tmpHeirNumber.HeirNumber43 = (row["HeirNumber43"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber43"]) : 0 ;
					tmpHeirNumber.HeirNumber32 = (row["HeirNumber32"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber32"]) : 0 ;
					tmpHeirNumber.HeirNumber33 = (row["HeirNumber33"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber33"]) : 0 ;
					tmpHeirNumber.HeirNumber34 = (row["HeirNumber34"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber34"]) : 0 ;
					tmpHeirNumber.HeirNumber35 = (row["HeirNumber35"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber35"]) : 0 ;
					tmpHeirNumber.HeirNumber36 = (row["HeirNumber36"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber36"]) : 0 ;
					tmpHeirNumber.HeirNumber37 = (row["HeirNumber37"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber37"]) : 0 ;
					tmpHeirNumber.HeirNumber26 = (row["HeirNumber26"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber26"]) : 0 ;
					tmpHeirNumber.HeirNumber27 = (row["HeirNumber27"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber27"]) : 0 ;
					tmpHeirNumber.HeirNumber28 = (row["HeirNumber28"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber28"]) : 0 ;
					tmpHeirNumber.HeirNumber29 = (row["HeirNumber29"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber29"]) : 0 ;
					tmpHeirNumber.HeirNumber30 = (row["HeirNumber30"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber30"]) : 0 ;
					tmpHeirNumber.HeirNumber31 = (row["HeirNumber31"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber31"]) : 0 ;
					tmpHeirNumber.HeirNumber20 = (row["HeirNumber20"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber20"]) : 0 ;
					tmpHeirNumber.HeirNumber21 = (row["HeirNumber21"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber21"]) : 0 ;
					tmpHeirNumber.HeirNumber22 = (row["HeirNumber22"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber22"]) : 0 ;
					tmpHeirNumber.HeirNumber23 = (row["HeirNumber23"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber23"]) : 0 ;
					tmpHeirNumber.HeirNumber24 = (row["HeirNumber24"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber24"]) : 0 ;
					tmpHeirNumber.HeirNumber25 = (row["HeirNumber25"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber25"]) : 0 ;
					tmpHeirNumber.HeirNumber10 = (row["HeirNumber10"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber10"]) : 0 ;
					tmpHeirNumber.HeirNumber15 = (row["HeirNumber15"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber15"]) : 0 ;
					tmpHeirNumber.HeirNumber16 = (row["HeirNumber16"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber16"]) : 0 ;
					tmpHeirNumber.HeirNumber17 = (row["HeirNumber17"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber17"]) : 0 ;
					tmpHeirNumber.HeirNumber18 = (row["HeirNumber18"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber18"]) : 0 ;
					tmpHeirNumber.HeirNumber19 = (row["HeirNumber19"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber19"]) : 0 ;
					tmpHeirNumber.HeirNumber1 = (row["HeirNumber1"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber1"].ToString() == "1" || row["HeirNumber1"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpHeirNumber.HeirNumber3 = (row["HeirNumber3"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber3"].ToString() == "1" || row["HeirNumber3"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpHeirNumber.HeirNumber4 = (row["HeirNumber4"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber4"].ToString() == "1" || row["HeirNumber4"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpHeirNumber.HeirNumber11 = (row["HeirNumber11"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber11"].ToString() == "1" || row["HeirNumber11"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpHeirNumber.HeirNumber12 = (row["HeirNumber12"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber12"].ToString() == "1" || row["HeirNumber12"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpHeirNumber.HeirNumber13 = (row["HeirNumber13"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber13"].ToString() == "1" || row["HeirNumber13"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpHeirNumber.HeirNumber14 = (row["HeirNumber14"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber14"].ToString() == "1" || row["HeirNumber14"].ToString().ToLower() == "true" ) ? true : false) : false ;

					listHeirNumber.Add(tmpHeirNumber);
				}
			}
		}

		return listHeirNumber;
	}

}
}
