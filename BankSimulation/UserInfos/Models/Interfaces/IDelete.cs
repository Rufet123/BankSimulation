using System;
using System.Linq;

namespace UserInfos.Models.Interfaces
{
	public interface IDelete
	{
        public static void DeleteUser(string name, string surename,int cvv)
        {
            Console.WriteLine("delete user cart");
        }
    }
}

