using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Seller
    {
        public ISell sell;

        public void Sell()
        {
            sell.Sell();
        }
        public void Sell1()
        {
            Console.WriteLine("Ноутбук продан");
        }

    }
}
