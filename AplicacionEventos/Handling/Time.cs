using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEventos.Handling
{
    public class Time : ITime
    {
        public string GetTimeOcurrence(DateTime dtDate)
        {
            if(dtDate < DateTime.Now)
            {
                return " ocurrió hace ";
            }
            else
            {
                return " ocurrirá dentro de ";
            }
        }
    }
}
