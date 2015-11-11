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
           _longRunningLibrary
                .Setup(l =>
                    l.RunForALongTime(It.IsAny<int>()))
                .Returns((int s) => 
                    string.Format("This method has been mocked! The input value is {0}", s));
           _longRunningLibrary
                .Setup(l =>
                    l.RunForALongTime(0))
                .Throws(new ArgumentException("0 is not a valid interval"));
        }

        [Test]
        public void TestLongRunningLibrary()
        {
            var result = _longRunningLibrary.Object.RunForALongTime(0);
            Console.WriteLine("Return from method was '{0}'", result);
            Assert.AreEqual(result, "This method has been mocked! The input value is 0");
        }
    }
}
