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

        [TestMethod]
        public void CellEnsureCellHasAPosition()
        {
            Cell cell = new Cell();
            Assert.AreEqual(0, cell.X);
            Assert.AreEqual(0, cell.Y);
        }

        [TestMethod]
        public void CellEnsureWeCanProvidePosition()
        {
            int x = 1;
            int y = 2;
            Cell cell = new Cell { X = x, Y = y };
            /* the same as:
             Cell cell = new Cell();
             cell.X = x;
             cell.Y = y;
             */

            Assert.AreEqual(x, cell.X);
            Assert.AreEqual(y, cell.Y);
        }
    }
}
