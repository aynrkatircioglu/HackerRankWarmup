using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        /* https://www.hackerrank.com/challenges/time-conversion/problem?isFullScreen=true&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen */
        static void Main(string[] args)
        {
            var time = Console.ReadLine();
            var pmOrAm = time.Substring(8);
            var hourComponent = time.Substring(0, 2);
            var remainingTime = time.Substring(2, 6);

            if (pmOrAm == "AM" && hourComponent == "12")
            {
                hourComponent = "00";
            }
            else if (pmOrAm == "PM")
            {
                var numericHour = int.Parse(hourComponent);
                if (numericHour != 12)
                {
                    hourComponent = Convert.ToString(12 + numericHour);
                }
            }
            Console.WriteLine(hourComponent + remainingTime);
        }
    }
}
