using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p.Model
{
    enum vrstaFigure {P, S, L , D, K  }
    enum bojaFigure {BELA, CRNA }
    class Figura
    {
        private bojaFigure boja;
        private vrstaFigure vrsta;
        

        public  bojaFigure Boja
        {
            get { return boja; }
            set { boja = value; }
        }

        

        public vrstaFigure Vrsta
        {
            get { return vrsta; }
            set { vrsta = value; }
        }




    }
}
