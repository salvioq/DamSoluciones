Imports System.Windows.Media
Class MainWindow
    Dim EfBlur As TextEffectCollection

    Private Sub AccionJugar(sender As Object, e As RoutedEventArgs) Handles btnJugar.Click
        Dim w As New Juego3enRaya()
        w.ShowDialog()

    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Application.Current.Shutdown()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Me.Title = Me.Title & "Tres en Raya"
        lblTitulo.Content = "Tres en Raya"
        txJugador.Text = "Introduce tu nombre..."
        btnJugar.IsEnabled = True

        Dim sc As String = "Center"
        For Each c As Control In grid0.Children
            c.SetCurrentValue(HorizontalContentAlignmentProperty, sc)
        Next
        'grid0.Arrange(Rect.Empty)
        Me.InvalidateArrange()
        Me.UpdateLayout()
        MessageBox.Show("Puede editar su nombre")

        txJugador.Focus()
        txJugador.SelectAll()
    End Sub


    Private Sub TxChange_Nombre(sender As Object, e As TextChangedEventArgs) Handles txJugador.TextChanged
        ' MessageBox.Show("Cambiado Texto " & txJugador.Text)
        ' se produce a cada caracter tecleado en el textbox
    End Sub

    Private Sub TxInput_Nombre(sender As Object, e As TextCompositionEventArgs) Handles txJugador.TextInput
        MessageBox.Show("Entrado Texto" & txJugador.Text)
    End Sub

    Private Sub Nombre_LostFocus(sender As Object, e As RoutedEventArgs) Handles txJugador.LostFocus

        If txJugador.Text.Equals("") Then
            MessageBox.Show("Lf No deje el nombre en blanco")
            txJugador.Focus()
        Else
            btnJugar.IsEnabled = True
        End If
    End Sub

    Private Sub Nombre_LostKbFocus(sender As Object, e As KeyboardFocusChangedEventArgs) Handles txJugador.LostKeyboardFocus
        If txJugador.Text.Equals("") Then
            MessageBox.Show("LKF No deje el nombre en blanco")
            txJugador.Focus()
        Else
            btnJugar.IsEnabled = True
        End If
    End Sub

    Private Sub Preview_Nombre(sender As Object, e As TextCompositionEventArgs) Handles txJugador.PreviewTextInput
        MessageBox.Show("Preview " & txJugador.Text)
    End Sub
End Class
