using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERVER;

/// <summary>
/// AUTHORS: Jack Hughes, Matthew Whitehouse & Marc Price
/// Date: 25/03/2022
/// Code for the command invoker
/// </summary>
namespace GUI
{
    /// <summary>
    /// An Interface used to invoke Commands.
    /// </summary>
    public interface ICommandInvoker
    {
        #region Methods

        /// <summary>
        /// Method: ExecuteCommand, calls the Execute Method on the Command that has been passed into it via a Parameter.
        /// </summary>
        /// <param name="pCommand">The Command that needs to be executed next.</param>
        void ExecuteCommand(ICommand pCommand);

        #endregion
    }
}
