Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, resultado As Double

        ' Verifica que los TextBox no estén vacíos
        If String.IsNullOrWhiteSpace(txtNum1.Text) OrElse String.IsNullOrWhiteSpace(txtNum2.Text) Then
            MessageBox.Show("Por favor, ingresa valores en ambos campos.")
            Return
        End If

        ' Verifica que los números sean válidos
        If Not Double.TryParse(txtNum1.Text, num1) OrElse Not Double.TryParse(txtNum2.Text, num2) Then
            MessageBox.Show("Por favor, ingresa números válidos.")
            Return
        End If

        ' Verifica que se haya seleccionado una operación
        If cmbOperacion.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, selecciona una operación.")
            Return
        End If

        ' Realiza la operación seleccionada
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
                    Return
                End If
            Case Else
                MessageBox.Show("Selecciona una operación válida.")
                Return
        End Select

        ' Muestra el resultado con dos decimales
        lblResultado.Text = "Resultado: " & resultado.ToString("F2")
    End Sub
End Class
