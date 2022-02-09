using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, в которой создайте переменную min. Значение переменной должен задавать пользователь,
/// интервал допустимых значений 0 до 59, необходимо организовать проверку на ввод допустимого интервала.
/// Определите в какую четверть часа попадает значение переменной (в первую, вторую, третью или четвертую).
/// </summary>
namespace Conditional_operators_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number [0,59]: ");
            int min = int.Parse(Console.ReadLine());

            if(min >= 0 && min < 60)
            {
                if(min >= 0 && min < 15)
                {
                    Console.WriteLine("first quarter ");
                }
                else if (min >= 15 && min < 30)
                {
                    Console.WriteLine("second quarter ");
                }
                else if (min >= 30 && min < 45)
                {
                    Console.WriteLine("third quarter");
                }
                else
                {
                    Console.WriteLine("fourth quarter");
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
