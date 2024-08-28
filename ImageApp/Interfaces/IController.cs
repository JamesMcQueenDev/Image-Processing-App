using System;
using GUI;
using SERVER;

namespace ImageApp
{
    /// <summary>
    /// Authors: Jack Hughes & Matthew Whitehouse
    /// Date: 13/12/2021
    /// Code for the Controller class
    /// </summary>
    public interface IController
    {
        /// <summary>
        /// CREATES a new ImageHandler window
        /// </summary>
        void AddImageHandler();
    }
}
