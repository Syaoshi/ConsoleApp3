using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook qnotebook = new Notebook("Ноутбук ASUS");
            Seller seller = new Seller();
            seller.sell = qnotebook;
            seller.Sell();
            IPrice notebook = new Notebook("Notebook ASUS");
            notebook = new NotebookCase(notebook);
            notebook = new NotebookMouse(notebook);
            Console.WriteLine("Итоговая стоимость" + notebook.PriceNotebook());
        }
    }
}
