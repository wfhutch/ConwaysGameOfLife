using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;

namespace ConwaysGameOfLifeTests
{
    [TestClass]
    public class UnBoundedWorldTests
    {
                    [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            UnboundedWorld myInstance = new UnboundedWorld();
            Assert.IsNotNull(myInstance);
        }
    }
}

