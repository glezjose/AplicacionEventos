using AplicacionEventos.Events;
using System;
using System.Collections.Generic;

namespace AplicacionEventos.Processing
{
    public class Processor : IProcessor
    {
        public List<IEvent> ProcessEvent(List<string> lstEvents)
        {
            List<IEvent> _lstEvents = new List<IEvent>();
            foreach (string _cEvent in lstEvents)
            {
                string[] _arrEvent = _cEvent.Split(',');

                IEvent _oEvent = new Event()
                {
                    cName = _arrEvent[0],
                    dtDate = Convert.ToDateTime(_arrEvent[1])
                };

                _lstEvents.Add(_oEvent);
            }
            return _lstEvents;
        }
    }
}
