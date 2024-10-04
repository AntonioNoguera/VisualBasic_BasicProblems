Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Inicializa las variables
        Dim total As Double = 0
        Dim cantidadNotas As Integer = 0

        ' Lista de los TextBox que contienen las calificaciones
        Dim notas() As TextBox = {txtNota1, txtNota2, txtNota3, txtNota4}

        ' Ciclo For para sumar las notas
        For Each nota As TextBox In notas
            Dim valorNota As Double

            ' Verifica si el campo no está vacío
            If String.IsNullOrWhiteSpace(nota.Text) Then
                MessageBox.Show("Uno de los campos de nota está vacío. Ingresa una nota.")
                Return
            End If

            ' Verifica si la nota es un número válido
            If Not Double.TryParse(nota.Text, valorNota) Then
                MessageBox.Show("Por favor, ingresa una nota válida en cada campo.")
                Return
            End If

            ' Verifica si la nota está en el rango válido (0-100)
            If valorNota < 0 Or valorNota > 100 Then
                MessageBox.Show("Las notas deben estar entre 0 y 100.")
                Return
            End If

            total += valorNota
            cantidadNotas += 1
        Next

        ' Verifica si hay notas válidas para calcular el promedio
        If cantidadNotas > 0 Then
            Dim promedio As Double = total / cantidadNotas
            lblPromedio.Text = "Promedio: " & promedio.ToString("F2")
        Else
            MessageBox.Show("Por favor, ingresa notas válidas.")
        End If
    End Sub

End Class
