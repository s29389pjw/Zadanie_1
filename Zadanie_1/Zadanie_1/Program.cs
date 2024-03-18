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
        foreach (int number2 in numbers)
        {
            sum += number2;
        }
        return sum / numbers.Length;
    }
    public static int CalculateMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty", nameof(numbers));
        }
        
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    
    
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(numbers);
        Console.WriteLine($"The average is: {average}");
        int max = CalculateMax(numbers);
        Console.WriteLine($"The maximum value is: {max}");
    }
}