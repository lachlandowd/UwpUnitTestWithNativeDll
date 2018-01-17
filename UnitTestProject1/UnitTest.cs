using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using SamplesNative;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var helper = new DeviceLostHelper();
        }
    }
}
