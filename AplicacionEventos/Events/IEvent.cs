using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEventos.Events
{
    public interface IEvent
    {
        string cName { get; set; }
        DateTime dtDate { get; set; }
    }
}
