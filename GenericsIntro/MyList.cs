using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] list;
        //constructor
        public MyList()
        {
            list = new T[0];
        }
        public void Add(T item) 
        {
            T[] tempArray = list;
            list = new T[list.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                list[i] = tempArray[i];
            }
            list[list.Length-1] = item;
        }
    }
}
