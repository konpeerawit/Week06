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
            double w = 0d;
            ask(ref w);
            calculate(ref w);
            Console.WriteLine("Weight on Moon is : {0}", w);
            Console.ReadKey();
                    }
                static double ask(ref double w)
        {
            Console.Write("Enter weight on Moon : ");
           w = double.Parse(Console.ReadLine());
            return w;

       }
        static double calculate(ref double w)
        {
            w *= 1.6;
            return w;
        }
    }
}
