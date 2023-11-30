using System;

public class Program
{
    public static void Main(string[] args)
    {
        Random rand = new Random();
        int size = 10;
        double[] array = new double[size];
        double result = 0;
      
        for (int i = 0; i < size; i++)
        {
            array[i] = Math.Round(rand.NextDouble() * 100, 2);
        }

        double max = array[0];
        double min = array[0];

        for (int i = 1; i < size; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            else if (array[i] < min)
            {
                min = array[i];
            }
        }
        Console.WriteLine($"Максимальное значение: {max}");
        Console.WriteLine($"Минимальное значение: {min}");
        result = max - min;
        Console.WriteLine($"Результат: {result}");
    }
}