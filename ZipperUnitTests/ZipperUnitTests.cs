using System;
using CreatingTheCustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZipperUnitTests
{
    [TestClass]
    public class ZipperUnitTests
    {
        [TestMethod]
        public void TestMethod1_ZipsBothLists_TakesValuesInBothListsAndAddsThemToNewListInOrderOfIndex()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            TheCustomList<int> myList2 = new TheCustomList<int>();
            TheCustomList<int> myList3 = new TheCustomList<int>();

            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;

            string expected = "1 2 3 4";
            string actual;

            //Act
            myList.Add(value1);
            myList.Add(value3);
            myList2.Add(value2);
            myList2.Add(value4);


            myList3 = myList3.ListZipper(myList, myList2);
            actual = myList3.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1_ZipsBothListsWithDifferentValueAmounts_TakesValuesInBothListsAndAddsThemToNewListInOrderOfIndex()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            TheCustomList<int> myList2 = new TheCustomList<int>();
            TheCustomList<int> myList3 = new TheCustomList<int>();

            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;

            string expected = "1 2 3 4 5";
            string actual;

            //Act
            myList.Add(value1);
            myList.Add(value3);
            myList.Add(value5);
            myList2.Add(value2);
            myList2.Add(value4);


            myList3 = myList3.ListZipper(myList, myList2);
            actual = myList3.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1_CapacityCheck_MakingSureCapacityIsIncreasedInNewList()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            TheCustomList<int> myList2 = new TheCustomList<int>();
            TheCustomList<int> myList3 = new TheCustomList<int>();

            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;

            int expected = 8;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value3);
            myList.Add(value5);
            myList2.Add(value2);
            myList2.Add(value4);


            myList3 = myList3.ListZipper(myList, myList2);
            actual = myList3.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1_CountCheck_TakesValuesInBothListsAndAddsThemToNewListInOrderOfIndex()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            TheCustomList<int> myList2 = new TheCustomList<int>();
            TheCustomList<int> myList3 = new TheCustomList<int>();

            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;

            int expected = 5;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value3);
            myList.Add(value5);
            myList2.Add(value2);
            myList2.Add(value4);


            myList3 = myList3.ListZipper(myList, myList2);
            actual = myList3.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
