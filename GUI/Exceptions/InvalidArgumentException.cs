using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Marc Price
/// Date: 07/07/07
/// 
/// This exception should be thrown whenever a String instance is unexpectedly empty (ie: "").
/// </summary>
namespace GUI
{
    /// <summary>
    /// InvalidArgumentException class.
    /// This exception should be thrown whenever a method argument is set to a silly value.
    /// </summary>
    public class InvalidArgumentException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public InvalidArgumentException()
        {
        }

        /// <summary>
        /// Recommended constructor.
        /// </summary>
        /// <param name="message">String containing the message to the user</param>
        public InvalidArgumentException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Only use this constructor if other exceptions are likely to be queued.
        /// </summary>
        /// <param name="message">String containing the message to the user</param>
        /// <param name="inner">Reference to other Exceptions that have been raised</param>
        public InvalidArgumentException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
