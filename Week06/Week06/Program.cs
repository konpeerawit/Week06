using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int i = 0;
            int[] numbers = new int[6];
            ask (numbers[i]);
            answer(numbers);

        }
        static int ask(int n, int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter numbers {0}", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            return n;
        }
        static double answer(int n, int[] numbers)
        {
            for (int i = 0; i < 7; i++)
            {
                if ((numbers[i] % 7) = 0)
                {
                    Console.Write("");
                }
            }
            return n;

        }
    }
}
