using Ninject.Activation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqExamples.Ninject
{
    public class WebServiceProxyProvider : Provider<IWebServiceProxy>
    {
        protected override IWebServiceProxy CreateInstance(IContext context)
        {
            var webAddress = "webServiceAddress";
            return new WebServiceProxy(webAddress);
        }
    }
}
