using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YEMEK_SİPARİŞ_HESABI_C__ÖRNEK
{
    internal class Program
    {
        static void _Mesaj()
        {
            Console.WriteLine("YEMEK MENÜSÜNE HOŞGELDİNİZ \n");
            Console.WriteLine("         YEMEKLER : " + "  " + "         İÇEÇEKLER :");
            Console.WriteLine("                                                      \n");
            Console.WriteLine("1 : ET DÖNER : 7 TL" + "               " + "7 : AYRAN : 3 TL\n");
            Console.WriteLine("2 : TAVUK DÖNER : 4 TL" + "            " + "8 : KOLA : 5 TL\n");
            Console.WriteLine("3 : ÇORBALAR : 3 TL" + "               " + " 9 : ŞALGAM : 6 TL\n");
            Console.WriteLine("4 : SALATALAR : 15 TL" + "    " + "10 : FANTA : 5 TL \n");
            Console.WriteLine("5 : KURU / PİLAV : 10 TL" + "          " + "11 :   SU   : 3 TL\n");
            Console.WriteLine("6 : PİDE : 7 TL" + "               " + "12 :   ÇAY : 3 TL\n");
        }
        static void _Tarih()
        {
            DateTime zaman = DateTime.Now;
            Console.WriteLine(zaman);
        }
        static void _SonMesaj()
        {
            Console.WriteLine("TEŞEKKÜR EDERİZ YİNE BEKLERİZ SAĞLICAKLA..");
        }
        static double _Hesap()
        {
            double seçim, adet, toplam, hesap = 0;

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("ALACAGINIZ URUNUN NUMARASINI GIRINIZ");
                seçim = Convert.ToDouble(Console.ReadLine());


                if (seçim == 1)
                {
                    Console.Write("KAÇ PORSİYON ET DÖNER İSTİYORSUNUZ : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 7;
                    hesap = hesap + toplam;
                }

                else if (seçim == 2)
                {
                    Console.Write("KAÇ PORSİYON TAVUK DÖNER İSTİYORSUNUZ : ");
                    adet = Convert.ToDouble(Console.ReadLine());

                    toplam = adet * 4;
                    hesap = hesap + toplam;
                }

                else if (seçim == 3)
                {
                    Console.Write("KAÇ PORSİYON ÇORBA İSTİYORSUNUZ : ");
                    adet = Convert.ToDouble(Console.ReadLine());

                    toplam = adet * 3;
                    hesap = hesap + toplam;
                }

                else if (seçim == 4)
                {
                    Console.Write("KAÇ PORSİYON SALATA İSTİYORSUNUZ : ");
                    adet = Convert.ToDouble(Console.ReadLine());

                    toplam = adet * 15;
                    hesap = hesap + toplam;
                }

                else if (seçim == 5)
                {
                    Console.Write("KAÇ PORSİYON KURU//PİLAV İSTİYORSUNUZ : ");
                    adet = Convert.ToDouble(Console.ReadLine());

                    toplam = adet * 10;
                    hesap = hesap + toplam;
                }

                else if (seçim == 6)
                {
                    Console.Write("KAÇ PORSİYON PİDE İSTİYORSUNUZ : ");
                    adet = Convert.ToDouble(Console.ReadLine());

                    toplam = adet * 7;
                    hesap = hesap + toplam;
                }

                else if (seçim == 7)
                {
                    Console.Write("KAÇ ADET AYRAN İSTİYORSUNUZ : ");
                    adet = Convert.ToDouble(Console.ReadLine());

                    toplam = adet * 7;
                    hesap = hesap + toplam;
                }

                else if (seçim == 8)
                {
                    Console.Write("KAÇ ADET KOLA ISTIYORSUNUZ : ");
                    adet = Convert.ToDouble(Console.ReadLine());

                    toplam = adet * 5;
                    hesap = hesap + toplam;
                }

                else if (seçim == 9)
                {
                    Console.Write("KAÇ ADET ŞALGAM İSTİYORSUNUZ : ");
                    adet = Convert.ToDouble(Console.ReadLine());

                    toplam = adet * 6;
                    hesap = hesap + toplam;
                }

                else if (seçim == 10)
                {
                    Console.Write("KAÇ ADET FANTA İSTİYORSUNUZ : ");
                    adet = Convert.ToDouble(Console.ReadLine());

                    toplam = adet * 5;
                    hesap = hesap + toplam;
                }

                else if (seçim == 11)
                {
                    Console.Write("KAÇ ADET SU İSTİYORSUNUZ : ");
                    adet = Convert.ToDouble(Console.ReadLine());

                    toplam = adet * 3;
                    hesap = hesap + toplam;
                }

                else if (seçim == 12)
                {
                    Console.Write("KAÇ ADET ÇAY İSTİYORSUNUZ : ");
                    adet = Convert.ToDouble(Console.ReadLine());

                    toplam = adet * 3;
                    hesap = hesap + toplam;
                }
                else
                    Console.WriteLine("BÖYLE BİR SEÇİM BULUNAMADI\n");
                Console.WriteLine();
                Console.WriteLine("BAŞKA BİR İSTEGİNİZ VAR MI ?");
                Console.WriteLine("İŞLEMİ BİTİRMEK İÇİN 'H' BASINIZ");
                string cevap = Console.ReadLine();
                if (cevap == "h" || cevap == "H" || cevap == "hayır" || cevap == "HAYIR" || cevap == "HAYİR" || cevap == "hayir")
                {
                    break;
                }

            }
            Console.Clear();
            Console.WriteLine("TOPLAM TUTARINIZ : {0}", hesap);
            _SonMesaj();
            _Tarih();
            Console.ReadKey();
            return _Hesap();






        }

        
        static void Main(string[] args)
        {
           
            _Mesaj();
            Console.WriteLine();
            _Hesap();
            Console.WriteLine();
        
           


        }
    }
}
