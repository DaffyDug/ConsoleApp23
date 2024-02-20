using System;

namespace ConsoleApp23
{
    class Pay
    {
        protected float _Many { get; private set; }
        public Pay(float Many)
        {
            _Many = Many;
        }
        public virtual void Buy(float buy)
        {
            if (_Many<=0)
            {
                _Many = 0;
                Console.WriteLine("нету денег, иди работай");
            }
            else
            {
                _Many =- buy;
            }
        }
    }
}
