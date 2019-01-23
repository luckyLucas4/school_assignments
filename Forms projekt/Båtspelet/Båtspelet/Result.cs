using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Båtspelet
{
    // Definierar ett resultat-objekt
    public class Resultat : IComparable<Resultat>
    {
        public string name { get; } // Namnet som har skrivits in
        public int score { get; } // Poängen som länkas till namnet

        // Konstruktorn för resultatet
        public Resultat(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        // Visar att resultat i en lista ska sorteras efter storleken på poängen
        public int CompareTo(Resultat other)
        {
            if (score > other.score)
                return 1;
            else if (score < other.score)
                return -1;
            else
                return 0;
        }
    }
}
