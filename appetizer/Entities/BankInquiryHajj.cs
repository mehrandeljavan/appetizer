using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class BankInquiryHajj
{
	private int bankInquiryHajjID;
	private string title;
	private List<Hajj> hajjList;

	public int BankInquiryHajjID
	{
		get
		{
			return bankInquiryHajjID;
		}
		set
		{
			bankInquiryHajjID = value;
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

	public List<Hajj> HajjList
	{
		get
		{
			return hajjList;
		}
		set
		{
			hajjList = value;
		}
	}

	public List<Hajj> GetListHajj()
	{
		HajjList = new BankInquiryHajjDBAccess().GetListHajj(this.BankInquiryHajjID);
		return HajjList;
	}

	public bool AddHajj(Hajj hajj)
	{
		hajj.BankInquiryHajjID = this.BankInquiryHajjID;
		HajjDBAccess hajjDBAccess = new HajjDBAccess();
		if (hajjDBAccess.Insert(hajj)>0)
			return (true);
		return (false);
	}

}
}
