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
            UnboundedWorld instance = new UnboundedWorld();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void UnBoundedEnsureWorldHasZeroCells()
        {
            UnboundedWorld instance = new UnboundedWorld();

            int expected_number_of_cells = 0;
            int actual_number_of_cells = instance.CellCount();

            Assert.AreEqual(expected_number_of_cells, actual_number_of_cells);
        }

        [TestMethod]
        public void UnboundedEnsureThereAreCells()
        {
            UnboundedWorld instance = new UnboundedWorld();

            int x = 4;
            int y = 3;
            instance.AddCell(x,y);

            Assert.AreEqual(1, instance.CellCount());
        }
    }
}

