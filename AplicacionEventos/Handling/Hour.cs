using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionEventos.Events;
using AplicacionEventos.Writing;

namespace AplicacionEventos.Handling
{
    public class Hour : Handler
    {
        private readonly IWriter _oWriter;
        private readonly ITime _oTime;

        public Hour(IWriter _oWriter, ITime _oTime)
        {
            this._oWriter = _oWriter;
            this._oTime = _oTime;
        }

        protected override bool Process(IEvent _oEvent)
        {
            string cMessage;
            TimeSpan _tsRange = _oEvent.dtDate - DateTime.Now;
            double _dTimeRange = Math.Abs(_tsRange.TotalHours);
            if (_dTimeRange >= 24)
            {
                return false;
            }
            else
            {
                cMessage = _oEvent.cName + _oTime.GetTimeOcurrence(_oEvent.dtDate) + Math.Round(_dTimeRange) + " horas";
                _oWriter.WriteResult(cMessage);
                return true;
            }
        }
    }
}
