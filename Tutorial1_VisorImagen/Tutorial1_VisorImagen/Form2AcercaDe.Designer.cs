namespace Tutorial1_VisorImagen
{
    partial class Form2AcercaDe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_imagen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lemon", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visualizador de Imagenes";
            this.label1.Click += new System.EventHandler(this.Detectar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_aceptar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_aceptar.Location = new System.Drawing.Point(0, 140);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(275, 23);
            this.btn_aceptar.TabIndex = 1;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.Detectar_Click);
            // 
            // btn_imagen
            // 
            this.btn_imagen.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_imagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imagen.Image = global::Tutorial1_VisorImagen.Properties.Resources.Voxox_Lenovo_Fav_icon;
            this.btn_imagen.Location = new System.Drawing.Point(102, 57);
            this.btn_imagen.Name = "btn_imagen";
            this.btn_imagen.Size = new System.Drawing.Size(75, 60);
            this.btn_imagen.TabIndex = 3;
            this.btn_imagen.UseVisualStyleBackColor = true;
            this.btn_imagen.UseWaitCursor = true;
            this.btn_imagen.Click += new System.EventHandler(this.Detectar_Click);
            // 
            // Form2AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_imagen);
            this.Controls.Add(this.btn_aceptar);
            this.Name = "Form2AcercaDe";
            this.Text = "Acerca de...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_imagen;
    }
}