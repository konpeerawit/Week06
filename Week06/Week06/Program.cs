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
            ask(ref n);
            answer(n);
            Console.ReadKey();
        }
        static int ask(ref int n)
        { 
          Console.Write("Enter number : ");
          n = int.Parse(Console.ReadLine());
          return n;
        }
        static int answer(int n)
        {
          Console.WriteLine("This number is : " + (n % 2 > 0 ? "Odd number" : "Even number"));
          return n;
        }
            
    }
    
}
