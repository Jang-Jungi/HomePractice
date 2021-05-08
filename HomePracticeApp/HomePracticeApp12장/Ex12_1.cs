using System;

namespace HomePracticeApp12장
{
    class Employee // Employee class 선언
    {
        private string name;
        private int age;

        public string Name { get { return name; } set { name = value; } }  // name get, set
        public int Age { get { return age; } set { age = value; } } // age get, set
    }
    class Ex12_1
    {
        static void Main(string[] args)
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
