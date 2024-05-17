// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)


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
            System.Console.WriteLine($"Массив создан.");
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

        int[] ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
            System.Console.WriteLine($"Массив перевернут.");
            return array;
        }

        System.Console.WriteLine($"Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Введите минимальное значение элемента: ");
        int min = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Введите максимальное значение элемента: ");
        int max = Convert.ToInt32(Console.ReadLine());
        int[] array = CreateArray(size, min, max);
        PrintArray(array);
        ReverseArray(array);
        PrintArray(array);
    }
}