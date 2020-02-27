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
    }
}
