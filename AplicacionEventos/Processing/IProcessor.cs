using AplicacionEventos.Events;
using System.Collections.Generic;

namespace AplicacionEventos.Processing
{
    public interface IProcessor
    {
        List<IEvent> ProcessEvent(List<string> lstEvents);
    }
}
