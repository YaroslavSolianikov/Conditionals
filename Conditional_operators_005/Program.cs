using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, которая решает квадратное уравнение. Пользователь должен ввести коэффициенты а, b и с квадратного уравнения ах2 + bх + с = 0.
/// После чего программа должна вывести на экран все корни этого уравнения или сообщение о том, что их нет.
/// Рассмотреть случаи когда дискриминант (D) квадратного уравнения > 0, когда D<0 и когда D = 0.
/// </summary>
namespace Conditional_operators_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            int c = int.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0)
            {
                double x = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"first solution {x} ");

                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"second solution {x2} ");
            }
            else if (D == 0)
            {
                double x = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"solution {x} ");
            }
            else
            {
                Console.WriteLine("no solutions D<0");
            }
            Console.ReadKey();
        }
    }
}
