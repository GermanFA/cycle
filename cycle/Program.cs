using System;

namespace cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTray;
            string message;

            Console.Write("Введите количество попыток:");
            countTray = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сообщение:");
            message = Console.ReadLine();


            for (int i = 0; i < countTray; i++) 
            {
                Console.WriteLine("Ваша " + i + " попытка. Ваше сообщение:" + message);

            }
           
        }
    }
}
