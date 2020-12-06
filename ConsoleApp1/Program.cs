using System;

namespace ConsoleApp1
{
    class Program
    {

        static void BubleSort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[i])
                    {
                        var temp = 0;
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                        for (int k = 0; k < array.Length; k++)
                        {
                            Console.Write(string.Format("{0}-", array[k]));
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 44, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            BubleSort(array);
            Console.WriteLine("Hello World!");
        }
    }
}
