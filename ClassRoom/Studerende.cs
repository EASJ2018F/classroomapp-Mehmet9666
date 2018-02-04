namespace ClassRoom
{
    public class Studerende
    {
        private string _navn;
        private int _fødselsmåned;
        private int _fødselsdag;
        private string _årstid;

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            _navn = navn;
            _fødselsmåned = fødselsmåned;
            _fødselsdag = fødselsdag;

        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public int Fødselsmåned
        {
            get { return _fødselsmåned; }
            set { _fødselsmåned = value; }
        }

        public int Fødselsdag
        {
           get { return _fødselsdag; }
           set { _fødselsdag = value; } 
        }

        public string Årstid
        {
            get { return _årstid; }
            set { _årstid = value; }
        }

        public string SøgÅrstid(int fødselsmåned)
        {
            if (fødselsmåned == 12 || fødselsmåned == 1 || fødselsmåned == 2)
            {
                Årstid = "Vinter";
            }
            if (fødselsmåned == 3 || fødselsmåned == 4 || fødselsmåned == 5)
            {
                Årstid = "Forår";
            }
            if (fødselsmåned == 6 || fødselsmåned == 7 || fødselsmåned == 8)
            {
                Årstid = "Sommer";
            }
            if (fødselsmåned == 9 || fødselsmåned == 10 || fødselsmåned == 11)
            {
                Årstid = "Efterår";
            }

            return Årstid;
        }


        public override string ToString()
        {
            return $"Navn: {Navn} Fødselsdag: {Fødselsdag} Fødselsmåned: {Fødselsmåned}";
        }
    }
}