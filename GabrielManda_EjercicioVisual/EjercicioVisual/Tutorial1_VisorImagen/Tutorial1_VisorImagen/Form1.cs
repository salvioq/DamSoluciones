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
    public partial class Form1 : Form
    {
        private DialogResult salida;
        private Form2AcercaDe form_acercade=null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            String txt_antes = lbl_estado.Text;
            lbl_estado.Text = "Asegurando el cierre de la aplicacion...";
            DialogResult = MessageBox.Show("Está seguro de cerrar?", "Cierre Visualizador", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (DialogResult == DialogResult.Yes) {
                this.Close();
            } else {
                lbl_estado.Text = txt_antes;
            }
        }

        private void Btn_cargarImagen_Click(object sender, EventArgs e)
        {
            lbl_estado.Text = "Seleccionando fichero de imagen...";
            salida = abrirFicheroDialogo.ShowDialog();
            if (salida == DialogResult.OK)
            {
                lbl_estado.Text = abrirFicheroDialogo.FileName.ToString();
                pictureBox1.Load(abrirFicheroDialogo.FileName);
            } else
            {
                lbl_estado.Text = "Sin imagen";
            }

        }

        private void Btn_ponColorFondo_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            lbl_estado.Text = "Cambiando color de fondo...";
            salida = colorFondoDialogo.ShowDialog();
            if(salida == DialogResult.OK)
            {
                lbl_estado.Text = "Nuevo color de fondo:" + colorFondoDialogo.Color.ToKnownColor();
                pictureBox1.BackColor = colorFondoDialogo.Color;
            } else
            {
                lbl_estado.Text = "Color de fondo no cambiado. Actual: " + pictureBox1.BackColor.ToKnownColor();
            }
        }
        private void Btn_limpiarImagen_Click(object sender, EventArgs e)
        {
            lbl_estado.Text = "Sin imagen.";
            pictureBox1.Image=null;
        }

        private void Rb_ninguno_CheckedChanged(object sender, EventArgs e)
        {
            lbl_estado.Text = "Imagen ajuste: Ninguno";
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        
        private void Rb_stretch_CheckedChanged(object sender, EventArgs e)
        {
            lbl_estado.Text = "Imagen ajuste: Stretch";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Rb_auto_CheckedChanged(object sender, EventArgs e)
        {
            lbl_estado.Text = "Imagen ajuste: Auto";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void Rb_centrar_CheckedChanged(object sender, EventArgs e)
        {
            lbl_estado.Text = "Imagen ajuste: Centrado";
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void Rb_zoom_CheckedChanged(object sender, EventArgs e)
        {
            lbl_estado.Text = "Imagen ajuste: Zoom";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Lbl_estado_Click(object sender, EventArgs e)
        {
            lbl_estado.Text = "Acerca de ...";           
            //Se abre el form
            if (form_acercade==null)
            {
                form_acercade = new Form2AcercaDe();
                form_acercade.TopLevel = true;
            } else
            {
                form_acercade.BringToFront();
            }
            salida=form_acercade.ShowDialog();
            if (salida == DialogResult.Yes)
                 lbl_estado.Text = "Pulsaste Botón Aceptar (SI)";
            else
                 lbl_estado.Text = "Pulsaste Botón Imagen (NO)";
        }
    }
}
