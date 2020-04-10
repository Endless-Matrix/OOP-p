using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p.Model
{
    class Korisnik
    {
        private string korisnickoIme;
        private string lozinka;

        

        public  string KorisnickoIme
        {
            get { return korisnickoIme; }
            set { korisnickoIme = value; }
        }

        

        public string Lozinka
        {
            get { return lozinka; }
            set { lozinka = value; }
        }


    }
}
