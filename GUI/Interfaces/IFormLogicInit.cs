using SERVER;

namespace GUI
{
    /// <summary>
    /// Contains the initialise method needed for the FormLogic class
    /// Author: Matthew Whitehouse
    /// Date: 13/12/2021
    /// </summary>
    public interface IFormLogicInit
    {
        /// <summary>
        /// INITIALISE the variables in FormLogic
        /// </summary>
        /// <param name="pServer"></param>
        void Init(IServer pServer);
    }
}