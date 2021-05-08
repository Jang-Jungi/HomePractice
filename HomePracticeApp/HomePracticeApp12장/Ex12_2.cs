using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePracticeApp12장
{
    class Employee1 // Employee class 선언
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Ex12_2
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Property의 개념");
            Employee obj = new();  // obj 객체 생성
            obj.Name = "홍길동";
            obj.Age = 20;
            Console.WriteLine($"이름은 : {obj.Name }");
            Console.WriteLine($"나이는 : {obj.Age }");
        }
    }
}
