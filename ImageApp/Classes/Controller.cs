using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GUI;
using SERVER;

namespace ImageApp
{
    /// <summary>
    /// Highest point of access in the program, allows for delegates to be sent to different classes that don't have access to each other directly
    /// Author: Matthew Whitehouse
    /// Date: 13/12/2021
    /// </summary>
    public class Controller
    {
        //INSTANCE of IServer, call is _server
        private IServer _server;

        //INSTANCE of IFormLogicInit, call it _formLogic
        private IFormLogicInit _formLogic;

        //INSTANCE of ViewBox, call it _viewBox
        private ViewBox _viewBox;

        //INSTANCE of delegate, call it _imageSizeDelegate
        private ImageSizeDelegate _imageSizeDelegate;

        //INSTANCE of delegate, call it _imageSelectDelegate
        private ImageSelectDelegate _imageSelectDelegate;

        //INSTANCE of delegate, call it _imageIncreaseDdelegate
        private ImageIncreaseDelegate _imageIncreaseDelegate;

        //INSTANCE of delegate, call it _imageDecreaseDelegate
        private ImageDecreaseDelegate _imageDecreaseDelegate;

        //INSTANCE of delegate, call it _imageRotateDelegate
        private ImageRotateDelegate _imageRotateDelegate;

        //INSTANCE of delegate, call it _imageFlipHorDelegate
        private ImageFlipHorDelegate _imageFlipHorDelegate;

        //INSTANCE of delegate, call it _imageFlipVertDelegate
        private ImageFlipVertDelegate _imageFlipVertDelegate;

        /// <summary>
        /// CONSTRUCTOR of Controller
        /// </summary>
        public Controller()
        {
            //INITIALISE instance of Server, call it _server
            _server = new Server();

            //INITIALISE instance of FormLogic, call is _formLogic
            _formLogic = new FormLogic();    
            
            //CALL Init method in FormLogic, pass instance of Server as parameter
            _formLogic.Initialise(_server);

            //INITIALISE new instance of ViewBox, call it _viewBox
            _viewBox = new ViewBox();

            //ASSIGN the method GetImage in IFormLogicButtons to _imageSizeDelegate
            _imageSizeDelegate = ((IFormLogicButtons)_formLogic).GetImage;

            //ASSIGN the method ImageSelect in IFormLogicButtons to _imageSelectDelegate
            _imageSelectDelegate = ((IFormLogicButtons)_formLogic).ImageSelect;

            //ASSIGN the method IncreaseImageVal in IFormLogicButtons to _imageIncreaseDelegate
            _imageIncreaseDelegate = ((IFormLogicButtons)_formLogic).IncreaseImageVal;

            //ASSIGN the method DecreaseImageVal in IFormLogicButtons to _imageDecreaseImageDelegate
            _imageDecreaseDelegate = ((IFormLogicButtons)_formLogic).DecreaseImageVal;

            //ASSIGN the method RotateImage in IFormLogicButtons to _imageRotateDelegate
            _imageRotateDelegate = ((IFormLogicButtons)_formLogic).RotateImage;

            //ASSIGN the method FlipHorizontal in IFormLogicButtons to _imageFlipHorDelegate
            _imageFlipHorDelegate = ((IFormLogicButtons)_formLogic).FlipHorizontal;

            //ASSIGN the method Flipvertical in IFormLogicButtons to _imageFlipVertDelegate 
            _imageFlipVertDelegate = ((IFormLogicButtons)_formLogic).FlipVertical;

            //PASS parameters through to Init method of _viewBox
            _viewBox.Init(_formLogic, 
                          _imageSizeDelegate, 
                          _imageSelectDelegate, 
                          _imageIncreaseDelegate, 
                          _imageDecreaseDelegate, 
                          _imageRotateDelegate, 
                          _imageFlipHorDelegate, 
                          _imageFlipVertDelegate);

            //RUN the application
            Application.Run(_viewBox);
        }
    }
}
