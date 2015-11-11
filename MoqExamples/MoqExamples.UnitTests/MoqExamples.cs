using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoqExamples.Library;
using Moq;

namespace MoqExamples.UnitTests
{
    [TestFixture]
    public class MoqExamples
    {
        private Mock<ILongRunningLibrary> _longRunningLibrary;

        [SetUp]
        public void SetupForTest()
        {
           _longRunningLibrary = new Mock<ILongRunningLibrary>();
        }

        [Test]
        public void TestLongRunningLibrary()
        {
            const int interval = 10;
            string returnMessage = String.Format("Waited for {0} seconds", interval);

            _longRunningLibrary.Setup(l => l.RunForALongTime(interval)).Returns(returnMessage);

            var result = _longRunningLibrary.Object.RunForALongTime(interval);
            Console.WriteLine("Return from method was '{0}'", result);
            Assert.AreEqual(result, returnMessage);
        }
    }
}
