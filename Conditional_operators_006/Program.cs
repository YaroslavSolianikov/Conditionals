using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, которая определяет, является ли год високосным. Пользователь вводит год.
/// Программа должна вывести на экран ответ, является ли год високосным.
/// Подсказка. Обычно каждый год, который делится на 4, — это високосный год, кроме лет столетий (делящихся на 100).
/// Но среди последних год, делящийся на 400, также считается високосным.
/// </summary>
namespace Conditional_operators_006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year:");
            int year = int.Parse(Console.ReadLine());

            if (year >= 0)
            {
                if ((year % 4 == 0 && year % 100 != 0) ^ year % 400 == 0)
                {
                    Console.WriteLine($"{year} leap year");
                }
                else
                {
                    Console.WriteLine($"{year} not leap year");
                }
            }
            else
            {
                Console.WriteLine("incorrect input");
            }
            Console.ReadKey();
        }
    }
}
