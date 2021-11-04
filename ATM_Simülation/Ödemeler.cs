using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simülation
{
    public class Ödemeler:Giris
    {
        public Ödemeler(string isim)
        {
        }
        public void Faturaodemesi()
        {
            while (true)
            { //Demo Olarka Borçlar Girilmiştir...
                Console.WriteLine("1.Elektrik Ödemeleri");
                Console.WriteLine("2.Su Faturası Ödemeleri");
                Console.WriteLine("3.Doğalgaz Fatura Ödemeleri");
                Console.WriteLine("0.Ana Menüye Dönmek için");
                Console.WriteLine("____________________________________"); // Bir Sonraki Aşamayı belirtmek için kullanılıyor 
                string faturaodemesi = Console.ReadLine();
                if (faturaodemesi == "1")
                {
                    int Elektrik_faturası_borc = 200;
                    Console.WriteLine("Elekrik Faturası Ödemesi");
                    Console.Write("Elektrik Dağıtım Kurumunuzun Adını Giriniz :");
                    string Elekrik_krmu = Console.ReadLine();
                    Console.Write("Sözleşme Hesap No :");
                    string sozlesme = Console.ReadLine();
                    Console.WriteLine(sozlesme + " sözleşme numaralı " + Elekrik_krmu + " Kurumuna bağlı faturanızın " + Elektrik_faturası_borc + "TL tutarında borcunuz " + getHesapadi() + " hesabınız üzerinden ödenicektir.Hesap Bakiyeniz " + getHesap_Bakiyesi() + "TL'dir");
                    Console.WriteLine("Faturanızı Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                    string onay = Console.ReadLine();                    
                    Console.WriteLine("____________________________________");
                    if (onay == "1")
                    {
                        Console.WriteLine("Faturanızın Ödemesi " + getHesapadi() + " üzerinden sağnlanmıştır.");
                        Console.WriteLine("Güncel hesap bakiyeniz :" + (getHesap_Bakiyesi()-Elektrik_faturası_borc));
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else if (onay == "2")
                    {
                        Console.WriteLine("Fatura ödemeniz Sağlanamadı ...");
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Faturanızı Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                        Console.WriteLine("____________________________________");
                    }
                } //Elektrik
                else if (faturaodemesi == "2")
                {
                    int su_faturası_borc = 75;
                    Console.WriteLine("Su Faturası Ödemesi");
                    Console.Write("Su Dağıtım Kurumunuzun Adını Giriniz :");
                    string su_krmu = Console.ReadLine();
                    Console.Write("Abone No :");
                    string sozlesme = Console.ReadLine();
                    Console.WriteLine(sozlesme + " Abone numaralı " + su_krmu + " Kurumuna bağlı faturanızın " + su_faturası_borc + "TL tutarında borcunuz " + getHesapadi() + " hesabınız üzerinden ödenicektir.Hesap Bakiyeniz " + getHesap_Bakiyesi() + " ödenmesini istiyormusunuz ?");
                    string onay = Console.ReadLine();
                    if (onay == "1")
                    {
                        Console.WriteLine("Faturanızın Ödemesi " + getHesapadi() + " üzerinden sağnlanmıştır.");
                        Console.WriteLine("Güncel hesap bakiyeniz :" + (getHesap_Bakiyesi()-su_faturası_borc));
                        break;
                    }
                    else if (onay == "2")
                    {
                        Console.WriteLine("Fatura ödemeniz Sağlanamadı ...");
                    }
                    else
                    {
                        Console.WriteLine("Faturanızı Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                    }
                } //Su 
                else if (faturaodemesi == "3")
                {
                    int dogalgaz_faturası_borc = 122;
                    Console.WriteLine("Su Faturası Ödemesi");
                    Console.Write("Su Dağıtım Kurumunuzun Adını Giriniz :");
                    string dogalgaz_krmu = Console.ReadLine();
                    Console.Write("Abone No :");
                    string sozlesme = Console.ReadLine();
                    Console.WriteLine(sozlesme + " Abone numaralı " + dogalgaz_krmu + " Kurumuna bağlı faturanızın " + dogalgaz_faturası_borc + "TL tutarında borcunuz " + getHesapadi() + " hesabınız üzerinden ödenicektir.Hesap Bakiyeniz " + getHesap_Bakiyesi() + " ödenmesini istiyormusunuz ?");
                    string onay = Console.ReadLine();
                    if (onay == "1")
                    {
                        Console.WriteLine("Faturanızın Ödemesi " + getHesapadi() + " üzerinden sağnlanmıştır.");
                        Console.WriteLine("Güncel hesap bakiyeniz :" + (getHesap_Bakiyesi()-dogalgaz_faturası_borc));
                        break;
                    }
                    else if (onay == "2")
                    {
                        Console.WriteLine("Fatura ödemeniz Sağlanamadı ...");
                    }
                    else
                    {
                        Console.WriteLine("Faturanızı Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                    }
                } //Doğalgaz
                else if (faturaodemesi=="0")
                {
                    break;
                } //Çıkış
                else
                {
                    Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz ...");
                }
                
            }

        } //Elektrik,Su,Doğalgaz Demo Borç
        public void gsm_tl()
        {
            while (true)
            { //Demo Olarka Borçlar Girilmiştir...
                Console.WriteLine("1.Turkcell Ödemeleri");
                Console.WriteLine("2.Turk Telekom (TT Mobile) Ödemeleri");
                Console.WriteLine("3.Vodafone Ödemeleri");
                Console.WriteLine("0.Ana Menüye Dönmek için");
                Console.WriteLine("____________________________________"); // Bir Sonraki Aşamayı belirtmek için kullanılıyor 
                string gsmodemesi = Console.ReadLine();
                if (gsmodemesi == "1")
                {
                    //int fatura_borc = 525;
                    Console.WriteLine("Gsm Faturası Ödemesi");
                    //Console.Write("Elektrik Dağıtım Kurumunuzun Adını Giriniz :");
                    //string turkcell_krmu = Console.ReadLine();
                    Console.Write("Cep Tel No :");
                    string sozlesmeNo = Console.ReadLine();
                    Console.Write("Ödeme Yapmak İsediğiniz tutarı giriniz :");
                    int fatura_borc = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(sozlesmeNo + " sözleşme numaralı " + "Turkcell" + " Kurumuna bağlı faturanızın " + fatura_borc + "TL tutarında borcunuz " + getHesapadi() + " hesabınız üzerinden ödenicektir.Hesap Bakiyeniz " + getHesap_Bakiyesi() + "TL'dir ");
                    Console.WriteLine("Ödemenizi Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                    string onay = Console.ReadLine();
                    Console.WriteLine("____________________________________");
                    if (onay == "1")
                    {
                        Console.WriteLine("Faturanızın Ödemesi " + getHesapadi() + " üzerinden sağnlanmıştır.");
                        Console.WriteLine("Güncel hesap bakiyeniz :" + (getHesap_Bakiyesi() - fatura_borc));
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else if (onay == "2")
                    {
                        Console.WriteLine("Fatura ödemeniz Sağlanamadı ...");
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Faturanızı Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                        Console.WriteLine("____________________________________");
                    }
                } // Turkcell
                else if (gsmodemesi == "2")
                {
                    Console.WriteLine("Turk Telekom (TT Mobil) Faturası Ödemesi");
                    
                    
                    Console.Write("Cep Tel No :");
                    string sozlesmeNo = Console.ReadLine();

                    Console.Write("Ödeme Yapmak İsediğiniz tutarı giriniz :");
                    int fatura_borc = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(sozlesmeNo + " sözleşme numaralı " + "Turkcell" + " Kurumuna bağlı faturanızın " + fatura_borc + "TL tutarında borcunuz " + getHesapadi() + " hesabınız üzerinden ödenicektir.Hesap Bakiyeniz " + getHesap_Bakiyesi() + "TL'dir");
                    Console.WriteLine("Ödemenizi Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");

                    string onay = Console.ReadLine();                    
                    Console.WriteLine("____________________________________");
                    
                    if (onay == "1")
                    {
                        Console.WriteLine("Faturanızın Ödemesi " + getHesapadi() + " üzerinden sağnlanmıştır.");
                        Console.WriteLine("Güncel hesap bakiyeniz :" + (getHesap_Bakiyesi() - fatura_borc));
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else if (onay == "2")
                    {
                        Console.WriteLine("Fatura ödemeniz Sağlanamadı ...");
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else if (gsmodemesi == "0")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Faturanızı Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                        Console.WriteLine("____________________________________");
                    }

                } // Turk Telekom
                else if (gsmodemesi == "3")
                {
                    //int fatura_borc = 233;
                    Console.WriteLine("Elekrik Faturası Ödemesi");
                    //Console.Write("Elektrik Dağıtım Kurumunuzun Adını Giriniz :");
                    //string turkcell_krmu = Console.ReadLine();
                    Console.Write("Cep Tel No :");
                    string sozlesmeNo = Console.ReadLine();
                    Console.Write("Ödeme Yapmak İsediğiniz tutarı giriniz :");
                    int fatura_borc = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(sozlesmeNo + " sözleşme numaralı " + "Turkcell" + " Kurumuna bağlı faturanızın " + fatura_borc + "TL tutarında borcunuz " + getHesapadi() + " hesabınız üzerinden ödenicektir.Hesap Bakiyeniz " + getHesap_Bakiyesi() + "TL'dir");
                    Console.WriteLine("Ödemenizi Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                    string onay = Console.ReadLine();
                    Console.WriteLine("____________________________________");
                    if (onay == "1")
                    {
                        Console.WriteLine("Faturanızın Ödemesi " + getHesapadi() + " üzerinden sağnlanmıştır.");
                        Console.WriteLine("Güncel hesap bakiyeniz :" + (getHesap_Bakiyesi() - fatura_borc));
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else if (onay == "2")
                    {
                        Console.WriteLine("Fatura ödemeniz Sağlanamadı ...");
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Faturanızı Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                        Console.WriteLine("____________________________________");
                    }

                } // Vodefone
                else if (gsmodemesi == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Faturanızı Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                    Console.WriteLine("____________________________________");
                }
            }
        } //Vodafone,Turkcell,TurkTelekom(TTmobile) Manuel tutar Girişi
        public void Sans_oyunlari()
        {

            while (true)
            { //Demo Olarka Borçlar Girilmiştir...
                Console.WriteLine("1.Nesine");
                Console.WriteLine("2.Oley");
                Console.WriteLine("3.Milli Piyango");
                Console.WriteLine("4.Türkiye Jokey Kulübü");
                Console.WriteLine("0.Ana Menüye Dönmek için");
                Console.WriteLine("____________________________________"); // Bir Sonraki Aşamayı belirtmek için kullanılıyor 
                string sansodemesi = Console.ReadLine();
                if (sansodemesi == "1")
                {                    
                    Console.WriteLine("Nesine Ödemesi");

                    Console.Write("Cep Tel No :");
                    string sozlesmeNo = Console.ReadLine();

                    Console.Write("Ödeme Yapmak İsediğiniz tutarı giriniz :");
                    int fatura_borc = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(sozlesmeNo + " sözleşme numaralı " + "Turkcell" + " Kurumuna bağlı faturanızın " + fatura_borc + "TL tutarında borcunuz " + getHesapadi() + " hesabınız üzerinden ödenicektir.Hesap Bakiyeniz " + getHesap_Bakiyesi() + "TL'dir ");
                    Console.WriteLine("Ödemenizi Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                    string onay = Console.ReadLine();
                    Console.WriteLine("____________________________________");
                    if (onay == "1")
                    {
                        Console.WriteLine("Faturanızın Ödemesi " + getHesapadi() + " üzerinden sağnlanmıştır.");
                        Console.WriteLine("Güncel hesap bakiyeniz :" + (getHesap_Bakiyesi() - fatura_borc));
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else if (onay == "2")
                    {
                        Console.WriteLine("Fatura ödemeniz Sağlanamadı ...");
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Faturanızı Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                        Console.WriteLine("____________________________________");
                    }
                }      // Nesine
                else if (sansodemesi == "2")
                {
                    Console.WriteLine("Oley Ödemesi");


                    Console.Write("Cep Tel No :");
                    string sozlesmeNo = Console.ReadLine();

                    Console.Write("Ödeme Yapmak İsediğiniz tutarı giriniz :");
                    int fatura_borc = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(sozlesmeNo + " sözleşme numaralı " + "Turkcell" + " Kurumuna bağlı faturanızın " + fatura_borc + "TL tutarında borcunuz " + getHesapadi() + " hesabınız üzerinden ödenicektir.Hesap Bakiyeniz " + getHesap_Bakiyesi() + "TL'dir");
                    Console.WriteLine("Ödemenizi Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");

                    string onay = Console.ReadLine();
                    Console.WriteLine("____________________________________");

                    if (onay == "1")
                    {
                        Console.WriteLine("Faturanızın Ödemesi " + getHesapadi() + " üzerinden sağnlanmıştır.");
                        Console.WriteLine("Güncel hesap bakiyeniz :" + (getHesap_Bakiyesi() - fatura_borc));
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else if (onay == "2")
                    {
                        Console.WriteLine("Fatura ödemeniz Sağlanamadı ...");
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Faturanızı Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                        Console.WriteLine("____________________________________");
                    }

                } // Oley
                else if (sansodemesi == "3")
                {
                    //int fatura_borc = 233;
                    Console.WriteLine("Milli Piyango Ödemesi");
                    //Console.Write("Elektrik Dağıtım Kurumunuzun Adını Giriniz :");
                    //string turkcell_krmu = Console.ReadLine();
                    Console.Write("Cep Tel No :");
                    string sozlesmeNo = Console.ReadLine();
                    Console.Write("Ödeme Yapmak İsediğiniz tutarı giriniz :");
                    int fatura_borc = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(sozlesmeNo + " sözleşme numaralı " + "Turkcell" + " Kurumuna bağlı faturanızın " + fatura_borc + "TL tutarında borcunuz " + getHesapadi() + " hesabınız üzerinden ödenicektir.Hesap Bakiyeniz " + getHesap_Bakiyesi() + "TL'dir");
                    Console.WriteLine("Ödemenizi Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                    string onay = Console.ReadLine();
                    Console.WriteLine("____________________________________");
                    if (onay == "1")
                    {
                        Console.WriteLine("Faturanızın Ödemesi " + getHesapadi() + " üzerinden sağnlanmıştır.");
                        Console.WriteLine("Güncel hesap bakiyeniz :" + (getHesap_Bakiyesi() - fatura_borc));
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else if (onay == "2")
                    {
                        Console.WriteLine("Fatura ödemeniz Sağlanamadı ...");
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Faturanızı Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                        Console.WriteLine("____________________________________");
                    }

                } // Milli Piyango
                else if (sansodemesi == "4")
                {
                    Console.WriteLine("Türkiye Jokey Kulübü Ödemesi");


                    Console.Write("Cep Tel No :");
                    string sozlesmeNo = Console.ReadLine();

                    Console.Write("Ödeme Yapmak İsediğiniz tutarı giriniz :");
                    int fatura_borc = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(sozlesmeNo + " sözleşme numaralı " + "Turkcell" + " Kurumuna bağlı faturanızın " + fatura_borc + "TL tutarında borcunuz " + getHesapadi() + " hesabınız üzerinden ödenicektir.Hesap Bakiyeniz " + getHesap_Bakiyesi() + "TL'dir");
                    Console.WriteLine("Ödemenizi Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");

                    string onay = Console.ReadLine();
                    Console.WriteLine("____________________________________");

                    if (onay == "1")
                    {
                        Console.WriteLine("Faturanızın Ödemesi " + getHesapadi() + " üzerinden sağnlanmıştır.");
                        Console.WriteLine("Güncel hesap bakiyeniz :" + (getHesap_Bakiyesi() - fatura_borc));
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else if (onay == "2")
                    {
                        Console.WriteLine("Fatura ödemeniz Sağlanamadı ...");
                        Console.WriteLine("____________________________________");
                        break;
                    }
                    else if (sansodemesi == "0")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Faturanızı Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                        Console.WriteLine("____________________________________");
                    }

                } // Türkiye Jokey Kulübü
                else if (sansodemesi == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Faturanızı Onaylamak için 1 e İşleminizi iptal etmek için ise 2 ye basınız");
                    Console.WriteLine("____________________________________");
                }
            }

        } //
        public void KriptoPara()
        {

        }
        public void hgsOdemeleri()
        {

        }
        public void EgitimOdeme()
        {

        }
        public void VergiOdeme()
        {

        }
    }
}
