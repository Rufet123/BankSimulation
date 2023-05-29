using System;
namespace UserInfos.Models.Interfaces
{
	public interface ICartToCart
	{
        public static void CartToCart(int amount, string from, string to)
        {
            Console.WriteLine("cart to cart proses:");
        }
    }
}

