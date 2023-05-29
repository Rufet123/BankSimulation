using System;
namespace UserInfos.Models
{
	public class Infos
	{
        private static string _adminPassword = "Rufet123";
        public Infos()
		{

		}
        public static void UserInfo(string name, string surename)
        {
            for (int i = 0; i < Data.Arr.Length; i++)
            {
                if (Data.Arr[i].Name.ToLower() == name.ToLower() && Data.Arr[i].SureName.ToLower() == surename.ToLower())
                {
                    Console.WriteLine($"\n ID:{Data.Arr[i].Id}\n user name {Data.Arr[i].Name}\nuser surename:{Data.Arr[i].SureName}");
                    Console.WriteLine($"cart numbers:{Data.Arr[i].CartNumbers}\nphone number:{Data.Arr[i].Phone}\npin:{Data.Arr[i].Pin}");
                    Console.WriteLine($"security code:{Data.Arr[i].Cvv}\nvalidity period:{Data.Arr[i].Date}\nAmount:{Data.Arr[i].Ammount}");
                }
            }
        }
        public static void AllInfos(string password)
        {
            if (password == _adminPassword)
            {
                for (int i = 0; i < Data.Arr.Length; i++)
                {
                    Console.WriteLine($"\nuser name:{Data.Arr[i].Name}\nuser surename:{Data.Arr[i].SureName}\nuser phone number:{Data.Arr[i].Phone}\n");
                }
            }
        }
    }
}

