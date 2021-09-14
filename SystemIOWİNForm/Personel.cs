using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOWİNForm
{
    public class Personel
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string email { get; set; }
        public string firmaAdi { get; set; }
        public string ulke { get; set; }

        public override string ToString()
        {
            return isim + " " + soyisim;
        }

        public string PersonelBilgiGetir()
        {
            return string.Format("İsim: {0} Soyisim: {1} Firma Adı: {2} Email: {3}", isim, soyisim, firmaAdi, email);
        }
    }
}
