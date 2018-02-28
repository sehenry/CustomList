using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace MyListTest
{
    [TestClass]
    public class MyListTesting
    {
        [TestMethod]
        public void TestMethodAddInt()
        {
            MyList<int> add = new MyList<int>() { 1, 2, 3, 4, 5 };

            int addedToList = 6;

            add.Add(addedToList);

            Assert.AreEqual(6, add.count);
        }
        [TestMethod]
        public void TestMethodAddString()
        {
            MyList<string> add = new MyList<string> { "hello", "world", "sarah", "is", "awesome" };

            string addedToList = "koda";

            add.Add(addedToList);

            Assert.AreEqual(6, add.count);
        }

        [TestMethod]
        public void TestIndexOfAdded()
        {
            MyList<double> add = new MyList<double> { 23.1, 31.9, 1.77, 6.799, 10.09 };

            double addedToList = 1000.14;

            add.Add(addedToList);

            Assert.AreEqual(add[5], addedToList);
        }

        [TestMethod]
        public void TestMethodRemove()
        {
            MyList<int> remove = new MyList<int> { 3, 7, 22, 34, 1 };

            int removeFromList = 3;

            remove.RemoveObject(removeFromList);

            Assert.AreEqual(4, remove.count);
        }

        [TestMethod]

        public void TestIndexOfRemovedInt()
        {
            MyList<int> remove = new MyList<int> { 4, 23, 32, 47, 50 };

            int removeFromList = 32;

            remove.FindIndex(removeFromList);

            Assert.AreEqual(remove[2], removeFromList);
        }
        //[TestMethod]
        //public void TestZipClasses()
        //{
        //    MyList < int > odd = new MyList<int> { 1, 3, 5};
        //    MyList < int > even = new MyList<int> { 2, 4, 6,};

        //    int zipResult;

        //    zipResult = odd.ZipClassesTogether(even); //figure out how to test the IEnumerable

        //    Assert.AreEqual(zipResult[1], 2);
        //}

    }
}
       
    

