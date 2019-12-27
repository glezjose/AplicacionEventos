using AplicacionEventos.Events;
using AplicacionEventos.Writing;
using System;

namespace AplicacionEventos.Handling
{
    public class Minute : Handler
    {
        private readonly IWriter _oWriter;
        private readonly ITime _oTime;

        public Minute(IWriter _oWriter, ITime _oTime)
        {
            this._oWriter = _oWriter;
            this._oTime = _oTime;
        }
        
        protected override bool Process(IEvent _oEvent)
        {
            string cMessage;
            TimeSpan _tsRange = _oEvent.dtDate - DateTime.Now;
            double _dTimeRange = Math.Abs(_tsRange.TotalMinutes);
            if(_dTimeRange >= 60)
            {
                return false;
            }
            else
            {
                cMessage = _oEvent.cName + _oTime.GetTimeOcurrence(_oEvent.dtDate) + Math.Round(_dTimeRange) + " minutos";
                _oWriter.WriteResult(cMessage);
                return true;
            }
        }
    }
}
