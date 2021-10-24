using System;

namespace ToDo_Uygulamasi
{
    public class Kart
    {
        private string baslik;
        private string icerik;
        private string atananKisi;
        private Enum buyukluk;

        public Kart(string _baslik, string _icerik, string _atananKisi, Enum _buyukluk)
        {
            Baslik = _baslik;
            Icerik = _icerik;
            AtananKisi = _atananKisi;
            Buyukluk = _buyukluk;
        }

        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        public string AtananKisi { get => atananKisi; set => atananKisi = value; }
        public Enum Buyukluk { get => buyukluk; set => buyukluk = value; }
    }

    public enum Buyuklukler
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}