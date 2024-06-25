using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = GenerateRandomNumbers(100, 1, 1000);
        List<int> primeNumbers = numbers.Where(IsPrime).ToList();
        List<int> fibonacciNumbers = numbers.Where(IsFibonacci).ToList();

        SaveToFile("prime_numbers.txt", primeNumbers);
        SaveToFile("fibonacci_numbers.txt", fibonacciNumbers);

        PrintStatistics(numbers, primeNumbers, fibonacciNumbers);
    }

    static List<int> GenerateRandomNumbers(int count, int min, int max)
    {
        Random rand = new Random();
        List<int> numbers = new List<int>();
        for (int i = 0; i < count; i++)
        {
            numbers.Add(rand.Next(min, max));
        }
        return numbers;
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    static bool IsFibonacci(int number)
    {
        int a = 0, b = 1;
        while (b < number)
        {
            int temp = b;
            b += a;
            a = temp;
        }
        return number == b || number == 0;
    }

    static void SaveToFile(string filename, List<int> numbers)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (int number in numbers)
            {
                writer.WriteLine(number);
            }
        }
    }

    static void PrintStatistics(List<int> allNumbers, List<int> primeNumbers, List<int> fibonacciNumbers)
    {
        Console.WriteLine("Generated Numbers: " + string.Join(", ", allNumbers));
        Console.WriteLine("Prime Numbers: " + string.Join(", ", primeNumbers));
        Console.WriteLine("Fibonacci Numbers: " + string.Join(", ", fibonacciNumbers));
        Console.WriteLine($"\nTotal Generated Numbers: {allNumbers.Count}");
        Console.WriteLine($"Total Prime Numbers: {primeNumbers.Count}");
        Console.WriteLine($"Total Fibonacci Numbers: {fibonacciNumbers.Count}");
    }
}
