using System;
namespace UserInfos.Models.Interfaces
{
	public interface ICashOut
	{
        public static void CashOut(int amount, string cartNumber)
        {
            Console.WriteLine("cash out proses");
        }
    }
}

