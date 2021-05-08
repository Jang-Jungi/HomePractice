using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePracticeApp
{
    class Ex13_3
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("2차원 배열 행렬");

            int[,] array = new int[2,3] { { 10, 20, 30 }, { 40, 50 , 60 } };
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                    sum += array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("합은 {0}",sum);
        }
    }
}
