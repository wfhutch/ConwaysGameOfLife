using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;
using System.Collections.Generic;

namespace ConwaysGameOfLifeTests
{
    [TestClass]
    public class BoundedWorldTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            BoundedWorld myInstance = new BoundedWorld();
            Assert.IsNotNull(myInstance);
        }

        [TestMethod]
        public void BoundedWorldEnsureWorldIsSmallerThanMax()
        {
            //Begin Arrange
            int height = 80;
            int width = 80;
            //End Arrange

            //Begin Act
            BoundedWorld world = new BoundedWorld(width, height);
            //End Act

            //Begin Assert
            Assert.IsNotNull(world);
            //End Assert
        }

        [TestMethod]
        public void EnsureIHaveArrayOfCorrectSize()
        {
            int height = 80;
            int width = 80;
            BoundedWorld world = new BoundedWorld(width, height);
            int expected_height = height;
            int expected_width = width;

            int actual_height = world.Height;
            int actual_width = world.Width;

            Assert.AreEqual(expected_height, actual_height);
            Assert.AreEqual(expected_width, actual_width);
        }

        [TestMethod]
        public void BoundedWorldEnsureWorldHasCells()
        {
            int height = 100;
            int width = 100;
            BoundedWorld world = new BoundedWorld(width, height);

            int expected_number_of_dead_cells = 10000;
            int expected_number_of_live_cells = 0;
            int actual_number_of_live_cells = world.AliveCellCount();
            int actual_number_of_dead_cells = world.DeadCellCount();

            Assert.AreEqual(expected_number_of_dead_cells, actual_number_of_dead_cells);
            Assert.AreEqual(expected_number_of_live_cells, actual_number_of_live_cells);

        }
    }
}
