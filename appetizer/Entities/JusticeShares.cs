using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class JusticeShares : Heritage
{
	private string registerNumber;
	private int shareNumber;
	private Int64 declarationID;

	public string RegisterNumber
	{
		get
		{
			return registerNumber;
		}
		set
		{
			registerNumber = value;
		}
	}

	public int ShareNumber
	{
		get
		{
			return shareNumber;
		}
		set
		{
			shareNumber = value;
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
