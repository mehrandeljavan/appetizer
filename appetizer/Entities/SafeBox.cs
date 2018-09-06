using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class SafeBox : Heritage
{
	private Int64 declarationID;
	private string boxNumber;
	private string place;
	private string agent;
	private string inquiry;

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

	public string BoxNumber
	{
		get
		{
			return boxNumber;
		}
		set
		{
			boxNumber = value;
		}
	}

	public string Place
	{
		get
		{
			return place;
		}
		set
		{
			place = value;
		}
	}

	public string Agent
	{
		get
		{
			return agent;
		}
		set
		{
			agent = value;
		}
	}

	public string Inquiry
	{
		get
		{
			return inquiry;
		}
		set
		{
			inquiry = value;
		}
	}

}
}
