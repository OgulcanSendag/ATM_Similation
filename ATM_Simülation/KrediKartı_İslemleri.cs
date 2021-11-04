using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simülation
{
    class KrediKartı_İslemleri : Giris
    {
        private int Limit = 25000;
        private string Kart_modelli = "American Express";


        public KrediKartı_İslemleri(int Limit, string Kart_modelli)
        {
            this.Limit = Limit;
            this.Kart_modelli = Kart_modelli;
        }
        //*************************
        public int getLimit()
        {
            return Limit;
        }
        public void setLimit(int limit)
        {
            this.Limit = limit;
        }
        //*************************
        public string getKart_modelli()
        {
            return Kart_modelli;
        }
        public void setKart_modelli(string kart_modelli)
        {
            this.Kart_modelli = kart_modelli;
        }


        public void ekstre()
        {
            Console.WriteLine(getisim()+"");
        }

    }
}
