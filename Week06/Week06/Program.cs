﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    class Program
    {
        static void Main()
        {
            object[] myObjArray = { 2, 'b', 1000.05d, "Hello World" };
            useParams(myObjArray);
            useParams("IE.Tech.", "KMITL", 2017);
            Console.ReadLine();
        }

        static void useParams(params object[] list)
        {
            foreach (object o in list)
                Console.Write(o + " ");
            Console.WriteLine();
        }

    }
}
