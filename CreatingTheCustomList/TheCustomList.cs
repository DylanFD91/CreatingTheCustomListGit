using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTheCustomList
{
    public class TheCustomList<T>
    {
        private int capacity = 4;
        private int count = 0;
        T[] Items;
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



        public void Remove(T item)
        {
            try//sets items to null
            {
                ListShifter(item);
            }
            catch (IndexOutOfRangeException ex)//throws exception if any object chosen isnt in the range
            {
                throw ex;
            }
        }
        private void ListShifter(T item)
        {
            int j = 0;
            T[] tempArray = new T[count];
            for (int tempArrayIndex = 0; tempArrayIndex < capacity; tempArrayIndex++)
            {

                if (Items[tempArrayIndex].Equals(item))//go through the index till i hit the passed item
                {
                    count--;
                }
                else//continue through the index
                {
                    //transfer content to temp array
                    tempArray[j] = Items[tempArrayIndex];
                    j++;
                }
            }
            Items = tempArray;
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
            
            for (int i = 0; i < list1.count; i++)
            {
                combinedList.Add(list1[i]);
            }

            for (int i = 0; i < list2.count; i++)
            {
                combinedList.Add(list2[i]);
            }

            return combinedList;
        }
    }
}
