using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePracticeApp14장
{
    class My<T>
    {
        private T[] arr;
        public My()
        {
            arr = new T[3];
        }
        public T this[int i] 
        { 
            get { return arr[i]; } 
            set { if (i >= arr.Length)
                    { 
                    Array.Resize<T> (ref arr, i+1 );
                }
                arr[i] = value;
            }
        }
        public int Length
        {  
            get { return arr.Length; } 
        }
    class Ex14_2
        {
            static void Main2(string[] args)
            {
                My<string> str = new My<string>();
                str[0] = "one"; 
                str[1] = "two";
                str[2] = "three";
                str[3] = "four";
                str[4] = "five";

                for (int i = 0; i < str.Length; i++)
                    Console.WriteLine(str[i]);

                My<int> num = new();
                num[0] = 10;
                num[1] = 20;
                num[2] = 30;
                num[3] = 40;
                num[4] = 50;
                
                for (int i = 0; i < num.Length; i++)
                    Console.WriteLine(num[i]);
            }
        }
    }
}
