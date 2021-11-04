using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simülation
{
    public class Giris
    {
        
        private string İsim="Ogulcan";
        private string HesapAdi = "İstanbul/Kartal";
        private int Hesap_Bakiyesi = 15000;

        public Giris(int Hesap_Bakiyesi,string isim,string Hesapadi)
        {
            this.İsim = isim;
            this.HesapAdi = Hesapadi;
            this.Hesap_Bakiyesi=Hesap_Bakiyesi;
        }

        public Giris()
        {
        }

        public int getHesap_Bakiyesi()
        {
            return Hesap_Bakiyesi;
        }

        public void setHesap_Bakiyesi(int Hesap_Bakiyesi)
        {
            this.Hesap_Bakiyesi = Hesap_Bakiyesi;
        }
        //----------------------
        public string getisim()
        {
            return İsim;
        }

        public void setisim(string isim)
        {
            this.İsim = isim;
        }
        //-----------------------
        public string getHesapadi()
        {
            return HesapAdi;
        }

        public void setHesapadi(string Hesapadi)
        {
            this.HesapAdi=Hesapadi;
        }

    }
}
