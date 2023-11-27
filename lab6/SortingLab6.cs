using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class SelectionSorts
    {
        public void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j].CompareTo(arr[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                T temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
        public static void PrintArray<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    class InsertionSorts
    {
        public void InsertionSort<T>(T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;

            for (int i = 1; i < n; ++i)
            {
                T key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        public static void PrintArray<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    class CocktailSorts
    {
        public void CocktailSort<T>(T[] arr) where T : IComparable<T>
        {
            bool swapped;
            int start = 0;
            int end = arr.Length - 1;

            do
            {
                swapped = false;
                for (int i = start; i < end; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;

                swapped = false;
                end--;
                for (int i = end - 1; i >= start; i--)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                        swapped = true;
                    }
                }

                start++;

            } while (swapped);
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public static void PrintArray<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    class ShellSorts
    {
        public void ShellSort<T>(T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    T temp = arr[i];
                    int j = i;

                    while (j >= gap && arr[j - gap].CompareTo(temp) > 0)
                    {
                        arr[j] = arr[j - gap];
                        j = j - gap;
                    }
                    arr[j] = temp;
                }

                gap /= 2;
            }
        }
        public static void PrintArray<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
