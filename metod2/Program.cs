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
        static void Main(string[] args)
        {

        }
    }
}
