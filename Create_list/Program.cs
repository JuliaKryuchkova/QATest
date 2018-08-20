using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
            Char delimiter = ' ';
            String[] words = text.Split(delimiter);
            foreach (var substring in words)
            {
                count = ++count;
                Console.WriteLine(count + ". " + substring);            
            }
            Console.ReadKey();
        }
    }
}
