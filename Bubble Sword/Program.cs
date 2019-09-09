using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {

        static int[] arrayToSort = { 14, 65, 63, 1, 54, 89, 84, 9, 98, 57, 71, 18, 21, 84, 69, 28, 11, 83, 13, 42, 64, 58, 78, 82, 13, 9, 96, 14, 39, 89, 40, 32, 51, 85, 48, 40, 32, 51, 85, 48, 40, 23, 15, 94, 93, 35, 81, 1, 9, 43, 39, 15, 17, 97, 52 };


        static int start = 0;
        static int temp = 0;
        static int loops = 0;
        static int swaps = 0;

        static void Main(string[] args)
        {

            //OptimizedBubbleSort(arrayToSort);
            CocktailShakerSort(arrayToSort);


            Console.ReadKey();
        }

        public static void OptimizedBubbleSort(int[] arrayToSort)
        {
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(Convert.ToString(arrayToSort[i]) + " ");
            }
            int length = arrayToSort.Length;

            for (int sort = 0; sort < arrayToSort.Length - 1; sort++)
            {
                
                for (int i = 0; i < length - 1; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        temp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = temp;
                        swaps++;
                        
                     
                    }
                    loops++;

                }
                length--;
            }


            Console.WriteLine();
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(Convert.ToString(arrayToSort[i]) + " ");

            }
            Console.WriteLine();
            Console.WriteLine("Bubble Sort");
            Console.WriteLine("Loops: " + loops);
            Console.WriteLine("Swaps: " + swaps);
        }


        public static void CocktailShakerSort(int[] arrayToSort)
        {
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(Convert.ToString(arrayToSort[i]) + " ");
            }
            int length = arrayToSort.Length;

            for (int sort = 0; sort < arrayToSort.Length - 1; sort++)
            {

                for (int i = 0; i < start + 1; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        temp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = temp;
                        swaps++;


                    }
                    loops++;

                }
                start++;
            }


            Console.WriteLine();
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(Convert.ToString(arrayToSort[i]) + " ");

            }
            Console.WriteLine();
            Console.WriteLine("Cocktail Shaker");
            Console.WriteLine("Loops: " + loops);
            Console.WriteLine("Swaps: " + swaps);
        }
    }
}
