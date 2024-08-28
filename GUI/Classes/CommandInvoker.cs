using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERVER;

/// <summary>
/// Author: Jack Hughes & Matthew Whitehouse
/// Date: 20/04/2022
/// Invokes the commands
/// </summary>
namespace GUI
{
    public class CommandInvoker : ICommandInvoker, IService
    {

        #region Methods

        /// <summary>
        /// Method: ExecuteCommand, calls the Execute Method on the Command that has been passed into it via a Parameter.
        /// </summary>
        /// <param name="pCommand">The Command that needs to be executed next.</param>
        public void ExecuteCommand(ICommand pCommand)
        {
            //CALLS the Execute Method on the pCommand Parameter.
            pCommand.Execute();
        }

        #endregion
    }
}
