using System;

namespace HomePracticeApp14장
{
    class Ex14_1
    {

        static void Copy<T>(T[]source, T[]target)
        {
            Console.WriteLine("Generic Programming");

            for (int i = 0; i < source.Length; i++)
            target[i] = source[i];
        }
        static void Main1(string[] args)
        {
            int[] s = { 10, 20, 30, 40, 50 };
            int[] t = new int[s.Length];
            Copy<int>( s,t);

            foreach (int item in t)
            
                Console.WriteLine(item);
                string[] s2 = { "one", "two", "three", "four", "five" };
                string[] t2 = new string[s2.Length];
                Copy<string>(s2, t2);

            foreach (string item in t2)
                 Console.WriteLine(item);
        }
    }
}
