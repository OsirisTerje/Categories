using System;
using NUnit.Framework;

namespace Core
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");
    //    }
    //}


    [Category("BigFeature")]
    public class TheCoreFeature
    {
        [Test]
        public void WhateverWeTestInCore()
        {
            Assert.Pass();
        }

        [Category("SomethingElse")]
        [Test]
        public void SomethingElseTestInCore()
        {
            Assert.Pass();
        }
    }
}
