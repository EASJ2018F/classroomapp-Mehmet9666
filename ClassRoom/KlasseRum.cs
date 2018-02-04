using System;
using System.Collections.Generic;

namespace ClassRoom
{
    public class KlasseRum
    {
        public string _klasseNavn;
        public List<Studerende> _klasseListe;
        public DateTime _semesterStart;
        

        public KlasseRum()
        {
            _klasseListe = new List<Studerende>();
        }
        
        public string KlasseNavn
        {
            get { return _klasseNavn; }
            set { _klasseNavn = value; }            
        }

        public List<Studerende> KlasseListe
        {
            get { return _klasseListe; }
            set { _klasseListe = value; }
        }

        public DateTime SemesterStart
        {
            get { return _semesterStart; }
            set { _semesterStart = value; }
        }

    }
}