using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmberekOOP
{
    internal class Emberek
    {
        private List<Ember> emberek;

        public Emberek(Ember[] emberTomb)
        {
            emberek = new List<Ember>();
            foreach (Ember ember in emberTomb)
            {
                emberek.Add(ember);
            }
            //emberek.AddRange(emberTomb);
        }

        public Emberek(string fajlNev)
        {
            emberek = new List<Ember>();
            using (StreamReader sr = new StreamReader(fajlNev))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    Ember ember = new Ember(line[0], line[1], line[2]);
                    emberek.Add(ember);
                }
            }
            
        }

        public override string ToString()
        {
            String fejlec = String.Format("{0,-30} {1,10} ({2,3} év) {3,15}",
                "Név", "Szül.dátum", "Kor", "Szül. Hely");
            StringBuilder sb = new StringBuilder(fejlec);
            foreach (Ember ember in emberek)
            {
                sb.Append("\n").Append(ember);
            }
            return sb.ToString();
        }
    }
}
