using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        Console.WriteLine("Enter the number of random values you want to generate: \n");
        int count = int.Parse(Console.ReadLine());

        int[] numbers = new int[count];
        for (int i = 0; i < count; i++)
        {
            numbers[i] = r.Next(1, 100);
        }

        Console.WriteLine("\nHere's your numbers:\n");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");

        Console.WriteLine($"Total of the numbers array = {Add(numbers)} \n");
        Console.WriteLine($"Product of the numbers array = {Multiply(numbers)}");
    }

    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }

    static int Multiply(params int[] numbers)
    {
        int total = 1; // Initialize total to 1 for multiplication
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }
}