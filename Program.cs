using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый массив");

            Console.WriteLine("Введите 1 если хотите ввести одномерный массив, 2 если двумерный");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    int a;
                    Console.WriteLine("Введите количество элементов массива");
                    a = int.Parse(Console.ReadLine());
                    int[] Array = new int[a];
                    Console.WriteLine("Введите " + a + " чисел");
                    for (int i = 0; i < Array.Length; i++)
                    {
                        Console.Write("{0}-е число: ", i + 1);
                        Array[i] = Int32.Parse(Console.ReadLine());
                    }
                    break;

                case "2":
                    int b;
                    int c;
                    Console.WriteLine("Введите количество элементов первого измерения массива");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите количество элементов второго измерения массива");
                    c = int.Parse(Console.ReadLine());
                    int[,] Array2 = new int[b, c];
                    for (int i = 0; i < Array2.GetLength(0); i++)
                    {
                        for (int j = 0; j < Array2.GetLength(1); j++)
                        {
                            Console.WriteLine("Y: " + i + "X: " + j);
                            Array2[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int y = 0; y < Array2.GetLength(0); y++)
                    {
                        for (int x = 0; x < Array2.GetLength(1); x++)
                        {
                            Console.Write(Array2[y, x] + "\t");
                        }
                        Console.WriteLine();
                    }
                    break;

                default:
                    Console.WriteLine("Вы ввели неправильный символ");
                    break;
            }

            Console.WriteLine("Введите подмассив");

            Console.WriteLine("Введите 1 если хотите ввести одномерный массив, 2 если двумерный");
            string selection2 = Console.ReadLine();

            switch (selection2)
            {
                case "1":
                    int a;
                    Console.WriteLine("Введите количество элементов массива");
                    a = int.Parse(Console.ReadLine());
                    int[] Array3 = new int[a];
                    Console.WriteLine("Введите " + a + " чисел");
                    for (int i = 0; i < Array3.Length; i++)
                    {
                        Console.Write("{0}-е число: ", i + 1);
                        Array3[i] = Int32.Parse(Console.ReadLine());
                    }
                    break;

                case "2":
                    int b;
                    int c;
                    Console.WriteLine("Введите количество элементов первого измерения массива");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите количество элементов второго измерения массива");
                    c = int.Parse(Console.ReadLine());
                    int[,] Array4 = new int[b, c];
                    for (int i = 0; i < Array4.GetLength(0); i++)
                    {
                        for (int j = 0; j < Array4.GetLength(1); j++)
                        {
                            Console.WriteLine("Y: " + i + "X: " + j);
                            Array4[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int y = 0; y < Array4.GetLength(0); y++)
                    {
                        for (int x = 0; x < Array4.GetLength(1); x++)
                        {
                            Console.Write(Array4[y, x] + "\t");
                        }
                        Console.WriteLine();
                    }
                    break;

                default:
                    Console.WriteLine("Вы ввели неправильный символ");
                    break;
            }
            public static bool ContainsAtIndex(int[] array, int[] subArray, int index)
            {
                bool contains = true;
                if (subArray.Length > 0)
                {
                    int subLength = subArray.Length;
                    for (int subIndex = 0; subIndex < subLength; subIndex += 1)
                    {
                        if (array[subIndex + index] != subArray[subIndex])
                        {
                            contains = false;
                            break;
                        }
                    }
                }
                return contains;
            }
        }
    }
}
