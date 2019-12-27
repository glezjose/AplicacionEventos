using System;

namespace AplicacionEventos.Logica
{
    public class Fecha
    {
        /// <summary>
        /// Es para obtener el mensaje correspondiente.
        /// </summary>
        /// <param name="dtFecha">Es la fecha en formato DateTime</param>
        /// <param name="cEvento">Es el nombre del evento.</param>
        /// <returns>Regresa el mensaje en forma correcta.</returns>
        public string ObtenerMensaje(DateTime dtFecha, string cEvento)
        {
            TimeSpan _tsTiempo = new TimeSpan();
            string _cMensaje = "";
            if (dtFecha < DateTime.Now)
            {
                if ((dtFecha.Date == DateTime.Now.Date) && (dtFecha.TimeOfDay < DateTime.Now.TimeOfDay))
                {
                    _tsTiempo = DateTime.Now.TimeOfDay - dtFecha.TimeOfDay;
                    _cMensaje = cEvento + " ocurrió hace " + ValidarMinutos(_tsTiempo);
                }
                else
                {
                    _tsTiempo = DateTime.Now.Date - dtFecha.Date;
                    _cMensaje = cEvento + " ocurrió hace " + ValidarDias(_tsTiempo);
                }

            }
            else if (dtFecha > DateTime.Now)
            {
                if ((dtFecha.Date == DateTime.Now.Date) && (dtFecha.TimeOfDay > DateTime.Now.TimeOfDay))
                {
                    _tsTiempo = dtFecha.TimeOfDay - DateTime.Now.TimeOfDay;
                    _cMensaje = cEvento + " ocurrirá dentro de " + ValidarMinutos(_tsTiempo);
                }
                else
                {
                    _tsTiempo = dtFecha.Date - DateTime.Now.Date;
                    _cMensaje = cEvento + " ocurrirá dentro de " + ValidarDias(_tsTiempo);
                }
            }
            return _cMensaje;
        }

        /// <summary>
        /// Es para validar si los días se pasan de 30 y se conviertan en meses.
        /// </summary>
        /// <param name="_tsTiempo">Es el tiempo con el cual se valida.</param>
        /// <returns>Regresa una cadena en el formato correcto.</returns>
        public string ValidarDias(TimeSpan _tsTiempo)
        {
            string _cFecha = "";
            if(_tsTiempo.TotalDays >= 30)
            {
                _cFecha = Math.Round(_tsTiempo.Days / 30.436875) + " meses";
            }
            else
            {
                _cFecha = _tsTiempo.Days + " días";
            }
            return _cFecha;
        }

        /// <summary>
        /// Es para validar si los minutos se pasan de 60 minutos que se convierta en horas.
        /// </summary>
        /// <param name="_tsTiempo">Es el tiempo con el cual se valida</param>
        /// <returns>Regresa una cadena con el formato correcto del tiempo.</returns>
        public string ValidarMinutos(TimeSpan _tsTiempo)
        {
           string _cTiempo = "";
            if (_tsTiempo.TotalMinutes >= 60)
            {
                _cTiempo = Math.Round(_tsTiempo.TotalHours) + " horas";
            }
            else
            {
                _cTiempo = Math.Round(_tsTiempo.TotalMinutes) + " minutos";
            }
            return _cTiempo;
        }
    }
}
