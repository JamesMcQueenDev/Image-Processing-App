using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER
{
    /// <summary>
    /// Authors: Jack Hughes & Matthew Whitehouse
    /// Date: 20/04/2022
    /// GETS and RETURNS _sate
    /// </summary>
    public class ImageEventArgs : EventArgs
    {
        // DEFINE private string, call it _state 
        private String _state;

        public String State 
        { 
            get
            {
                return _state;
            } 
            set
            {
                _state = value;
            }
        }

    }
}
