using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            for (count = 1; count <= 99; count++)
            {
                if (count % 2 == 1)
                {
                    Console.WriteLine(count);
                }
            }
        }
    }
}
