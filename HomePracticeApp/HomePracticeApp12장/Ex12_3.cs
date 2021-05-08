using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePracticeApp12장
{
    class Rect // Rect class 선언
    {
        private int x;
        private int y;

        public int X
        {
            get
            { return x; }
            set
            {
                if (value > 0) { x = value; }

                else
                {
                    Console.WriteLine("양의 정수를 입력하세요");
                }

            }
        }
        public int Y
        {
            get
            { return y; }
            set
            {
                if (value > 0) { y = value; }

                else
                {
                    Console.WriteLine("양의 정수를 입력하세요");
                }
            }
        }
        public Rect(int a, int b){ X = a; Y = b; } // 생성자
        public int Area() { return (this.x * this.y); }

        class Ex12_3
        {
            static void Main3(string[] args)
            {
                Rect r = new Rect(10,2);
                Console.WriteLine($"너비는 {r.Area()} 입니다."); 
            }
        }
    }
}
