using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_4_3_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            foreach (var item in arr)
            {
                if (item > 0)
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
