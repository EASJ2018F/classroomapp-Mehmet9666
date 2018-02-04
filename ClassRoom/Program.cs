using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum easj = new KlasseRum();

            Studerende mü = new Studerende("Mü", 06, 11);
            Studerende malcolm = new Studerende("Malcolm", 01, 01);
            Studerende martin = new Studerende("Martin", 12, 31);

            easj._klasseListe.Add(mü);
            easj._klasseListe.Add(malcolm);
            easj._klasseListe.Add(martin);

            easj.SemesterStart = DateTime.Parse("29-01-2018");
            easj.KlasseNavn = "3F";

            Console.WriteLine(easj.KlasseNavn);
            // Console.WriteLine("\n");
            Console.WriteLine(easj.SemesterStart);
            Console.WriteLine("\n");

            foreach (var studerende in easj._klasseListe)
            {
                Console.WriteLine(studerende);
            }

            var Vinter = (from Studerende in easj._klasseListe
                where Studerende.Fødselsmåned == 1 || Studerende.Fødselsmåned == 2 || Studerende.Fødselsmåned == 3
                select Studerende.Navn).Count();

            var Forår = (from Studerende in easj._klasseListe
                where Studerende.Fødselsmåned == 4 || Studerende.Fødselsmåned == 5 || Studerende.Fødselsmåned == 6
                select Studerende.Navn).Count();

            var Sommer = (from Studerende in easj._klasseListe
                where Studerende.Fødselsmåned == 7 || Studerende.Fødselsmåned == 8 || Studerende.Fødselsmåned == 9
                select Studerende.Navn).Count();

            var Efterår = (from Studerende in easj._klasseListe
                where Studerende.Fødselsmåned == 4 || Studerende.Fødselsmåned == 5 || Studerende.Fødselsmåned == 6
                select Studerende.Navn).Count();

            var Ugyldigmåned = (from Studerende in easj._klasseListe
                where Studerende.Fødselsmåned < 0 || Studerende.Fødselsmåned > 12
                select Studerende.Navn).Count();

            Console.WriteLine("\n");
            Console.WriteLine(Vinter + " studerende har fødseldag i vinter");
            Console.WriteLine(Forår + " studerende har fødseldag i forår");
            Console.WriteLine(Sommer + " studerende har fødseldag i sommer");
            Console.WriteLine(Efterår + " studerende har fødseldag i efterår");
            Console.WriteLine("\n");
            Console.WriteLine(Ugyldigmåned + " uglydig(e) måned(er) valgt af studerende");


            Console.ReadKey();
        }
    }
}
