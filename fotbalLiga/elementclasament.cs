using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fotbalLiga
{
    public class elementclasament
    {
        public echipa clubul;
        public int m;
        public int v;
        public int e;
        public int i;
        public int gm;
        public int gp;
        public int gol;
        public int pct;
        public int adv;

        public elementclasament(echipa pclubul)
        {
            clubul = pclubul;
        }
    }
}
