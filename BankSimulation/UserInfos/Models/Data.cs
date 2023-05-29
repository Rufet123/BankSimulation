using System;
using System.Linq;
using System.Text.RegularExpressions;
using UserInfos.Models.Interfaces;

namespace UserInfos.Models
{
	public class Data:IAdd,IUpdate,IDelete, ICashIn, ICashOut, ICartToCart,IUpdatePhone
	{
		public static User[] Arr = new User[0];
		public Data()
		{
		}
		public static void UpdatePin(string name, string surename, int pin,int cvv)
		{
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].Name.ToLower() == name.ToLower() && Arr[i].SureName.ToLower() == surename.ToLower() && Arr[i].Cvv==cvv)
                {
                    if (pin > 1000 && pin < 10000)
                    {
                        Arr[i].Pin = pin;
                        Console.WriteLine("user pin succesfully update:");
                    }
                    else
                    {
                        Console.WriteLine("pin is not valid");
                    }
                }
                else
                {
                    Console.WriteLine("this user is not valid");
                }

            }
        }
        public static void DeleteUser(string name, string surename,int cvv)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].Name.ToLower() == name.ToLower() && Arr[i].SureName.ToLower() == surename.ToLower() && Arr[i].Cvv==cvv)
                {
                    Arr = Arr.Where(val => val != Arr[i]).ToArray();
                    Console.WriteLine("User is succesfully removed");
                }
                else
                {
                    Console.WriteLine("this user is not valid");
                }
            }
        }
        public static void AddUser(User user)
        {
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = user;
            Console.WriteLine("your cart succesfuly created :");
        }
        public static void CashIn(double amount, string cartNumber,string currency)
        {
            Boolean sended = false;
            if (currency.ToLower()=="usd")
            {
                amount *= 1.7;
            }
            else if (currency.ToLower()=="eur")
            {
                amount *= 2;
            }
            else if (currency.ToLower()=="azn")
            {
                amount *= 1;
            }
            else
            {
                Console.WriteLine("currency is not valid it must be AZN,USD,EUR");
            }
            for (int i = 0; i < Arr.Length; i++)
            {
                if (cartNumber == Arr[i].CartNumbers)
                {
                    Console.WriteLine("please check information is belong to you");
                    Console.WriteLine($"\n{Arr[i].Name}\n{Arr[i].SureName}\n");
                    Arr[i].Ammount += amount;
                    Console.WriteLine("money succesfuly added take check please");
                    sended = true;
                    break;
                }
            }
            if (sended==false)
            {
                Console.WriteLine("cart number is not valid enter form \"xxxx xxxx xxxx xxxx\"");
            }
        }
        public static void CashOut(int amount,string cartNumber)
        {
            bool cash = true;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (cartNumber == Arr[i].CartNumbers)
                {
                    if (amount > Arr[i].Ammount)
                    {
                        cash = false;
                        break;
                    }
                    Arr[i].Ammount -= amount;
                    Console.WriteLine($"your balance:{Arr[i].Ammount}");
                }
            }
            if (cash==false)
            {
                Console.WriteLine($"your balance is less from {amount}");
            }
        }
        public static void CartToCart(int amount,string from,string to)
        {
            Boolean sended = true;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (from == Arr[i].CartNumbers)
                {
                    if (amount > Arr[i].Ammount)
                    {
                        sended = false;
                        break;
                    }
                    Arr[i].Ammount -= amount;
                }
                else if (to == Arr[i].CartNumbers)
                {
                    Arr[i].Ammount += amount;
                    Console.WriteLine($"sent {amount} azn to {Arr[i].CartNumbers} cart numbers: ");
                }
            }
            if (sended==false)
            {
                Console.WriteLine($"your balance is less from {amount}");
            }
        }
        public static void UpdatePhone(string phone,string name,string surename,int pin)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].Name.ToLower() == name.ToLower() & Arr[i].SureName.ToLower() == surename.ToLower() & Arr[i].Pin==pin)
                {
                    string patern = @"^\+994(51|50|55|70|77|99)\d{7}$";
                    if (Regex.IsMatch(phone, patern))
                    {
                        Arr[i].Phone = phone;
                        Console.WriteLine("phone number succesfully update");
                    }
                    else
                    {
                        Console.WriteLine("phone number is not valid phone number example +994XXXXXXXXX");
                    }
                }
            }
        }
    }
}

