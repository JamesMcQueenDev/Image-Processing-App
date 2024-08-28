using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER
{
    public interface IListener
    {
        void Handler(Object pSource, ImageEventArgs pArgs);
    }
}
