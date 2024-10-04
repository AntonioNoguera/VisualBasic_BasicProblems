Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nota As Integer

        ' Verifica si la nota ingresada es válida
        If Integer.TryParse(txtNota.Text, nota) Then
            Select Case nota
                Case >= 90
                    lblResultado.Text = "Calificación: A"
                Case >= 80
                    lblResultado.Text = "Calificación: B"
                Case >= 70
                    lblResultado.Text = "Calificación: C"
                Case >= 60
                    lblResultado.Text = "Calificación: D"
                Case Else
                    lblResultado.Text = "Calificación: F"
            End Select
        Else
            MessageBox.Show("Por favor, ingresa una nota válida.")
        End If
    End Sub
End Class
