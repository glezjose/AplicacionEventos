using System;

namespace AplicacionEventos.Writing
{
    public class Writer : IWriter
    {
        public void WriteResult(string cMessage)
        {
            Console.WriteLine(cMessage);
        }
    }
}
