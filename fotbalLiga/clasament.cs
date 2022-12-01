using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fotbalLiga
{
    public class clasament
    {
        public List<elementclasament> echipele = new List<elementclasament>();

        public clasament() { }
        public clasament(elementclasament elementulclasamentului) {
            echipele.Add(elementulclasamentului);
        }
       



    }
}
