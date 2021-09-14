using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Udemy.SystemIO.DirectoryIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //YeniKlasorOlustur("c:\\Osman");
            //KlasorVarlıkKontrol("c:\\Osman");
            //KlasorSil("c:\\Osman");
            //Odev1("c:\\Udemy");
            KlasorTasima("c:\\Udemy", "c:\\Tasimaİslemi\\Udemy");
        }

        static void YeniKlasorOlustur(string path)
        {
            DirectoryInfo info = Directory.CreateDirectory(path); //istediğimiz dizinde klasör oluşturduk.
        }

        static void KlasorVarlıkKontrol(string path)
        {
            bool klasorvarmi = Directory.Exists(path);
        }

        static void KlasorSil(string path)
        {
            Directory.Delete(path,true); //Klasörün içerisinde farklı dosyalar varsa silemez. True yazdığımızda içinde dosya varsa bile siler.
        }

        static void Odev1(string path)
        {
            //C sürücüsü içinde udemy adında bir klasör oluşturun varsa silin yoksa oluşturun.
            //Klasör yok ise oluşturun.

            bool udemyvarmi = Directory.Exists(path);
            if (udemyvarmi==false)
            {
                Console.WriteLine("Klasör bulunamadı. Oluşturulacak. Herhangi bir tuşa basınız..");
                Console.ReadKey();
                DirectoryInfo udemyinfo = Directory.CreateDirectory(path);
                Console.WriteLine("Klasör Oluşturuldu.");
                Console.ReadLine();
            }
            else
            {
                Directory.Delete(path, true);
                Console.WriteLine("Var olan klasör silindi. Yeni klasör oluşturulacak. Herhangi bir tuşa basın..");
                Console.ReadKey();
                DirectoryInfo udemyinfo2 = Directory.CreateDirectory(path);
                Console.WriteLine("Klasör Oluşturuldu.");
                Console.ReadLine();
            }

        }

        static void KlasorTasima(string kaynak,string hedef)
        {
            Directory.Move(kaynak, hedef);
        }
    }
}
