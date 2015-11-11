using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoqExamples.Library
{
    public class LongRunningLibrary :ILongRunningLibrary
    {
        public string RunForALongTime(int interval)
        {
            throw new NotImplementedException();
        }
    }
}
