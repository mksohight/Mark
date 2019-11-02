using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, lol = 0;
            for (int x = -1; x <= 3; x++)
            {
                sum += x;
                lol++;
            }
            Console.WriteLine(sum / lol);
            Console.ReadKey();
            
        }
    }
}