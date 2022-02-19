using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVeryBigSum
{
    class Program
    {
        static void Main(String[] args)
        {
            var finalSum = 0L;
            var x = int.Parse(Console.ReadLine());
            var arrayTemp = Console.ReadLine().Split(' ');
            var array = Array.ConvertAll(arrayTemp, long.Parse);

            for (int i = 0; i < x; i++)
                finalSum += array[i];

            Console.WriteLine(finalSum);
        }
    }
}
