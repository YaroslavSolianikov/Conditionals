using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application. Напишите программу, в которой создайте переменную a.
/// Значение переменной, а должен задавать пользователь. Если а < 10 то выведите 'Верно', иначе (a>10) выведите 'Неверно'.
/// </summary>
namespace Conditional_operators_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int a = int.Parse(Console.ReadLine());

            bool res = a < 10 ? true : false;
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
