using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class Program
    {
        static int c = 10;
        static int m = 5;
        static int s = 15;
        static bool proverka(int nc, int nm, int ns)
        {
            if (c >= nc && m >= nm && s >= ns)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void prigotovlenie(int nc, int nm, int ns)
        {
            c = c - nc;
            m = m - nm;
            s = s - ns;
            Console.WriteLine($"Напиток готов");
        }
        static void ostatki()
        {
            Console.WriteLine($"Остатки по ингредиентам");
            Console.WriteLine($"Кофе: {c} порций");
            Console.WriteLine($"Молоко: {m} порций");
            Console.WriteLine($"Сахар: {s} порций");
        }
        static void zapravka()
        {
            Console.WriteLine($"Заправка .....");
            c = 10;
            m = 5;
            s = 15;
            Console.WriteLine("Кофемашинка заправлена");
            ostatki();
        }
        static void espresso()
        {
            if (proverka(1, 0, 0))
            {
                prigotovlenie(1, 0, 0);
            }
            else
            {
                Console.WriteLine($"Не хватает ингридиентов");
            }
        }
        static void latte()
        {
            if (proverka(1, 2, 0))
            {
                prigotovlenie(1, 2, 0);
            }
            else
            {
                Console.WriteLine($"Не хватает ингридиентов");
            }
        }
        static void cappuccino()
        {
            if (proverka(1, 1, 0))
            {
                prigotovlenie(1, 1, 0);
            }
            else
            {
                Console.WriteLine($"Не хватает ингридиентов");
            }
        }
        static void sahar()
        {
            if (proverka(0, 0, 1))
            {
                s = s - 1;
                Console.WriteLine($"Сахар добавлен");
            }
            else
            {
                Console.WriteLine($"Не хватает сахара");
            }
        }
        static void Main(string[] args)
        {
            int a = 0;
            while (a != 7)
            {
                Console.WriteLine($"Меню:");
                Console.WriteLine("1. Эспрессо (1 кофе, 0 молока, 0 сахара)");
                Console.WriteLine("2. Латте (1 кофе, 2 молока, 0 сахара)");
                Console.WriteLine("3. Капучино (1 кофе, 1 молоко, 0 сахара)");
                Console.WriteLine("4. Добавить сахар (опционально, можно добавить 1 сахар)");
                Console.WriteLine("5. Показать остатки");
                Console.WriteLine("6. Заправить кофемашину");
                Console.WriteLine("7. Выход");
                Console.Write("Выберите действие: ");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        espresso();
                        break;
                    case 2:
                        latte();
                        break;
                    case 3:
                        cappuccino();
                        break;
                    case 4:
                        sahar();
                        break;
                    case 5:
                        ostatki();
                        break;
                    case 6:
                        zapravka();
                        break;
                    case 7:
                        Console.WriteLine($"Выход из программы");
                        break;
                    default:
                        Console.WriteLine($"Неверный ввод, попробуйте снова");
                        break;
                }
            }
        }
    }
}
