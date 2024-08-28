using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using GUI;

namespace TestingProject
{
    /// <summary>
    /// Authors: Jack Hughes & Matthew Whitehouse
    /// Date: 03/04/2022
    /// Tests the CommandInvoker
    /// reference: https://www.youtube.com/channel/UCRYpBqoEHa-gNcrwJqobC0A/videos
    /// </summary>
    [TestClass]
    public class CommandInvokerTest
    {
        /// <summary>
        /// Tests the CommandInvoker 
        /// </summary>
        [TestMethod]
        public void ShouldCallExecuteCommand()
        {
            #region ARRANGE

            // DEFINE an ICommandInvoker, call it _testInvoker
            ICommandInvoker _testInvoker = new CommandInvoker();

            // DEFINE a variable, call it _mockCommand
            var _mockCommand = new Mock<ICommand>();

            // CALL Setup method form _mockCommand
            _mockCommand.Setup(mock => mock.Execute());

            // SET boolean as TRUE, call it _hasPassed
            bool _hasPassed = true;

            #endregion ARRANGE


            #region ACT

            // CALL ExecuteCommand from _testInvoker
            _testInvoker.ExecuteCommand(_mockCommand.Object);

            #endregion ACT


            #region ASSERT

            // Try catch block
            try
            {
                // CALL Verify method of _mockCommand
                _mockCommand.Verify(mock => mock.Execute(), Times.Once());
            }
            catch (MockException e)
            {
                // SET _hasPassed to FALSE
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
