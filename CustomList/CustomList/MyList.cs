using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList <T>: IEnumerable <T>
    {
        public T[] myArray = new T[10];        
        public int Count = 0;
       

        public T this[T index]
        {
            get
            {
                return index;
            }
        }
        public override string ToString()
        {
            return this.ToString();
        }

        public void Add(T value)
        {
            myArray[Count] = value;
            Count += 1;

            //return this.value = value;
            //myList.Add(value);
        }
        public bool Remove(T value)
        {
            return true;
        }

        //public IEnumerator<T> IterateList() can I not call the IEnumerator something else?
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
