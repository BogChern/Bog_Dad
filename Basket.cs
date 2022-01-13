using System;

namespace Laba6
{
    class Basket
    {
        public int Price { get; set; }

        public Basket()
        {
            Price = 0;
        }

        public void ChangePrice(int count, int price)
        {
            Price += count * price;
        }

        public void PrintCheck()
        {
            if (Price < 1)
                Console.WriteLine("\nЧек не может быть напечатан: корзина пуста.");
            else
            {
                Console.WriteLine("\nЧек напечатан! Корзина очищена.");
                Price = 0;
            }
        }
    }
}
