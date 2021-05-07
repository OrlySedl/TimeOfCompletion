using System;
using System.Collections.Generic;

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

        static int[] StackStockSpan(int[] quotes)
        {
            int[] spans = new int[quotes.Length];
            spans[0] = 1;
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            for (int i = 1; i < quotes.Length; i++)
            {
                while (stack.Count != 0 && quotes[stack.Peek()] <= quotes[i])
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    spans[i] = i + 1;
                }
                else
                {
                    spans[i] = i - stack.Peek()
                }
                stack.Push(i);
            }
            return spans;
        }
    }
}
