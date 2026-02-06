using System;

namespace InternetStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Good iPhone12 = new Good("IPhone 12");
            Good iPhone11 = new Good("IPhone 11");

            Warehouse warehouse = new Warehouse();

            Shop shop = new Shop(warehouse);

            warehouse.Deliver(iPhone12, 10);
            warehouse.Deliver(iPhone11, 1);

            Console.WriteLine("ТОВАРЫ НА СКЛАДЕ");
            warehouse.ShowGoods();

            shop.PlaceGoodToCart(iPhone12, 4);
            shop.PlaceGoodToCart(iPhone11, 3);

            Console.WriteLine("ТОВАРЫ В КОРЗИНЕ");
            shop.Cart.ShowGoods();

            Console.WriteLine(shop.Order().Paylink);

            shop.PlaceGoodToCart(iPhone12, 9);
        }
    }
}
