using System;

class Program
{
    static void Main()
    {
        int[] data = {115, 182, 191, 31, 196, 1099, 5, 172, 10, 179,
                      83, 21, 20, 21, 186, 177, 195, 193,
                      188, 199, 62, 109, 105, 183, 110};

        Array.Sort(data);

        double Q1 = GetQ1(data);
        double Q3 = GetQ3(data);

        double IQR = Q3 - Q1;

        double low = Q1 - 1.5 * IQR;
        double high = Q3 + 1.5 * IQR;

        Console.WriteLine("Lower Limit = " + low);
        Console.WriteLine("Upper Limit = " + high);
        Console.WriteLine();

        CheckOutliers(data, low, high);
    }

    static double GetQ1(int[] arr)
    {
        return arr[arr.Length / 4];
    }

    static double GetQ3(int[] arr)
    {
        return arr[(3 * arr.Length) / 4];
    }

    static void CheckOutliers(int[] arr, double low, double high)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < low || arr[i] > high)
            {
                Console.WriteLine(arr[i] + " is Outlier");
            }
            else
            {
                Console.WriteLine(arr[i] + " is Normal");
            }
        }
    }
}