using System;
using System.Collections.Generic;

namespace MyCollectionBild
{
    public class MyCollection<T>
    {
        private List<T> collectionList = new List<T>();

        public void AddUnit(T unit)
        {
            collectionList.Add(unit);
        }

        public T this[int number]
        {
            get { return collectionList[number]; } 
        }

        public int CountUnit
        {
            get { return collectionList.Count; }
        }
    }
}
