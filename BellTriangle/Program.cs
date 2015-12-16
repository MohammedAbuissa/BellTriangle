using System;
using System.Collections.Generic;

namespace BellTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //maximum number of rows to not overflow is 9;
            //initialize the variables
            short i = 0, j = 0, l = 1;
            //read the number of rows
            short n = short.Parse(Console.ReadLine());
            //calculate the number of elements, which will be the size of the array
            n = (short) (n * (n + 1) / 2);
            //shouldn't be in Assembly
            List<short> r = new List<short>();
            //initialize the sequence with 1
            r.Add(1);
            Console.Write(r[0]);
            //start an new row
            R1: Console.WriteLine();
            //increment the size of the row
            l++;
            //realize the size of the row
            i += l;
            //quit if you passed the number of elements
            if (i > n) goto R3;
            //increment the inside row pointer
            j++;
            //copy the last value in the past row inside the first value in the new row
            r.Add(r[j - 1]);
            Console.Write(r[j] +" ");
            //caluculate the rest of the row
            //increment the inside row pointer
            R2: j++;
            //caluculate the new entery
            r.Add((short) (r[j - 1] + r[j - l]));
            Console.Write(r[j] + " ");
            //go to the next row
            if (j == i) goto R1;
            //go to the next element of the row
            goto R2;
            //end of program
            R3: Console.ReadLine();
        }
    }
}
