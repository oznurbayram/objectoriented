using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassYapisi
{
    class Program
    {  
        //OOP PRENSIPLERI
        //Encapsulation
        //Inheritance
        
        //abstraction => Kendinden intance edilemez ancak kalıtım yapılabilen sınıfları tanımlamak için kullanılır.Absraction metot yazılabilinir içine
        //sealed => Kendinden kalıtım yapılamaz ancak intance edilebilinir class tanımlamak için kullanılır

        static void Main(string[] args)
        {
            // Hasta hasta = new Hasta("oznur","denemesoyad","12345678911");
            Hasta hasta = new Hasta();  //instance

            hasta.soyad = "bayram";
            hasta.ad = "oznur";
            hasta.TCNO = "11111111111";

            Doktor doktor = new Doktor();
            doktor.ad = "drOznur";

        

        }
    }
}
