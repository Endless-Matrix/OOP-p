using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_p.Model;

namespace OOP_p
{ 
    public partial class Radnja : Form
    {  
       
     
        
        public Radnja()
        {
            InitializeComponent();
        }
        
        private void Radnja_Load(object sender, EventArgs e)
        {
            Panel[,] tabla = new Panel[8, 8];
            const int vPolja = 40;
       
            Color b1 = Color.Black;
            Color b2 = Color.White;
            

            for (var i = 0; i < 8; i++)
            {
                for (var j = 0; j < 8; j++)
                {
  
                     Panel p = new Panel
                     {
                         Size = new Size(vPolja, vPolja),
                         Location = new Point(vPolja * i, vPolja * j)
                     };

                    Controls.Add(p);

                    if (i % 2 == 0)
                    {
                        if(j % 2 != 0)
                        {
                            p.BackColor = b1;
                        }
                        else
                        {
                            p.BackColor = b2;
                        }
                    }
                        
                    else
                    {
                        if(j % 2 != 0)
                        {
                            p.BackColor = b2;
                        }
                        else
                        {
                            p.BackColor = b1;
                        }
                    }
                        
                }
            }
        }
    }
}
