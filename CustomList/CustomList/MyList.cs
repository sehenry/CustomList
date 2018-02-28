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
        public T[] myArray = new T[100];        
        public int count = 0;
        public int capacity = 100;
        public int i = 0;

        public T this[int index]
        {
            get
            {
                return myArray[index];
            }
            set
            {             
            }
        }
        public override string ToString()
        {
            return this.ToString();
        }

        public void Add(T value)
        {
            myArray[count] = value;
            count += 1;

            if (count * 2 > capacity)
            DoubleArraySize();
        } 
        public void DoubleArraySize()
        {
            myArray = new T[capacity * 2];
        }

        public int FindIndex(T value)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i].Equals(value)== true) 
                {
                    return i;
                }
            }
            return -1;
        }

        public int RemoveObject(T value)
        {
            myArray[i] = value;

            count--;
            return i;
        }

        public void AddListsTogether()
        {

        }

        public void SubtractOneListFromAnother()
        {

        }

        //public void ZipClassesTogether()
        //{
        //    //figure out how to have two instances of list or array as variables to then be used in the IEnumerable
        //    IEnumerable<string> result = listOne.Zip(listTwo, (a, b) => a.ToString() + b);

        //    foreach(string s in result)
        //    {
        //        return;
        //    }
        //}

        public IEnumerator<T> GetEnumerator() 
        {
            for(int i = 0; i < myArray.Length; i++)
            {
                yield return myArray[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
