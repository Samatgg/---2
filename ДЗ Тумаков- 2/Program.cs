using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_Тумаков__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Упражнение 2.1 - Имя пользователя и приветствие
            Console.WriteLine("Упр 2.1 - Имя пользователя и приветствие");
            Console.WriteLine("Введите свое имя");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name + "!");

            // Упражнение 2.2 - Два числа, результат деления, исключение - деление на ноль
            Console.WriteLine("Упр 2.2 - Два числа, результат деления, исключение - деление на ноль");
            Console.WriteLine("Введите первое число");
            double firstvalue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondvalue = double.Parse(Console.ReadLine());
            double result = firstvalue / secondvalue;
            if (secondvalue != 0)
            {
                Console.WriteLine("Результат деления чисел = " + result);
            }
            else
            {
                Console.WriteLine("Число нельзя делить на ноль!");
            }
        }
    }
}
