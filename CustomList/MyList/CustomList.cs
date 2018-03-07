using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class CustomList<T> : IEnumerable<T>
    {
        public T[] myArray;
        public int count = 0;
        public int capacity;
    
        public CustomList()
        {
            capacity = 100;
            myArray = new T[capacity];
        }
        public T this[int index]
        {
            get
            {
                return myArray[index];
            }
            set
            {
                myArray[index] = value;
            }
        }
        public override string ToString()
        {
            CustomList<T> overrideString = new CustomList<T>();

            return overrideString[0] + "" + overrideString[0];
        }
        public void Add(T value)
        {
            if (count * 2 > capacity)
            {
                DoubleArraySize();
            }
                
            myArray[count] = value;
            count ++;        
        }
        public void DoubleArraySize()
        {
            myArray = new T[capacity * 2];
        }

        public int FindIndex(T value)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i].Equals(value) == true)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool RemoveObject(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (myArray[i].Equals(value) == true)
                {
                    RemoveObject(value);
                    for (int j = i; j < count; j++)
                    {
                        myArray[j] = myArray[j + 1];
                    }
                    count--;
                    return true;
                }
            }             
                    return false;              
        }       
        public static CustomList<T> operator +(CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> list = new CustomList<T>();

            for (int i = 0; i < one.count; i++)
            {
                list.Add(one[i]);
            }

            for (int i = 0; i < two.count; i++)
            {
                list.Add(two[i]);
            }

            return list;
        }
        public static CustomList<T> operator -(CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> list = new CustomList<T>();

            for (int i = 0; i < one.count; i++)
            {
                list.Add(one[i]);
            }

            for (int i = 0; i < two.count; i++)
            {
                if (two[i].Equals(one[i]))
                {
                    list.RemoveObject(two[i]);
                }
            }
            return list;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < myArray.Length; i++)
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

        public void ZipClasses()
        {
   
            //IEnumerable<string> result = listOne.Zip(listTwo, (a, b) => a.ToString() + b);

            foreach (string s in result)
        {
        
        }
}

