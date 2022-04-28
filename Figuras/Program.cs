using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
     class Program
    {
        static void Main(string[] args) { 

            Fabrica fabrica = new Fabrica();

            fabrica.mostrarFiguras();

            Console.ReadKey();
        }
    }
}
