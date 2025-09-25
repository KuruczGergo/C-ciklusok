using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //1 feladat

            Console.Write("Kérem az első számot");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot");
            int szam2 = int.Parse(Console.ReadLine());
            
            if (szam1 < szam2)
            {
                Console.WriteLine($"A nagyobbik szám a {szam2} és a különbség {szam2-szam1}");
            }
            else if (szam1 > szam2)
            {
                Console.WriteLine($"A nagyobbik szám a {szam1} és a különbség {szam1 - szam2}");
            }





            Console.WriteLine("-----------------------------------------------------");
            //Feladat 2









        }
    }
}
