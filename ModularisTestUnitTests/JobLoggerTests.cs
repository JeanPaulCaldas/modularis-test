using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModularisTest.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.Tests
{
    [TestClass]
    public class JobLoggerTests
    {
        //arrange
        private readonly Message message = new Message("Test message", MessageType.Message);

        [TestMethod]
        public void LogMessageTest()
        {
            //arrange
            var destinations = new LogDestination[] { LogDestination.Console };
            //act - assert
            JobLogger.Instance().LogMessage(message, destinations);
        }

        [TestMethod]
        [ExpectedException(typeof(NoValidArgsException), "Missing args was inappropriately allowed.")]
        public void LogMissingMessages()
        {
            //arrange
            var destinations = new LogDestination[] { LogDestination.Console };
            //act - assert
            JobLogger.Instance().LogMessage(null, destinations);
        }

        [TestMethod]
        [ExpectedException(typeof(NoValidArgsException), "Missing args was inappropriately allowed.")]
        public void LogMissingDestinations()
        {
            //act - assert
            JobLogger.Instance().LogMessage(message, null);
        }

        [TestMethod]
        [ExpectedException(typeof(NoValidArgsException), "Missing args was inappropriately allowed.")]
        public void LogEmptyDestinations()
        {
            //arrange
            var destinations = new LogDestination[] { };
            //act - assert
            JobLogger.Instance().LogMessage(message, destinations);
        }
    }
}