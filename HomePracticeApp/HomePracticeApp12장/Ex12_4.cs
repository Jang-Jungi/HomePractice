using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePracticeApp12장
{
    class Ex12_4
    {
        static void Main4(string[] args)
        {
            var a = new { name = "홍길동", age = 20 };
            Console.WriteLine($"이름 : {a.name}, 나이 : {a.age}");

            var b = new { title = "성적",  score = new int[] { 99 ,91 , 95 } };
            Console.Write("{0} ", b.title);

            foreach (var s in b.score)

            Console.Write("{0} ", s);
        }
    }
}
