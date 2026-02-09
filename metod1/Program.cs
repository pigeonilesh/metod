using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod1
{
    internal class Program
    {
        static int Sum()
        {
            Console.WriteLine($"Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            return sum;
        }
        static int Vach()
        {
            Console.WriteLine($"Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int vach = num1 - num2;
            return vach;
        }
        static int Ym()
        {
            Console.WriteLine($"Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int ym = num1 * num2;
            return ym;
        }
        static int Del()
        {
            Console.WriteLine($"Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int del = num1 / num2;
            return del;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");
            Console.WriteLine("Выбирете действие (+, -, *, /)");
            string vvod = Console.ReadLine();
            switch (vvod)
            {
                case "+":
                    Console.WriteLine(Sum());
                    break;
                case "-":
                    Console.WriteLine(Vach());
                    break;
                case "*":
                    Console.WriteLine(Ym());
                    break;
                case "/":
                    Console.WriteLine(Del());
                    break;
                default:
                    Console.WriteLine($"Неверный ввод");
                    break;
            }
        }
    }
}
