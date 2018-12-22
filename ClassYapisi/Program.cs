using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hasta hasta = new Hasta();
            hasta.ad = "a";
            hasta.soyad = "b";
            hasta.TCNO = "11111111111"; 

            Console.WriteLine(hasta.TCNO);
        }
    }
}
