Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, resultado As Double

        ' Verifica que los números sean válidos
        If Double.TryParse(txtNum1.Text, num1) AndAlso Double.TryParse(txtNum2.Text, num2) Then
            Select Case cmbOperacion.SelectedItem.ToString()
                Case "Suma"
                    resultado = num1 + num2
                Case "Resta"
                    resultado = num1 - num2
                Case "Multiplicación"
                    resultado = num1 * num2
                Case "División"
                    If num2 <> 0 Then
                        resultado = num1 / num2
                    Else
                        MessageBox.Show("No se puede dividir entre cero.")
                        Exit Sub
                    End If
                Case Else
                    MessageBox.Show("Selecciona una operación válida.")
                    Exit Sub
            End Select

            lblResultado.Text = resultado.ToString("F2")
        Else
            MessageBox.Show("Por favor, ingresa números válidos.")
        End If
    End Sub

End Class
