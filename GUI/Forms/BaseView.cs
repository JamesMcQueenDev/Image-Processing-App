using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Author: Jack Hughes & Matthew Whitehouse
/// Date: 15/04/2022
/// The form that the user interacts with to use different features of the app
/// </summary>
namespace GUI
{
    /// <summary>
    /// Holds the methods being called in the form
    /// </summary>
    public partial class BaseView : Form, IBaseView
    {
        //DEFINE an action, call it _invokeCommand
        private Action<ICommand> _invokeCommand;
        
        //DEFINE  an ICommand, call it _imageHandlerCommand
        private ICommand _imageHandlerCommand;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        public BaseView()
        {
            //CALL method InitializeComponent
            InitializeComponent();
        }

        /// <summary>
        /// INITIALISE the invoker and select command 
        /// </summary>
        /// <param name="pInvokeCommand"></param>
        /// <param name="pSelectImage"></param>
        public void Initialize(Action<ICommand> pInvokeCommand, ICommand pSelectImage)
        {
            //INITIALIES pInvokeCommand as _invokeCommand
            _invokeCommand = pInvokeCommand;

            //INITIALISE pSelectImage as _imageHandlerCommand
            _imageHandlerCommand = pSelectImage;
        }

        /// <summary>
        /// SET the command
        /// </summary>
        public ICommand ImageSelectCommand
        {
            //SET _imageHandlerCommand
            set
            {
                _imageHandlerCommand = value;
            }
        }

        /// <summary>
        /// When the button is clicked, INVOKE the _imageHandlerCommand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddImageHandler_Click(object sender, EventArgs e)
        {
            //INVOKE the _imageHandlerCommand
            _invokeCommand(_imageHandlerCommand);
        }
    }
}
