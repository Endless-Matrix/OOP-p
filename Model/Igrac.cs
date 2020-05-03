using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p.Model
{
   abstract class Igrac
    {
        private bool beli;
        private bool covek;
        
        public bool beleFigure()
        {
            return this.beli == true;
        }

        public bool covekIliNe()
        {
            return this.covek == true;
        }
    }
}
