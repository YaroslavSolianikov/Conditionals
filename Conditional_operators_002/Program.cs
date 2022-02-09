using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Напишите программу, которая будет рассчитывать процент скидки в зависимости от количества купленного товара.
/// Если куплено больше 3 единиц товара, тогда скидка должна быть 10 процентов от общей суммы, если же количество больше 3 и меньше 7,
/// то 20процентов от общей суммы, иначе, если больше 7 то 25 процентов от общей суммы. Цену товара и купленное количество товара пользователь должен задавать вводом с консоли.
/// </summary>
namespace Conditional_operators_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the price of product: ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of product: ");
            int amount = int.Parse(Console.ReadLine());
            int res = amount * price;

            if (price > 0 && amount > 0)
            {
                if(amount <= 3)
                {
                    Console.WriteLine($"You must pay: {res - res / 100 * 10}");
                }
                else if (amount > 3 && amount < 7)
                {
                    Console.WriteLine($"You must pay: {res - res / 100 * 20}");
                }
                else
                {
                    Console.WriteLine($"You must pay: {res - res / 100 * 25}");
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
