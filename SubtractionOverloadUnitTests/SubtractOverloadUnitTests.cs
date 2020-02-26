using System;
using CreatingTheCustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SubtractionOverloadUnitTests
{
    [TestClass]
    public class SubtractOverloadUnitTests
    {
        [TestMethod]
        public void SubtractOverload_SubtractingOneValue_RemovingOneValueFromOriginalList()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            TheCustomList<int> myList2 = new TheCustomList<int>();
            int value1 = 1;
            int value2 = 2;

            int expected = 1;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList2.Add(value2);

            TheCustomList<int> result = myList - myList2;

            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractOverload_SubractTwoValues_RemoveTwoValuesFromOriginalList()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            TheCustomList<int> myList2 = new TheCustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;

            int expected = 2;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList2.Add(value1);
            myList2.Add(value2);
            myList2.Add(value5);

            TheCustomList<int> result = myList - myList2;

            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractOverload_CheckCount_MakingSureTheCountEqualsTheRemainingVariables()
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

            int expected = 5;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);
            myList2.Add(value2);

            TheCustomList<int> result = myList - myList2;

            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractOverload_CapacityCheck_MakingSureCapacityDoesntIncreaseAfterRemoval()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            TheCustomList<int> myList2 = new TheCustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;

            int expected = 4;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList2.Add(value2);

            TheCustomList<int> result = myList - myList2;

            actual = result.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractOverload_IndexCheck_MakingSureValuesAreAtProperIndex()
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
            myList.Add(value3);
            myList2.Add(value2);

            TheCustomList<int> result = myList - myList2;

            actual = result[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
