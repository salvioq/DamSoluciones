Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' No code needed here for this sample.
    End Sub

    Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged
        ' If the user selects the Stretch check box,  
        ' change the PictureBox's SizeMode property to "Stretch". 
        ' If the user clears the check box, change it to "Normal".
        ' Choosing Stretch shows the entire image in the available space.          
        If checkBox1.Checked Then
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        ' Close the form. 
        Me.Close()
    End Sub

    Private Sub backgroundButton_Click(sender As Object, e As EventArgs) Handles backgroundButton.Click
        ' Show the color picker dialog box. If the user chooses OK, change the 
        ' PictureBox control's background to the color the user chose. 
        If colorDialog1.ShowDialog() = DialogResult.OK Then
            pictureBox1.BackColor = colorDialog1.Color
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ' Clear the picture.
        pictureBox1.Image = Nothing
    End Sub

    Private Sub showButton_Click(sender As Object, e As EventArgs) Handles showButton.Click
        ' Show the Open File dialog. If the user chooses OK, load the 
        ' picture that the user chose.
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            pictureBox1.Load(openFileDialog1.FileName)
        End If
    End Sub
End Class
