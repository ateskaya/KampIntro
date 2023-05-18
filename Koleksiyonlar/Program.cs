using System;

namespace Koleksiyonlar
{
    class Program
    {
        public static void Main(string[] args)
        {
            //string[] isimler = new string[] { "İbrahim", "Bayram", "Kamil", "Ramil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //string[] tutucu = new string[] { };
            //tutucu = isimler;
            //isimler = new string[5];


            List<string> isimler2 = new List<string> { "İbrahim", "Bayram", "Kamil", "Ramil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Fidan");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}