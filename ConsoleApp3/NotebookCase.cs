using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class NotebookCase : IPrice
    {
        public IPrice Notebook { get; set; }

        public NotebookCase(IPrice notebook)
        {
            Notebook = notebook;
        }

        public int PriceNotebook()
        {
            Console.WriteLine("Добавлен чехол");
            return Notebook.PriceNotebook() + 5000;
        }
    }
}
