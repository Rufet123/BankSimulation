using System;
namespace UserInfos.Models
{
	public interface IAdd
	{
        public static void AddUser(User user)
        {
            Console.WriteLine("add new user");
        }
    }
}

