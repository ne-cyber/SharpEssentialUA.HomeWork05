using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        // Потрібно: Створити масив розмірністю N елементів,
        // заповнити його довільними цілими значеннями.
        // Вивести найбільше значення масиву,
        // найменше значення масиву,
        // загальну суму елементів,
        // середнє арифметичне всіх елементів,
        // вивести всі непарні значення.

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            const int N = 12;
            int[] array = new int[N];

            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }

            // Вивід елементів масиву
            Console.Write("Масив елеметів: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.WriteLine();


            // Пошук максимального значення
            int max = array.Max();
            //або 
            //int[] sortedArray = new int[N];
            //array.CopyTo(sortedArray, 0);
            //Array.Sort(sortedArray);
            //int max = sortedArray[N - 1];

            Console.WriteLine($"Найбільше значення масиву: {max}");

            // Пошук мінімального значення
            int min = array.Min();
            //або 
            //int min = sortedArray[0];
            Console.WriteLine($"Найменше значення масиву: {min}");

            // Сума
            int sum = array.Sum();
            //або
            //int sum = 0;
            //Array.ForEach(array, elm => { sum += elm; });
            //Console.WriteLine($"Загальна сума елементів: {sum}");

            // Середнє значення
            double avarage = array.Average();
            //або
            //double avarage;
            //avarage = (double)sum / N;
            //Console.WriteLine($"Середне аріфметичне всіх елементів: {avarage}");

            // Непарні числа
            int[] oddArray = array.Where(elm => { return (elm % 2 != 0 ? true : false); }).ToArray();
            Console.Write("Непарні значення: ");
            for (int i = 0; i < oddArray.Length; i++)
            {
                Console.Write(oddArray[i]);
                Console.Write(" ");
            }

            Console.ReadKey();
        }
    }
}
