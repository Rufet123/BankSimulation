using System;
namespace UserInfos.Models
{
	public interface IUpdate
	{
        public static void UpdatePin(string name, string surename, int pin)
        {
            Console.WriteLine("update user");
        }

    }
}

