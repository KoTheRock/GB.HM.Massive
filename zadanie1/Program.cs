using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Random rand = new Random();
        int size = 10;
        int[] array = new int[size];
        int countInRange = 0;

        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(1, 101);
            if (array[i] > 19 && array[i] < 91)
            {
                countInRange++;
            }
        }
        Console.Write($"{countInRange} ");
     }
 }
