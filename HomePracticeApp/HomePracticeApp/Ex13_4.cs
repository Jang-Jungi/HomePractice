using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePracticeApp
{
    class Ex13_4
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("가변 배열 행렬");

            int[][] array = new int[3][];
            array[0] = new int[6] { 1, 2, 3, 4, 5, 6 };
            array[1] = new int[] { 11,22,33 };
            array[2] = new int[] { 44,55,66,77 };

            foreach (int[] a in array)
            {
                Console.WriteLine("크기는 : {0}", a.Length);
                foreach (int  b in a)
                {
                    Console.Write("{0}, ", b);
                }
                Console.WriteLine();
            }
        }
    }
}
 
