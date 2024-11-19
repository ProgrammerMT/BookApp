using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookController controller = new BookController();
            controller.Run();
        }
    }
}
