using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MoqExamples.Library
{
    public class LongRunningLibrary :ILongRunningLibrary
    {
        public string RunForALongTime(int interval)
        {
            var timeToWait = interval * 1000;
            Thread.Sleep(timeToWait);
            return string.Format("Waited {0} seconds", interval);
        }
    }
}
