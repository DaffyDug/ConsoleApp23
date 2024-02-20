using System;
namespace ConsoleApp23
{
    class Non_Cash : Pay
    {
        public Non_Cash(float Many) : base(Many)
        {

        }
        public override void Buy(float buy)
        {
            Console.Write("Обращение к серверу \n Передача запроса \n Получение ответа \n ");
            base.Buy(_Many);
        }
    }

}
