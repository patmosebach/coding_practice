using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            int[] a = { 1, 2, 3, 4, 5, 6, 0, 0, 0, 0 };
            int[] b = { 7, 8, 9, 10 };
            p.SortedMerge(a, b);

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        //
        public int[] SortedMerge(int[] a, int[] b)
        {
            int resultIndex = a.Length - 1;
            int bIndex = b.Length - 1;
            int aIndex = resultIndex - b.Length;

            while(resultIndex > 0)
            {
                if (bIndex == 0 || !(aIndex == 0) || a[aIndex] > b[bIndex] )
                {
                    //place a
                    a[resultIndex--] = a[aIndex--];
                }
                else {
                    //place b
                    a[resultIndex--] = b[bIndex--];
                }
            }

            PrintArray(a);
            return a;
        }

        static void PrintArray(int[] var)
        {
            for(int i = 0; i < var.Length; i++)
            {
                Console.WriteLine(var[i]);
            }
        }
    }
}