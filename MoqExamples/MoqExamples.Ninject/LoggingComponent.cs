﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoqExamples.Ninject
{
    public class LoggingComponent : ILoggingComponent
    {
        public LoggingComponent(ILoggingDataSink loggingDataSink)
        {
        }
    }
}
