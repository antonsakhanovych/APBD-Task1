﻿// See https://aka.ms/new-console-template for more information
class Hello
{
    static double getAverage(int[] arr)
    {
        double sum = 0;
        for (int d = 0; d < arr.Length; d++) {
            sum += arr[d];
        }
        return sum / arr.Length;
    }

    static int getMax(int[] arr)
    {
        int max = arr [0];
        for (int i = 1; i < arr.Length; i++) {
            if (max < arr[i]) {
                max = arr [i];
            }
        }
        return max;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string sNumber = "s26776";
        int age = 20;
        for (int i = 0; i < 3; i++) {
            Console.WriteLine(sNumber + " loves APBD! and " + sNumber + " is " + age + " years old." );
        }
        int[] numbers = [1, 99, 2, 3, 1010, 5, 8, 10];
        Console.Write("[ ");
        Console.Write(String.Join(" ", numbers));
        Console.WriteLine(" ]");
        Console.WriteLine("Average: " + getAverage(numbers));
        Console.WriteLine("Max: " + getMax(numbers));
    }
}
