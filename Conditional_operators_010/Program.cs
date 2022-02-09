using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу расчета начисления премий сотрудникам. Премии рассчитываются согласно выслуге лет. 
/// Если выслуга до 5 лет, премия составляет 10% от заработной платы.Если выслуга от 5 лет(включительно) до 10 лет, премия составляет 15% от заработной платы.
///Если выслуга от 10 лет(включительно) до 15 лет, премия составляет 25% от заработной платы.
///Если выслуга от 15 лет(включительно) до 20 лет, премия составляет 35% от заработной платы.
///Если выслуга от 20 лет(включительно) до 25 лет, премия составляет 45% от заработной платы.
///Если выслуга от 25 лет(включительно) и более, премия составляет 50% от заработной платы.Результаты расчета, выведите на экран.
/// </summary>
namespace Conditional_operators_010
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter years");
            int year = int.Parse(Console.ReadLine());
            int salary = 1000;
            if (year >= 0)
            {
                if (year < 5)
                {
                    Console.WriteLine($"your salary is - {salary + salary * 0.1}");
                }
                else if (year >= 5 && year < 10)
                {
                    Console.WriteLine($"your salary is - {salary + salary * 0.15}");
                }
                else if (year >= 10 && year < 15)
                {
                    Console.WriteLine($"your salary is - {salary + salary * 0.25}");
                }
                else if (year >= 15 && year < 20)
                {
                    Console.WriteLine($"your salary is - {salary + salary * 0.35}");
                }
                else if (year >= 20 && year < 25)
                {
                    Console.WriteLine($"your salary is - {salary + salary * 0.45}");
                }
                else
                {
                    Console.WriteLine($"your salary is - {salary + salary * 0.5}");
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
