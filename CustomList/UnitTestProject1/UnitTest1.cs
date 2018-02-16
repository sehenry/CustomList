using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace MyListTest
{
    [TestClass]
    public double[] numbersAdded = new double[6];

    public class MyListTesting
    {
        [TestMethod]
        public void TestMethodAddInt()
        {
            MyList<int> add = new MyList<int>() { 1, 2, 3, 4, 5};
                     
            int addedToList = 6;        
                 
            add.Add(addedToList);

            Assert.AreEqual(6, add.Count);
        }
        [TestMethod]
        public void TestMethodAddString()
        {
            MyList<string> add = new MyList<string> { "hello", "world", "sarah", "is", "awesome" };

            string addedToList = "koda";

            add.Add(addedToList);

            Assert.AreEqual(6, add.Count);
        }
        [TestMethod]
        public void TestMethodAddDouble()
        {
            MyList<double> add = new MyList<double> { 23.1, 31.9, 1.77, 6.799, 10.09 };

            double addedToList = 1000.14;
            double i = 0;
            add.Add(addedToList);

            Assert.AreEqual(add[5], addedToList); //check that addedToList is at index [5]
        }

        [TestMethod]
        public void TestMethodRemove()
        {
            MyList<int> subtract = new MyList<int>();

            int removeFromList = 3;

            subtract.Remove(removeFromList);

            Assert.AreEqual(-1, subtract.Count);
        }
        [TestMethod]
        public void TestIterateList()
        {

        }
    }
}
