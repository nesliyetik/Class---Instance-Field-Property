using System;

namespace sinfkavrami

{
    class Program
    {

        static void Main (string[] args)
        {
            //Söz Dizimi
            //class SinifAdi
            //{
            //  [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
            //  [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi ([ParameterizedThreadStart Listesi])   
            //}
            //  {
            //  Metot Komutları
            //  }

            //Erişim Belirleyiciler

            // * Public: her yerden erişilebilir. programın herhangi bir yerinden erişilebilir.
            // * Private: sadece tanımlandığı sınıf içerisinde erişilebilirdir.
            // * Internal: kendi bulunduğu proje içerisinde erişilebilirdir.
            // * Protected: sadece tanımlandığı sınıfta ve o sınıftan kalıtım/miras alan sınıflardan erişilebilirdir.


            //*****Çalışan sınıfından bir instance/ bir örnek yaratıyoruz:

            Calisan calisan1 = new Calisan();
            calisan1.Ad= "Ayşe";
            calisan1.Soyad="Deniz";
            calisan1.No=1234;
            calisan1.Departman="Satin alma";

            calisan1.calisanBilgileri();

            Console.WriteLine("*************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad= "Umut";
            calisan2.Soyad="Yilmaz";
            calisan2.No=12345;
            calisan2.Departman="İK";

            calisan2.calisanBilgileri();
        }

    }

    class Calisan
    {
        public string Ad;

        public string Soyad;

        public int No;

        public string Departman;

        //çalışan sınıfının bilgilerini getiren metod:

        public void calisanBilgileri()

        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }

    }

}