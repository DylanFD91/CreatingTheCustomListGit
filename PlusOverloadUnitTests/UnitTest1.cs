using System;
using CreatingTheCustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlusOverloadUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_CountTest()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            TheCustomList<int> myList2 = new TheCustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            int expected = 6;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList2.Add(value4);
            myList2.Add(value5);
            myList2.Add(value6);

            TheCustomList<int> result = myList + myList2;

            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_FirstIndexChecker()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            TheCustomList<int> myList2 = new TheCustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;

            int expected = 1;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList2.Add(value3);


            TheCustomList<int> result = myList + myList2;
            actual = result[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_LastIndexChecker()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            TheCustomList<int> myList2 = new TheCustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;

            int expected = 3;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList2.Add(value3);

            TheCustomList<int> result = myList + myList2;
            actual = result[2];

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethod4_ReportOutValues()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            TheCustomList<int> myList2 = new TheCustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;

            int expected1 = 1;
            int actual1;
            int expected2 = 2;
            int actual2;
            int expected3 = 3;
            int actual3;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList2.Add(value3);

            TheCustomList<int> result = myList + myList2;
            actual1 = result[0];
            actual2 = result[1];
            actual3 = result[2];

            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
        [TestMethod]
        public void TestMethod5_CapacityOfNewList()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            TheCustomList<int> myList2 = new TheCustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;

            int expected = 8;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList2.Add(value4);
            myList2.Add(value5);

            TheCustomList<int> result = myList + myList2;

            actual = result.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
