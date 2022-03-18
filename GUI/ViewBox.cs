using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SERVER;

namespace GUI
{
    /// <summary>
    /// Author: Matthew Whitehouse and Marc Price
    /// Date: 13/12/2021
    /// </summary>
    public partial class ViewBox : Form
    {
        //INSTANCE of IFormLogicInit, call it _formLogic
        IFormLogicInit _formLogic;

        //INSTANCE of ImageSizeDelegate, call it _imageSizeDelegate
        ImageSizeDelegate _imageSizeDelegate;

        //INSTANCE of ImageSelectDelegate, call it _imageSelectDelegate
        ImageSelectDelegate _imageSelectDelegate;

        //INSTANCE of ImageIncreaseDelegate, call it _imageIncreaseDelegate
        ImageIncreaseDelegate _imageIncreaseDelegate;

        //INSTANCE of ImageDecreaseDelegate, call it _imageDecreaseDelegate
        ImageDecreaseDelegate _imageDecreaseDelegate;

        //INSTANCE of ImageRotateDelegate, call it _imageRotateDelegate
        ImageRotateDelegate _imageRotateDelegate;

        //INSTANCE of ImageFlipVertDelegate, call it _imageFlipVertDelegate     
        ImageFlipVertDelegate _imageFlipVertDelegate;

        //INSTANCE of ImageFlipHorDelegate, call it _imageFlipHorDelegate
        ImageFlipHorDelegate _imageFlipHorDelegate;

        IncreaseBrightnessDelegate _increaseBrightnessDelegate;

        DecreaseBrightnessDelegate _decreaseBrightnessDelegate;

        SaveImageDelegate _saveImageDelegate;

        string _commandCalled;


        /// <summary>
        /// CONSTRUCTOR for ViewBox
        /// </summary>
        public ViewBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// INITIALISE the variables in ViewBox
        /// PASS instance of the method inside of FormLogic using delegates
        /// </summary>
        /// <param name="pFormLogic"></param>
        /// <param name="pImageSizeDelegate"></param>
        /// <param name="pImageSelectDelegate"></param>
        /// <param name="pImageIncreaseDelegate"></param>
        /// <param name="pImageDecreaseDelegate"></param>
        /// <param name="pImageRotateDelegate"></param>
        /// <param name="pImageFlipHorDelegate"></param>
        /// <param name="pImageFlipVertDelegate"></param>
        public void Init(IFormLogicInit pFormLogic, ImageSizeDelegate pImageSizeDelegate, ImageSelectDelegate pImageSelectDelegate, ImageIncreaseDelegate pImageIncreaseDelegate, ImageDecreaseDelegate pImageDecreaseDelegate, ImageRotateDelegate pImageRotateDelegate,ImageFlipHorDelegate pImageFlipHorDelegate, ImageFlipVertDelegate pImageFlipVertDelegate, IncreaseBrightnessDelegate pIncreaseBrightnessDelegate, DecreaseBrightnessDelegate pDecreaseBrightnessDelegate, SaveImageDelegate pSaveImageDelegate)
        {
            //ASSIGN pFormLogic to _formLogic
            _formLogic = pFormLogic;

            //ASSIGN pImageSizeDelegate to _imageSizeDelegate
            _imageSizeDelegate = pImageSizeDelegate;

            //ASSIGN pImageSelectDelegate to _imageSelectDelegate
            _imageSelectDelegate = pImageSelectDelegate;

            //ASSIGN pImageIncreaseDelegate to _imageIncreaseDelegate
            _imageIncreaseDelegate = pImageIncreaseDelegate;

            //ASSIGN pImageDecreaseDelegate to _imageDecreaseDelegate
            _imageDecreaseDelegate = pImageDecreaseDelegate;

            //ASSIGN pImageRotateDelegate to _imageRotateDelegate
            _imageRotateDelegate = pImageRotateDelegate;

            //ASSIGN pImageFlipHorDelegate to _imageFlipHorDelegate
            _imageFlipHorDelegate = pImageFlipHorDelegate;

            //ASSIGN pImageFlipVertDelegate to _imageFlipVertDelegate
            _imageFlipVertDelegate = pImageFlipVertDelegate;


            _increaseBrightnessDelegate = pIncreaseBrightnessDelegate;

            _decreaseBrightnessDelegate = pDecreaseBrightnessDelegate;

            _saveImageDelegate = pSaveImageDelegate;

        }

        /// <summary>
        /// CLOSE the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            //CLOSE the form
            this.Close();
        }

