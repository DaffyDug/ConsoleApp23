using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            float many = 21312.213f;
            Cash pay = new Cash(many);
            Pay_Player pay_player = new Pay_Player(pay);
            pay_player.Pay_Product(21.54f);
        }
    }
}
