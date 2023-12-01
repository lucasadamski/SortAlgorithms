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

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}