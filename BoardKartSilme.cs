using System;
using System.Collections.Generic;

namespace ToDo_Uygulamasi
{
    public static class BoardKartSilme
    {
        public static void BoardKartSilmeEkranGoster()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:  ");
            string baslik = Console.ReadLine();
            bool bulundu = false;
            foreach (Kart kart1 in Kolonlar.toDoLine.Keys)
            {
                if (baslik == kart1.Baslik)
                {
                    bulundu = true;
                    KartSilme(kart1,Kolonlar.doneLine);
                    break;
                }
            }
            if (bulundu == false)
            {
                foreach (Kart kart2 in Kolonlar.inProgressLine.Keys)
                {
                   if (baslik == kart2.Baslik)
                    {
                        bulundu = true;
                        KartSilme(kart2,Kolonlar.inProgressLine);
                        break;
                    } 
                }
                if (bulundu == false)
                {
                    foreach (Kart kart3 in Kolonlar.doneLine.Keys)
                    {
                        if (baslik == kart3.Baslik)
                        {
                            bulundu = true;
                            KartSilme(kart3,Kolonlar.doneLine);
                            break;
                        }
                    }
                    if (bulundu == false)
                    {
                        KartBulunamadi();
                    }
                }
            }
        }
        static void KartSilme(Kart kart,Dictionary<Kart,string> kolon)
        {
            kolon.Remove(kart);
            Console.WriteLine("***Kart silindi***");
            Console.WriteLine("\nAna ekrana dönmek için    : (Enter)");
            Console.ReadLine();
            Program.AnaEkranGoster();
        }

        static void KartBulunamadi()
        {
            Console.WriteLine("\nAradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için : (2)");
            switch (Console.ReadLine())
            {
                case "1":
                    Program.AnaEkranGoster();
                    break;
                case "2":
                    BoardKartSilmeEkranGoster();
                    break;
                default:
                    Console.WriteLine("Yanlış giriş yaptınız. Lütfen tekrar deneyin");
                    KartBulunamadi();
                    break;
            }
        }
    }
}