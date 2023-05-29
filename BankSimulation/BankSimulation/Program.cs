using System;
using UserInfos;
using UserInfos.Models;
namespace BankSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" add cart account press 0");
                Console.WriteLine("delete cart account press 1");
                Console.WriteLine("update cart account press 2");
                Console.WriteLine("cash in pres 3");
                Console.WriteLine("cash out press 4");
                Console.WriteLine("cart to cart press 5");
                Console.WriteLine("update phone number press 6");
                Console.WriteLine("show your cart info press 7");
                Console.WriteLine("proses was finshed press 8");
                Console.WriteLine("if you are admin enter 9 and show all infos");
                int select = Convert.ToInt32(Console.ReadLine());
                if (select==8)
                {
                    Console.WriteLine("proses was finshed");
                    break;
                }
                else if(select==0)
                {
                    Console.WriteLine("enter name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter surename");
                    string surename = Console.ReadLine();
                    Console.WriteLine("enter phone number must bu +994XXXXXXXXX format");
                    string phone = Console.ReadLine();
                    User user = new User(name,surename,phone);
                    Data.AddUser(user);
                }
                else if (select==1)
                {
                    Console.WriteLine("enter your name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter  your surename");
                    string surename = Console.ReadLine();
                    Console.WriteLine("enter your security code");
                    int cvv = Convert.ToInt32(Console.ReadLine());
                    Data.DeleteUser(name, surename, cvv);
                }
                else if (select==2)
                {
                    Console.WriteLine("enter your name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your surename");
                    string surename = Console.ReadLine();
                    Console.WriteLine("enter your secutiry code");
                    int cvv = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter new pin code for update your pin");
                    int pin = Convert.ToInt32(Console.ReadLine());
                    Data.UpdatePin(name, surename, pin, cvv);
                }
                else if (select==3)
                {
                    Console.WriteLine("Enter the amount you want to deposit");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter your cart number:it must  be xxxx xxxx xxxx xxxx format");
                    string cartNo = Console.ReadLine();
                    Console.WriteLine("enter currency and it must be AZN,EUR,USD");
                    string currency = Console.ReadLine();
                    Data.CashIn(amount, cartNo, currency);
                }
                else if (select==4)
                {
                    Console.WriteLine("Enter the amount you want to withdraw");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter your cart number:it must  be xxxx xxxx xxxx xxxx format");
                    string cartNo = Console.ReadLine();
                    Data.CashOut(amount, cartNo);
                }
                else if (select==5)
                {
                    Console.WriteLine("enter amount which you want to sent");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter your cart number:it must  be xxxx xxxx xxxx xxxx format");
                    string from = Console.ReadLine();
                    Console.WriteLine("Enter the recipient's card number:it must  be xxxx xxxx xxxx xxxx format");
                    string to = Console.ReadLine();
                    Data.CartToCart(amount, from, to);
                }
                else if (select==6)
                {
                    Console.WriteLine("if you want to update your old phone number enter your new phone number ");
                    Console.WriteLine("phone number format +994XXXXXXXXX");
                    string phoneNumber = Console.ReadLine();
                    Console.WriteLine("enter your name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your surename");
                    string surename = Console.ReadLine();
                    Console.WriteLine("enter your pin code");
                    int pin = Convert.ToInt32(Console.ReadLine());
                    Data.UpdatePhone(phoneNumber, name, surename, pin);
                }
                else if (select==7)
                {
                    Console.WriteLine("enter your name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your surename");
                    string surename = Console.ReadLine();
                    Infos.UserInfo(name, surename);
                }
                else if (select==9)
                {
                    Console.WriteLine("enter admin password");
                    string password = Console.ReadLine();
                    Infos.AllInfos(password);
                }
            }
           
        }
    }
}

