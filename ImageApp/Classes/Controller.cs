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
    public class Controller : IController
    {
        //DEFINE private IList, call it _imageHandlerList
        private IList<(IImageView pView, IImageMod pMod)> _imageHandlerList;

        //DEFINE private IFactory, call it _factory, creating an abstract factory
        private IFactory _factory;

        //DEFINE private Action, call it _invokeCommand
        private Action<ICommand> _invokeCommand;

        //DEFINE private IBaseView _baseView
        private IBaseView _baseView;

        /// <summary>
        /// CONSTRUCTOR of Controller
        /// </summary>
        public Controller(IFactory pFactory, Action<ICommand> pInvokeCommand, IBaseView pBaseView)
        {
            // SET pFactory as _factory
            _factory = pFactory;

            // SET pInvokeCommand as _invokeCommand
            _invokeCommand = pInvokeCommand;

            // SET pBaseView as _baseView
            _baseView = pBaseView;

            // CREATES _imageHandlerList as a _factory, CALL method Create
            _imageHandlerList = _factory.Create<IList<(IImageView pView, IImageMod pMod)>, List<(IImageView pView, IImageMod pMod)>>();

            // SET an ICommandZeroParam as _addImageCommand
            ICommandZeroParam _addImageCommand = _factory.Create<ICommandZeroParam, Command>();

            //SET SetAction of _addImageCommand as AddImageHandler
            _addImageCommand.SetAction = AddImageHandler;

            //CALL Intialize of _baseView
            _baseView.Initialize(_invokeCommand, _addImageCommand);
        }

        /// <summary>
        /// CREATES a new ImageHandler window
        /// </summary>
        public void AddImageHandler()
        {
            // ADD to list in the ImageHandler
            _imageHandlerList.Add((_factory.Create<IImageView, ImageView>(), _factory.Create<IImageMod, ImageMod>()));

            // LOAD the command 
            ICommandZeroParam _loadImageCommand = _factory.Create<ICommandZeroParam, Command>();

            // LOAD the ImageModel and SET the action
            _loadImageCommand.SetAction = _imageHandlerList[_imageHandlerList.Count - 1].pMod.LoadImage;

            // LOAD the command 
            ICommandZeroParam _rotateImageCommand = _factory.Create<ICommandZeroParam, Command>();

            // LOAD the ImageModel and SET the action
            _rotateImageCommand.SetAction = _imageHandlerList[_imageHandlerList.Count - 1].pMod.RotateImage;

            // LOAD the command 
            ICommandZeroParam _flipImageCommand = _factory.Create<ICommandZeroParam, Command>();

            // LOAD the ImageModel and SET the action
            _flipImageCommand.SetAction = _imageHandlerList[_imageHandlerList.Count - 1].pMod.FlipImage;

            // LOAD the command 
            ICommandZeroParam _brightImageCommand = _factory.Create<ICommandZeroParam, Command>();

            // LOAD the ImageModel and SET the action
            _brightImageCommand.SetAction = _imageHandlerList[_imageHandlerList.Count - 1].pMod.Brightness;

            // LOAD the command 
            ICommandZeroParam _contrastImageCommand = _factory.Create<ICommandZeroParam, Command>();

            // LOAD the ImageModel and SET the action
            _contrastImageCommand.SetAction = _imageHandlerList[_imageHandlerList.Count - 1].pMod.Contrast;

            // LOAD the command 
            ICommandZeroParam _pixelateImageCommand = _factory.Create<ICommandZeroParam, Command>();

            // LOAD the ImageModel and SET the action
            _pixelateImageCommand.SetAction = _imageHandlerList[_imageHandlerList.Count - 1].pMod.Pixelate;

            // LOAD the command 
            ICommandZeroParam _opacityImageCommand = _factory.Create<ICommandZeroParam, Command>();

            // LOAD the ImageModel and SET the action
            _opacityImageCommand.SetAction = _imageHandlerList[_imageHandlerList.Count - 1].pMod.Opacity;

            // LOAD the command 
            ICommandZeroParam _hueImageCommand = _factory.Create<ICommandZeroParam, Command>();

            // LOAD the ImageModel and SET the action
            _hueImageCommand.SetAction = _imageHandlerList[_imageHandlerList.Count - 1].pMod.Hue;

            // LOAD the command 
            ICommandZeroParam _gaussianImageCommand = _factory.Create<ICommandZeroParam, Command>();

            // LOAD the ImageModel and SET the action
            _gaussianImageCommand.SetAction = _imageHandlerList[_imageHandlerList.Count - 1].pMod.Gaussian;

            // LOAD the command 
            ICommandZeroParam _saturationImageCommand = _factory.Create<ICommandZeroParam, Command>();

            // LOAD the ImageModel and SET the action
            _saturationImageCommand.SetAction = _imageHandlerList[_imageHandlerList.Count - 1].pMod.Saturation;

            // INITIALISE the image view
            (_imageHandlerList[_imageHandlerList.Count - 1].pView).Initialize(_invokeCommand, _loadImageCommand, 
            _rotateImageCommand, _flipImageCommand, _brightImageCommand, _contrastImageCommand, _pixelateImageCommand, _opacityImageCommand, _hueImageCommand, _gaussianImageCommand, _saturationImageCommand);

            // INITIALISE the image model 
            (_imageHandlerList[_imageHandlerList.Count - 1].pMod as IPublisher).Initialize(_factory);

            // SUBSCRIBE the image model to the image view
            (_imageHandlerList[_imageHandlerList.Count - 1].pMod as IPublisher).Subscribe((_imageHandlerList[_imageHandlerList.Count - 1].pView as IListener).Handler);

        }
    }
}
