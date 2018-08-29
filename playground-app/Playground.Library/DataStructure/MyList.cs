using System;
using System.Collections.Generic;

namespace Playground.Library.DataStructure
{
    /// <summary>
    /// Constant time data structure
    /// </summary>
    public class MyList<T> where T : new()
    {
        private List<T> _myList;

        private Dictionary<T, int> _myDict;

        public MyList()
        {
            _myList = new List<T>();
            _myDict = new Dictionary<T, int>();
        }

        public int Length
        {
            get
            {
                return _myList.Count;
            }
        }

       public void Add(T data)
        {
            if (_myDict.ContainsKey(data))
                return;

            _myList.Add(data);
            _myDict.Add(data, Length - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)this;
        }

        public void Remove(T data)
        {
            var index = _myDict[data];
            _myDict.Remove(data);

            var lastData = _myList[Length - 1];
            SwapWithLast(index);

            _myList.RemoveAt(Length - 1);

            _myDict.Add(lastData, index);
        }

        public T GetRandom()
        {
            var random = new Random();
            var randIndex = random.Next(Length - 1);

            return _myList[randIndex];
        }

        private void SwapWithLast(int index)
        {
            var temp = _myList[Length - 1];
            _myList[Length - 1] = _myList[index];
            _myList[index] = temp;
        }

    }
}
