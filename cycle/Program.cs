using System;

namespace cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTry;
            string message;

            Console.Write("Введите количество попыток:");
            countTry = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сообщение:");
            message = Console.ReadLine();

            for (int i = 0; i < countTry; i++) 
            {
                Console.WriteLine("Ваша " + i + " попытка. Ваше сообщение:" + message);
            }
           
        }
    }
}
