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
        int count = 0;
        T[] Items;
        public void Add(T item)
        {
            //increment count
            AddItemToList(item);

            //item needs to land at next available index
            ListIndexIncrease();

            //check to make sure it persists


            //count == maxcapacity, we need to increase capacity and copy
            ResizeArray();

        }

        private void ResizeArray()
        {
            T[] TempArray = new T[capacity *= 2];
            int tempArrayIndexCounter = 0;
            int tempItemsIndexCounter = 0;
            for (int tempArrayIndex = 0; TempArray.Length < Items.Length; tempArrayIndex++)
            {
                TempArray[tempArrayIndexCounter].Equals(Items[tempItemsIndexCounter]);
                tempArrayIndexCounter++;
                tempItemsIndexCounter++;
            }
            Items = TempArray;
        }

        private void AddItemToList(T item)
        {
            Items[count] = item;
        }
        private void ListIndexIncrease()
        {
            count++;
        }
    }
}
