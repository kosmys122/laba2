using System.Diagnostics.Metrics;

namespace laba2
{
    internal class Program
    {
        static int health = 100;
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
            //Задание 5
            Console.Write("Число1 ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Число2 ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }
            //Задание 6
            Console.Write("Число1 ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Число2 ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Операция ");
            string c = Console.ReadLine();
            if (c == "+")
            {
                Console.WriteLine($"{a}{c}{b}={a + b}");
            }
            if (c == "-")
            {
                Console.WriteLine($"{a}{c}{b}={a - b}");
            }
            if (c == "*")
            {
                Console.WriteLine($"{a}{c}{b}={a * b}");
            }
            if (c == "/")
            {
                Console.WriteLine($"{a}{c}{b}={a / +b}");
            }
            //Задание 7
            Console.Write("Порядковый номер ");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверк");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }
            //Задание 8
            Console.Write("Число1 ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Число2 ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Операция ");
            string c = Console.ReadLine();
            switch (c)
            {
                case "+":
                    Console.WriteLine($"{a}{c}{b}={a + b}");
                    break;
                case "-":
                    Console.WriteLine($"{a}{c}{b}={a - b}");
                    break;
                case "*":
                    Console.WriteLine($"{a}{c}{b}={a * b}");
                    break;
                case "/":
                    Console.WriteLine($"{a}{c}{b}={a / +b}");
                    break;
            }
            //Задание 9
            Console.Write("Число ");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Лёгкий");
                    break;
                case 2:
                    Console.WriteLine("Средний");
                    break;
                case 3:
                    Console.WriteLine("Сложный");
                    break;
            }
            //Задание 10
            Console.WriteLine($"Здоровье персонажа: {health}");
            TakeDamage(30);
        }
        static void TakeDamage(int damage)
        {
            health -= damage;
            Console.WriteLine($"Персонаж получил {damage} урона. Текущее здоролье: {health}.");
        }
        //Задание 11
        Console.Write("Выберите персонажа ");
        string a = Console.ReadLine();
        switch (a)
        {
            case "воин" or "разбойник" or "паладин" or "варвар":
                Console.WriteLine("Ближний бой");
                break;
            case "маг" or "охотник" or "друид" or "жрец":
                Console.WriteLine("Дальний бой");
                break;





                   //Задание 12
            //Console.Write("Число1 ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Число2 ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Число3 ");
            //int c = int.Parse(Console.ReadLine());
            //int f = 0;
            //if (a>0)
            //{
            //    f = f + a;
            //}
            //if (b > 0)
            //{
            //    f = f + b;
            //}
            //if (c > 0)
            //{
            //    f = f + c;
            //}
            //Console.WriteLine(f);





        }

}
}
