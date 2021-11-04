using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simülation
{
    public class kredi_İslemleri
    {
        public void kredihesaplama()
        {
            Console.WriteLine("Max vade oranı 36 ay olmalıdır...");
            double faizOrani = 1.20;
            Console.Write("Vade Oranı :");
            int vadeorani=Convert.ToInt32(Console.ReadLine());
            Console.Write("Kredi Tuarı :");
            double Kreditutarı = Convert.ToDouble(Console.ReadLine());
            double borc = ((Kreditutarı*faizOrani)+Kreditutarı);
            Console.WriteLine(borc);


        }
        /*
        public void  KrediHesaplayıcı();
        {
            public static IEnumerable<Taksit> Hesapla(decimal KrediTutarı, decimal FaizOranı, DateTime BaşlangıçTarihi, int TaksitAdedi = 12)
            {
                for (int i = 0; i < TaksitAdedi; i++)
                    yield return new Taksit()
                    {
                        Tarih = BaşlangıçTarihi.AddMonths(i),
                        Miktar = KrediTutarı * (FaizOranı * (decimal)(Math.Pow(1 + (double)FaizOranı, TaksitAdedi))) / (decimal)(Math.Pow(1 + (double)FaizOranı, TaksitAdedi) - 1),
                    };
            }
        }

        public class Taksit
        {
            public DateTime Tarih { get; set; }
            public decimal Miktar { get; set; }
            public decimal AnaParaÖdemesi { get; set; }
            public decimal FaizTutarı
            {
                get
                {
                    return Miktar - AnaParaÖdemesi;
                }
            }

        }*/

    }
}
