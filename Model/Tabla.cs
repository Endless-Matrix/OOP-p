using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p.Model
{
    class Tabla
    {
        private int  velicina = 8;
        private int[,] matrica;


        

        public  int Velicina
        {
            get { return velicina; }
            set { velicina = value; }
        }


        

        public int[,] Matrica
        {
            get { return matrica; }
            set { matrica = value; }
        }



    }
}
