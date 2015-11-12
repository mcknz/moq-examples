using Ninject.Activation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqExamples.Ninject
{
    public class DataAccessComponentProvider : Provider<IDataAccessComponent>
    {
        protected override IDataAccessComponent CreateInstance(IContext context)
        {
            var dbConnectionString = "dbString";
            return new DataAccessComponent(dbConnectionString);
        }
    }
}
