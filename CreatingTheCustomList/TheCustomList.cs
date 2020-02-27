using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTheCustomList
{
    public class TheCustomList<T> : IEnumerable
    {
        private int capacity = 4;
        private int count = 0;
        private T[] Items;
        public T this[int i]//Indexer
        {
            get => Items[i];
            set => Items[i] = value;
        }
        public TheCustomList()//Builds a custom list
        {
            Items = new T[capacity];
        }
        public int Count//Gets the count and allows the index count to be acessed
        {
            get 
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public void Add(T item)
        {
            //count == maxcapacity, we need to increase capacity and copy
            if (Count == Capacity)
            {
                ResizeArray();
            }
            //increment count
            AddItemToList(item);

            //item needs to land at next available index
            ListIndexIncrease();

        }
        private void ResizeArray()//Resizes array when capacity is reached
        {
            T[] TempArray = new T[capacity *= 2];

            for (int tempArrayIndex = 0; tempArrayIndex < count; tempArrayIndex++)
            {
                TempArray[tempArrayIndex] = Items[tempArrayIndex];
            }
            Items = TempArray;
        }
        private void AddItemToList(T item)//Adds an item to the list on the current count of index
        {
            Items[count] = item;
        }
        private void ListIndexIncrease()//increases the list index count after an item is added
        {
            count++;
        }



        public bool Remove(T item)
        {
            int j = 0;
            bool removedItem = false;
            T[] tempArray = new T[count];
            for (int tempArrayIndex = 0; tempArrayIndex < count; tempArrayIndex++)
            {
                if (Items[tempArrayIndex].Equals(item))//go through the index till i hit the passed item
                {
                    removedItem = true;
                }
                else//continue through the index
                {
                    //transfer content to temp array
                    tempArray[j] = Items[tempArrayIndex];
                    j++;
                }
            }
            Items = tempArray;
            if(removedItem == true)
            {
                count--;
            }
            return removedItem;
        }



        public override string ToString()
        {
            string stringReturn = "";
            for (int i = 0; i < count; i++)
            {
                if (i == 0)
                {
                    stringReturn += Items[i];
                }
                else
                {
                    stringReturn += " " + Items[i];
                }
            }
            return stringReturn;
        }



        public static TheCustomList<T> operator+ (TheCustomList<T> list1, TheCustomList<T> list2)
        {
            TheCustomList<T> combinedList = new TheCustomList<T>();
            for (int i = 0; i < list1.Count; i++)
            {
                combinedList.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                combinedList.Add(list2[i]);
            }
            return combinedList;
        }
        public static TheCustomList<T> operator- (TheCustomList<T> list1, TheCustomList<T> list2)
        {
            TheCustomList<T> finalList = list1.ReturnCopyList();

            for (int i = 0; i < list2.count; i++)//removes copies of list 1 and 2 from final list
            {
                finalList.Remove(list2[i]);
            }
            return finalList;
        }
        private TheCustomList<T> ReturnCopyList()
        {
            TheCustomList<T> copiedList = new TheCustomList<T>();
            for (int i = 0; i < Count; i++)//copies list 1 to final list return
            {
                copiedList.Add(Items[i]);
            }
            return copiedList;
        }



        public TheCustomList<T> ListZipper(TheCustomList<T> list1, TheCustomList<T> list2)
        {
            TheCustomList<T> zippedList = new TheCustomList<T>();
            int combinedListCount = list1.count + list2.count;
            for (int i = 0; i < combinedListCount; i++)
            {
                zippedList.Add(list1[i]);
                zippedList.Add(list2[i]);
            }
            return zippedList;
        }



        public IEnumerator GetEnumerator()
        {
            TheCustomList<T> fill = new TheCustomList<T>();
            for (int i = 0; i < count; i++)
            {
                yield return fill;
            }
        }
    }
}
