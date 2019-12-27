using AplicacionEventos.Events;

namespace AplicacionEventos.Handling
{
    public interface IHandler
    {
        void SetNext(IHandler _oHandler);
        void ProcessResult(IEvent _oEvent);
    }
}
