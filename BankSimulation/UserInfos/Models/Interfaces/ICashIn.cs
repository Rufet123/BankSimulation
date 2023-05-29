using System;
namespace UserInfos.Models.Interfaces
{
	public interface ICashIn
	{
        public static void CashIn(double amount, string cartNumber, string currency)
        {
            Console.WriteLine("cash in proses:");
        }
    }
}

