using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqExamples.Ninject
{
    public class BusinessService
    {
        private readonly string _databaseConnectionString = "dbString";
        private readonly string _webServiceAddress = "webAddress";
        private readonly ILoggingDataSink _loggingDataSink;

        private IDataAccessComponent _dataAccessComponent;
        private IWebServiceProxy _webServiceProxy;
        private ILoggingComponent _loggingComponent;

        public BusinessService()
        {
            _loggingDataSink = new LoggingDataSink();
            _loggingComponent = new LoggingComponent(_loggingDataSink);
            _webServiceProxy = new WebServiceProxy(_webServiceAddress);
            _dataAccessComponent = new DataAccessComponent(_databaseConnectionString);
        }

    }
}
