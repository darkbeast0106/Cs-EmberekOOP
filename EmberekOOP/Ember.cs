using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmberekOOP
{
    internal class Ember
    {
        private string nev;
        private string szulDatum;
        private string szulHely;

        public Ember(string nev, string szulDatum, string szulHely)
        {
            this.nev = nev;
            this.szulDatum = szulDatum;
            this.szulHely = szulHely;
        }

        public string Nev { get => nev; }
        public string SzulDatum { get => szulDatum; }
        public string SzulHely { get => szulHely; }

        public int SzuletesiEv
        {
            get 
            {
                return int.Parse(szulDatum.Substring(0, 4));
            }
        }

        public int SzuletesiHonap
        {
            get
            {
                string[] szuletesiAdatok = szulDatum.Split('-');
                return int.Parse(szuletesiAdatok[1]);
            }
        }

        public int SzuletesiNap
        {
            get
            {
                string[] szuletesiAdatok = szulDatum.Split('-');
                return int.Parse(szuletesiAdatok[2]);
            }
        }

        public int Eletkor
        {
            get
            {
                DateTime maiDatum = DateTime.Now;
                DateTime szuletesiDatum = new DateTime(SzuletesiEv, SzuletesiHonap, SzuletesiNap);
                TimeSpan elteltIdo = maiDatum - szuletesiDatum;
                return (int)(elteltIdo.Days / 365.25);
            }
        }

        public override string ToString()
        {
            return String.Format("{0,-30} {1,10} ({3,3} év) {2,15}", this.nev, 
                this.szulDatum, this.szulHely, this.Eletkor);
        }
    }
}
