using Indexers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        // Розширте приклад 5 (російсько-англійський словник) ще і українським словником.
        // Реалізуйте можливість пошуку не тільки за ключовими російським словами і словами на інших мовах.



        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Dictionary dic = new Dictionary();    

            while(true)
            {
                Console.Write("Введіть слово: ");
                string word = Console.ReadLine();

                Console.WriteLine(dic[word]);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
