using System.Diagnostics.Metrics;

namespace laba2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Задание 1
            Console.Write("Число:");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
                Console.WriteLine("Число не чётное");


            //Задание 2
            Console.Write("Пароль ");
            string a = Console.ReadLine();
            Console.Write("Подтверждение пароля ");
            string b = Console.ReadLine();
            if (a == b)
            {
                Console.WriteLine("Пароль принят");
            }
            else
                Console.WriteLine("Пароль не принят");
            //Задание 3
            Console.Write("Число:");
            int a = int.Parse(Console.ReadLine());
            if (a / 1000 + a % 10 == a / 100 % 10 - a / 10 % 10)
            {
                Console.WriteLine("ДА");
            }
            else
                Console.WriteLine("НЕТ");
            //Задание 4
            Console.Write("Возраст:");
            int a = int.Parse(Console.ReadLine());
            if (a >= 18)
            {
                Console.WriteLine("Доступ разрешен");
            }
            else
                Console.WriteLine("Доступ запрещен");
        }
    }
}
