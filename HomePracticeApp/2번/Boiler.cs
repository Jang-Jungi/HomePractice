using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1번
{
    class Boiler
    {
        private int voltage;
        private int temperature;

        public string Brand {get; set;}
        public int Voltage
        {
            get
            { return this.voltage; }
            set
            {
                try
                {
                    if (value == 110)
                    {
                        this.voltage = 110;
                    }
                    else if (value == 110)
                    {
                        this.voltage = 220;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("다시 입력하세요");
                }
            }
        }
        public int Temperature
        {
            get { return this.temperature; }
            set
            {
                if (value <= 5)
                {
                    this.temperature = 5;
                }
                else if (value >= 70)
                {
                    this.temperature = 70;
                }
                else
                    this.temperature = value;
            }
        }
        public void PrintAll()
        {
            Console.WriteLine($"Brand : {Brand}, Voltage : {this.voltage}, Temperature : {temperature} ");
        }
    }
}
