using System.Drawing;

namespace SortAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 6, 8, 2, 4, 6, 9, 2, 4, 0, 1 };

            InnerSort(array);
            PrintArray(array);

            array = new int[] { 6, 8, 2, 4, 6, 9, 2, 4, 0, 1 };
            BubbleSort(array);
            PrintArray(array);

            array = new int[] { 6, 8, 2, 4, 6, 9, 2, 4, 0, 1 };
            ShakerSort(array);
            PrintArray(array);

        }
        static void InnerSort(int[] tab)
        {
            for (int i = 1; i < tab.Length; i++)
            {
                int j = i;
                int temp = tab[j];
                while ((j > 0) && (tab[j - 1] > temp))
                {
                    tab[j] = tab[j - 1];
                    j--;
                }
                tab[j] = temp;
            }
        }

        static void BubbleSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j >= i; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }

        static void ShakerSort(int[] array)
        {
            int size = array.Length;
            int left = 1;
            int right = size - 1;
            int k = size - 1; // ?
            do
            {
                for (int j = right; j >= left; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        k = j; // ?
                    }
                }
                left = k + 1; // ?
                for (int j = left; j <= right; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        k = j; // ?
                    }
                }
                right = k - 1; // ?

            } while (left <= right);

        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.Write("\n");
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}