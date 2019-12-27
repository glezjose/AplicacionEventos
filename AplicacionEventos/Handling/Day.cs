﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionEventos.Events;
using AplicacionEventos.Writing;

namespace AplicacionEventos.Handling
{
    public class Day : Handler
    {
        private readonly IWriter _oWriter;
        private readonly ITime _oTime;

        public Day(IWriter _oWriter, ITime _oTime)
        {
            this._oWriter = _oWriter;
            this._oTime = _oTime;
        }

        protected override bool Process(IEvent _oEvent)
        {
            string cMessage;
            TimeSpan _tsRange = _oEvent.dtDate - DateTime.Now;
            double _dTimeRange = Math.Abs(_tsRange.TotalDays);
            if (_dTimeRange >= 30)
            {
                return false;
            }
            else
            {
                cMessage = _oEvent.cName + _oTime.GetTimeOcurrence(_oEvent.dtDate) + Math.Round(_dTimeRange) + " días";
                _oWriter.WriteResult(cMessage);
                return true;
            }
        }
    }
}
