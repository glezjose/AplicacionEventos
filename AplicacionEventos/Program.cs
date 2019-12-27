using AplicacionEventos.Events;
using AplicacionEventos.Handling;
using AplicacionEventos.Processing;
using AplicacionEventos.Reading;
using AplicacionEventos.Writing;
using System;
using System.Collections.Generic;

namespace AplicacionEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader _oReader = new Reader();

            string _cPath = "../../File/file.txt";
            List<string> _lstEvents;
            _lstEvents = _oReader.ReadFile(_cPath);

            IProcessor _oProcessor = new Processor();
            List<IEvent> _lstEventsObject;
            _lstEventsObject = _oProcessor.ProcessEvent(_lstEvents);

            IWriter _oWriter = new Writer();
            ITime _oTime = new Time();
            Handler _oMinute = new Minute(_oWriter, _oTime);
            Handler _oHour = new Hour(_oWriter, _oTime);
            Handler _oDay = new Day(_oWriter, _oTime);
            Handler _oMonth = new Month(_oWriter, _oTime);

            _oMinute.SetNext(_oHour);
            _oHour.SetNext(_oDay);
            _oDay.SetNext(_oMonth);

            foreach (IEvent _event in _lstEventsObject)
            {
                _oMinute.ProcessResult(_event);
            }

            Console.ReadKey();
        }
    }
}
