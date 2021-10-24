using System;

namespace ToDo_Uygulamasi
{
    public static class BoardKartEkleme
    {
        public static void BoardKartEklemeEkranGoster()
        {
            
            Console.Write("Başlık Giriniz                                  : ");
            string baslik = Console.ReadLine();
            Console.Write("İçerik Giriniz                                  : ");
            string icerik = Console.ReadLine();
            
            
            Enum buyukluk = BuyuklukSecme();

            string atananKisi = KisiSecme();
            
            

            Kart yeniKart = new Kart(baslik,icerik,atananKisi,buyukluk);
            Kolonlar.toDoLine.Add(yeniKart,yeniKart.AtananKisi);
            Console.WriteLine("***Board'a kart eklendi***");
            Console.WriteLine("\nAna ekrana dönmek için    : (Enter)");
            Console.ReadLine();

            Program.AnaEkranGoster();
        }

        static Enum BuyuklukSecme()
        {
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
            Enum buyukluk = null;
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    buyukluk = Buyuklukler.XS;
                    break;
                case 2:
                    buyukluk = Buyuklukler.S;
                    break;
                case 3:
                    buyukluk = Buyuklukler.M;
                    break;
                case 4:
                    buyukluk = Buyuklukler.L;
                    break;
                case 5:
                    buyukluk = Buyuklukler.S;
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız.\n");
                    BuyuklukSecme();
                    break;
            }
            return buyukluk;
        }

        static string KisiSecme()
        {
            Console.Write("Kişi Seçiniz                                    : ");
            string id = Console.ReadLine();
            
            if (Kisiler.takimUyeleri.ContainsKey(id))
            {   
                if (Kolonlar.toDoLine.ContainsValue(Kisiler.takimUyeleri[id]) || Kolonlar.inProgressLine.ContainsValue(Kisiler.takimUyeleri[id]) || Kolonlar.doneLine.ContainsValue(Kisiler.takimUyeleri[id]))
                {
                    Console.Write("Bu kişi zaten Board'da mevcut. Tekrar deneyin.\n");
                    return KisiSecme();
                }
                else
                {
                    string atananKisi = Kisiler.takimUyeleri[id];
                    return atananKisi;
                }
                
            }
            else
            {
                Console.WriteLine("Hatalı girişler yaptınız. Lütfen tekrar deneyin\n");
                return KisiSecme();
            }
        }
    }
}