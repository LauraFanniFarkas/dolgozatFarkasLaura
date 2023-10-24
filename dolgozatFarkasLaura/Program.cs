using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dolgozatFarkasLaura
{
    class Program
    {        

        static void Main(string[] args)
        {
            var bolygok = new List<Bolygo>();
            using (var sr = new StreamReader(@"..\..\src\solsys.txt",Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    bolygok.Add(new Bolygo(sr.ReadLine()));
                }
            }
            Console.WriteLine($"3.1: {bolygok.Count} bolygó van a naprendszerben");
            var f2 = bolygok.Average(b => b.HoldjainakSzama);
            Console.WriteLine($"3.2: a bolygóknak átlagosan {f2} holdja van");
            var f3 = bolygok.Max(b => b.TerfogatanakAranya);
            var f4 = bolygok.SingleOrDefault(b => b.TerfogatanakAranya == f3);
            Console.WriteLine($"a legnagyobb térfogatú bolygó a {f4.BolygoNev}");
            Console.Write("3.4: Írd be a keresett bolygó nevét:");
            string nev = Console.ReadLine();
            var f5 = bolygok.SingleOrDefault(b => b.BolygoNev == nev);
            if (f5 != null)
            {
                Console.WriteLine("van ilyen bolygó a listában");
            }
            else
            {
                Console.WriteLine("Nincs ilyen bolygó a listában.");
            }
            Console.Write("Írj be egy egész számot: ");
            string szam = Console.ReadLine();

            
            Console.ReadKey();
        }
    }
}
