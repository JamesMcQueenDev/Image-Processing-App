
using ImageApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SERVER;
using System;
using GUI;
using System.Collections.Generic;

namespace TestingProject
{
    /// <summary>
    /// Authors: Jack Hughes & Matthew Whitehouse
    /// Date: 24/04/2022
    /// This is used to test the Controller
    /// reference: https://www.youtube.com/channel/UCRYpBqoEHa-gNcrwJqobC0A/videos
    /// </summary>
    [TestClass]
    public class ControllerTest
    {
        // DEFINE private mock IFactory
        private Mock<IFactory> _mockFactory;

        // DEFINE private mock ICommandInvoker
        private Mock<ICommandInvoker> _mockInvoker;

        // DEFINE private mock ICommandZeroParam
        private Mock<ICommandZeroParam> _mockAddImageCommand;

        // DEFINE private mock IBaseView
        private Mock<IBaseView> _mockBaseView;

        // DEFINE private mock IImageView
        private Mock<IImageView> _mockImageView;

        // DEFINE private mock IImageMod
        private Mock<IImageMod> _mockImageMod;

        // DEFINE private IList, call it _imageHandlerList
        private IList<(IImageView pView, IImageMod pMod)> _imageHandlerList;

        [TestInitialize]
        public void Setup()
        {
            // INSTANTIATE new mock ICommandZeroParam
            _mockAddImageCommand = new Mock<ICommandZeroParam>();

            //Call SetupSet of _mockImageCommand
            _mockAddImageCommand.SetupSet(mock => mock.SetAction = It.IsAny<Action>()).Verifiable();

            // INSTANTIATE new mock IImageView
            _mockImageView = new Mock<IImageView>();

            // INSTANTIATE new mock IImageMod
            _mockImageMod = new Mock<IImageMod>();

            // SETUP _mockImageView 
            _mockImageMod.As<IPublisher>().Setup(mock => mock.Subscribe(_mockImageView.As<IListener>().Object.Handler)).Verifiable();

            // INSTANTIATE new List 
            _imageHandlerList = new List<(IImageView pView, IImageMod pMod)>();

            // INSTANTIATE and SETUP mock IFactory
            _mockFactory = new Mock<IFactory>();
            _mockFactory.Setup(mock => mock.Create<ICommandZeroParam, Command>()).Returns(_mockAddImageCommand.Object);
            _mockFactory.Setup(mock => mock.Create<IImageView, ImageView>()).Returns(_mockImageView.Object);
            _mockFactory.Setup(mock => mock.Create<IImageMod, ImageMod>()).Returns(_mockImageMod.Object);

            _mockFactory.Setup(mock => mock.Create<IList<(IImageView pView, IImageMod pMod)>,
            List<(IImageView pView, IImageMod pMod)>>()).Returns(_imageHandlerList);


            _mockInvoker = new Mock<ICommandInvoker>();

            _mockBaseView = new Mock<IBaseView>();
            _mockBaseView.Setup(mock => mock.Initialize(_mockInvoker.Object.ExecuteCommand, _mockAddImageCommand.Object));
        }

        [TestMethod]
        public void ShouldInitializeBaseView()
        {
            #region ARRANGE
            // SET bool to true
            bool _hasPassed = true;

            #endregion ARRANGE


            #region ACT
            // CREATE a new Controller
            IController _controller = new Controller(_mockFactory.Object, _mockInvoker.Object.ExecuteCommand, _mockBaseView.Object);

            #endregion ACT


            #region ASSERT
            // TEST the _controller
            try
            {
                _mockBaseView.Verify(mock => mock.Initialize(_mockInvoker.Object.ExecuteCommand, _mockAddImageCommand.Object), Times.Once);
            }
            catch (MockException e)
            {
                _hasPassed = false;
            }
            finally
            {
                Assert.IsTrue(_hasPassed);
            }

            #endregion ASSERT
        }

