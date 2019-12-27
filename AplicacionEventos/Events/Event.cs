using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEventos.Events
{
    public class Event : IEvent
    {
        public string cName { get; set; }
        public DateTime dtDate { get; set; }
    }
}
