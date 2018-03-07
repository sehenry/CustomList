using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyList;

namespace MyListTest
{
    [TestClass]
    public class MyListTesting
    {
        [TestMethod]
        public void TestMethodAddInt()
        {
            CustomList<int> add = new CustomList<int>() { 1, 2, 3, 4, 5 };

            int addedToList = 6;

            add.Add(addedToList);

            Assert.AreEqual(6, add.count);
        }
        [TestMethod]
        public void TestMethodAddString()
        {
            CustomList<string> add = new CustomList<string> { "hello", "world", "sarah", "is", "awesome" };

            string addedToList = "koda";

            add.Add(addedToList);

            Assert.AreEqual(6, add.count);
        }

        [TestMethod]
        public void TestIndexOfAdded()
        {
            CustomList<double> add = new CustomList<double> { 23.1, 31.9, 1.77, 6.799, 10.09 };

            double addedToList = 1000.14;

            add.Add(addedToList);

            Assert.AreEqual(add[5], addedToList);
        }

        [TestMethod]
        public void TestMethodRemove()
        {
            CustomList<int> remove = new CustomList<int> { 3, 7, 22, 34, 1 };

            int removeFromList = 3;

            remove.RemoveObject(removeFromList);

            Assert.AreEqual(4, remove.count);
        }
        [TestMethod]
        public void TestRemoveMethod()
        {
            CustomList<int> remove = new CustomList<int> { 1, 2, 3, 4, 5 };

            int removeFromList = 1;

            remove.RemoveObject(removeFromList);

            Assert.AreEqual(remove[0], 2);
        }

        [TestMethod]

        public void TestIndexOfRemovedInt()
        {
            CustomList<int> remove = new CustomList<int> { 4, 23, 32, 47, 50 };

            int removeFromList = 32;

            remove.FindIndex(removeFromList);

            Assert.AreNotEqual(remove[2], removeFromList);
        }
        [TestMethod]
        public void TestPlusOperator()
        {
            CustomList<int> one = new CustomList<int> { 3, 4, 7, 12, 15 };
            CustomList<int> two = new CustomList<int> { 6, 1, 18, 20, 5 };

            CustomList<int> finalList = one + two;

            Assert.AreEqual(10, finalList.count);
        }

        [TestMethod]
        public void TestMinusOperator()
        {
            CustomList<int> one = new CustomList<int> { 1, 4, 22, 33, 11, 6, 18 };
            CustomList<int> two = new CustomList<int> { 1, 3, 22, 44, 52, 6, 19 };

            CustomList<int> finalList = one - two;

            Assert.AreEqual(11, finalList.count);
        }
        //[TestMethod]
        //public void TestZipClasses()
        //{
        //    MyList < int > odd = new MyList<int> { 1, 3, 5};
        //    MyList < int > even = new MyList<int> { 2, 4, 6,};

        //    MyList<int> zipResult = odd.ZipClassesTogether(even);

        //    Assert.AreEqual(zipResult[1], 2);
        //}

    }
}
       
    

