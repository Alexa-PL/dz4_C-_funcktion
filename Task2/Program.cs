// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System;
class Program
{
    public static void Main()
    {
        int[] CreateArray(int size, int min, int max) //функция создания массива
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(min, max);
            }
            return array;
        }

        void PrintArray(int[] array) // функция печати массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write(array[i] + " ");
            }
            System.Console.WriteLine();
        }

        int CountEvenNum(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        System.Console.WriteLine($"Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int min = 100;
        int max = 999;
        int[] array = CreateArray(size,min,max);
        System.Console.Write($"В массиве из целых 3-х значных чисел: "); 
        PrintArray(array);
        System.Console.Write($"четных чисел найдено в количестве {CountEvenNum(array)} штук.");

    }
}