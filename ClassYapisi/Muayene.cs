using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassYapisi
{
   public class Muayene
    {
        public DateTime tarih { get; set; }

        public string tani { get; set; }

        public Doktor doktor { get; set; }

        public Hasta hasta { get; set; }    
    }
}
