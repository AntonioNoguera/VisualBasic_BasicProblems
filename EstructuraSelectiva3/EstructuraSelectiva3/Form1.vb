Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim edad As Integer

        ' Verifica que el campo de texto no esté vacío
        If String.IsNullOrWhiteSpace(txtEdad.Text) Then
            MessageBox.Show("Por favor, ingresa tu edad.")
            Return
        End If

        ' Verifica si la edad ingresada es un número válido
        If Not Integer.TryParse(txtEdad.Text, edad) Then
            MessageBox.Show("Por favor, ingresa una edad válida.")
            Return
        End If

        ' Verifica si la edad está dentro de un rango razonable
        If edad < 0 Or edad > 120 Then
            MessageBox.Show("Por favor, ingresa una edad entre 0 y 120.")
            Return
        End If

        ' Verifica si es mayor o menor de edad
        If edad >= 18 Then
            lblResultado.Text = "Eres mayor de edad."
        Else
            lblResultado.Text = "Eres menor de edad."
        End If
    End Sub
End Class
