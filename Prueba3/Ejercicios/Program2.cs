using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Cola pila = new Cola();

            pila.agregar(5);
            pila.agregar(4);
            pila.agregar(3);
            pila.agregar(2);
            pila.agregar(1);

            pila.listar();

            Console.ReadKey();

        }
    }
}
