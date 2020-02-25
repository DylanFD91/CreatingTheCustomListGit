using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTheCustomList
{
    public class TheCustomList<T>
    {
        int capacity = 4;
        public int count = 0;
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

        public void Add(T item)
        {
            //count == maxcapacity, we need to increase capacity and copy
            if (Count == capacity)
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

            for (int tempArrayIndex = 0; TempArray.Length < Items.Length; tempArrayIndex++)
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
            try
            {

            }
            catch (System.IndexOutOfRangeException ex)
            {

                throw;
            }
        }
    }
}
