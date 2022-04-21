using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_OOP_game
{
    internal class Hrac : Hernipostava
    {
        public enum Oblicej { velkahlava, malahlava, siska, koule };
        protected Oblicej oblicej;
        public enum Vlasy { patka, culik, ples, jezek };
        protected Vlasy vlasy;
        public enum Barva { blond, zrzek, brunet, cernovlasec };
        protected Barva barva;
        public int XP = 0;
        public Hrac(string jmeno, Oblicej oblicej, Vlasy vlasy, Barva barva) : base(jmeno)
        {
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barva = barva;
        }
        public int PridejXP(int XP)
        {
            this.XP = XP;
            int lol = XP;
            while (lol >=100)
            {
                level++;
                lol = XP - 100;
            }
            return XP;

        }
        public override string ToString()
        {
            return base.ToString() + String.Format(", jeho obličej je {0}, jeho vlasy jsou {1}, jeho barva vlasů je {2}", oblicej, vlasy, barva);
        }

    }
}
