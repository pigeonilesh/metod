using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Program
    {
        static bool dlina(string parol)
        {
            List<char> sb = new List<char>(parol);
            if (sb.Count >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool sifra(string parol)
        {
            List<char> sb = new List<char>(parol);
            bool a = false;
            foreach (var s in sb)
            {
                if(s >= '\u0030' && s <= '\u0039')
                {
                    a = true;
                    break;
                }
                else
                {
                    a = false;
                }
            }
            return a;
        }
        static bool bykva(string parol)
        {
            List<char> sb = new List<char>(parol);
            bool a = false;
            foreach (var s in sb)
            {
                if (s >= '\u0041' && s <= '\u005A')
                {
                    a = true;
                    break;
                }
                else
                {
                    a = false;
                }
            }
            return a;
        }
        static bool vse(string parol)
        {
            return dlina(parol) && sifra(parol) && bykva(parol);
        }
        static void otchet(string parol)
        {
            Console.WriteLine($"Отчет:");
            if (dlina(parol))
            {
                Console.WriteLine($"Длина не меньше 8 символов: +");
            }
            else
            {
                Console.WriteLine($"Длина не меньше 8 символов: -");
            }
            if (sifra(parol))
            {
                Console.WriteLine($"Есть хотя бы одна цифра: +");
            }
            else
            {
                Console.WriteLine($"Есть хотя бы одна цифра: -");
            }
            if (bykva(parol))
            {
                Console.WriteLine($"Есть хотя бы одна заглавная буква: +");
            }
            else
            {
                Console.WriteLine($"Есть хотя бы одна заглавная буква: -");
            }
            Console.WriteLine();
            Console.WriteLine($"Итог: ");
            if (vse(parol))
            {
                Console.WriteLine($"Пароль надежный, можно использовать");
            }
            else
            {
                Console.WriteLine($"Пароль ненадежный, придумайте другой");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите ваш пароль:");
            string parol = Console.ReadLine();
            otchet(parol);
        }
    }
}
