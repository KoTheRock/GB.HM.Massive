using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Random rand = new Random();
        int num;
        int tempNumber = rand.Next(0, 100001);
             
       
        int digitCount = 1;
        int temp = tempNumber;
        while (temp != 0)
        {
            temp /= 10;
            digitCount ++;
        }

        int[] array = new int [digitCount];
        
        num = tempNumber;
        for (int i = digitCount - 1; i >= 0; i--)
        {
            array[i] = num % 10;
            num /= 10;
        }
        Console.WriteLine("Массив цифр числа:");
        foreach (var digit in array)
        {
        Console.Write($"{digit} ");
        }
    }
}
            