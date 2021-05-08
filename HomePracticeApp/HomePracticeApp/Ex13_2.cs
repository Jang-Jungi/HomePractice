using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePracticeApp
{
    class Ex13_2
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("System.Array");

            int[] score = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("배열의 타입 : {0}",score.GetType());           
            Console.WriteLine("배열의 베이스타입 : {0}",score.GetType().BaseType);
        }
    }
}
