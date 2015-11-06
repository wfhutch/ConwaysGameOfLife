using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;
using System.Collections.Generic;

namespace ConwaysGameOfLifeTests
{
    [TestClass]
    public class RuleTests
    {
        [TestMethod()]
        public void ConstructorTest()
        {
            List<List<bool>> initialState = new List<List<bool>>();
            initialState.Add(new List<bool>(new bool[] { true, false }));
            initialState.Add(new List<bool>(new bool[] { false, false }));

            Board conways = new ConwaysGameOfLife.ConwaysGameOfLife(initialState);

            CollectionAssert.AreEquivalent(conways.ToList(), initialState);

        }

        [TestMethod()]
        public void Rule1Test()
        {
            List<List<bool>> initialState = new List<List<bool>>();
            initialState.Add(new List<bool>(new bool[] { true, false }));
            initialState.Add(new List<bool>(new bool[] { false, false }));

            Board conways = new ConwaysGameOfLife.ConwaysGameOfLife(initialState);
            conways.Tick();

            List<List<bool>> expectedState = new List<List<bool>>();
            initialState.Add(new List<bool>(new bool[] { false, false }));
            initialState.Add(new List<bool>(new bool[] { false, false }));

            CollectionAssert.AreEqual(expectedState[0], conways.ToList()[0]);
            CollectionAssert.AreEqual(expectedState[1], conways.ToList()[1]);
        }
    



        //[TestMethod]
        //public void OneLiveCell()
        //{
        //    List<List<bool>> row = new List<List<bool>>();
        //    row.Add(new List<bool>(new bool[] { true, true, true }));
        //    row.Add(new List<bool>(new bool[] { true, false, true }));
        //    row.Add(new List<bool>(new bool[] { true, true, true }));

        //}
    }
}
