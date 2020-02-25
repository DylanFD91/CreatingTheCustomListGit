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

        public T this[int i]
        {
            get => Items[i];
            set => Items[i] = value;
        }


        /*public int Count
        {
            get;
        }*/

        public void Add(T item)
        {
            //increment count
            AddItemToList(item);

            //item needs to land at next available index
            ListIndexIncrease();

            //count == maxcapacity, we need to increase capacity and copy
            ResizeArray();

        }

        private void ResizeArray()
        {
            T[] TempArray = new T[capacity *= 2];

            for (int tempArrayIndex = 0; TempArray.Length < Items.Length; tempArrayIndex++)
            {
                TempArray[tempArrayIndex] = Items[tempArrayIndex];
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
