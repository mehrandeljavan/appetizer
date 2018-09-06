using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class HomeFurnishings : Heritage
{
	private string title;
	private Int64 declarationID;

	public string Title
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
