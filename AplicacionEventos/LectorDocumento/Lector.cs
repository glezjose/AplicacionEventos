using AplicacionEventos.Logica;
using System;
using System.IO;

namespace AplicacionEventos.LectorDocumento
{
    public class Lector
    {
        /// <summary>
        /// Es el método el cual se utiliza para leer el archivo txt.
        /// </summary>
        public void LeerArchivo()
        {
            Fecha _oFecha = new Fecha();
            try
            {
                using (StreamReader _srLector = new StreamReader("C:/Dual2019/AplicacionEventos/AplicacionEventos/Archivo/file.txt"))
                {
                    string _cLinea;
                    while ((_cLinea = _srLector.ReadLine()) != null)
                    {
                        string[] _arrPalabras = _cLinea.Split(',');

                        DateTime _dtFecha = Convert.ToDateTime(_arrPalabras[1]);


                        string _cMensaje = _oFecha.ObtenerMensaje(_dtFecha, _arrPalabras[0]);
                        Console.WriteLine(_cMensaje);

                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("El archivo no se pudo leer.");
            }
        }
    }
}
