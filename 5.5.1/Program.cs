using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5._1
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string text = Console.ReadLine();
            SplitText(text);
            EnterText(SplitText(text));
            
        }
        static string[] SplitText(string text){
           return text.Split();
           
        }
        static void EnterText(string[] split)
        {
            foreach (string s in split)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

        }
        
        
        

    }
    
    
}
