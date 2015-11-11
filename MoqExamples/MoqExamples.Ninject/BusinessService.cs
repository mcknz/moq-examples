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

        public BusinessService(IDataAccessComponent dataAccessComponent)
        {
            _dataAccessComponent = dataAccessComponent;
        }

    }
}
