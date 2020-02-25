using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreatingTheCustomList;

namespace TestTheCustomList
{
    [TestClass]
    public class AddUnitTests
    {
        [TestMethod]
        public void Add_OneValue_ListCountIncrement()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            int expected = 1;

            //Act
            myList.Add(5);

            //Assert
            Assert.AreEqual(expected, myList.Count);
        }
        [TestMethod]
        public void Add_ExpectingAValue_ExpectingASpecificValueAddedToTheList()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            int expected = 5;

            //Act
            myList.Add(expected);

            //Assert
            Assert.AreEqual(expected, myList[0]);
        }
        [TestMethod]
        public void Add_SpecificNumbers_ExpectingTheIndexToEqualASpecificInteger()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            int expected = 5;
            int fillValue1 = 7;
            int fillValue2 = 11;

            //Act
            myList.Add(expected);
            myList.Add(fillValue1);
            myList.Add(fillValue2);

            //Assert
            Assert.AreEqual(expected, myList[0]);
        }
        [TestMethod]
        public void Add_AddingNegativeNumbers_BeingAbleToAddNegativeNumbersInTheList()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            int expected = -10;

            //Act
            myList.Add(expected);

            //Assert
            Assert.AreEqual(expected, myList[0]);
        }
        [TestMethod]
        public void Add_CapacityIncrease_MakingSureThatTheCapcityIncreasesInTheListAndKeepsOriginalValues()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            int expectedListCount = 6;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);


            //Assert
            Assert.AreEqual(expectedListCount, myList[5]);
        }
    }
}
