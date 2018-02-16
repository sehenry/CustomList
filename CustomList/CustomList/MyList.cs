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
        public int Count; 
        public T Add(T value)
        {
            return value;
        }
        public T Remove(T value)
        {
            return value;
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
