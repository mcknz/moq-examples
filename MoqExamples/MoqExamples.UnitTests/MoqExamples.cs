using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoqExamples.Library;

namespace MoqExamples.UnitTests
{
    [TestFixture]
    public class MoqExamples
    {
        //_longRunningLibrary

        [SetUp]
        public void SetupForTest()
        {
           // _longRunningLibrary = new LongRunningLibrary();
        }

        [Test]
        public void TestLongRunningLibrary()
        {
            const int interval = 10;
            ILongRunningLibrary longRunningLibrary = new LongRunningLibrary();
            var result = longRunningLibrary.RunForALongTime(interval);
            Console.WriteLine("Return from method was '{0}'", result);
        }
    }
}
