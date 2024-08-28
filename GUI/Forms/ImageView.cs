using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SERVER;
using ImageProcessor;

/// <summary>
/// Author: Jack Hughes & Matthew Whitehouse
/// Date: 15/04/2022
/// Allows the user to select the image
/// </summary>
namespace GUI
{
    /// <summary>
    /// Allows the user to select the image
    /// </summary>
    public partial class ImageView : Form, IImageView, IListener
    {

        // DEFINE action as _invokeCommand
        private Action<ICommand> _invokeCommand;

        //DEFINE private variable of type ICommand, call it _loadImageCommand
        private ICommand _loadImageCommand;

        //DEFINE private variable of type ICommand, call it _rotateCommand
        private ICommand _rotateCommand;

        //DEFINE private variable of type ICommand, call it _flipCommand
        private ICommand _flipCommand;

        //DEFINE private variable of type ICommand, call it _brightCommand
        private ICommand _brightCommand;

        //DEFINE private variable of type ICommand, call it _contrastCommand
        private ICommand _contrastCommand;

        //DEFINE private variable of type ICommand, call it _pixelateCommand
        private ICommand _pixelateCommand;

        //DEFINE private variable of type ICommand, call it _hueCommand
        private ICommand _hueCommand;

        //DEFINE private variable of type ICommand, call it _opacityCommand
        private ICommand _opacityCommand;

        //DEFINE private variable of type ICommand, call it _gaussianCommand
        private ICommand _gaussianCommand;

        //DEFINE private variable of type ICommand, call it _saturationCommand
        private ICommand _saturationCommand;


        //DEFINE private variable of type ImageFactory, call it _imageFactory
        private ImageFactory _imageFactory;

        private Image _newImage, _currentImage;

        /// <summary>
        /// Constructor of ImageView
        /// </summary>
        public ImageView()
        {
            //CALL method InitializeComponent()
            InitializeComponent();
        }

        /// <summary>
        /// INITIALISE the class
        /// </summary>
        /// <param name="pInvokeCommand"></param>
        /// <param name="pLoadImage"></param>
        public void Initialize(Action<ICommand> pInvokeCommand, ICommand pLoadImage, ICommand pRotate, ICommand pFlip, ICommand pBright, ICommand pContrast, ICommand pPixelate, ICommand pOpacity, ICommand pHue, ICommand pGaussian, ICommand pSaturation)
        {
            _imageFactory = new ImageFactory();

            // SET pInvokeCommand as _invokeCommand
            _invokeCommand = pInvokeCommand;

            // SET  ploadImage as _loadImageCommand
            _loadImageCommand = pLoadImage;

            // SET  pRotate as _rotateCommand
            _rotateCommand = pRotate;

            // SET  pFlip as _flipCommand
            _flipCommand = pFlip;

            // SET  pBright as _brightCommand
            _brightCommand = pBright;

            // SET  pContrast as _ContrastCommand
            _contrastCommand = pContrast;

            // SET  pContrast as _pixelateCommand
            _pixelateCommand = pPixelate;

            // SET  pContrast as _opacityCommand
            _opacityCommand = pOpacity;

            // SET  pContrast as _hueCommand
            _hueCommand = pHue;

            // SET  pContrast as _gaussianCommand
            _gaussianCommand = pGaussian;

            // SET  pContrast as _gaussianCommand
            _saturationCommand = pSaturation;
        }

        /// <summary>
        /// UPDATES form based on the event passed in
        /// </summary>
        /// <param name="pSource"></param>
        /// <param name="pArgs"></param>
        public void Handler(Object pSource, ImageEventArgs pArgs)
        {
            //SHOW New Image Handler View
            Show();

            #region Load Image

            if (pArgs.State == "Load")
            {
                OpenFileDialog _openFileDialog = new OpenFileDialog();

                //FILTER the files seen in the file dialog to only show .png files
                _openFileDialog.Filter = "Image Files(*.png)|*.png";

                //IF there is a file to open
                if (_openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string _imagePath = _openFileDialog.FileName;

                        //ASSIGN file path of chosen image to _imagePath
                        _newImage = Bitmap.FromFile(Path.GetFullPath(_imagePath));
                        _currentImage = _newImage;
                        _imageFactory.Load(_newImage);

                        MyImage.Image = _newImage;
                    }
                    catch (Exception e)
                    {
                        //THROW exception
                        MessageBox.Show($"Security error.\n\nError message: {e.Message}\n\n" + $"Details:\n\n{e.StackTrace}");
                    }
                }

            }

            #endregion

            #region Rotate
            // IF button is clicked
            if (pArgs.State == "Rotate")
            {
                // IF an image is there
                if (MyImage.Image != null)
                {
                    // ROTATE the image 
                    //Image _newImage = MyImage.Image;

                    _newImage.RotateFlip(RotateFlipType.Rotate90FlipNone);

                    MyImage.Image = _newImage;
                }
                else
                {
                    //THROW message
                    MessageBox.Show("Please Load an Image first with the Load Image Button.");
                }
            }
            #endregion

