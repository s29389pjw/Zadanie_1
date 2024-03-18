using System;

public class AverageCalculator
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty", nameof(numbers));
        }
        
        double sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Length;
    }
    
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(numbers);
        Console.WriteLine($"The average is: {average}");
    }
}