using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using GUI;
using SERVER;

namespace TestingProject
{
    /// <summary>
    /// Authors: Jack Hughes & Matthew Whitehouse
    /// Date: 15/04/2022
    /// Tests the ImageModel
    /// reference: https://www.youtube.com/channel/UCRYpBqoEHa-gNcrwJqobC0A/videos
    /// </summary>
    [TestClass]
    public class ImageModelTest
    {
        // DEFINE a Mock IFactory, call it _mockFactory
        private Mock<IFactory> _mockFactory;

        // DEFINE a Mock IListener, call it _mockListener
        private Mock<IListener> _mockListener;

        // DEFINE an ImageEventArgs, call it _args
        private ImageEventArgs _args;

        // DEFINE an ImageMod, call it _imageMod
        private ImageMod _imageMod;

        /// <summary>
        /// SETUP the test class
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            // SET _args as ImageEventArgs
            _args = new ImageEventArgs();

            // SET _mockListener as a new Mock IListener 
            _mockListener = new Mock<IListener>();

            // VERIFY the _mockListener 
            _mockListener.Setup(mock => mock.Handler(_imageMod, _args)).Verifiable();

            // SET  _mockFactory as a new Mock IFactory
            _mockFactory = new Mock<IFactory>();

            // RETURN arguments of _mockFatory
            _mockFactory.Setup(mock => mock.Create<EventArgs, ImageEventArgs>()).Returns(_args);
        }

        /// <summary>
        /// Ensure that subscribe should throw not initialized exception
        /// </summary>
        [TestMethod]
        public void SubscribeShouldThrowNotInitializedException()
        {
            #region ARRANGE
            // SET bool as FALSE
            bool _hasPassed = false;

            // SET _imageMod as new ImageMod
            _imageMod = new ImageMod();

            #endregion ARRANGE

            //Try catch Subscribe Image Model to the Mock Listener
            #region ACT
            try
            {
                (_imageMod as IPublisher).Subscribe(_mockListener.Object.Handler);
            }  

            #endregion ACT


            #region ASSERT
            
            catch (NotInitializedException e)
            {
                _hasPassed = true;
            }
            finally
            {
                Assert.IsTrue(_hasPassed);
            }

            #endregion ASSERT
        }

        /// <summary>
        /// Ensures that subscribe should publish event
        /// </summary>
        [TestMethod]
        public void SubscribeShouldPublishEvent()
        {
            #region ARRANGE
            // SET bool as true
            bool _hasPassed = true;

            // SET _imageMod as new ImageMod
            _imageMod = new ImageMod();

            // INITIALISE the _imageMod
            (_imageMod as IPublisher).Initialize(_mockFactory.Object);

            #endregion ARRANGE


            #region ACT
            // Subscribe _imageMod to _mockListener
            (_imageMod as IPublisher).Subscribe(_mockListener.Object.Handler);

            #endregion ACT


            #region ASSERT

            try
            {
                _mockListener.Verify(mock => mock.Handler(_imageMod, _args));
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
    }
}
