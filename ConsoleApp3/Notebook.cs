using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Notebook : IPrice, ISell
    {
        public string Model { get; protected set; }

        public Notebook(string model)
        {
            Model = model;
        }
        public void Sell()
        {
            Console.WriteLine("Ноутбук продан");
        }
        public int PriceNotebook()
        {
            return 50000;
        }
    }
    
}
