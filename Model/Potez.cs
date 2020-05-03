using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p.Model
{
    enum Stanje {AKTIVNO , CRNI_JE_POBEDIO, BELI_JE_POBEDIO, PAT, PREDAJA }
    public class Potez
    {
        private Igrac igrac;
        private Mesto pocetak;
        private Mesto kraj;
        private Figura pomerena;
        private Figura uklonjena;
        private bool rokada = false;

        public Potez()
        {
            rokada = false;
        }

        public bool rokadaIzvrsena()
        {
            return this.rokada == true;
        }

       

        public bool Rokada
        {
            get { return rokada; }
            set { rokada = value; }
        }

    }
}
