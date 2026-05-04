using System;

class Program
{
    static void Main()
    {
        int[] numbers = {115, 182, 191, 31, 196, 1099, 5, 172, 10, 179,
                         83, 21, 20, 21, 186, 177, 195, 193,
                         188, 199, 62, 109, 105, 183, 110};

        int n = numbers.Length;

        // Sorting
        Array.Sort(numbers);

        // Mean
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];
        }

        double mean = sum / n;

        // Median
        double median;
        if (n % 2 == 0)
        {
            median = (numbers[n / 2] + numbers[(n / 2) - 1]) / 2.0;
        }
        else
        {
            median = numbers[n / 2];
        }

        // Mode (simple method)
        int mode = numbers[0];
        int maxCount = 1;

        for (int i = 0; i < n; i++)
        {
            int count = 0;

            for (int j = 0; j < n; j++)
            {
                if (numbers[j] == numbers[i])
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                mode = numbers[i];
            }
        }

        // Variance
        double variance = 0;

        for (int i = 0; i < n; i++)
        {
            variance += Math.Pow(numbers[i] - mean, 2);
        }

        variance = variance / n;

        // Standard Deviation
        double stdDev = Math.Sqrt(variance);

        // Range
        int range = numbers[n - 1] - numbers[0];

        // Quartiles
        double Q2 = median;
        double Q1 = numbers[n / 4];
        double Q3 = numbers[(3 * n) / 4];

        // Interquartile Range
        double IQR = Q3 - Q1;

        // Percentiles
        double P20 = numbers[(int)(0.20 * n)];
        double P50 = numbers[(int)(0.50 * n)];

        Console.WriteLine("Mean = " + mean);
        Console.WriteLine("Median = " + median);
        Console.WriteLine("Mode = " + mode);
        Console.WriteLine("Variance = " + variance);
        Console.WriteLine("Standard Deviation = " + stdDev);
        Console.WriteLine("Range = " + range);

        Console.WriteLine("P20 = " + P20);
        Console.WriteLine("P50 = " + P50);

        Console.WriteLine("Q1 = " + Q1);
        Console.WriteLine("Q2 = " + Q2);
        Console.WriteLine("Q3 = " + Q3);

        Console.WriteLine("Interquartile Range = " + IQR);

        Console.WriteLine("Summation = " + sum);
    }
}