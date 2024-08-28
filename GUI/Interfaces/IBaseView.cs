using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Authors: Jack Hughes & Matthew Whitehouse
/// Date: 20/04/2022
/// Interface for the original form
/// </summary>
namespace GUI
{
    public interface IBaseView
    {
        /// <summary>
        /// INITIALISE the invoker and select command 
        /// </summary>
        /// <param name="pInvokeCommand"></param>
        /// <param name="pSelectImage"></param>
        void Initialize(Action<ICommand> pInvokeCommand, ICommand pSelectImage);

        /// <summary>
        /// SET the command
        /// </summary>
        ICommand ImageSelectCommand { set; }
    }
}
