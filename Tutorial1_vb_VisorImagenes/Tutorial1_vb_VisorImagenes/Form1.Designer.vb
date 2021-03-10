<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.backgroundButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.showButton = New System.Windows.Forms.Button()
        Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.checkBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'pictureBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.pictureBox1, 2)
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(794, 376)
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Location = New System.Drawing.Point(3, 385)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(93, 17)
        Me.checkBox1.TabIndex = 1
        Me.checkBox1.Text = "Ajuste Imagen"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.closeButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.backgroundButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.clearButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.showButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(163, 385)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(634, 62)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(3, 3)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 23)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "Cerrar"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'backgroundButton
        '
        Me.backgroundButton.Location = New System.Drawing.Point(84, 3)
        Me.backgroundButton.Name = "backgroundButton"
        Me.backgroundButton.Size = New System.Drawing.Size(124, 23)
        Me.backgroundButton.TabIndex = 1
        Me.backgroundButton.Text = "Cambiar Color Fondo"
        Me.backgroundButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(214, 3)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(97, 23)
        Me.clearButton.TabIndex = 2
        Me.clearButton.Text = "Borrar Imagen"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'showButton
        '
        Me.showButton.Location = New System.Drawing.Point(317, 3)
        Me.showButton.Name = "showButton"
        Me.showButton.Size = New System.Drawing.Size(75, 23)
        Me.showButton.TabIndex = 3
        Me.showButton.Text = "Cargar Imagen"
        Me.showButton.UseVisualStyleBackColor = True
        '
        'openFileDialog1
        '
        Me.openFileDialog1.InitialDirectory = "%USERPROFILE%"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1 vb"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pictureBox1 As PictureBox
    Friend WithEvents checkBox1 As CheckBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents closeButton As Button
    Friend WithEvents backgroundButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents showButton As Button
    Friend WithEvents colorDialog1 As ColorDialog
    Friend WithEvents openFileDialog1 As OpenFileDialog
End Class
