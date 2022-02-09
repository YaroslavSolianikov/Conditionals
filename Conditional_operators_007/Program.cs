using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу - консольный калькулятор. Создайте две переменные с именами operand1 и operand2.
/// Задайте переменным некоторые произвольные значения. Предложите пользователю ввести знак арифметической операции. 
/// Примите значение введенное пользователем и поместите его в строковую переменную sign. 
/// Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
/// Выведите на экран результат выполнения арифметической операции. В случае использования операции деления, организуйте проверку попытки деления на ноль.
/// И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.
/// </summary>
namespace Conditional_operators_007
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 1th number");
                double operand1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2th number");
                double operand2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter sign (+,-,*,/,%)");
                char sign = char.Parse(Console.ReadLine());
               
                switch (sign)
                {
                    case '+':
                        Console.WriteLine($"result:{operand1+operand2}");
                        break;
                    case '-':
                        Console.WriteLine($"result:{operand1 - operand2}");
                        break;
                    case '*':
                        Console.WriteLine($"result:{operand1 * operand2}");
                        break;
                    case '/' when operand2 !=0:
                        //if(operand2 !=0)
                            Console.WriteLine($"result:{operand1 / operand2}");
                        //else
                            //Console.WriteLine("operand2 == 0!");
                        break;
                    case '%':
                        Console.WriteLine($"result:{operand1 % operand2}");
                        break;
                    default:
                        Console.WriteLine("incorrect sign");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
