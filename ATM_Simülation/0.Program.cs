using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simülation
{
    class Program
    {

        static void Main(string[] args)
        {
            Giris giris = new Giris(); // giriş bölmünde Müşteri Bilgilerine Ulaşılır...
            int paracekimLimitti = 1500;
            int attempt = 3;
            while (true) // şifre Denemesi İçin Döngüye Alınır...
            {
                 Console.WriteLine("Lütfen Kartınızı Takın!"); // Banka Ve ya Kredi KArtı Takması İstenir...
                Console.WriteLine("Hoşgeldiniz "+giris.getisim()+" "+" Bey/Hanım");
                 Console.Write("Lütfen kart şifrenizi giriniz : ");
                 int password = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("____________________________________");


                if (password==1234)
                {
                    break;
                }
                else
                {
                    if (attempt > 0)
                    {

                        Console.WriteLine("Yanlış girdiniz lütfen tekrar deneyiniz...");
                        attempt -= 1;
                    }
                    if (attempt==0)
                    {
                        Console.WriteLine("Kart Engellendi");
                        Console.ReadLine();
                        break;

                    }
                   
                }
              
            } //Şifre Bölmü
            while (true)
            {
                // Ana Menü Sayfası 
                Console.WriteLine("Lütfen Yapmak İstedğiniz işlemi Seçiniz :");
                Console.WriteLine("1.Para Çekme");
                Console.WriteLine("2.Para Yatırma");
                Console.WriteLine("3.Kredi Başvurusu");
                Console.WriteLine("4.Ödemeler");
                
                Console.WriteLine("5.Para Transferleri");
                Console.WriteLine("6.Kredi Kartı İşlemleri");
                Console.WriteLine("7.Hesap İşlemleri");
                Console.WriteLine("8.Diğer İşlemler");
                Console.WriteLine("0.Çıkış Yap");
                Console.WriteLine("____________________________________");

                string MüsteriSecim = Console.ReadLine();

                if (MüsteriSecim=="1") // Para Çekme class gidip ordan para çekip güncel bakiyeyi yazdırıcaz...
                {
                    while (true)
                    {
                        Console.WriteLine("Günlük Para Çekim Limitiniz " + paracekimLimitti + "TL dir.");
                        Console.WriteLine("Lütfen Yapmak İstedğiniz işlemi Seçiniz :");
                        Console.WriteLine("1.Hesaptan Çekim");
                        Console.WriteLine("2.Kredi Kartından");
                        Console.WriteLine("0.Ana Menüye dönmek");
                        Console.WriteLine("____________________________");
                        string paracekislem = Console.ReadLine();
                        if (paracekislem=="1") //hesap Bilgilerine Erişim Sağlanılıcak ve para çekimi sağlanmış olucak
                        {
                            Console.WriteLine("Hesap bağlı Şube :" + giris.getHesapadi());
                            Console.WriteLine("Hesap Bakiyeniz :" + giris.getHesap_Bakiyesi());
                            Console.Write("Hesabınızdan çekin yapmak istediğiniz tutarı giriniz :");
                            int istenen_tutar=Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(giris.getHesap_Bakiyesi() - istenen_tutar);
                            Console.WriteLine("Paranızı Almayı Unutmayınız");
                            Console.WriteLine("____________________________");
                            Console.WriteLine("Güncel Bakkiyeniz :");
                            Console.WriteLine("Hesap bağlı Şube :" + giris.getHesapadi());
                            Console.WriteLine("Hesap Bakiyeniz :" + giris.getHesap_Bakiyesi());
                        }
                        else if (paracekislem=="2")
                        {
                            

                        }
                        else if (paracekislem == "0")
                        {
                            Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz");
                            Console.WriteLine("____________________________");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz ...");
                        }
                    }
                } //Para Çekme
                else if (MüsteriSecim == "2") // Para Yatırma class gidip ordan para yatırıp güncel bakiyeyi yazdırıcaz...
                {
                    Console.WriteLine("Lütfen Yapmak İstedğiniz işlemi Seçiniz :");
                    Console.WriteLine("1.Hesaba Para Yatırma");
                    Console.WriteLine("2.Kredi Kartına Para Yatırma");
                    Console.WriteLine("0.Ana Menüye dönmek");
                    Console.WriteLine("____________________________");

                    string parayatırmaislem = Console.ReadLine();
                    while (true)
                    {
                        if (parayatırmaislem == "1")
                        {


                        }
                        else if (parayatırmaislem == "2")
                        {


                        }
                        else if (parayatırmaislem=="0")
                        {
                            Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz");
                            Console.WriteLine("____________________________");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz ...");
                        }
                    }
                } //Para Yatırma
                else if (MüsteriSecim == "3") 
                {
                    while (true)
                    {
                        Console.WriteLine("Lütfen Kredi ile ilgili işlemizi seçiniz :");
                        Console.WriteLine("1.Başvuru/Hesaplama Yap");
                        Console.WriteLine("2.Aktif Krediler");
                        Console.WriteLine("0.Ana Menüye Dönmek için ");
                        Console.WriteLine("____________________________");

                        string Krediislem = Console.ReadLine();
                        if (Krediislem == "1")
                        {
                            kredi_İslemleri kredi_İslemleri = new kredi_İslemleri();
                            kredi_İslemleri.kredihesaplama();


                        }
                        else if (Krediislem == "2")
                        {
                            while (true)
                            {
                                Console.WriteLine("Aktif Kredi ile ilgili Yapmak İstedğiniz işlemi Seçiniz :");
                                Console.WriteLine("1.Ödeme Yap");
                                Console.WriteLine("2.Ödeme planı Görüntüleme ");
                                Console.WriteLine("0.Ana Menüye Dönmek için ");
                                Console.WriteLine("____________________________");

                                string Krediislem1 = Console.ReadLine();

                                if (Krediislem1=="1")
                                {
                                    Console.WriteLine("Mevcut Bir krediniz bulunmuyor");
                                    Console.WriteLine("____________________________");

                                }
                                else if (Krediislem1 == "2")
                                {
                                    Console.WriteLine("Mevcut Bir krediniz bulunmuyor");
                                    Console.WriteLine("____________________________");
                                }
                                else if(Krediislem1=="0")
                                {
                                    Console.WriteLine("Kredi Menüsüne Yönlendiriliyorsunuz ...");
                                    Console.WriteLine("____________________________");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz ...");
                                    Console.WriteLine("____________________________");
                                }
                            }
                        }
                        else if (Krediislem=="0")
                        {
                            Console.WriteLine("Ana menüye Yönlendiriliyorsunuz ...");
                            Console.WriteLine("____________________________");
                            break;

                        }
                        else 
                        {
                            Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz ...");
                            
                        }

                    }



                } //Kredi başvuru işlemleri
                else if (MüsteriSecim == "4")  
                {
                    while (true)
                    {
                        Console.WriteLine("Lütfen Yapmak İstedğiniz işlemi Seçiniz :");
                        Console.WriteLine("1.Fatura Ödemleri");
                        Console.WriteLine("2.GSM/TL yüleme");
                        Console.WriteLine("3.Şans Oyunları");
                        Console.WriteLine("4.Kripto Para Ödemeleri");
                        Console.WriteLine("5.HGS Ödemeleri");
                        Console.WriteLine("6.Eğitim Kurumları Ödemeleri");
                        Console.WriteLine("7.Vergi Ödemeleri");
                        Console.WriteLine("8.Kayıtlı Ödemeler");
                        Console.WriteLine("0.Ana Menüye Dönmek için");
                        Console.WriteLine("____________________________________");
                        string odemeSecim = Console.ReadLine();

                        Ödemeler ödemeler = new Ödemeler(odemeSecim);
                        if (odemeSecim=="1")
                        {
                            ödemeler.Faturaodemesi();
                        } //Fatura
                        else if (odemeSecim == "2")
                        {
                            ödemeler.gsm_tl();
                        } //GSM
                        else if (odemeSecim == "3")
                        {
                            ödemeler.Sans_oyunlari();
                        } //Sans Oyunları
                        else if (odemeSecim == "4")
                        {
                            ödemeler.KriptoPara();
                        } //Kripto Para
                        else if (odemeSecim == "5")
                        {
                            ödemeler.hgsOdemeleri();
                        } //HGS
                        else if (odemeSecim == "6")
                        {
                            ödemeler.EgitimOdeme();
                        } //Eğitim
                        else if (odemeSecim == "7")
                        {
                            ödemeler.VergiOdeme();
                        } //Vergi 
                        else if (odemeSecim == "8") 
                        {
                           
                        } //
                        else if (odemeSecim == "0")
                        {
                            Console.WriteLine("0.Ana Menüye Yönlendiriliorsunuz");

                            break;
                        }
                        else
                        {

                        }
                    }

                } //Ödemeler
                else if (MüsteriSecim == "5") 
                {

                } //Para Transferi
                else if (MüsteriSecim == "6")
                {
                    while (true)
                    {
                        Console.WriteLine("Kredi Kartı İşlemleri :");
                        Console.WriteLine("1.Ekstre");
                        Console.WriteLine("2.Dönemiçi");
                        Console.WriteLine("3.Bekliyen işlemler");
                        Console.WriteLine("4.Gelecek Dönem");
                        Console.WriteLine("5.Chippara");
                        Console.WriteLine("0.Ana Menü");
                        string kk_secim = Console.ReadLine();

                        if (kk_secim == "1")
                        {

                        }
                        else if (kk_secim == "2")
                        {

                        }
                        else if (kk_secim == "3")
                        {

                        }
                        else if (kk_secim == "4")
                        {

                        }
                        else if (kk_secim == "5")
                        {

                        }
                        else if (kk_secim == "0")
                        {
                            Console.WriteLine("Ana Menüye Yönlendirliyorsunuz");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli bir işlem giriniz...");
                        }
                    }

                } //Kredi Kartı işlemleri
                else if (MüsteriSecim == "7")
                {
                    Console.WriteLine("Hesap bağlı Şube :"+giris.getHesapadi());
                    Console.WriteLine("Hesap Bakiyeniz :"+giris.getHesap_Bakiyesi());
                    Console.WriteLine("____________________________________");


                } //Hesap İşlemleri
                else if (MüsteriSecim == "8") //Diğer İşlemler
                {

                } //Diğer
                else if (MüsteriSecim == "0") // Kart İade İşlemi
                {                    
                    Console.WriteLine("Kartınızı Almayı Unutmayınız!");
                    Console.WriteLine("Bizimle işlem Yaptığınız için Teşekkürler :)");
                    Console.WriteLine("____________________________________");
                    Console.ReadLine();
                    break;
                } //Çıkış
                else
                {
                    Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz ...");
                    
                }


            } //Ana Menü

            

        } 
    }
}
