Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim edad As Integer

        ' Verifica si la edad ingresada es válida
        If Integer.TryParse(txtEdad.Text, edad) Then
            If edad >= 18 Then
                lblResultado.Text = "Eres mayor de edad."
            Else
                lblResultado.Text = "Eres menor de edad."
            End If
        Else
            MessageBox.Show("Por favor, ingresa una edad válida.")
        End If
    End Sub
End Class
