using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER
{
    public interface IServiceLocator : IService
    {
        /*
        #region Methods

        /// <summary>
        /// Method: Get, gets and returns an IService from the EngineManager for use, if it doesn't exist yet, it is created using the _serviceFactory.
        /// </summary>
        /// <typeparam name="T">Holds a reference to the IService that is being called in EngineManager.</typeparam>
        /// <returns>An IService found within EngineManager.</returns>
        IService Get<T>() where T : IService, new();

        #endregion
        */
    }
}
