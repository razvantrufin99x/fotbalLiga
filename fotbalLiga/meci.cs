using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fotbalLiga
{
    public class meci
    {
        public int numar;
        public echipa eg;
        public int gg;
        public int go;
        public echipa eo;
        public int ggp;
        public int gop;
        public DateTime data;

        public meci() { }
        public meci(int pnumar, echipa peg,  echipa peo)
        {
            numar = pnumar;
            eg = peg;
            eo = peo;

        }
        public meci(int pnumar, echipa peg, int pgg, int pgo, echipa peo)
        {
            numar = pnumar;
            eg = peg;
            gg = pgg;
            eo = peo;
            eo = peo;

        }
    }
}
