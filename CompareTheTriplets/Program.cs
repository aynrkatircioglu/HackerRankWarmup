using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(String[] args)
        {
            var array_a0 = Console.ReadLine().Split(' ');
            var a0 = int.Parse(array_a0[0]);
            var a1 = int.Parse(array_a0[1]);
            var a2 = int.Parse(array_a0[2]);
            var array_b0 = Console.ReadLine().Split(' ');
            var b0 = int.Parse(array_b0[0]);
            var b1 = int.Parse(array_b0[1]);
            var b2 = int.Parse(array_b0[2]);

            int aliceTotalScore = 0;
            int bobTotalScore = 0;
            if (a0 > b0)
                aliceTotalScore++;
            else if (b0 > a0)
                bobTotalScore++;

            if (a1 > b1)
                aliceTotalScore++;
            else if (b1 > a1)
                bobTotalScore++;

            if (a2 > b2)
                aliceTotalScore++;
            else if (b2 > a2)
                bobTotalScore++;

            Console.WriteLine(aliceTotalScore + " " + bobTotalScore);
        }
    }
}