        [TestMethod]
        public void ShouldCreateImageHandlerList()
        {
            #region ARRANGE
            // SET the bool to true
            bool _hasPassed = true;

            #endregion ARRANGE


            #region ACT
            // CREATE a new Controller
            IController _controller = new Controller(_mockFactory.Object, _mockInvoker.Object.ExecuteCommand, _mockBaseView.Object);

            #endregion ACT


            #region ASSERT
            // TEST the _controller
            try
            {
                _mockFactory.Verify(mock => mock.Create<IList<(IImageView pView, IImageMod pMod)>,
                                                    List<(IImageView pView, IImageMod pMod)>>());
            }
            catch (MockException e)
            {
                _hasPassed = false;
            }
            finally
            {
                Assert.IsTrue(_hasPassed);
            }

            #endregion ASSERT
        }

        [TestMethod]
        public void ShouldSetAddImageHandlerCommand()
        {
            #region ARRANGE
            // SET the bool to true
            bool _hasPassed = true;

            #endregion ARRANGE


            #region ACT
            // CREATE a new Controller
            IController _controller = new Controller(_mockFactory.Object, _mockInvoker.Object.ExecuteCommand, _mockBaseView.Object);

            #endregion ACT


            #region ASSERT
            // TEST the _controller
            try
            {
                _mockAddImageCommand.VerifySet(mock => mock.SetAction = It.Is<Action>(action => action == _controller.AddImageHandler));
            }
            catch (MockException e)
            {
                _hasPassed = false;
            }
            finally
            {
                Assert.IsTrue(_hasPassed);
            }

            #endregion ASSERT
        }
        
        [TestMethod]
        public void ShouldCreateNewImageView()
        {
            #region ARRANGE
            // SET bool as true
            bool _hasPassed = true;

            // CREATE  a new Controller
            IController _controller = new Controller(_mockFactory.Object, _mockInvoker.Object.ExecuteCommand, _mockBaseView.Object);

            #endregion ARRANGE


            #region ACT
            // CALL AddImageHandler method in Controller
            _controller.AddImageHandler();

            #endregion ACT


            #region ASSERT
            // TEST the _controller 
            try
            {
                _mockFactory.Verify(mock => mock.Create<IImageView, ImageView>(), Times.Once());
            }
            catch
            {
                _hasPassed = false;
            }
            finally
            {
                Assert.IsTrue(_hasPassed);
            }

            #endregion ASSERT
        }
        
        [TestMethod]
        public void ShouldCreateNewImageModel()
        {
            #region ARRANGE
            // SET boolean to true
            bool _hasPassed = true;

            // CREATE a new Controller
            IController _controller = new Controller(_mockFactory.Object, _mockInvoker.Object.ExecuteCommand, _mockBaseView.Object);

            #endregion ARRANGE


            #region ACT
            // CALL the AddImageHandler method inside of Controller
            _controller.AddImageHandler();

            #endregion ACT


            #region ASSERT
            // TEST the _controller
            try
            {
                _mockFactory.Verify(mock => mock.Create<IImageMod, ImageMod>(), Times.Once());
            }
            catch
            {
                _hasPassed = false;
            }
            finally
            {
                Assert.IsTrue(_hasPassed);
            }

            #endregion ASSERT
        }

        [TestMethod]
        public void ShouldSubscribeViewToModel()
        {
            #region ARRANGE
            // SET the boolean to true
            bool _hasPassed = true;

            // CREATE a new Controller, call it _controller
            IController _controller = new Controller(_mockFactory.Object, _mockInvoker.Object.ExecuteCommand, _mockBaseView.Object);

            #endregion ARRANGE


            #region ACT
            // CALL the AddImageHandler method in Controller
            _controller.AddImageHandler();

            #endregion ACT


            #region ASSERT
            // TEST the _controller
            try
            {
                _mockImageMod.As<IPublisher>().Verify(mock => mock.Subscribe(_mockImageView.As<IListener>().Object.Handler));
            }
            catch
            {
                _hasPassed = false;
            }
            finally
            {
                Assert.IsTrue(_hasPassed);
            }

            #endregion ASSERT

            }
        }
    }
