using System;
namespace UserInfos.Models
{
	public class User:CartInfos
	{
		public double Ammount { get; set; } = 0;
		public User(string name,string surename,string phone):base(name,surename,phone)
		{
		}
		
		
	}
}

