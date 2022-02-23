using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        /*https://www.hackerrank.com/challenges/staircase/problem?isFullScreen=true&h_r=next-challenge&h_v=zen*/
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                var spaces = new String(' ', x - i);
                var hashes = new String('#', i);
                Console.WriteLine(spaces + hashes);
            }
        }
    }
}
