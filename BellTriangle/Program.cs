using System;
using System.Collections.Generic;

namespace BellTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //maximum number of rows to not overflow is 9;
            short i = 0, j = 0, l = 1;
            short n = short.Parse(Console.ReadLine());
            n = (short) (n * (n + 1) / 2);
            List<short> r = new List<short>();
            r.Add(1);
            Console.Write(r[0]);
            R1: Console.WriteLine();
            l++;
            i += l;
            if (i > n) goto R3;
            j++;
            r.Add(r[j - 1]);
            Console.Write(r[j] +" ");
            R2: j++;
            r.Add((short) (r[j - 1] + r[j - l]));
            Console.Write(r[j] + " ");
            if (j == i) goto R1;
            goto R2;
            R3: Console.ReadLine();
        }
    }
}
