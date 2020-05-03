using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using OOP_p.Model;

namespace OOP_p
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnVerifikacija_Click(object sender, EventArgs e)
        {
            Radnja frmr = new Radnja();
            frmr.ShowDialog();
        }

        private void btnNapravi_Click(object sender, EventArgs e)
        {
            List<Potez> lista = new List<Potez>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Potez>));
            lista.Add(new Potez());
            lista.Add(new Potez());
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\soda.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, lista);
                MessageBox.Show("Napravljen");
            }
        }

        private void btnProcitaj_Click(object sender, EventArgs e)
        {
            List<Potez> lista = new List<Potez>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Potez>));
            
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\soda.xml", FileMode.Open, FileAccess.Read))
            {
                lista = serial.Deserialize(fs) as List<Potez>;
            }
            dataGridView1.DataSource = lista;
        }
    }
}
