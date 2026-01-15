//sorting in c# 

namespace SortingDemo
{
    class Program
    {
        // Bubble Sort is a process of sorting in which each pair of adjacent elements is compared and the elements are swapped if they are not in order.
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            //here i is for number of passes
            for (int i = 0; i < n - 1; i++)
            {
                //here j is for number of comparisons in each pass
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //here temp is for holding the value while swapping
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

// Insertion Sort is a simple sorting algorithm that builds the final sorted array (or list) one item at a time.
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
// creting a method for selecton sort
//selecton sort is a process of sorting in which the smallest element is selected from the unsorted array and swapped with the leftmost unsorted element, and that element becomes a part of the sorted array.
static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Swap the found minimum element with the first element
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Bubble Sort:");
            Console.WriteLine("Unsorted: " + string.Join(", ", arr1));
            BubbleSort(arr1);
            Console.WriteLine("Sorted:   " + string.Join(", ", arr1));

            Console.WriteLine();

            int[] arr2 = { 12, 11, 13, 5, 6 };
            Console.WriteLine("Insertion Sort:");
            Console.WriteLine("Unsorted: " + string.Join(", ", arr2));
            InsertionSort(arr2);
            Console.WriteLine("Sorted:   " + string.Join(", ", arr2));
            //selection sort
            int[] arr3 = { 64, 25, 12, 22, 11 };
            Console.WriteLine("Selection Sort:");
            Console.WriteLine("Unsorted: " + string.Join(", ", arr3));
            SelectionSort(arr3);
            Console.WriteLine("Sorted:   " + string.Join(", ", arr3));
        }
    }
}