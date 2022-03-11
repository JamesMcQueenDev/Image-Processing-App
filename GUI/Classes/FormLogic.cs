using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using SERVER;

namespace GUI
{
    /// <summary>
    /// Author: Matthew Whitehouse
    /// Date: 13/12/2021
    /// </summary>
    public class FormLogic : IFormLogicInit, IFormLogicButtons
    {
        //Instance of IServer
        IServer _server;

        //Instance of OpenFileDialog
        private OpenFileDialog _openFileDialog;

        //Stores the image path of current image
        string _imagePath;

        //Stores image paths for all selected images
        IList<String> _filePathList;

        //Value of current image
        int _currentImage;

        //Length of the list
        int _listLength;

        /// <summary>
        /// CONSTRUCTOR of FormLogic
        /// </summary>
        public FormLogic()
        {
            
        }

        /// <summary>
        /// INITIALISE the variables in FormLogic
        /// </summary>
        /// <param name="pServer"></param>
        public void Initialise(IServer pServer)
        {
            //INITIALISE instance of IServer, call it _server
            _server = pServer;

            //INITIALISE new OpenFileDialog, call it _openFileDialog
            _openFileDialog = new OpenFileDialog();

            //FILTER the files seen in the file dialog to only show .png files
            _openFileDialog.Filter = "Image Files(*.png)|*.png";

            //INITIALISE a lise for file paths, call is _filePathList
            _filePathList = new List<String>();

            //COUNT the length of the list, call is _listLength
            _listLength = _filePathList.Count;

            //INITIALISE value of the current image in the list, call is _currentImage
            _currentImage = 0;
        }

        /// <summary>
        /// SELECT the image stored on the machine if there is one there
        /// </summary>
        public void ImageSelect()
        {
            //IF there is a file to open
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //ASSIGN file path of chosen image to _imagePath
                    _imagePath = _openFileDialog.FileName;

                    //CHECK if the image already exists
                    if (_filePathList.Contains(_imagePath))
                    {
                        //do nothing
                    }
                    else
                    {
                        //ADD the image to the list
                        _filePathList.Add(_imagePath);

                        //ASSIGN int value to _currentImage
                        _currentImage = _filePathList.Count - 1;
                    }

                    //LOAD the list
                    _server.Load(_filePathList);

                }
                catch (Exception ex)
                {
                    //THROW exception
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        /// <summary>
        /// ITERATE through the list of images selected 
        /// </summary>
        public void IncreaseImageVal()
        {
            //IF the _currentImage falls within a valid range of the list and there is an image
            //https://stackoverflow.com/questions/3949113/check-if-element-at-position-x-exists-in-the-list
            //Anthony Pegram
            if (_filePathList.Count > _currentImage + 1 && _filePathList[_currentImage + 1] != null)
            {
                //INCREASE the _currentImage by 1
                _currentImage++;

            }
            else
            {
                //do nothing
            }
        }

        /// <summary>
        /// MOVE backwards through the list of selected images
        /// </summary>
        public void DecreaseImageVal()
        {

            //IF the _currentImage falls within a valid range of the list and there is an image
            //https://stackoverflow.com/questions/3949113/check-if-element-at-position-x-exists-in-the-list
            //Anthony Pegram
            if (_currentImage > 0 && _filePathList[_currentImage - 1] != null)
            {
                //DECREASE the _currentImage by 1
                _currentImage--;
            }
            else
            {
                //do nothing
            }
        }

        /// <summary>
        /// CALL the RotateImage method in server
        /// </summary>
        public void RotateImage()
        {
            //CALL RotateImage method in server, pass through the current image file path
            _server.RotateImage(_filePathList[_currentImage]);
        }

        /// <summary>
        /// CALL the HorizontalFlipImage method in server
        /// </summary>
        public void FlipHorizontal()
        {
            //CALL HorizontalFlipImage method in server, pass through the current image file path
            _server.HorizontalFlipImage(_filePathList[_currentImage]);
        }

        /// <summary>
        /// CALL the VerticalFlipImage method in server
        /// </summary>
        public void FlipVertical()
        {
            //CALL VerticalFlipImage method in server, pass through the current image file path
            _server.VerticalFlipImage(_filePathList[_currentImage]);
        }

        /// <summary>
        /// RETURN the image found using the file path selected
        /// </summary>
        /// <param name="pWidth"></param>
        /// <param name="pHeight"></param>
        /// <returns>_image</returns>
        public Image GetImage(int pWidth, int pHeight)
        {
            //LOAD the _image
            try
            {
                //CREATE an image from the file path, scaling it to the picture box
                Image _image = _server.GetImage(_filePathList[_currentImage], pWidth, pHeight);

                //RETURN the image
                return _image;
            }
            // IF the filename is invalid...
            catch (FileNotFoundException e)
            {
                // Throw an InvalidArgumentException:
                throw new InvalidArgumentException("ImageHandler: invalid path/filename for image");
            }
            
        }
    }
}
