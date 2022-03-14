using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaGalerisiProjesi
{
    internal class Galeri
    {
        private List<Araba> Arabalar = new List<Araba>(); // yani galeri sınıfı oluşturulunca hemen arabalar sınıfıda oluşturlur demek.
        //private ile dışarıdan kimsenin erişmesini istemiyoruz.Sadece benim kontrolümde erişebiliyor aslında
        public void ArabaEkle(Araba a)
        {
            Arabalar.Add(a);
        }
        public void ArabaSat(Araba a)
        {
            Arabalar.Remove (a);
        }
        public string ArabalariListele()
        {
            string bilgi ="" ;
            foreach (Araba araba in Arabalar) //var item in Arabalar olarak da bırakabilirdik ama ben burada araba ataması gerektiğini söylüyorum.
            {
                bilgi += "Marka:" + araba.Marka +// \n ile alt satıra geçiyorum daha düzgün olması için.
                    "\nModel:" + araba.Model +
                    "\nRenk:" + araba.Renk + "\n \n ";
            }
            return bilgi; //Bu sayede arabaların hepsini listelemiş oluyorum.   
        }
        public List<Araba>ArabaListesiVer() //geriye araba listesi dönüyor.
        {
            return Arabalar;
        }
    }
}
