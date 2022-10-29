using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_ilk_ödev
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Kullanıcıdan 2 tane not alan ve bu notların ortalamasını alan
            // 95-100 arası ise A1 (4,00) yazdıran
            // 90-94 arası ise A2 (3,75) yazdıran
            // 85-89 arası ise A3 (3,50) yazdıran
            // 80-84 arası ise B1 (3,30) yazdıran
            // 75-79 arası ise B2 (3,10) yazdıran
            // 70-74 arası ise B3 (2,90) yazdıran
            // 65-69 arası ise C1 (2,70) yazdıran
            // 60-64 arası ise C2 (2,50) yazdıran
            // 55-59 arası ise D1 (2,25) ŞARTLI GEÇER yazdıran
            // 0-54 arası ise F1 (1,75) BAŞARISIZ yazdıran

            string[] isimListesi = new string[5];
            int[] sonucListesi = new int[5];

            bool hataKontrol = false;

            for ( int i = 0; i < 5; i++ )
            {
                try
                {
                    Console.WriteLine("Lütfen isminizi giriniz");
                    isimListesi[i] = Console.ReadLine();
                    Console.WriteLine("Lütfen Vize Notunuzu Giriniz");
                    int vize_not = Convert.ToInt32(Console.ReadLine());
                    if (vize_not < 0 || vize_not > 100) throw new ArgumentException("hatali sayi girdiniz");
                    Console.WriteLine("Lütfen Final Notu Giriniz");
                    int final_not = Convert.ToInt32((Console.ReadLine()));
                    if (final_not < 0 || final_not > 100) throw new ArgumentException("hatali sayi girdiniz");
                    sonucListesi[i] = vize_not * 40 / 100 + final_not * 70 / 100;
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    hataKontrol = true;
                    Console.WriteLine("tekrar girin");
                }
                if (hataKontrol == true)
                {

                    while (hataKontrol == true)
                    {
                        try
                        {
                            Console.WriteLine("Lütfen isminizi giriniz");
                            isimListesi[i] = Console.ReadLine();
                            Console.WriteLine("Lütfen Vize Notunuzu Giriniz");
                            int vize_not = Convert.ToInt32(Console.ReadLine());
                            if (vize_not < 0 || vize_not > 100) throw new ArgumentException("hatali sayi girdiniz");
                            Console.WriteLine("Lütfen Final Notu Giriniz");
                            int final_not = Convert.ToInt32((Console.ReadLine()));
                            if (final_not < 0 || final_not > 100) throw new ArgumentException("hatali sayi girdiniz");
                            sonucListesi[i] = vize_not * 40 / 100 + final_not * 70 / 100;
                            hataKontrol = false;
                        } catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            hataKontrol = true;
                            Console.WriteLine("tekrar girin");
                        }
                    }
                }

                
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(isimListesi[i]);
                Hesapla(sonucListesi[i]);
            }
            Console.ReadLine();
        }
        public static void Hesapla(int sonuc)
        {
            if (sonuc >= 95)
            {
                Console.WriteLine("Not Değeriniz:A1 (4,00)");
            }
            else if (sonuc >= 90 && sonuc < 95)
            {
                Console.WriteLine("Not Değeriniz:A2 (3,75) ");
            }
            else if (sonuc >= 85 && sonuc < 90)
            {
                Console.WriteLine("Not Değeriniz:A3 (3.50)");
            }
            else if (sonuc >= 80 && sonuc < 85)
            {
                Console.WriteLine("Not Değeriniz:B1 (3,30)");
            }
            else if (sonuc >= 75 && sonuc < 80)
            {
                Console.WriteLine("Not Değeriniz:B2 (3,10)");
            }
            else if (sonuc >= 70 && sonuc < 75)
            {
                Console.WriteLine("Not Değeriniz:B3 (2,90)");
            }
            else if (sonuc >= 65 && sonuc < 70)
            {
                Console.WriteLine("Not Değeriniz:C1 (2,70)");
            }
            else if (sonuc >= 60 && sonuc < 65)
            {
                Console.WriteLine("Not Değeriniz:C2 (2,50)");
            }
            else if (sonuc >= 55 && sonuc < 60)
            {
                Console.WriteLine("Not Değeriniz:D1 (2,25) ŞARTLI GEÇER");
            }
            else if (sonuc >= 0 && sonuc < 55)
            {
                Console.WriteLine("Not Değeriniz:F1 (1,75) BAŞARISIZ");
            }
        }
    }
}