            #region Flip
            // IF button is clicked
            if (pArgs.State == "Flip")
            {
                // IF an image is there
                if (MyImage.Image != null)
                {
                    // Flip the image
                    //Image _newImage = MyImage.Image;

                    _newImage.RotateFlip(RotateFlipType.RotateNoneFlipX);

                    MyImage.Image = _newImage;
                }
                else
                {
                    //THROW message
                    MessageBox.Show("Please Load an Image first with the Load Image Button.");
                }
            }

            #endregion

            #region Brightness

            if (pArgs.State == "Brightness")
            {
                if (MyImage.Image != null)
                {
                    //CHANGE the brightness
                    _imageFactory.Brightness(BrightnessBar.Value);
                    MyImage.Image = _imageFactory.Image;
                    _imageFactory.Load(_currentImage);

                }
                else
                {
                    //THROW message
                    MessageBox.Show("Please Load an Image first with the Load Image Button.");
                }

            }

            #endregion

            #region Contrast
            if (pArgs.State == "Contrast")
            {
                if (MyImage.Image != null)
                {
                    // CHANGE the contrast
                    _imageFactory.Contrast(ContrastBar.Value);
                    MyImage.Image = _imageFactory.Image;
                    _imageFactory.Load(_currentImage);

                }
                else
                {
                    //THROW message
                    MessageBox.Show("Please Load an Image first with the Load Image Button.");
                }

            }

            #endregion

            #region Saturation
            if (pArgs.State == "Saturation")
            {
                if (MyImage.Image != null)
                {
                    // CHANGE the Saturation
                    _imageFactory.Saturation(SaturationAdjustBar.Value);
                    MyImage.Image = _imageFactory.Image;
                    _imageFactory.Load(_currentImage);

                }
                else
                {
                    //THROW message
                    MessageBox.Show("Please Load an Image first with the Load Image Button.");
                }

            }
            #endregion


            #region Pixelate
            if (pArgs.State == "Pixelate")
            {
                if (MyImage.Image != null)
                {
                    // CHANGE the pixelation
                    _imageFactory.Pixelate(PixelateBar.Value);
                    MyImage.Image = _imageFactory.Image;
                    _imageFactory.Load(_currentImage);

                }
                else
                {
                    //THROW message
                    MessageBox.Show("Please Load an Image first with the Load Image Button.");
                }

            }
            #endregion

            #region Opacity
            if (pArgs.State == "Opacity")
            {
                if (MyImage.Image != null)
                {
                    // CHANGE the opacity
                    _imageFactory.Alpha(OpacityAdjustBar.Value);
                    MyImage.Image = _imageFactory.Image;
                    _imageFactory.Load(_currentImage);

                }
                else
                {
                    //THROW message
                    MessageBox.Show("Please Load an Image first with the Load Image Button.");
                }

            }
            #endregion

            #region Hue
            if (pArgs.State == "Hue")
            {
                if (MyImage.Image != null)
                {
                    // CHANGE the hue
                    _imageFactory.Hue(HueBar.Value);
                    MyImage.Image = _imageFactory.Image;
                    _imageFactory.Load(_currentImage);

                }
                else
                {
                    //THROW message
                    MessageBox.Show("Please Load an Image first with the Load Image Button.");
                }

            }
            #endregion

            #region Gaussian
            if (pArgs.State == "Gaussian")
            {
                if (MyImage.Image != null)
                {
                    // CHANGE the blur
                    _imageFactory.GaussianBlur(GaussianBlurBar.Value);
                    MyImage.Image = _imageFactory.Image;
                    _imageFactory.Load(_currentImage);

                }
                else
                {
                    //THROW message
                    MessageBox.Show("Please Load an Image first with the Load Image Button.");
                }

            }
            #endregion

        }

        // INVOKE command
        private void LoadImage_Click(object sender, EventArgs e)
        {
            _invokeCommand(_loadImageCommand);
        }

        // INVOKE command
        private void Rotate_Click(object sender, EventArgs e)
        {
            _invokeCommand(_rotateCommand);
        }

        // INVOKE command
        private void Flip_Click(object sender, EventArgs e)
        {
            _invokeCommand(_flipCommand);
        }

        // INVOKE command
        private void ContrastBar_Scroll(object sender, EventArgs e)
        {
            _invokeCommand(_contrastCommand);
        }

        // INVOKE command
        private void PixelateBar_Scroll(object sender, EventArgs e)
        {
            _invokeCommand(_pixelateCommand);
        }

        // INVOKE command
        private void HueBar_Scroll(object sender, EventArgs e)
        {
            _invokeCommand(_hueCommand);
        }

        // INVOKE command
        private void GaussianBlurBar_Scroll(object sender, EventArgs e)
        {
            _invokeCommand(_gaussianCommand);

        }

        // INVOKE command
        private void OpacityAdjustBar_Scroll(object sender, EventArgs e)
        {
            _invokeCommand(_opacityCommand);
        }

        // INVOKE command
        private void SaturationAdjustBar_Scroll(object sender, EventArgs e)
        {
            _invokeCommand(_saturationCommand);
        }

        // INVOKE command
        private void BrightnessBar_Scroll(object sender, EventArgs e)
        {
            _invokeCommand(_brightCommand);
        }
    }
}
