using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOWİNForm
{
    public class DataIslemleri
    {
        
       
        public DataIslemleri()
        {

        }

        public List<Personel> PersonelGetir(int adet)
        {
            List<Personel> personelListe= new List<Personel>();
            int id = 0;
            for (int i = 0; i <= adet; i++)
            {
                Personel personel=new Personel();
                personel.id = id++;
                personel.isim = FakeData.NameData.GetFirstName();
                personel.soyisim = FakeData.NameData.GetSurname();
                personel.firmaAdi = FakeData.NetworkData.GetDomain();
                personel.email = personel.isim + "." + personel.soyisim + "@" + personel.firmaAdi;
                personel.ulke = FakeData.PlaceData.GetCountry();

                personelListe.Add(personel);
            }

            return personelListe;
        }

        public void PersonelKayddet(string path,List<Personel> personels)
        {
            DirectoryInfo ulkebilgisi = null;
            //for ile ülke dosyasının olup olmadığına baktık. varsa bişi yamadık yoksa oluşturduk.
            for (int i = 0; i < personels.Count; i++)
            {
                if (Directory.Exists(path+"\\"+personels[i].ulke))
                {
                    ulkebilgisi = new DirectoryInfo((path + "\\" + personels[i].ulke));
                }
                else
                {
                 ulkebilgisi=   Directory.CreateDirectory(path + "\\" + personels[i].ulke);
                }

                //Ülke bilgisinin içine o ülkeden olan kişileri kaydettik.
              FileStream fs=  File.Create((ulkebilgisi.FullName + "\\"+ personels[i].isim +"." + personels[i].soyisim) + "txt");
                byte[] personelbilgi = new UTF8Encoding(true).GetBytes(personels[i].PersonelBilgiGetir());
                fs.Write(personelbilgi, 0, personelbilgi.Length);
                fs.Close();
            }
        }
    }
}
