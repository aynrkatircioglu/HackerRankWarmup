using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Program
    {
        /* https://www.hackerrank.com/challenges/birthday-cake-candles/problem?isFullScreen=true&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen */
        static void Main(string[] args)
        {
            Console.WriteLine();
            var tempHeight = Console.ReadLine().Split(' ');
            var height = Array.ConvertAll(tempHeight, int.Parse);
            var maxValue = height[0];
            var maxValueOccurence = 1;

            for (int i = 1; i < height.Length; i++)
            {
                if (height[i] == maxValue)
                {
                    maxValueOccurence++;
                    continue;
                }
                if (height[i] > maxValue)
                {
                    maxValue = height[i];
                    maxValueOccurence = 1;
                }
            }
            Console.WriteLine(maxValueOccurence);
        }
    }
}
