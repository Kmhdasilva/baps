using System;
using System.Collections.Generic;
using System.Text;

namespace bapsMobiel
{
    class Room
    {
        private string kamer_id;
        private string naam;
        private string licht;
        private string temperatuur;
        private string gordijnen;
        private string waterniveau_bad;
        private string deur;

        public Room(string id, string name, string lighting, string temp, string curtain, string waterlevel, string door)
        {
            kamer_id = id;
            naam = name;
            licht = lighting;
            temperatuur = temp;
            gordijnen = curtain;
            waterniveau_bad = waterlevel;
            deur = door;
        }


        public string kamerId
        {
            get { return kamer_id; }
            set { kamer_id = value; }
        }
        public string kamerNaam
        {
            get { return naam; }
            set { naam = value; }
        }
        public string belichting
        {
            get { return licht; }
            set { licht = value; }
        }
        public string temp
        {
            get { return temperatuur; }
            set { temperatuur = value; }
        }
        public string gordijnStand
        {
            get { return gordijnen; }
            set { gordijnen = value; }
        }
        public string waterstandBad
        {
            get { return waterniveau_bad; }
            set { waterniveau_bad = value; }
        }
        public string deurStand
        {
            get { return deur; }
            set { deur = value; }
        }
    }

}
