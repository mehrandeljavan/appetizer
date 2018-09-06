using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class BourseStock : Heritage
{
	private string hall;
	private string seller;
	private string sheetNumber;
	private string stockNumber;
	private float stockValue;
	private Int64 declarationID;

	public string Hall
	{
		get
		{
			return hall;
		}
		set
		{
			hall = value;
		}
	}

	public string Seller
	{
		get
		{
			return seller;
		}
		set
		{
			seller = value;
		}
	}

	public string SheetNumber
	{
		get
		{
			return sheetNumber;
		}
		set
		{
			sheetNumber = value;
		}
	}

	public string StockNumber
	{
		get
		{
			return stockNumber;
		}
		set
		{
			stockNumber = value;
		}
	}

	public float StockValue
	{
		get
		{
			return stockValue;
		}
		set
		{
			stockValue = value;
		}
	}

	public Int64 DeclarationID
	{
		get
		{
			return declarationID;
		}
		set
		{
			declarationID = value;
		}
	}

}
}
