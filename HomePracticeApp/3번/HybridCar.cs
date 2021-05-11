using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3번
{
    class HybridCar : ElecticCar
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int YearNodel { get; set; }
        public int MaxSpeed { get; set; }
        public string UniqueNumber { get; set; }

        public override void Start() // virtual을 써주어야 자식 클래스에서 정의가 된다.
        {
            base.Start();
            Console.WriteLine($"{this.Name} 고양이 {this.Color}이(가) ZZ잡니다!");
        }
    }
}
