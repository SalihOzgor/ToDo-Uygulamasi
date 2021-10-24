using System.Collections.Generic;

namespace ToDo_Uygulamasi
{
    public static class Kolonlar
    {
        public static Dictionary<Kart,string> toDoLine;
        public static Dictionary<Kart,string> inProgressLine;
        public static Dictionary<Kart,string> doneLine;
        static Kolonlar()
        {
            toDoLine = new Dictionary<Kart,string>();
            inProgressLine = new Dictionary<Kart,string>();
            doneLine = new Dictionary<Kart,string>();
        }
            
            
    }
}