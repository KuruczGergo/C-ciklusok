using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 feladat

            Console.Write("Kérem az első számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot: " +
                "");
            int szam2 = int.Parse(Console.ReadLine());

            if (szam1 < szam2)
            {
                Console.WriteLine($"A nagyobbik szám a {szam2} és a különbség {szam2 - szam1}");
            }
            else if (szam1 > szam2)
            {
                Console.WriteLine($"A nagyobbik szám a {szam1} és a különbség {szam1 - szam2}");
            }





            Console.WriteLine("-----------------------------------------------------");
            //Feladat 2


            /*
            Console.Write("Adjon meg egy számot");
            int szam = int.Parse(Console.ReadLine());
            int darab = 0;
            List<int> szamok = new List<int>();
            int szam;
            while (szam1 != 0)
            {
                Console.Write("Adjon meg egy számot");
                szam = int.Parse(Console.ReadLine());
            }
            */

            List<int> szamok = new List<int>();
            int szam;

            while (true)
            {
                Console.Write("Adjon meg egy számot: ");
                szam = int.Parse(Console.ReadLine());
                if (szam == 0) break;
                szamok.Add(szam);
            }

            int maxSzam = 0, maxDb = 0;
            for (int i = 0; i < szamok.Count; i++)
            {
                int db = 1;
                for (int j = i + 1; j < szamok.Count; j++)
                    if (szamok[i] == szamok[j]) db++;

                if (db > maxDb)
                {
                    maxDb = db;
                    maxSzam = szamok[i];
                }
            }

            if (szamok.Count > 0)
                Console.WriteLine($"A legtöbbször megadott szám: {maxSzam} ({maxDb} alkalommal)");

            Console.WriteLine("-----------------------------------------------------");
            //Feladat 3

            List<int> szamok2 = new List<int>();
            int paros = 0, paratlan = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Kérem a {i + 1} számot: ");
                int szam3 = int.Parse(Console.ReadLine());
                szamok2.Add(szam3);
                if (szam3 % 2 == 0) paros++;
                else paratlan++;
            }
            Console.WriteLine($"Páros számok: {paros}, Páratlan számok: {paratlan}");


            Console.WriteLine("------------------------------------------------------");
            //Feladat 4



            Console.Write("Kérek egy szót ");
            string szo = Console.ReadLine();
            int darabszo = 0;
            while (szo != "vége")
            {
                Console.Write("Kérek egy szót ");
                szo = Console.ReadLine();
                if (szo.Length > 5)
                {
                    darabszo++;
                }
            }
            Console.WriteLine($"Összesen {darabszo} db 5 karakternél hosszabb szót adott meg.");


            Console.WriteLine("------------------------------------------------------");
            //Feladat 5

            int osszeg = 0;
            int darab = 0;
            int egyes = 0;
            int kettes = 0;
            int harmas = 0;
            int negyes = 0;
            int otos = 0;

            Console.Write("Osztályzat (1-5, -1 vége): ");
            int jegy = int.Parse(Console.ReadLine());

            while (jegy != -1)
            {
                if (jegy >= 1 && jegy <= 5)
                {
                    osszeg += jegy;
                    darab++;
                    if (jegy == 1) egyes++;
                    else if (jegy == 2) kettes++;
                    else if (jegy == 3) harmas++;
                    else if (jegy == 4) negyes++;
                    else otos++;
                }

                Console.Write("Osztályzat (1-5, -1 vége): ");
                jegy = int.Parse(Console.ReadLine());
            }

            if (darab > 0)
                Console.WriteLine($"Átlag: {(double)osszeg / darab:F2}");
            else
                Console.WriteLine("Nem adott meg osztályzatot.");
            Console.WriteLine($"1-es: {egyes}, 2-es: {kettes}, 3-as: {harmas}, 4-es: {negyes}, 5-ös: {otos}");

            Console.WriteLine("------------------------------------------------------");
            //Feladat 6

            Console.Write("Adj meg egy számot (1–10): ");
            int szam7 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{szam7} szorzótáblája (csak a 3-mal osztható eredmények):");

            for (int i = 1; i <= 10; i++)
            {
                int eredmeny = szam7 * i;
                if (eredmeny % 3 == 0)
                {
                    Console.WriteLine($"{szam7} x {i} = {eredmeny}");
                }
            }

            Console.WriteLine("------------------------------------------------------");
            //Feladat 7

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Kérek egy számot ({i}/10): ");
                int szam8 = int.Parse(Console.ReadLine());

                string elojel = szam8 >= 0 ? "pozitív" : "negatív";
                string paritas = szam8 % 2 == 0 ? "páros" : "páratlan";
                string oszthato3 = szam8 % 3 == 0 ? "osztható 3-mal" : "nem osztható 3-mal";

                Console.WriteLine($"{szam8}: {elojel}, {paritas}, {oszthato3}\n");
            }

            Console.WriteLine("------------------------------------------------------");
            //Feladat 8

            string jelszo1 = "";
            string jelszo2 = "";
            while (true)
            {
                Console.Write("Adja meg a jelszót: ");
                jelszo1 = Console.ReadLine();

                Console.Write("Adja meg a jelszót ismét: ");
                jelszo2 = Console.ReadLine();

                if (jelszo1 == jelszo2)
                {
                    Console.WriteLine("Tovább léphetsz");
                    break;
                }
                else
                {
                    Console.WriteLine("Próbáld újra");
                }
            }
            Console.Write("Adj meg bármilyen szöveget: ");
            string szoveg = Console.ReadLine();
            string visszafele = "";
            for (int i = szoveg.Length - 1; i >= 0; i--)
            {
                visszafele += szoveg[i];
            }
            Console.WriteLine("Visszafelé: " + visszafele);


            Console.WriteLine("------------------------------------------------------");
            //Feladat 9

            List<int> szamok4 = new List<int>();
            int db5 = 0;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i % j == 0)
                    {
                        db5++;
                    }
                }
                if (db5 <= 2)
                {
                    szamok4.Add(i);
                }
                db5 = 0;
            }
            foreach (var item in szamok4)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine($"{szamok4.Count} prím szám van.");


            Console.WriteLine("------------------------------------------------------");
            //Feladat 10


           

                Random random = new Random();
                int playerPont = 0, gepPont = 0;

                for (int kor = 1; kor <= 5; kor++)
                {
                    string player = "";
                    string computer = "";

                    while (player != "KŐ" && player != "PAPÍR" && player != "OLLÓ")
                    {
                        Console.Write($"Kérem a választását (kő, papír, olló) - {kor}. kör: ");
                        player = Console.ReadLine().ToUpper();
                    }

                    switch (random.Next(1, 4))
                    {
                        case 1:
                            computer = "KŐ";
                            break;
                        case 2:
                            computer = "PAPÍR";
                            break;
                        case 3:
                            computer = "OLLÓ";
                            break;
                    }

                    Console.WriteLine($"A játékos választása: {player}");
                    Console.WriteLine($"A gép választása: {computer}");

                    if (player == computer)
                    {
                        Console.WriteLine("Döntetlen!");
                    }
                    else if ((player == "KŐ" && computer == "OLLÓ") ||
                             (player == "PAPÍR" && computer == "KŐ") ||
                             (player == "OLLÓ" && computer == "PAPÍR"))
                    {
                        Console.WriteLine("A játékos nyert!");
                        playerPont++;
                    }
                    else
                    {
                        Console.WriteLine("A gép nyert!");
                        gepPont++;
                    }

                    Console.WriteLine();
                }

                Console.WriteLine($"Végső eredmény: Játékos {playerPont} - Gép {gepPont}");

                if (playerPont > gepPont)
                    Console.WriteLine("Gratulálok, nyertél!");
                else if (playerPont < gepPont)
                    Console.WriteLine("Sajnos a gép nyert.");
                else
                    Console.WriteLine("Döntetlen lett a játék.");

























            }
        }
    }

