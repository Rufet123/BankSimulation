using System;
using System.Text.RegularExpressions;

namespace UserInfos.Models
{
	public abstract class CartInfos
	{
		public int Id { get; private set; } = 0;
		public string Name { get; set;}
		public string SureName { get; set;}
		public string CartNumbers { get; private set; } 
		public DateTime Date { get; private set; }
        public int Pin { get; internal set; } = 101;
        public int Cvv { get; private set; } = 101;
        public string Phone { get; internal set; }
        
		public CartInfos(string name,string surename,string phone)
		{
			this.Name = name;
			this.SureName = surename;
            AddId();
            AddCartNumber();
            AddDate();
            AddPin();
            AddCvv();
            AddPhone(phone);
		}
        public void AddPhone(string phone)
        {
            string patern = @"^\+994(51|50|55|70|77|99)\d{7}$";
            if (Regex.IsMatch(phone, patern))
            {
                this.Phone = phone;
                Console.WriteLine("phone number succesfully added");
            }
            else
            {
                Console.WriteLine("phone number is not valid phone number example +994XXXXXXXXX");
            }
        }
        public void AddCvv()
        {
            Boolean find = false;
            Random randCvv = new Random();
            
            while (find == false)
            {
                this.Cvv = randCvv.Next(100, 1000);
                for (int i = 0; i < Data.Arr.Length; i++)
                {

                    if (this.Cvv == Data.Arr[i].Cvv)
                    {
                        find = true;

                    }

                }
                if (find == false)
                {
                    break;
                }
            }
        }
        public void AddPin()
        {
            Boolean find = false;
            Random randPin = new Random();
            
            while (find==false)
            {
                this.Pin = randPin.Next(100, 1000);
                for (int i = 0; i < Data.Arr.Length; i++)
                {
                    
                    if (this.Pin == Data.Arr[i].Pin)
                    {
                        find = true;
                        
                    }
                    
                }
                if (find==false)
                {
                    break;
                }
            }
        }
        public void AddDate()
        {
            Random randYear = new Random();
            Random randMonth = new Random();
            Random randDay = new Random();
            int year = randYear.Next(2024, 2030);
            int month = randMonth.Next(1, 13);
            int day = randDay.Next(1, 32);
            this.Date=new DateTime(year, month, day);
        }
		public void AddCartNumber()
		{
            Boolean find = false;
            Random cartNumberPart = new Random();
            
            
            while (find == false)
            {
                int numberPart1 = cartNumberPart.Next(10000000, 100000000);
                string strNumber1 = Convert.ToString(numberPart1);
                int numberPart2 = cartNumberPart.Next(10000000, 100000000);
                string strNumber2 = Convert.ToString(numberPart2);
                string sum = strNumber1 + strNumber2;
                for (int j = 0; j < sum.Length; j++)
                {
                    this.CartNumbers += sum[j];
                    if ((j + 1) % 4 == 0)
                    {
                        this.CartNumbers += " ";
                    }

                }
                for (int i = 0; i < Data.Arr.Length; i++)
                {

                    if (this.CartNumbers == Data.Arr[i].CartNumbers)
                    {
                        find = true;

                    }

                }
                if (find == false)
                {
                    break;
                }
            }
        }
		public void AddId()
		{
            Random randId = new Random();
            Boolean find = false;

            while (find == false)
            {
                this.Id = randId.Next(100, 1000);
                for (int i = 0; i < Data.Arr.Length; i++)
                {

                    if (this.Id == Data.Arr[i].Id)
                    {
                        find = true;

                    }

                }
                if (find == false)
                {
                    break;
                }
            }
        }
		public CartInfos()
		{

		}
	}
}

