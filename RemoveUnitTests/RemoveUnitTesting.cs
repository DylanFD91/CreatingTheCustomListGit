using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreatingTheCustomList;

namespace RemoveUnitTests
{
    [TestClass]
    public class RemoveUnitTesting
    {
        [TestMethod]
        public void Remove_RemovingAnObject_RemoveAnObjectAtSpecifiedIndex()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            int value1 = 1;
            int expected = 0;

            //Act
            myList.Add(value1);

            myList.Remove(value1);

            //Assert
            Assert.AreEqual(expected, myList[0]);
        }
        [TestMethod]
        public void Remove_RemovingAnObjectAndSeeingIfItemsGetMovedUp_RemoveAnObjectAtSpecifiedIndexThenTheRestOfTheIndexShiftsUp()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;

            int expected = 3;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);

            myList.Remove(value2);

            //Assert
            Assert.AreEqual(expected, myList[1]);
        }
        [TestMethod]
        public void Remove_RemovingAnObjectExpandedArray_RemovingAnObjectInAExpandedArray()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            int expected = 6;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);

            myList.Remove(value5);

            //Assert
            Assert.AreEqual(expected, 6);
        }
        [TestMethod]
        public void Remove_RemoveAnObjectNotInArray_TryingToRemoveAnObjectThatDoesntExistShouldThrowException()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            int value1 = 1;

            //Act
            myList.Add(value1);

            myList.Remove(myList[2]);

            //Assert

        }
    }
}
