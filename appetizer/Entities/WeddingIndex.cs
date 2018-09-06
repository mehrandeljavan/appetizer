using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class WeddingIndex
{
	private int weddingYear;
	private int title;
	private float indexValue;
	private List<Dowry> dowryList;

	public int WeddingYear
	{
		get
		{
			return weddingYear;
		}
		set
		{
			weddingYear = value;
		}
	}

	public int Title
	{
		get
		{
			return title;
		}
		set
		{
			title = value;
		}
	}

	public float IndexValue
	{
		get
		{
			return indexValue;
		}
		set
		{
			indexValue = value;
		}
	}

	public List<Dowry> DowryList
	{
		get
		{
			return dowryList;
		}
		set
		{
			dowryList = value;
		}
	}

	public List<Dowry> GetListDowry()
	{
		DowryList = new WeddingIndexDBAccess().GetListDowry(this.WeddingYear);
		return DowryList;
	}

	public bool AddDowry(Dowry dowry)
	{
		dowry.WeddingYear = this.WeddingYear;
		DowryDBAccess dowryDBAccess = new DowryDBAccess();
		if (dowryDBAccess.Insert(dowry)>0)
			return (true);
		return (false);
	}

}
}
