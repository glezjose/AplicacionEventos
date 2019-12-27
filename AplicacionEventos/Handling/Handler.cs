using AplicacionEventos.Events;
using AplicacionEventos.Processing;

namespace AplicacionEventos.Handling
{
    public abstract class Handler : IHandler
    {
        private IHandler _handler;

        public void ProcessResult(IEvent _oEvent)
        {
            if (!Process(_oEvent))
            {
                this._handler?.ProcessResult(_oEvent);
            }

        }

        public void SetNext(IHandler handler)
        {
            this._handler = handler;
        }

        protected abstract bool Process(IEvent _oEvent);
    }
}
