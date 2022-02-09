using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу русско-английский переводчик. Программа знает 10 слов о погоде.
/// Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
/// Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.
/// </summary>
namespace Conditional_operators_009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово о погоде");
            string weather = Convert.ToString(Console.ReadLine());

            switch (weather)
            {
                case "солнечно":
                    Console.WriteLine($"{weather} - sunny");
                    break;
                case "холодно":
                    Console.WriteLine($"{weather} - cold");
                    break;
                case "тепло":
                    Console.WriteLine($"{weather} - warm");
                    break;
                case "прохладно":
                    Console.WriteLine($"{weather} - cool");
                    break;
                case "туман":
                    Console.WriteLine($"{weather} - fog");
                    break;
                case "снежно":
                    Console.WriteLine($"{weather} - snowy");
                    break;
                case "дождливо":
                    Console.WriteLine($"{weather} - rainy");
                    break;
                case "тучно":
                    Console.WriteLine($"{weather} - overcast");
                    break;
                case "облачно":
                    Console.WriteLine($"{weather} - cloudy");
                    break;
                case "жарко":
                    Console.WriteLine($"{weather} - hot");
                    break;
                default:
                    Console.WriteLine("Нету перевода этого слова");
                    break;
            }
            Console.ReadKey();
        }
    }
}
