using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER
{
    public class ServiceLocator : IServiceLocator, IService
    {
        /*
        #region Variables

        //DECLARE a new IDictionary<Type, IService> called _serviceRegister.
        private IDictionary<Type, IService> _serviceRegister;

        //DECLARE a new IFactory<IService> called _serviceFactory.
        private IFactory<IService> _serviceFactory;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor: For the EngineManager Class.
        /// </summary>
        /// <param name="pServiceFactory">Holds a reference to the Factory previously created within Program during Startup.</param>
        public ServiceLocator(IFactory<IService> pServiceFactory)
        {
            //INSTANSIATES the _serviceRegister IDictionary as a new Dictionary, holds Types and Implimentors of IService.
            _serviceRegister = new Dictionary<Type, IService>();

            //SETS the _serviceFactory Variable to the passed in pServiceFactory.
            _serviceFactory = pServiceFactory;

        }

        #endregion

        #region Methods

        /// <summary>
        /// Method: Get, gets and returns an IService from the EngineManager for use, if it doesn't exist yet, it is created using the _serviceFactory.
        /// </summary>
        /// <typeparam name="T">Holds a reference to the IService that is being called in EngineManager.</typeparam>
        /// <returns>An IService found within EngineManager.</returns>
        public IService Get<T>() where T : IService, new()
        {
            //IF the _serviceRegister does not contain the IService in T.
            if (!_serviceRegister.ContainsKey(typeof(T)))
            {
                //ADD and CREATE the IService found within to _serviceRegister.
                _serviceRegister.Add(typeof(T), _serviceFactory.Create<T>());

                //PRINT the new Service added.
                Console.WriteLine("Added new Service called" + typeof(T));
            }

            //RETURN the IService T from _serviceRegister.
            return _serviceRegister[typeof(T)];
        }

        #endregion
        */
    }
}
