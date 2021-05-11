using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3번
{
    class Car
    {
        public virtual void Start() => Console.WriteLine($"아이오닉의 시동을 겁니다.");
        public void Accelerate() { Console.WriteLine($"최대시속 220km/h로 가속합니다"); }
        public void TurnRight() { Console.WriteLine($"아이오닉을 우회전합니다"); }
        public void Brake() { Console.WriteLine($"아이오닉의 브레이크를 밟습니다"); }
    }
}
