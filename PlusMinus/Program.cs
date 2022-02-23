using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace PlusMinus
{
    /*https://www.hackerrank.com/challenges/plus-minus/problem */
    class Program
    {
        static void Main(String[] args)
        {
            var zeroNumbers = 0;
            var negativeNumbers = 0;
            var positiveNumbers = 0;
           
            ReadLine();
            var temp = ReadLine().Split(' ');
            var arr = Array.ConvertAll(temp, Int32.Parse);

            for (int array = 0; array < arr.Length; array++)
            {
                if (arr[array] > 0)
                    ++positiveNumbers;
                else if (arr[array] < 0)
                    ++negativeNumbers;
                else
                    ++zeroNumbers;
            }

            Console.WriteLine((double)positiveNumbers / arr.Length);
            Console.WriteLine((double)negativeNumbers / arr.Length);
            Console.WriteLine((double)zeroNumbers / arr.Length);
        }
    }
}
