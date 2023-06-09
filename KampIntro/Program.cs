﻿using System;

namespace KampIntro
{
    class Program
    {
        public static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun == dolarBugun)
            {
                Console.WriteLine("Değişmedi butonu");
            }
            else
            {
                Console.WriteLine("Artış butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }

}