using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;

namespace ConwaysGameOfLifeTests
{
    [TestClass]
    public class CellTests
    {
        [TestMethod]
        public void CellEnsureCellIsAlive()
        {
            // Object Initializer Syntax
            // Use public setters when creating new instance
            // Use {} instead of ()
            Cell cell = new Cell { IsAlive = true };
            Assert.IsTrue(cell.IsAlive);
        }

        [TestMethod]
        public void CellEnsureIsDeadByDefault()
        {
            Cell cell = new Cell();
            Assert.IsFalse(cell.IsAlive);
        }
    }
}
