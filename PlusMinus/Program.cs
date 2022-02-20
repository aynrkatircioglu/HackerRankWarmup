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

            for (int arr_i = 0; arr_i < arr.Length; arr_i++)
            {
                if (arr[arr_i] > 0)
                    ++positiveNumbers;
                else if (arr[arr_i] < 0)
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
