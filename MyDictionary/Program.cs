using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dersler1 = new MyDictionary<int, string>();
            dersler1.Add(01, "Matematik");
            dersler1.Add(02, "Türkçe");
            dersler1.Add(03, "Kimya");

            MyDictionary<int, string> dersler2 = new MyDictionary<int, string>();
            dersler2.Add(01, "Sosyal Bilgiler");
            dersler2.Add(02, "Fen Bilgisi");
            dersler2.Add(03, "Müzik");



        }
    }
}
