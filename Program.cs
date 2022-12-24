using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Söz Dizimi
            // class SinifAdi
            {
                [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
                [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi (Parametre Listesi)
                {
                    Metot kKomutları
                }
            }*/

            /*Erişim Belirleyiciler
                *public
                *private
                *internal
                *protected
            */

            Calisan calisan1 = new Calisan();
            calisan1.Ad="Ayşe";
            calisan1.Soyad="Kara";
            calisan1.No=23454321;
            calisan1.Departman="İnsan Kaynakları";
            calisan1.CalisanBilgileri();
            Console.WriteLine("**********");

            Calisan calisan2 = new Calisan();
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=12345678;
            calisan2.Departman="Satın Alma";

            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}", No);
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman);

        }
    }
}
    