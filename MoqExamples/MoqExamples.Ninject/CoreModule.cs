using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqExamples.Ninject
{
    public class CoreModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoggingDataSink>().To<LoggingDataSink>();
            Bind<ILoggingComponent>().To<LoggingComponent>();
            Bind<IDataAccessComponent>().ToProvider(new DataAccessComponentProvider());
            Bind<IWebServiceProxy>().ToProvider(new WebServiceProxyProvider());
        }
    }
}
