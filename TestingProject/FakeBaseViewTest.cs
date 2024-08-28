using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GUI;
using SERVER;
using Moq;

namespace TestingProject
{
    /// <summary>
    /// Authors: Jack Hughes, Matthew Whitehouse & Marc Price
    /// Date: 24/04/2022
    /// This is used to test the BaseView
    /// reference: https://www.youtube.com/channel/UCRYpBqoEHa-gNcrwJqobC0A/videos
    /// </summary>
    [TestClass]
    public class FakeBaseViewTest
    {
        [TestMethod]
        public void CheckThatCannotBeUsedWithInitCalled()
        {
            #region ARRANGE
            // CREATE a new FakeBaseView
            IBaseView _fakeBaseView = new FakeBaseView();

            // SET  the boolean to false
            bool _exceptionCaught = false;

            #endregion ARRANGE


            #region ACT
            // TEST the BaseView
            try
            {
                (_fakeBaseView as FakeBaseView).AddButtonClick();
            }
            catch (NotInitializedException e)
            {
                _exceptionCaught = true;
            }

            #endregion ACT


            #region ASSERT

            finally
            { 
                Assert.IsTrue(_exceptionCaught); 
            }

            #endregion ASSERT 
        }

        [TestMethod]
        public void CheckThatCanBeUsedWithInitCalled()
        {
            #region ARRANGE
            // CREATE a new FakeBaseView
            IBaseView _fakeBaseView = new FakeBaseView();

            //CREATE a new Mock ICommand 
            var _mockCommand = new Mock<ICommand>();

            // CREATE a new Mock ICommandInvoker
            var _mockCommandInvoker = new Mock<ICommandInvoker>();
            _mockCommandInvoker.Setup(mock => mock.ExecuteCommand(_mockCommand.Object));

            // INITIALISE the _fakeBaseView
            _fakeBaseView.Initialize(_mockCommandInvoker.Object.ExecuteCommand, _mockCommand.Object);

            // SET the boolean to false
            bool _exceptionCaught = false;

            #endregion ARRANGE


            #region ACT
            // TEST the AddButton_Click
            try
            {
                (_fakeBaseView as FakeBaseView).AddButtonClick();
            }
            catch (NotInitializedException e)
            {
                _exceptionCaught = true;
            }

            #endregion ACT


            #region ASSERT

            finally
            {
                Assert.IsFalse(_exceptionCaught);
            }

            #endregion ASSERT 
        }
    }
}
