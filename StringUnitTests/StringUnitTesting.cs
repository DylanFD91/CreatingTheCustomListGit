using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreatingTheCustomList;

namespace StringUnitTests
{
    [TestClass]
    public class StringUnitTesting
    {
        [TestMethod]
        public void ToStringOverride_CreateAListOfIntsAndGetAString_TakesAListAndOutputsAllValuesAsAString()
        {
            //Arrange
            TheCustomList<int> myList = new TheCustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            string expected = "1 2 3 4 5";
            string actual = "";

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);

            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
