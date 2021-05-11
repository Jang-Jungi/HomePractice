using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3번
{
    class Car
    {
        public string Name { get; set; }
        public string Maker { get; set; }
        public string Color { get; set; }
        public int YearNodel { get; set; }
        public int MaxSpeed { get; set; }
        public string UniqueNumber { get; set; }

        public void Start() => Console.WriteLine($"{Name}의 시동을 겁니다.");
        public void Accelerate() { Console.WriteLine($"최대시속 {MaxSpeed}km/h로 가속합니다"); }
        public virtual void Recharge() { Console.WriteLine("달리면서 배터리를 충전합니다"); }
        public void TurnRight() { Console.WriteLine($"{Name}을 우회전합니다"); }
        public void Brake() { Console.WriteLine($"{Name}의 브레이크를 밟습니다"); }
    }
}
