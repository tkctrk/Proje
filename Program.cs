using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TRY_CATCH_HESAP_MAKINESI_YAPIMI_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("1.SAYIYI GİRİNİZ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2.SAYIYI GİRİNİZ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("YAPMAK İSTEDIGINIZ İSLEMİ SECİN \n TOPLAMA İÇİN [+]\n ÇIKARTMA İŞLEMİ İCİN [-]\n ÇARPMA İŞLEMİ İÇİN [*]\n BÖLME İŞLEMİ İÇİN [/]");
                string islem = Console.ReadLine();
                Console.Clear();
                int sonuc;               
                while (islem=="t")
                {                                        
                    switch (islem)
                    {
                        case "+":
                            sonuc = num + num1;
                            break;
                        case "-":
                            sonuc = num - num1;
                            break;
                        case "*":
                            sonuc = num * num1;
                            break;
                        case "/":
                            sonuc = num / num1;
                            break;                        
                    }
                    Console.Clear();
                    
                }
                Console.WriteLine("YAPTIĞINIZ SEÇİM : {0}",islem);
                Console.WriteLine();
                Console.WriteLine("ÇIKARTMA İŞLEMİ SONUCUNUZ : {0}", sonuc = num - num1);
                Console.WriteLine("BÖLME İŞLEMİ SONUCUNUZ    : {0}", sonuc = num / num1);
                Console.WriteLine("ÇARPMA İŞLEMİ SONUCUNUZ   : {0}",sonuc = num * num1) ;
                Console.WriteLine("TOPLAMA İŞLEMİ SONUCUNUZ  : {0}", sonuc = num + num1);

            }
            catch (Exception)
            {
                Console.WriteLine("HATALI BIR SECIM YAPTINIZ İŞLEM SONLANDIRILIYOR");

            }
            
            Console.ReadKey();
        }
    }
}
