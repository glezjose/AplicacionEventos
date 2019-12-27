using System.Collections.Generic;

namespace AplicacionEventos.Reading
{
    interface IReader
    {
        List<string> ReadFile(string cPath);
    }
}
