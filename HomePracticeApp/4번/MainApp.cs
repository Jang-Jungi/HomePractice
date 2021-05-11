using System;

namespace _4번
{
    class MainApp
    {
        static void Main(string[] args)
        {

            무지개[] 무지개1 =
            {

            new 무지개(){ Color="Purple", 색깔="보라색"},
                new 무지개() { Color = "Indigo", 색깔 = "남색" },
                new 무지개() { Color = "Blue", 색깔 = "파란색" },
                new 무지개() { Color = "Green", 색깔 = "초록색" },
                new 무지개() { Color = "Yellow", 색깔 = "노란색" },
                new 무지개() { Color = "Orange", 색깔 = "주황색" },
                new 무지개() { Color = "Red", 색깔 = "빨간색" }
            };
            Console.WriteLine("무지개 색은 빨간색, 주황색, 노란색, 초록색, 파란색, 남색, 보라색, 입니다.");
            Console.WriteLine();
            Console.WriteLine("Key 와 Value 확인");

            foreach (var item in 무지개1)
            {
                Console.WriteLine($"{item.Color}은 {item.색깔} 입니다.");
            }
        }
    }
}
