using System;
namespace ConsoleApp23
{
    class Pay_Player
    {
        Pay _pay;
        public Pay_Player(Pay pay)
        {
            _pay = pay;
        }
        public void Pay_Product(float cost)
        {
            _pay.Buy(cost);
            Console.WriteLine("вы купили продукт");
        }
    }

}
