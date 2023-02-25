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

            Console.WriteLine("***Çalışan 1****");
            
            Calisan calisan1 = new Calisan("Ayşe","Deniz",1234,"Satin alma");
            calisan1.calisanBilgileri();

            Console.WriteLine("***Çalışan 2****");

            Calisan calisan2 = new Calisan();
            calisan2.Ad= "Umut";
            calisan2.Soyad="Yilmaz";
            calisan2.No=12345;
            calisan2.Departman="İK";

            calisan2.calisanBilgileri();

            Console.WriteLine("***Çalışan 3****");
            Calisan calisan3 = new Calisan("Nesli","Yetik");

            calisan3.calisanBilgileri();
        
        }

    }

    class Calisan
    {
        public string Ad;

        public string Soyad;

        public int No;

        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)

        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No= no;
            this.Departman= departman;

        }

        public Calisan(string ad, string soyad)

        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan(){}

        //Kurucu metot özellikleri:
            //*bir sınıfın new ile yeni bir nesnesini oluşturduğumuzda arka planda otomatik olarak çalıştırılan metotlara kurucu metotlar denir.
            //*kurucu metotların ismi sınıf ismi ile aynı olmak zorundadır.
            //*kurucu metotların erişim belirleyicileri public olmak zorundadır.
            //*kurucu metotların geri dönüş tipi yoktur.
            //*kurucu metotlar, normal fonksiyonlar gibi overload edilebilir.



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