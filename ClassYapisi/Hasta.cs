using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassYapisi
{
   public class Hasta
    {
        public string ad;
        public string soyad;
        private string _TCNO;
        public Muayene[] muayene;

        //Encapsulation işlemi = dışarıdan erişimi yönetebilmektir
        public string TCNO
        {
            get{
                return _TCNO; }
            set
            {
                if (value.Length == 11)
                {
                    if (!value.StartsWith("0"))
                    {
                        _TCNO = value;
                        return;
                    }
                    Console.WriteLine("tc hatali kardes");
                }

            }
        }
    }
}
