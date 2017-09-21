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
            int H, M1, M2;
            Console.Write("Enter height : ");
            H = int.Parse(Console.ReadLine());
            Console.Write("Enter long1 : ");
            M1 = int.Parse(Console.ReadLine());
            Console.Write("Enter long2 : ");
            M2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Trapezoid Area is : " + ans(H, M1, M2));
            Console.ReadKey();
                    }
        static double ans(int H, int M1, int M2)
        {
            return (0.5 * (M1 + M2) * H);
        }
    }
}
