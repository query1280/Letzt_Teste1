using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r1 = new Random();
            Random r2 = new Random();

            int s1 = r1.Next(1, 9);
            int s2 = r1.Next(10, 18);

            List<int> a = new List<int>();

            for (int i = 1; i <= 9; i++)
            {
                a.Add(r1.Next(1, 9));
                
            }

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(a[i]);
            }

            List<int> b = new List<int>();
        }
    }
}
