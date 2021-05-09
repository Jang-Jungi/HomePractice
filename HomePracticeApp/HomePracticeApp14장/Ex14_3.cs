using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePracticeApp14장
{
    class Arr1<T> where T : struct
    {
        public T[] arr { get; set; }
        public Arr1 (int s)
        {
            arr = new T[s];
        }
    }
    class Ex14_3
    {
        static void Main3(string[] args)
        {
            Arr1<int> a = new(3);
            a.arr[0] = 10;
            a.arr[1] = 20;
            a.arr[2] = 30;
            for (int i = 0; i < 3; i++)
                Console.WriteLine(a.arr[i]);
        }
    }
}
