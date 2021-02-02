using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryHomework
{
    class MyDictionary<K,V>
    {
        K[] array1; //class çağırıldığında direkt oluşan boş 1.dizi
        K[] tempArray1; //çağırdığımız değerleri geçici olarak tutan 1.dizi
        V[] array2; //class çağırıldığında direkt oluşan boş 2.dizi
        V[] tempArray2; //çağırdığımız değerleri geçici olarak tutan 2.dizi

        public MyDictionary()
        {
            //Constructor içinde newledik. Çünkü array1 ve array2 dizileri için boş bir alan tanımladık. 
            array1 = new K[0];
            array2 = new V[0];
   
        }
        public void Add(K item1, V item2 ) //K ve V tipinde itemlar(elemanlar) oluşturduk
        {
            tempArray1 = array1; //array 1'i tempArray1'e atadık. Her eklediğimiz eleman için
            //önceki verileri(elemanları) tutabilsin diye.
        
            array1 = new K[array1.Length + 1];// eleman sayısını 1'er attırabilmek için array1 dizisini newledik.
            

            for (int  i= 0; i < tempArray1.Length; i++) //listelenen elemanları for döngüsü ile yazdırdık.
            {
                array1[i] = tempArray1[i]; // listeledikten sonra tempArray1 dizisindeki elemanları
                //tekrar aynı sıra ile array1'e ata diyoruz.
               
            }

            array1[array1.Length - 1] = item1; //kullanıcının girdiği dizinin son elemanını array1 dizimize atıyoruz.


            tempArray2 = array2; //aynı işlemleri array2 için yapıyoruz. 
            array2 = new V[array2.Length + 1];
            for (int i = 0; i < tempArray2.Length; i++)
            {
                array2[i] = tempArray2[i];

            }

            array2[array2.Length - 1] = item2;
            Console.WriteLine(item1 + " " + item2); //öğrencimizin dizideki numara ve isimlerini yazdırıyoruz. 

        }

        

    }
}
