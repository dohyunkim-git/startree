using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 8 - 1; j > i; j--)
                    Console.Write(" ");
                for (int j =0 ; j < 2 * i + 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
