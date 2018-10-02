using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Categories
{
    [Category("BigFeature")]
    public class TheBigFeature
    {
        [Test]
        public void WhateverWeTest()
        {
            Assert.Pass();
        }

        [Category("SomethingElse")]
        [Test]
        public void SomethingElseTest()
        {
            Assert.Pass();
        }
    }
}
