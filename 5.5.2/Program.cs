using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string text = Console.ReadLine();
            Console.WriteLine(ReversWords(text));
            Console.ReadKey();
        }
        static string ReversWords(string text)
        {
            string[] WordArray = SplitText(text);
            string ResultString = "";
            foreach (string NewString in WordArray.Reverse())
            {
                ResultString += NewString + " ";
            }
            return ResultString;

        }
        static string[] SplitText(string text)
        {
            return text.Split(' ');
        }

    }
}
