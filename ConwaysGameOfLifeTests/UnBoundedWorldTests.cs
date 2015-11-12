using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;
using System.Collections.Generic;

namespace ConwaysGameOfLifeTests
{
    [TestClass]
    public class UnBoundedWorldTests
    {
                    [TestMethod]
        public void UnboundedEnsureICanCreateAnInstance()
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

        [TestMethod]
        public void UnboundedEnsureCorrectNumberOfAliveNeighbors()
        {
            UnboundedWorld instance = new UnboundedWorld();

            instance.AddCell(4, 4);
            instance.AddCell(4, 5);
            instance.AddCell(4, 3);
            List<Cell> expected_alive_neighbors = new List<Cell>
            {
                new Cell {X = 4, Y = 5 },
                new Cell {X = 4, Y = 3 }
                
            };
            List<Cell> actual_alive_neighbors = instance.AliveNeighbors(4,4);
            int expected_alive_neighbors_count = 2;
            int actual_alive_neighbors_count = actual_alive_neighbors.Count;

            //Assert.IsTrue(actual_alive_neighbors[0].Equals(new Cell { X = 4, Y = 5 }));


            //CollectionAssert.AreEqual(expected_alive_neighbors, actual_alive_neighbors);
            Assert.AreEqual(expected_alive_neighbors_count, actual_alive_neighbors_count);


        }
    }
}

