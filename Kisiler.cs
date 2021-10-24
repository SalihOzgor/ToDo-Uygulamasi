using System.Collections.Generic;

namespace ToDo_Uygulamasi
{
    public static class Kisiler
    {
        public static Dictionary<string,string> takimUyeleri;
        static Kisiler()
        {
            takimUyeleri  = new Dictionary<string, string>()
            {
                {"2019-1","Recep Şahin"},
                {"2019-2","Recep Karapınar"},
                {"2020-1","Aslı Dönmez"},
                {"2020-2","Onur Alper"},
                {"2020-3","Ömer Reis"},
                {"2021-1","Ayşe Demir"},
                {"2021-2","Mehmet Gümüş"}
            };
        }
                
            
    }
}