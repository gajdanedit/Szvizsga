using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static Adatbazis db = new Adatbazis();
        static List<Dolgozo> dolgozok;
        static void Main(string[] args)
        {
            dolgozok = db.getAllDolgozo();
            feladat01();
            feladat02();
            feladat03();
            feladat04();
            Console.WriteLine("Program vége!");
            Console.ReadLine();
        }

        private static void feladat04()
        {
            //-- hányan dolgoznak az egyes
            Console.WriteLine("4.feladat:");
            foreach(var item in dolgozok.FindAll(a => a.reszleg == "asztalosműhely"))
            {
                Console.WriteLine($"\t{item.nev}");
            }
        }

        private static void feladat03()
        {
            //-- hányan dolgoznak az egyes részlegeken
            Console.WriteLine("3. feladat:");
            foreach (var item in dolgozok.GroupBy(a => a.reszleg).Select(b => new {reszleg = b.Key, letszam = b.Count() }).OrderBy(c => c.reszleg))
            {
                Console.WriteLine($"\t{item.reszleg}: {item.letszam} fő");
            }
        }

        private static void feladat02()
        {
            //-- a legmagasabb keresetű dolgozo nevét
            int maxBer = dolgozok.Max(a => a.ber);
            Dolgozo dolgozo = dolgozok.Find(a => a.ber == maxBer);
            Console.WriteLine("2. feladat:");
            Console.WriteLine($"\tLegjobban kereső: {dolgozo.nev}");
        }

        private static void feladat01()
        {
            Console.WriteLine("1. feladatt: ");
            Console.WriteLine($"\tA dolgozók száma: {dolgozok.Count} fő");
        }
    }
}
