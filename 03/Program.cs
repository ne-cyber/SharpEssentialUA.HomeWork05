using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        // Потрібно: Створити клас MyMatrix, який забезпечує надання матриці довільного розміру
        // з можливістю зміни числа рядків і стовпців.
        // Написати програму, яка виводить на екран матрицю
        // і похідні від неї матриці різних порядків.

        class MyMatrix
        {
            private int[,] matrix;

            public MyMatrix(int rows, int columns)
            {
                matrix = new int[rows, columns];
            }

            public MyMatrix()
                : this(0, 0) { }

            public int Rows
            {
                get { return matrix.GetLength(0); }
                set
                {
                    Resize(value, this.Columns);
                }
            }

            public int Columns
            {
                get { return matrix.GetLength(1); }
                set
                {
                    Resize(this.Rows, value);
                }
            }

            public int this[int i, int j]
            {
                get
                {
                    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
                        return matrix[i, j];
                    else
                    {
                        Console.WriteLine("спроба звернення за межи масиву");
                        return default;
                    }
                }
                set
                {
                    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
                        matrix[i, j] = value;
                    else
                        Console.WriteLine("спроба запису за межи масиву");

                }
            }

            private void Resize(int rows, int cols)
            {
                var newArray = new int[rows, cols];

                for (int i = 0; i < Math.Min(rows, matrix.GetLength(0)); i++)
                    for (int j = 0; j < Math.Min(cols, matrix.GetLength(1)); j++)
                        newArray[i, j] = matrix[i, j];

                matrix = newArray;
            }
        }




        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(4, 4);
            MyFillMatrix(matrix);
            ShowMatrix(matrix);
            Console.WriteLine(new string('-', 30));


            matrix.Rows = 10;
            matrix.Columns = 5;
            ShowMatrix(matrix);
            Console.WriteLine(new string('-', 30));


            matrix.Rows = 3;
            matrix.Columns = 2;
            ShowMatrix(matrix);
            Console.WriteLine(new string('-', 30));


            Console.ReadKey();
        }

        static void ShowMatrix(MyMatrix m)
        {
            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Columns; j++)
                {
                    Console.Write($"{m[i, j],2}");
                }
                Console.WriteLine();
            }
        }

        static void MyFillMatrix(MyMatrix m)
        {
            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Columns; j++)
                {
                    m[i, j] = (int)Math.Sqrt(i * i + j * j);
                }
            }
        }
    }
}
