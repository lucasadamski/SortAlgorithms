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

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.Write("\n");
        }
    }
}