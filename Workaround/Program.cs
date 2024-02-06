using Business.Concrete;
using Entities.Concrete;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Workaround
{
    class Program
    {
         static void Main(string[] args)
        {
            //Değişkenler
            // instance ol oluşturma
            Vatandaş vatandaş = new Vatandaş();
            SelamVer(isim: "büşra");
            SelamVer();
            Console.WriteLine(Topla());
            Console.WriteLine(Topla(3, 4));
            //referans tipleri(Array, Class,interface,Abstract)
            //Diziler:Array
            //bellekte iki kısım vardır Stack ve Heap referans tiplerini kullanmak için bellekte yer açmak gerekir
            //bu işlem new yapılarak gerçekleşir new denildiğinde heap kısmında yer açılır
                      //stack 101      //heap 101
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Büşra";
            ogrenciler[1] = "Kübra";
            ogrenciler[2] = "Gülçin";
            //101              //102
            ogrenciler = new string[4];
            //Yeni new tanımlandığı için Büşra Gülçin Kübra dizisi devre dışı olur Garbage Collector arka planda bu arrayı siler
            ogrenciler[3] = "Ahmet";
            for (int i = 0; i < ogrenciler.Length; i++)
            {

                Console.WriteLine(ogrenciler[i]); //"...." ,"........",".....","Ahmet","......"
            }
            string[] sehirler1 = new[] { "Adana", "Ankara","Şanlıurfa" };
            string[] sehirler2 = new[] { "İstanbul", "Bursa", "Diyarbakır" };
            sehirler1 = sehirler2;
            sehirler1[2] = "Sivas";
            Console.WriteLine(sehirler1[0]);
            foreach (string s in sehirler1)
            {
                Console.WriteLine(s);
            }
            List<string> yensehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "Şanlıurfa 1" };
            yensehirler1.Add("İzmir 1");
            foreach (var sehir in yensehirler1)
            {
                Console.WriteLine(sehir);
            }
            Person person1= new Person();
            person1.FirstName = "Büşra";
            person1.LastName = "Güneş";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity = 2453245654;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();



        }


        //parametre verilmezse isim olarak isimsiz yazdır
        //resharper visual studio kulanımını kolaylaştıran eklenti
        static void SelamVer( string isim="isimsiz")
        {
            Console.WriteLine("Merhaba "+isim);
        }
        static int Topla(int sayi1=1, int sayi2=2)
        {
            return sayi1+sayi2;
        }
        private static void Değişkenler()
        {
            string mesaj = "Merhaba";
            double tutar = 10000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string Soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 1234567890;
            Console.WriteLine(tutar * 1.18);

        }
        //pascal casing
        public class Vatandaş
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int DogumYili { get; set; }
            public long TcNo { get; set; }


        }
        
    }
}
