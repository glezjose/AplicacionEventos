using AplicacionEventos.LectorDocumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Lector _oReader = new Lector();
            _oReader.LeerArchivo();

            Console.ReadKey();
        }
    }
}