        /// <summary>
        /// CALL the RotateImage method in FormLogic
        /// UPDATE the pictureBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RotateButton_Click(object sender, EventArgs e)
        {
            //If there is an image in the picture box, rotate the image 90 degrees, else do nothing
            if (pictureBox1.Image != null)
            {
                //CALL the method in FormLogic through the _imageRotateDelegate
                _imageRotateDelegate();
                _commandCalled = "Rotate Clockwise";
                Update();
            }
            else
            {
                //do nothing
            }
        }

        /// <summary>
        /// CALL the FlipHorizontal method in FormLogic
        /// UPDATE the pictureBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FliphorizontalButton_Click(object sender, EventArgs e)
        {
            //If there is an image in the picture box, flip the image, else do nothing
            if (pictureBox1.Image != null)
            {
                //CALL the method in FormLogic through the _imageFlipHorDelegate
                _imageFlipHorDelegate();
                _commandCalled = "Flip Horizontal";
                Update();
            }
            else
            {
                //do nothing
            }
        }

        /// <summary>
        /// CALL the FlipVertical method in FormLogic
        /// UPDATE the pictureBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipVertical_Click(object sender, EventArgs e)
        {
            //If there is an image in the picture box, flip the image, else do nothing
            if (pictureBox1.Image != null)
            {
                //CALL the method in FormLogic through the _imageFlipDelegate
                _imageFlipVertDelegate();
                _commandCalled = "Flip Vertical";
                Update();
            }
            else
            {
                //do nothing
            }
        }

        /// <summary>
        /// CALL the ImageSelect method in FormLogic
        /// UPDATE the pictureBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            //CALL the method in FormLogic through the _imageSelectDelegate
            _imageSelectDelegate();
            _commandCalled = "Load";
            Update();
        }

        /// <summary>
        /// CALL the IncreaseImageVal method in FormLogic
        /// UPDATE the pictureBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForwardButton_Click(object sender, EventArgs e)
        {
            //If there is an image in the picture box, iterate through the list, else do nothing
            if (pictureBox1.Image != null)
            {
                //CALL the method in FormLogic through the _imageIncreaseDelegate
                _imageIncreaseDelegate();
                _commandCalled = "Next";
                Update();
            }
            else
            {
                //do nothing
            }
        }

        /// <summary>
        /// CALL the DecreaseImageVal method in FormLogic
        /// UPDATE the pictureBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackwardButton_Click(object sender, EventArgs e)
        {
            //If there is an image in the list, move backward through the list, else do nothing
            if (pictureBox1.Image != null)
            {
                //CALL the method  in FormLogic through the _imageDecreaseDelegate
                _imageDecreaseDelegate();
                _commandCalled = "Previous";
                Update();

            }
            else
            {
                //do nothing
            }
        }


        #region Code Snippet: makes this borderless window movable
        // Modified from https://stackoverflow.com/a/24561946 and attributed to user jay_t55

        // DECLARE a boolean that is set to true when a mouse down event is detected, call it _mouseDown:
        private bool _mouseDown = false;

        // DECLARE a Point object to store the last location of the window origin (ie memory), call it _lastLocation:
        private Point _lastLocation;

        // Mouse down event handler
        private void ViewBox_MouseDown(object sender, MouseEventArgs e)
        {
            // SET _mouseDown true:
            _mouseDown = true;

            // STORE current location to _lastLocation:
            _lastLocation = e.Location;
        }

        // Mouse move event handler
        private void ViewBox_MouseMove(object sender, MouseEventArgs e)
        {
            // Only act if mouse button is down...
            if (_mouseDown)
            {
                // SET new location according to mouse movement from _lastLocation:
                this.Location = new Point(
                    (this.Location.X - _lastLocation.X) + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);

                // UPDATE this window:
                this.Update();

            }
        }

        // Mouse up event handler
        private void ViewBox_MouseUp(object sender, MouseEventArgs e)
        {
            // RESET _mouseDown to false:
            _mouseDown = false;

        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BrightnessDecrease_Click(object sender, EventArgs e)
        {
            _increaseBrightnessDelegate();
            _commandCalled = "Increase Brightness";
            Update();
        }

        private void BrightnessIncrease_Click(object sender, EventArgs e)
        {
            _decreaseBrightnessDelegate();
            _commandCalled = "Decrease Brightness";
            Update();
        }

        public void Update()
        {
            //UPDATE the pictureBox1
            pictureBox1.Image = _imageSizeDelegate(pictureBox1.Width, pictureBox1.Height);
            CommandCalledBox.Text = _commandCalled;
        }

        private void CommandCalledBox_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _saveImageDelegate();   
        }
    }
}
