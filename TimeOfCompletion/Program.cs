using System;

namespace TimeOfCompletion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int[] SimpleStockSpan(int[] quotes)
        {
            int[] spans = new int[quotes.Length];
            for (int i = 0; i < quotes.Length; i++)
            {
                int k = 1;
                bool spanEnd = false;
                while (i - k >= 0 && !spanEnd)
                {
                    if (quotes[i - k] <= quotes[i])
                    {
                        k = k + 1;
                    }
                    else
                    {
                        spanEnd = true;
                    }
                }
                spans[i] = k;
            }
            return spans;
        }
    }
}
