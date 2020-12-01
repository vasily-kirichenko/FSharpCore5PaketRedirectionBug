using System;
using FSharpCore5PaketRedirectionBug;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, Settings.Default.foo);
        }
    }
}