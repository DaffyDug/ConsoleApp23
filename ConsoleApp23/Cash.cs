using System;
namespace ConsoleApp23
{
    class Cash : Pay
    {
        public Cash(float Many) : base(Many)
        {

        }
        public override void Buy(float buy)
        {
            base.Buy(_Many);
            if (_Many < buy)
            {
                Console.WriteLine("Забыл сдачу");
            }
            else
            {
                Console.WriteLine("Забрал сдачу");
            }

        }
    }
}
