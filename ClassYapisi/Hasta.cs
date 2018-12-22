using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassYapisi
{
    public abstract class Insan   //abstract Insan tipinden nesne oluşmasını önler 
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string TCNO { get; set; }

    }  

    public abstract class Personel : Insan   // Inheritance Insandan kalıtıyor
    {
        public string Maas { get; set; }
    }

    public class Hasta : Insan
    {
        #region
        /*
        //constructor
        public Hasta(string _ad, string _soyad, string _tcNo)
        {
            ad = _ad;
            soyad = _soyad;
            TCNO = _tcNo;
        }

        //overloading
        public Hasta()
        {
            
        }

        //.NET 3.5
        public string ad { private get; set; }  //dışarıdan setlenmeyi engellemek için private ekle
        public string soyad { get; set; } //dışarıdan get engellemek için private ekle

        public string adSoyad {
            get
            {
                return ad + " " + soyad;
            }
        }

        private string _TCNO;
        public Muayene[] muayene;

        //.NET 2.0
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
        */
       #endregion

        public Muayene[] Muayeneler { get; set; }


    }

    public class Doktor : Personel

    {
      
    }

    public class Memur : Personel

    {
       
    }

    public sealed class Sekreter : Personel  //sealed > sekreterin kalıtım yapılması önler

    {
         
    }

    public class Sozlesmeli : Personel
    {
        public byte SozlesmeSuresi { get; set; }
    }

}
