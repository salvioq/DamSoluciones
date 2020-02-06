Public Class Juego3enRaya
    ' Definiciones iniciales
    Public Turno As Boolean = True
    ' True  - X Azul
    ' False - O Rojo

    Dim sBlanco As String
    Const X As String = "X"
    Const O As String = "O"
    Dim Cuenta As Integer


    ' Colores y fondos
    Public ColorAzul As Color = Color.FromArgb(100, 64, 64, 255)
    ' #FF4040FF
    Public ColorRojo As Color = Color.FromArgb(100, 255, 64, 64)
    ' #FFFF4040
    Public ColorInactivo As Color = Color.FromArgb(100, 221, 221, 221)
    ' #FFDDDDDD
    ' ResourceKey = SystemColors.InactiveSelectionHighlightBrushKey
    Public BackAzul, BackRojo, BackInicial, ForeInicial As Brush

    Private Sub LoadWindow(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        'Const iBlanco As Integer = 254
        'Const cBlanco As Char = Chr(iBlanco)
        sBlanco = Chr(254)
        BackAzul = txPuntAzul.Background
        BackRojo = txPuntRojo.Background
        ForeInicial = btnIniciar.Background
        BackInicial = btnIniciar.Background
        Iniciar()
    End Sub

    Private Sub Iniciar_Click(sender As Object, e As RoutedEventArgs) Handles btnIniciar.Click
        MessageBox.Show("Iniciando...")
        Iniciar()
    End Sub

    Private Sub Iniciar()
        'Dim mensaje = "Contienen "
        For Each c In panel3.Children
            c.isEnabled = True
            c.Content = sBlanco
            c.Foreground = BackInicial
            c.Background = BackInicial
            'mensaje = mensaje & c.Name & ";" & c.Content & vbTab
        Next
        'MessageBox.Show(mensaje)
    End Sub

    Private Sub AccionTerminar(sender As Object, e As RoutedEventArgs) Handles btnTerminar.Click
        MessageBox.Show("Hasta otra...")
        Me.Close()
    End Sub

    Private Sub MuestraTurno()
        txTurnoAzul.Visibility = Turno
        txTurnoRojo.Visibility = Not Turno
    End Sub

    Private Sub AcumulaPuntos()
        If Turno Then
            txPuntAzul.Content = CStr(Val(txPuntAzul.Content) + 1)
        Else
            txPuntRojo.Content = CStr(Val(txPuntRojo.Content) + 1)
        End If
    End Sub

    Private Sub AccionJugar(sender As Object, e As RoutedEventArgs) _
            Handles A1.Click, A2.Click, A3.Click,
                    B1.Click, B2.Click, B3.Click,
                    C1.Click, C2.Click, C3.Click
        Dim b As Button = TryCast(sender, Button)
        If b.Content = sBlanco Then
            If Turno Then
                b.Content = X
                b.Foreground = BackAzul
                b.BorderBrush = BackInicial
                b.Background = BackAzul
            Else
                b.Content = O
                b.Foreground = BackRojo
                b.BorderBrush = BackInicial
                b.Background = BackRojo
            End If

            b.IsEnabled = False
            Cuenta = Cuenta + 1
            ' acumula puntos 
            AcumulaPuntos()
            'CambiaTurno
            Turno = Not Turno
            MuestraTurno()
            '
            ComprobarGanador(b.Name)
        Else
            MessageBox.Show("Ya pulsado " & b.Name)
        End If
    End Sub



    Private Sub ComprobarGanador(pulsado As String)
        MessageBox.Show("Ahora pulsado " & pulsado)
        ' No es optimo recorrer 9 elementos cuando solo hay que comprobar 3

        'MessageBox.Show("Aqui se comprueba si hay 3 en raya")
        Dim donde_hay_raya As String = ""
        If CompruebaFila("A", donde_hay_raya) Or
            CompruebaFila("B", donde_hay_raya) Or
            CompruebaFila("C", donde_hay_raya) Then
            MessageBox.Show("Ganador fila: " & donde_hay_raya)
        End If
        If CompruebaColumna("1", donde_hay_raya) Or
            CompruebaColumna("2", donde_hay_raya) Or
            CompruebaColumna("3", donde_hay_raya) Then
            MessageBox.Show("Ganador columna: " & donde_hay_raya)
        End If
        If CompruebaDiagonal("d1", donde_hay_raya) Or
            CompruebaDiagonal("d2", donde_hay_raya) Then
            MessageBox.Show("Ganador Diagonal: " & donde_hay_raya)
        End If

    End Sub

    Private Function CompruebaFila(fila As String, ByRef s As String) As Boolean
        Dim raya3 As Boolean = False
        Select Case fila
            Case "A" : If Not (A1.IsEnabled And A2.IsEnabled And A3.IsEnabled) Then
                    If A1.Content.Equals(A2.Content) _
                        And A2.Content.Equals(A3.Content) Then
                        raya3 = True
                        s = "A1 A2 A3"
                    End If
                End If

            Case "B" : If Not (B1.IsEnabled And B2.IsEnabled And B3.IsEnabled) Then
                    If B1.Content.Equals(B2.Content) _
                        And B2.Content.Equals(B3.Content) Then
                        raya3 = True
                        s = "B1 B2 B3"
                    End If
                End If

            Case "C" : If Not (C1.IsEnabled And C2.IsEnabled And C3.IsEnabled) Then
                    If C1.Content.Equals(C2.Content) _
                        And C2.Content.Equals(C3.Content) Then
                        raya3 = True
                        s = "C1 C2 C3"
                    End If
                End If

        End Select

        Return raya3
    End Function

    Private Function CompruebaColumna(columna As String, ByRef s As String) As Boolean
        Dim raya3 As Boolean = False
        Select Case columna
            Case "1"
                If Not (A1.IsEnabled And B1.IsEnabled And C1.IsEnabled) Then
                    If A1.Content.Equals(B1.Content) _
                        And B1.Content.Equals(C1.Content) Then
                        raya3 = True
                        s = "A1 B1 C1"
                    End If
                End If

            Case "2"
                If Not (A2.IsEnabled And B2.IsEnabled And C2.IsEnabled) Then
                    If A2.Content.Equals(B2.Content) _
                            And B2.Content.Equals(C2.Content) Then
                        raya3 = True
                        s = "A2 B2 C2"
                    End If
                End If

            Case "3"
                If Not (A3.IsEnabled And B3.IsEnabled And C3.IsEnabled) Then
                    If A3.Content.Equals(B3.Content) _
                        And B3.Content.Equals(C3.Content) Then
                        raya3 = True
                        s = "A3 B3 C3"
                    End If
                End If

        End Select
        Return raya3
    End Function

    Private Function CompruebaDiagonal(diag As String, ByRef s As String) As Boolean
        Dim raya3 As Boolean = False
        Select Case diag
            Case "d1"
                If Not (A1.IsEnabled And B2.IsEnabled And C3.IsEnabled) Then
                    If A1.Content.Equals(B2.Content) _
                        And B2.Content.Equals(C3.Content) Then
                        raya3 = True
                        s = "A1 B2 C3"
                    End If
                End If

            Case "d2"
                If Not (A3.IsEnabled And B2.IsEnabled And C1.IsEnabled) Then
                    If A3.Content.Equals(B2.Content) _
                        And B2.Content.Equals(C1.Content) Then
                        raya3 = True
                        s = "A3 B2 C1"
                    End If
                End If

        End Select
        Return raya3
    End Function



End Class
