using System;
using System.Text.RegularExpressions;

namespace UserInfos.Models.Interfaces
{
	public interface IUpdatePhone
	{
        public static void UpdatePhone(string phone, string name, string surename, int pin)
        {
            Console.WriteLine("update Phone number");
        }
    }
}

