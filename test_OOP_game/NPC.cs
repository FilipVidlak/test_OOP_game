using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_OOP_game
{
    internal class NPC : Hernipostava
    {
        public enum Prace {obchodnik,nepritel,obyvatel}
        public Prace prace;
        public bool sila = false;
        public NPC(string jmeno,Prace prace,bool sila) : base(jmeno)
        {
            this.prace = prace;
            this.sila = sila;
        }
        public bool NotBoss()
        {
            sila = false;
            return sila;
        }
        public override void Zmenapozice(int pozicex, int pozicey)
        {
            static int pozicex = 4;
            static int pozicey = 4;
        }
        public override string ToString()
        {
            if (!sila)
            {
                return base.ToString() + String.Format("Práce NPC je {0}, jeho síla je minimální, takže není BOSS", prace);
            }
            if(sila)
            {
                return base.ToString() + String.Format(", práce NPC je {0}, jeho síla je extrémní, je to BOSS", prace);
            }
        }

    }
}
