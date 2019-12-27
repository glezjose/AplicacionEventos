using System;
using System.Collections.Generic;
using System.IO;

namespace AplicacionEventos.Reading
{
    public class Reader : IReader
    {
        public string cPath { get; set; }

        public List<string> ReadFile(string cPath)
        {
            List<string> _lstEvents = new List<string>();
            try
            {
                using (StreamReader _srReader = new StreamReader(cPath))
                {
                    string _cLine;
                    while ((_cLine = _srReader.ReadLine()) != null)
                    {
                        _lstEvents.Add(_cLine);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("El archivo no se pudo leer.");
            }

            return _lstEvents;
        }
    }
}
