using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod2
{
    internal class Program
    {
        static int CountWords(string text)
        {
            string[] words = text.Split(new char[] {' ', '.', ',', '!', ':', ';', '?'}, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        static int CountsSymbolWithoutSpaces(string text)
        {
            int counter = 0;
            foreach (char t in text)
            {
                if (t != ' ')
                {
                    counter++;
                }
            }
            return counter;
        }
        static string SearchVeryLongWords(string text)
        {
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', ':', ';', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string verylong = "";
            foreach (string word in words)
            {
                if (word.Length > verylong.Length)
                {
                    verylong = word;
                }
            }
            return verylong;
        }
        static bool IsItQuestion(string text)
        {
            string clearText = text.Trim();
            if (clearText.Length == 0)
            {
                return false;
            }
            return clearText[clearText.Length - 1] == '?';
        }
        static void ynicslov(string text)
        {
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', ':', ';', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> slova= new Dictionary<string, int>();
            foreach(string w in words)
            {
                if (!slova.ContainsKey(w))
                {
                    slova.Add(w, 1);
                }
                else
                {
                    slova[w]++;
                }
            }
            Console.WriteLine($"Все уникальные слова и их количество");
            foreach (var s in slova)
            {
                Console.WriteLine($"{s.Key} - {s.Value}");
            }
        }
        static void ton(string text)
        {
            List<string> poz = new List<string>()
            {
                "отлично", "прекрасно", "замечательно", "супер", "круто", "шикарно", "нравится", "обожаю", "восхищаюсь", "радует", "счастье", "лучший", "отличный", "качественный", "надежный", "удобный", "стильный", "выгодно", "идеально", "достойно", "спасибо", "благодарю", "признателен", "обязательно", "с удовольствием", "от души", "на высоте", "шедевр"
            };
            List<string> neg = new List<string>()
            {
                "ужасно", "кошмар", "отвратительно", "бесит", "раздражает", "ненавижу", "расстроен", "жаль", "обидно", "надоело", "плохой", "худший", "дешевый", "грязный", "сломанный", "битый", "бракованный", "неудобный", "страшный", "не работает", "сломалось", "не пришло", "обманули", "развод", "ошибка", "сбой", "тормозит", "виснет", "не понравился", "не подошел", "не рекомендую", "зря потратил"
            };
            string[] words = text.ToLower().Split(new char[] { ' ', '.', ',', '!', ':', ';', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int kpoz = 0;
            int kneg = 0;
            foreach (string w in words)
            {
                if (poz.Contains(w))
                {
                    kpoz++;
                }
                if (neg.Contains(w))
                {
                    kneg++;
                }
            }
            if (kpoz == kneg)
            {
                Console.WriteLine("Нейтральный текст");
            }
            else if (kpoz > kneg)
            {
                Console.WriteLine("Текст позитивный");
            }
            else
            {
                Console.WriteLine("Текст негативный");
            }
        }
        static void Main(string[] args)
        {
            int a = 0;
            string text = "";
            while (a != 8)
            {
                Console.WriteLine($"Меню");
                Console.WriteLine($"1. Ввести текст");
                Console.WriteLine($"2. Подсчет слов в тексте");
                Console.WriteLine($"3. Подсчет символов (без пробелов)");
                Console.WriteLine($"4. Поиск самого длинного слова");
                Console.WriteLine($"5. Проверка предложения на вопросительность");
                Console.WriteLine($"6. Подсчет уникальных слов");
                Console.WriteLine($"7. Определения тона текста");
                Console.WriteLine($"8. Выход");
                Console.Write($"Выберите действие: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (a)
                {
                    case 1:
                        Console.WriteLine($"Введите текст в одну строчку (если ранее вы уже записывали текст, то он перезапишется)");
                        text = Console.ReadLine();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine($"Количество слов в тексте : {CountWords(text)}");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine($"Количество символов в тексте: {CountsSymbolWithoutSpaces(text)}");
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine($"Самое длинное слово в тексте: {SearchVeryLongWords(text)}");
                        Console.WriteLine();
                        break;
                    case 5:
                        if (IsItQuestion(text))
                        {
                            Console.WriteLine($"Предложение вопросительное");
                        }
                        else
                        {
                            Console.WriteLine($"Предложение невопросительное");
                        }
                        Console.WriteLine();
                        break;
                    case 6:
                        ynicslov(text);
                        Console.WriteLine();
                        break;
                    case 7:
                        ton(text);
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.WriteLine($"Выход из программы");
                        break;
                    default:
                        Console.WriteLine($"Неверный ввод, попробуйте еще раз");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
