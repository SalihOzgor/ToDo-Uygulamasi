using System;

namespace ToDo_Uygulamasi
{
    public static class BoardListeleme
    {
        public static void BoardListelemeEkranGoster()
        {
            Console.WriteLine("\nTODO Line");
            Console.WriteLine("************************");

            if (Kolonlar.toDoLine.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (Kart kart in Kolonlar.toDoLine.Keys)
                {
                    Console.WriteLine("Başlık: {0}\nİçerik: {1}\nAtanan Kişi: {2}\nBüyüklük: {3}\n-",kart.Baslik,kart.Icerik,kart.AtananKisi,kart.Buyukluk);
                }
            }

            Console.WriteLine("\nIN PROGRESS Line");
            Console.WriteLine("************************");

            if (Kolonlar.inProgressLine.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (Kart kart in Kolonlar.inProgressLine.Keys)
                {
                    Console.WriteLine("Başlık: {0}\nİçerik: {1}\nAtanan Kişi: {2}\nBüyüklük: {3}\n-",kart.Baslik,kart.Icerik,kart.AtananKisi,kart.Buyukluk);
                }
            }

            Console.WriteLine("\nDONE Line");
            Console.WriteLine("************************");

            if (Kolonlar.doneLine.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (Kart kart in Kolonlar.doneLine.Keys)
                {
                    Console.WriteLine("Başlık: {0}\nİçerik: {1}\nAtanan Kişi: {2}\nBüyüklük: {3}\n-",kart.Baslik,kart.Icerik,kart.AtananKisi,kart.Buyukluk);
                    
                }
            }

            Console.WriteLine("\nAna ekrana dönmek için    : (Enter)");
            Console.ReadLine();

            Program.AnaEkranGoster();
        }
    }
}