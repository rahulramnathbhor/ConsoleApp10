using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedExample
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 5; i >=1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j.ToString());
                }
                Console.WriteLine();
            }
        }




    }
}

