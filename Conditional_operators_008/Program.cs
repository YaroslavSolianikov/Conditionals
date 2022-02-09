using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100].
/// Если да, то укажите, в какой именно промежуток.
/// Если пользователь указывает число не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.
/// </summary>
namespace Conditional_operators_008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = int.Parse(Console.ReadLine());

            if (a>=0 && a < 15)
            {
                Console.WriteLine("[0-14]");
            }
            else if (a >= 15 && a < 36)
            {
                Console.WriteLine("[15-35]");
            }
            else if (a >= 36 && a < 51 )
            {
                Console.WriteLine("[36-50]");
            }
            else if (a >= 51 && a < 101)
            {
                Console.WriteLine("[51-100]");
            }
            else
            {
                Console.WriteLine("no one");
            }
            Console.ReadKey();
        }
    }
}
