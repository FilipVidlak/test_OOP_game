using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_OOP_game
{
    internal class Hernipostava
    {
        protected string jmeno { get { return jmeno; } set { jmeno = value; } }
        protected int level = 1;
        public int pozicex { get { return pozicex; } private set { pozicex = 0; } }
        public int pozicey { get { return pozicey; } private set { pozicey = 0; } }

        public Hernipostava(string jmeno)//jmeno musim mit max 10 znaku
        {
            this.jmeno = jmeno;
        }
        public virtual void Zmenapozice(int pozicex, int pozicey)
        {
            this.pozicex = pozicex;
            this.pozicey = pozicey;
        }
        public override string ToString()
        {
            return String.Format("Jméno hráče je: {0}", jmeno);
        }

    }
}
