﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Ninject;
using MoqExamples.Ninject;

namespace MoqExamples.UnitTests
{
    [TestFixture]
    public class NinjectTests
    {
        [Test]
        public void ShouldBeAbleToGetBusinessServiceFromNinject()
        {
            BusinessService actual;
            var kernel = new StandardKernel(new CoreModule());
            actual = kernel.Get<BusinessService>();
            Assert.IsNotNull(actual);
        }
    }
}
