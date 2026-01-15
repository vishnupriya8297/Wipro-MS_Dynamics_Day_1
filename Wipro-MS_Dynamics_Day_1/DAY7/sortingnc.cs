using System;

namespace SortingAlgorithms
{
    class Program
    {
        // -------- Counting Sort Method --------
        static void CountingSort(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];

            int[] count = new int[max + 1];

            // Count occurrences
            for (int i = 0; i < arr.Length; i++)
                count[arr[i]]++;

            // Rebuild sorted array
            int index = 0;
            for (int i = 0; i <= max; i++)
            {
                while (count[i] > 0)
                {
                    arr[index++] = i;
                    count[i]--;
                }
            }
        }

        // -------- Radix Sort Method --------
        static void RadixSort(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                int n = arr.Length;
                int[] output = new int[n];
                int[] count = new int[10];

                // Count digits
                for (int i = 0; i < n; i++)
                    count[(arr[i] / exp) % 10]++;

                // Cumulative count
                for (int i = 1; i < 10; i++)
                    count[i] += count[i - 1];

                // Build output array (stable)
                for (int i = n - 1; i >= 0; i--)
                {
                    int digit = (arr[i] / exp) % 10;
                    output[count[digit] - 1] = arr[i];
                    count[digit]--;
                }

                // Copy back
                for (int i = 0; i < n; i++)
                    arr[i] = output[i];
            }
        }

        // -------- Main Method --------
        static void Main(string[] args)
        {
            int[] countArr = { 4, 2, 2, 8, 3, 1 };
            Console.WriteLine("Counting Sort:");
            Console.WriteLine("Before: " + string.Join(", ", countArr));
            CountingSort(countArr);
            Console.WriteLine("After : " + string.Join(", ", countArr));

            Console.WriteLine();

            int[] radixArr = { 170, 45, 75, 90, 802, 24, 2, 66 };
            Console.WriteLine("Radix Sort:");
            Console.WriteLine("Before: " + string.Join(", ", radixArr));
            RadixSort(radixArr);
            Console.WriteLine("After : " + string.Join(", ", radixArr));
        }
    }
}
