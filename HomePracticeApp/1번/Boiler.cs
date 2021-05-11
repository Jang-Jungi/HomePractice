using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1번
{
    class Boiler
    {
        public string Brand {get; set;}
        public int Voltage;
        public int Temperature;

        public void PrintAll()
        {
            Console.WriteLine($"Brand : {Brand}, Voltage : {Voltage}, Temperature : {Temperature} ");
        }
    }
}
