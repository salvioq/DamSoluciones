namespace Tutorial1_VisorImagen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_ninguno = new System.Windows.Forms.RadioButton();
            this.rb_stretch = new System.Windows.Forms.RadioButton();
            this.rb_auto = new System.Windows.Forms.RadioButton();
            this.rb_centrar = new System.Windows.Forms.RadioButton();
            this.rb_zoom = new System.Windows.Forms.RadioButton();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_ponColorFondo = new System.Windows.Forms.Button();
            this.btn_limpiarImagen = new System.Windows.Forms.Button();
            this.btn_cargarImagen = new System.Windows.Forms.Button();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.colorFondoDialogo = new System.Windows.Forms.ColorDialog();
            this.abrirFicheroDialogo = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_estado, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.94736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.btn_cerrar);
            this.flowLayoutPanel1.Controls.Add(this.btn_ponColorFondo);
            this.flowLayoutPanel1.Controls.Add(this.btn_limpiarImagen);
            this.flowLayoutPanel1.Controls.Add(this.btn_cargarImagen);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(203, 337);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(594, 83);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 328);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_zoom);
            this.groupBox1.Controls.Add(this.rb_centrar);
            this.groupBox1.Controls.Add(this.rb_auto);
            this.groupBox1.Controls.Add(this.rb_stretch);
            this.groupBox1.Controls.Add(this.rb_ninguno);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajuste Imagen";
            // 
            // rb_ninguno
            // 
            this.rb_ninguno.AutoSize = true;
            this.rb_ninguno.Checked = true;
            this.rb_ninguno.Location = new System.Drawing.Point(9, 19);
            this.rb_ninguno.Name = "rb_ninguno";
            this.rb_ninguno.Size = new System.Drawing.Size(65, 17);
            this.rb_ninguno.TabIndex = 2;
            this.rb_ninguno.TabStop = true;
            this.rb_ninguno.Text = "Ninguno";
            this.rb_ninguno.UseVisualStyleBackColor = true;
            this.rb_ninguno.CheckedChanged += new System.EventHandler(this.Rb_ninguno_CheckedChanged);
            // 
            // rb_stretch
            // 
            this.rb_stretch.AutoSize = true;
            this.rb_stretch.Location = new System.Drawing.Point(9, 42);
            this.rb_stretch.Name = "rb_stretch";
            this.rb_stretch.Size = new System.Drawing.Size(59, 17);
            this.rb_stretch.TabIndex = 3;
            this.rb_stretch.Text = "Stretch";
            this.rb_stretch.UseVisualStyleBackColor = true;
            this.rb_stretch.CheckedChanged += new System.EventHandler(this.Rb_stretch_CheckedChanged);
            // 
            // rb_auto
            // 
            this.rb_auto.AutoSize = true;
            this.rb_auto.Location = new System.Drawing.Point(112, 19);
            this.rb_auto.Name = "rb_auto";
            this.rb_auto.Size = new System.Drawing.Size(47, 17);
            this.rb_auto.TabIndex = 4;
            this.rb_auto.Text = "Auto";
            this.rb_auto.UseVisualStyleBackColor = true;
            this.rb_auto.CheckedChanged += new System.EventHandler(this.Rb_auto_CheckedChanged);
            // 
            // rb_centrar
            // 
            this.rb_centrar.AutoSize = true;
            this.rb_centrar.Location = new System.Drawing.Point(112, 42);
            this.rb_centrar.Name = "rb_centrar";
            this.rb_centrar.Size = new System.Drawing.Size(68, 17);
            this.rb_centrar.TabIndex = 5;
            this.rb_centrar.Text = "Centrado";
            this.rb_centrar.UseMnemonic = false;
            this.rb_centrar.UseVisualStyleBackColor = true;
            this.rb_centrar.CheckedChanged += new System.EventHandler(this.Rb_centrar_CheckedChanged);
            // 
            // rb_zoom
            // 
            this.rb_zoom.AutoSize = true;
            this.rb_zoom.Location = new System.Drawing.Point(63, 60);
            this.rb_zoom.Name = "rb_zoom";
            this.rb_zoom.Size = new System.Drawing.Size(52, 17);
            this.rb_zoom.TabIndex = 6;
            this.rb_zoom.Text = "Zoom";
            this.rb_zoom.UseMnemonic = false;
            this.rb_zoom.UseVisualStyleBackColor = true;
            this.rb_zoom.CheckedChanged += new System.EventHandler(this.Rb_zoom_CheckedChanged);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btn_cerrar.Location = new System.Drawing.Point(3, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(81, 33);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "&Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // btn_ponColorFondo
            // 
            this.btn_ponColorFondo.Location = new System.Drawing.Point(90, 3);
            this.btn_ponColorFondo.Name = "btn_ponColorFondo";
            this.btn_ponColorFondo.Size = new System.Drawing.Size(103, 33);
            this.btn_ponColorFondo.TabIndex = 1;
            this.btn_ponColorFondo.Text = "Color de &Fondo";
            this.btn_ponColorFondo.UseVisualStyleBackColor = true;
            this.btn_ponColorFondo.Click += new System.EventHandler(this.Btn_ponColorFondo_Click);
            // 
            // btn_limpiarImagen
            // 
            this.btn_limpiarImagen.Location = new System.Drawing.Point(199, 3);
            this.btn_limpiarImagen.Name = "btn_limpiarImagen";
            this.btn_limpiarImagen.Size = new System.Drawing.Size(103, 33);
            this.btn_limpiarImagen.TabIndex = 2;
            this.btn_limpiarImagen.Text = "&Limpiar imagen";
            this.btn_limpiarImagen.UseVisualStyleBackColor = true;
            this.btn_limpiarImagen.Click += new System.EventHandler(this.Btn_limpiarImagen_Click);
            // 
            // btn_cargarImagen
            // 
            this.btn_cargarImagen.Location = new System.Drawing.Point(308, 3);
            this.btn_cargarImagen.Name = "btn_cargarImagen";
            this.btn_cargarImagen.Size = new System.Drawing.Size(103, 33);
            this.btn_cargarImagen.TabIndex = 3;
            this.btn_cargarImagen.Text = "Cargar &Imagen";
            this.btn_cargarImagen.UseVisualStyleBackColor = true;
            this.btn_cargarImagen.Click += new System.EventHandler(this.Btn_cargarImagen_Click);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_estado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_estado, 2);
            this.lbl_estado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_estado.Location = new System.Drawing.Point(3, 423);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(794, 27);
            this.lbl_estado.TabIndex = 4;
            this.lbl_estado.Text = "Bienvenido...";
            this.lbl_estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_estado.Click += new System.EventHandler(this.Lbl_estado_Click);
            // 
            // abrirFicheroDialogo
            // 
            this.abrirFicheroDialogo.FileName = "openFileDialog1";
            this.abrirFicheroDialogo.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.abrirFicheroDialogo.Title = "Seleccione imagen...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Visualizador de Imágenes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_ninguno;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_ponColorFondo;
        private System.Windows.Forms.Button btn_limpiarImagen;
        private System.Windows.Forms.Button btn_cargarImagen;
        private System.Windows.Forms.RadioButton rb_zoom;
        private System.Windows.Forms.RadioButton rb_centrar;
        private System.Windows.Forms.RadioButton rb_auto;
        private System.Windows.Forms.RadioButton rb_stretch;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.ColorDialog colorFondoDialogo;
        private System.Windows.Forms.OpenFileDialog abrirFicheroDialogo;
    }
}

