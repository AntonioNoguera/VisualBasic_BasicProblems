Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer
        Dim resultado As Integer

        ' Verifica si se ingresó un número
        If Integer.TryParse(txtNumero.Text, numero) Then
            ' Limpia el ListBox antes de generar una nueva tabla
            lstResultados.Items.Clear()

            ' Ciclo For para generar la tabla del número ingresado
            For i As Integer = 1 To 10
                resultado = numero * i
                lstResultados.Items.Add(numero & " x " & i & " = " & resultado)
            Next
        Else
            MessageBox.Show("Por favor, ingresa un número válido.")
        End If
    End Sub

End Class
