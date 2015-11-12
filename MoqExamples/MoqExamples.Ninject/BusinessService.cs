using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqExamples.Ninject
{
    public class BusinessService
    {
        private IDataAccessComponent _dataAccessComponent;
        private IWebServiceProxy _webServiceProxy;
        private ILoggingComponent _loggingComponent;

        public BusinessService(ILoggingComponent loggingComponent,
                               IWebServiceProxy webServiceProxy,
                               IDataAccessComponent dataAccessComponent)
        {
            _loggingComponent = loggingComponent;
            _webServiceProxy = webServiceProxy;
            _dataAccessComponent = dataAccessComponent;
        }

    }
}
