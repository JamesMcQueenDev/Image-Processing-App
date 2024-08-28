using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.IO;
using Moq;
using GUI;
using SERVER;
using ImageApp;

/// <summary>
/// Original Author: Jack Hughes & Matthew Whitehouse
/// Date: 06/12/21
/// Simple Unit Testing Class. Tests the Loading and Getting of Images.
/// reference: https://www.youtube.com/channel/UCRYpBqoEHa-gNcrwJqobC0A/videos
/// </summary>
namespace TestingProject
{
    // Tests the retrieval and loading of the images
    [TestClass]
    public class EndToEndTest
    {

        private IImageMod _imageMod;

        private ImageEventArgs _args;

        private IBaseView _fakeBaseView;

        private ICommandZeroParam _addImageCommand;

        private ICommandZeroParam _loadImageCommand;

        private Mock<IImageView> _mockImageView;

        private IController _controller;

        private IList<(IImageView pView, IImageMod pMod)> _imageHandlerList;


        #region Setup

        private void StartApp()
        {
            _imageMod = new ImageMod();

            _args = new ImageEventArgs();

            _mockImageView = new Mock<IImageView>();

            _mockImageView.As<IListener>().Setup(mock => mock.Handler(_imageMod as IPublisher, _args)).Verifiable();

            _imageHandlerList = new List<(IImageView pView, IImageMod pMod)>();

            _addImageCommand = new Command();

            _loadImageCommand = new Command();

            var _mockFactory = new Mock<IFactory>();

            // SETUP ICommandInvoker
            _mockFactory.Setup(mock => mock.Create<ICommandInvoker, CommandInvoker>()).Returns(new CommandInvoker());

            // SETUP IBaseView
            _mockFactory.Setup(mock => mock.Create<IBaseView, BaseView>()).Returns(new FakeBaseView());

            // SETUP IImageView
            _mockFactory.Setup(mock => mock.Create<IImageView, ImageView>()).Returns(_mockImageView.Object);

            // SETUP IImageMod
            _mockFactory.Setup(mock => mock.Create<IImageMod, ImageMod>()).Returns(_imageMod);

            // SETUP EventArgs
            _mockFactory.Setup(mock => mock.Create<EventArgs, ImageEventArgs>()).Returns(_args as EventArgs);

            // SETUP IList
            _mockFactory.Setup(mock => mock.Create<IList<(IImageView pView, IImageMod pMod)>,
            List<(IImageView pView, IImageMod pMod)>>()).Returns(_imageHandlerList);

            // SETUP ICommandZeroParam that RETURNS _addImageCommand
            _mockFactory.Setup(mock => mock.Create<ICommandZeroParam, Command>()).Returns(_addImageCommand);

            // SETUP ICommandZeroParam that RETURNS _loadImageCommand
            _mockFactory.Setup(mock => mock.Create<ICommandZeroParam, Command>()).Returns(_loadImageCommand);

            // SET _commandInvoker as _mockFactory
            ICommandInvoker _commandInvoker = _mockFactory.Object.Create<ICommandInvoker, CommandInvoker>();

            // SET _fakeBaseView as _mockFactory
            _fakeBaseView = _mockFactory.Object.Create<IBaseView, BaseView>();

            // Initialise _fakeBaseView
            _fakeBaseView.Initialize(_commandInvoker.ExecuteCommand, _addImageCommand);

            // INSTANTIATE new Controller, call is _controller
            _controller = new Controller(_mockFactory.Object, _commandInvoker.ExecuteCommand, _fakeBaseView);

        }

        #endregion


        #region Test Methods
        // TEST if the image is retrieved and loaded properly
        [TestMethod]
        public void EndtoEnd()
        {
            #region ARRANGE
                // SET the bool to true
                bool hasPassed = true;
                // CALL the StartApp method
                StartApp();

            #endregion ARRANGE

            #region ACT
               // CALL the AddButtonClick method
               (_fakeBaseView as FakeBaseView).AddButtonClick();

            #endregion ACT

            #region ASSERT
                // TEST the ImageView
                try
                {
                    _mockImageView.As<IListener>().
                    Verify(mock => mock.Handler(_imageMod as IPublisher, _args));
                }
                catch (MockException e)
                {
                    hasPassed = false;
                }
                finally
                {
                    Assert.IsTrue(hasPassed);
                }

            #endregion ASSERT 

        }
        #endregion
    }
}

