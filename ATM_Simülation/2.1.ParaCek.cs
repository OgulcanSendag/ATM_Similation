using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simülation
{
    public class ParaCek:Giris
    {
        public ParaCek()
        {
        }

        public ParaCek(int Hesap_Bakiyesi,string isim,string HesapAdi):base(Hesap_Bakiyesi,isim,HesapAdi)
        {
            this.getHesap_Bakiyesi();
        }
        /* Opsiyonlu
        private void Paracekimi(int Cekilcek_Tutar)
        {
            Console.Write(getisim() + " Bey/Hanım " + getHesap_Bakiyesi() + "  Ne Kadar Çekmek İstiyorsunuz :");
            int cekilcektutar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Güncel Hesap Bakiyeniz şu anda" + (getHesap_Bakiyesi() - cekilcektutar));

        }*/
    }
}
