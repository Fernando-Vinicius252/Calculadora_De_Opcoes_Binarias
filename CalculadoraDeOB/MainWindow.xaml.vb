Class MainWindow

    Public Payout As Double
    Public Entrada, LouPpresumido As Double

    Private Sub ButtonCalc_Click(sender As Object, e As RoutedEventArgs) Handles ButtonCalc.Click
        Payout = TextBoxPayout.Text
        Entrada = TextBoxEntrada.Text

        LouPpresumido = Entrada * (Payout / 100)

        TextBox_L_ou_P_presumido.Text = "R$ " + LouPpresumido.ToString("#,###.00")



    End Sub

    Private Sub ButtonEntrsomaLucro_Click(sender As Object, e As RoutedEventArgs) Handles ButtonEntrsomaLucro.Click
        Dim soma As Double

        soma = Entrada + LouPpresumido

        TextBoxEntrada.Text = "R$ " + soma.ToString("#,###.00")

        LouPpresumido = soma * (Payout / 100)

        TextBox_L_ou_P_presumido.Text = "R$ " + LouPpresumido.ToString("#,###.00")

        LouPpresumido = TextBox_L_ou_P_presumido.Text

    End Sub

    Private Sub TextBoxPayout_TextChanged(sender As Object, e As TextChangedEventArgs) Handles TextBoxPayout.TextChanged
        If TextBoxPayout.IsKeyboardFocused Then
            TextBoxPayout.Foreground = Brushes.Black
        End If


    End Sub

    Private Sub TextBoxEntrada_TextChanged(sender As Object, e As TextChangedEventArgs) Handles TextBoxEntrada.TextChanged
        If TextBoxEntrada.IsKeyboardFocused Then
            TextBoxEntrada.Foreground = Brushes.Black

        End If


    End Sub

    Private Sub TextBox_L_ou_P_presumido_TextChanged(sender As Object, e As TextChangedEventArgs) Handles TextBox_L_ou_P_presumido.TextChanged

    End Sub

    Private Sub Window_LocationChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2X_Click(sender As Object, e As RoutedEventArgs) Handles Button2X.Click
        Entrada = Entrada * 2
        TextBoxEntrada.Text = "R$ " + Entrada.ToString("#,###.00")

        LouPpresumido = Entrada * (Payout / 100)

        TextBox_L_ou_P_presumido.Text = "R$ " + LouPpresumido.ToString("#,###.00")

        LouPpresumido = TextBox_L_ou_P_presumido.Text

    End Sub
End Class
