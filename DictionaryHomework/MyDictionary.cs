using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryHomework
{
    class MyDictionary<K,V>
    {
        K[] array1;
        K[] tempArray1;
        V[] array2;
        V[] tempArray2;
        
        public MyDictionary()
        {

            array1 = new K[0];
            array2 = new V[0];
   
        }
        public void Add(K item1, V item2 )
        {
            tempArray1 = array1;
            

            array1 = new K[array1.Length + 1];
            

            for (int  i= 0; i < tempArray1.Length; i++)
            {
                array1[i] = tempArray1[i];
               
            }

            array1[array1.Length - 1] = item1;


            tempArray2 = array2;
            array2 = new V[array2.Length + 1];
            for (int i = 0; i < tempArray2.Length; i++)
            {
                array2[i] = tempArray2[i];

            }

            array2[array2.Length - 1] = item2;
            Console.WriteLine(item1 + " " + item2);

        }

        

    }
}
