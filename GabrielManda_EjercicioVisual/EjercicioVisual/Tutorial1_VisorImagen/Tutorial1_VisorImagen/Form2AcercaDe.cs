using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial1_VisorImagen
{
    public partial class Form2AcercaDe : Form
    {
        public Form2AcercaDe()
        {
            InitializeComponent();
        }

        private void Detectar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pulsado " + sender.ToString());
            this.Hide();
        }
    }
}
