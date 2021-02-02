using System;


namespace DictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Ogrenci = new MyDictionary<int, string>();

            Ogrenci.Add(135, "Fatma Ikış ");
            Ogrenci.Add(230, "Esra Yılmaz");
            Ogrenci.Add(520, "Elif Nur Aktaş");
            Ogrenci.Add(780, "Can Tilki");
            Ogrenci.Add(1002, "Asaf Ağdepe");
            Ogrenci.Add(1256, "Dilay Çevik");
            Ogrenci.Add(1445, "Selim Çelikkıran");
        }
    }
}
