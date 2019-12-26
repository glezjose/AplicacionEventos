using System;

namespace AplicacionEventos.Logica
{
    public class Fecha
    {
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

        public string ValidarDias(TimeSpan _tsTiempo)
        {
            string _cFecha = "";
            if(_tsTiempo.TotalDays >= 30)
            {
                _cFecha = (_tsTiempo.Days / 30.436875) + " meses";
            }
            else
            {
                _cFecha = _tsTiempo.Days + " días";
            }
            return _cFecha;
        }

        public string ValidarMinutos(TimeSpan _tsTiempo)
        {
           string _cTiempo = "";
            if (_tsTiempo.TotalMinutes >= 60)
            {
                _cTiempo = _tsTiempo.TotalHours + " horas";
            }
            else
            {
                _cTiempo = _tsTiempo.TotalMinutes + " minutos";
            }
            return _cTiempo;
        }
    }
}
