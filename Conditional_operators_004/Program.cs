using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, в которой пользователь вводит целое число. 
/// Программа в свою очередь должна ответить, четным или нечетным является это число, делится ли оно на 3 и делится ли оно на 6.
/// </summary>
namespace Conditional_operators_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int a = int.Parse(Console.ReadLine());

            if(a % 2 == 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
            if(a % 3 == 0 && a!=0)
            {
                Console.WriteLine("divisible by three");
            }
            if(a % 6 == 0 && a != 0)
            {
                Console.WriteLine("divisible by six");
            }
            Console.ReadKey();
        }
    }
}
