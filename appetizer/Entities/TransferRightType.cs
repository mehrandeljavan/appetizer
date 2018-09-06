using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class TransferRightType
{
	private int transferRightTypeID;
	private string title;
	private List<TransferRight> transferRightList;

	public int TransferRightTypeID
	{
		get
		{
			return transferRightTypeID;
		}
		set
		{
			transferRightTypeID = value;
		}
	}

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

	public List<TransferRight> TransferRightList
	{
		get
		{
			return transferRightList;
		}
		set
		{
			transferRightList = value;
		}
	}

	public List<TransferRight> GetListTransferRight()
	{
		TransferRightList = new TransferRightTypeDBAccess().GetListTransferRight(this.TransferRightTypeID);
		return TransferRightList;
	}

	public bool AddTransferRight(TransferRight transferRight)
	{
		transferRight.TransferRightTypeID = this.TransferRightTypeID;
		TransferRightDBAccess transferRightDBAccess = new TransferRightDBAccess();
		if (transferRightDBAccess.Insert(transferRight)>0)
			return (true);
		return (false);
	}

}
}
