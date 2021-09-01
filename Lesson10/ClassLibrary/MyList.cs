using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class MyList : IList<MyItem>
    {
        private List<MyItem> objectMyItem = new List<MyItem>();

        public MyItem this[int index]
        {
            get { return objectMyItem[index]; }
            set { objectMyItem[index] = value; }
        }

        public int Count
        {
            get { return objectMyItem.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(MyItem item)
        {
            objectMyItem.Add(item);
        }

        public void Clear()
        {
            objectMyItem.Clear();
        }

        public bool Contains(MyItem item)
        {
            return objectMyItem.Contains(item);
        }

        public void CopyTo(MyItem[] array, int arrayIndex)
        {
            objectMyItem.CopyTo(array, arrayIndex);
        }

        public IEnumerator<MyItem> GetEnumerator()
        {
            return objectMyItem.GetEnumerator();
        }

        public int IndexOf(MyItem item)
        {
            return objectMyItem.IndexOf(item);
        }

        public void Insert(int index, MyItem item)
        {
            objectMyItem.Insert(index, item);
        }

        public bool Remove(MyItem item)
        {
            return objectMyItem.Remove(item);
        }

        public void RemoveAt(int index)
        {
            objectMyItem.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return objectMyItem.GetEnumerator();
        }
    }
}
