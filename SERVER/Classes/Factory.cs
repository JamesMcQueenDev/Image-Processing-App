using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER
{
    /// <summary>
    /// Author: Matthew Whitehouse
    /// Date: 12/04/2022
    /// An Abstract Factory Class used for the Creation of major things in the Engine, smaller stuff, such as Vector2's or Lists are still made with the new() system.
    /// </summary>
    /// <typeparam name="I">An Interface Type that is passed in when this Factory is made, anything created by it must impliment it.</typeparam>
    public class Factory : IFactory
    {
        #region Methods

        /// <summary>
        /// Method: Create, creates a brand new Object using the Parameters provided, as well as the type provided during the Factories initial Creation.
        /// </summary>
        /// <typeparam name="C">The new Object that needs to be created.</typeparam>
        /// <returns></returns>
        public I Create<I, C>() where C : I, new()
        {
            //DECLARE and INSTANSIATE a temporary Variable of the type passed into this Class, it must impliment the Type provided during the Factories Creation.
            I newObject = new C();

            //RETURN the newly created Object.
            return newObject;
        }

        #endregion
    }
}
