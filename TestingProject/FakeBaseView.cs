using System;
using System.Collections.Generic;
using System.Text;
using GUI;
using SERVER;

namespace TestingProject
{
    /// <summary>
    /// Authors: Jack Hughes & Matthew Whitehouse
    /// Date: 12/04/2022
    /// A fake version of the original form
    /// reference: https://www.youtube.com/channel/UCRYpBqoEHa-gNcrwJqobC0A/videos
    /// </summary>
    public class FakeBaseView : IBaseView
    {
        // SET bool to false
        private bool _isInitialized = false;

        // DEFINE action as _invokeCommand
        private Action<ICommand> _invokeCommand;

        // DEFINE ICommand as _imageSelectCommand
        private ICommand _imageSelectCommand;

        /// <summary>
        /// INITIALISE the class
        /// </summary>
        /// <param name="pInvokeCommand"></param>
        /// <param name="pSelectImage"></param>
        public void Initialize(Action<ICommand> pInvokeCommand, ICommand pSelectImage)
        {
            // SET pInvokeCommand as _invokeCommand
            _invokeCommand = pInvokeCommand;

            // SET  pSelectImage as _imageSelectCommand
            _imageSelectCommand = pSelectImage;

            // SET boolean to TRUE
            _isInitialized = true;
        }

        /// <summary>
        /// Adds a button click
        /// </summary>
        public void AddButtonClick()
        {
            // If boolean is FALSE
            if (!_isInitialized)
            {
                // THROW exception
                throw new NotInitializedException();
            }

            _invokeCommand(_imageSelectCommand);
        }

        /// <summary>
        /// SET the command
        /// </summary>
        public ICommand ImageSelectCommand 
        { 
            set 
            {
                _imageSelectCommand = value;
            } 
        }
    }
}
