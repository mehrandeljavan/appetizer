using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class WeddingIndex_Old
{
	private int weddingYear;
	private int title;
	private float indexValue;

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

}
}
