using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p.Model
{
    class Mesto
    {
        private int x;
        private int y;
        private Figura figura;

        public Mesto(int x, int y, Figura figura)
        {
            this.x = x;
            this.y = y;
            this.figura = figura;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Figura Figura
        {
            get { return figura; }
            set { figura = value; }
        }

    }
}
