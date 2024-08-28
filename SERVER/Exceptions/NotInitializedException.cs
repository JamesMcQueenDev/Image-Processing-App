using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER
{
    public class NotInitializedException : Exception
    {
        public NotInitializedException()
        {

        }

        public NotInitializedException(string pMessage)
            :base (pMessage)
        {

        }

        public NotInitializedException(string pMessage, Exception pInner)
    : base(pMessage, pInner)
        {

        }
    }
}
