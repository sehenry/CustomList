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
        public static int i = 0;

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
            T[] newArray = new T[100];        

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i].Equals(value) == true)
                {
                    count--;                   
                }
                else
                {
                    // add to newArray;
                    newArray[i] = myArray[i];
                }
            }

            myArray = newArray;

            return -1;
        }
        public static MyList<T> operator+ (MyList<T> one, MyList<T> two)
        {           
            MyList<T> list = new MyList<T>();
            
            for (i = 0; i< one.count; i++)
            {
                list.Add(one[i]);
            }

            for(i = 0; i< two.count; i++)
            {
                list.Add(two[i]);
            }

            return list;
        }
        public static MyList<T> operator- (MyList<T> one, MyList<T> two)
        {
            MyList<T> list = new MyList<T>();

            for (i = 0; i < one.count; i++)
            {
                list.Add(one[i]);
            }

            for (i = 0; i < two.count; i++)
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

//public void OverLoadPlusOperator(T list1, T list2)
//{
//    list1 = myArray[i];
//    list2 = myArray[i];



//    //myArray = new T [list1.AddRange(list2)];

//}

//public void ZipClassesTogether()
//{
//    //figure out how to have two instances of list or array as variables to then be used in the IEnumerable
//    IEnumerable<string> result = listOne.Zip(listTwo, (a, b) => a.ToString() + b);

//    foreach(string s in result)
//    {
//        return;
//    }
//}
//public void AddRange(IEnumerable<T> collection)
//{
//    T list1 = myArray[i];
//    T list2 = myArray[i];

//    // myArray = new T [list1.Add(list2)];
//}

