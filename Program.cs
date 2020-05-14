using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. i 2. zad
            //Console.WriteLine("Hello World");
            //Dataset dataset = new Dataset(@"C:/Korisnici/User/source/repos/LV4/LV4/dat.txt");
            //Analyzer3rdParty analyzer = new Analyzer3rdParty();
            //Adapter adapter = new Adapter(analyzer);
            //double[] redovi = new double[3];
            //double[] stupci = new double[4];
            //redovi = adapter.CalculateAveragePerRow(dataset);
            //stupci = adapter.CalculateAveragePerColumn(dataset);
            

            //for (int i = 0; i < redovi.Length; i++)
            //{
            //    Console.WriteLine(redovi[i]+"  ");
            //}
            //Console.WriteLine("\n");
            //for (int i = 0; i < stupci.Length; i++)
            //{
            //    Console.WriteLine(stupci[i]+"  ");
            //}


            ////3. i 4. zad
            //List<IRentable> lista = new List<IRentable>();
            Knjiga book1 = new Knjiga("TriPrascica");
            Video film1 = new Video("StarWars");
            ////lista.Add(book1);
            ////lista.Add(film1);   


            //HotItem hot = new HotItem(book1);
            //HotItem hot1 = new HotItem(film1);
            Knjiga book2 = new Knjiga("Crvenkapica");
            Video film2 = new Video("JamesBond");
            //HotItem hot2 = new HotItem(book2);
            //HotItem hot3 = new HotItem(film2);
            //lista.Add(hot);
            //lista.Add(hot1);
            //lista.Add(hot2);
            //lista.Add(hot3);

            //5.zad
            List<IRentable> flashSale = new List<IRentable>();

            DiscountedItem item = new DiscountedItem(book1);
            DiscountedItem item1 = new DiscountedItem(film1);
            DiscountedItem item2 = new DiscountedItem(book2);
            DiscountedItem item3 = new DiscountedItem(film2);
            flashSale.Add(item);
            flashSale.Add(item1);
            flashSale.Add(item2);
            flashSale.Add(item3);

          

            RentingConsolePrinter printer = new RentingConsolePrinter();
            //printer.PrintTotalPrice(lista);
            //printer.DisplayItems(lista);
            //5.zad
            printer.PrintTotalPrice(flashSale);
            printer.DisplayItems(flashSale);

            //razlika je u tome sto se ukupna cijena poveca za 1.99 i ispisuje se trending

            ////provjera 6 zad
            //string mail= "polarni@gmail.com";
            //EmailValidator evs = new EmailValidator();
            //evs.IsValidAddress(mail);
            //Console.WriteLine("Mail je valjan: " + evs.IsValidAddress(mail));

            //7 zad
            Validator val = new Validator();
            while (true)
            {
                UserEntry user = new UserEntry.ReadUserFromConsole();
                if (val.IsUserEntryValid(user) == true)
                {
                    Console.WriteLine("Valjan korisnik!");
                    break;
                }
                else continue;

            }
        }
    }
}
