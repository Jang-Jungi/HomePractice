using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5번
{
    class 고양이 : IAnimal
    {
        public string color { get; set; }
        private int age { get; set; }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    this.age = 1;
                }
                else if (value > 15)
                {
                    this.age = 15;
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public void Eat(string message)
        {
            Console.WriteLine($"{message}가 밥을 먹습니다.");
        }

        public void Sleep(string message)
        {
            Console.WriteLine($"{message}가 잠을 잡니다.");
        }

        public void Sound(string message)
        {
            Console.WriteLine($"{message}가 소리를 듣습니다.");
        }

    }
}
