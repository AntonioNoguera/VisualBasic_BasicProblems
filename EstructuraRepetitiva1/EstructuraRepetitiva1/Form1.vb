Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer
        Dim resultado As Integer

        ' Verifica si el campo está vacío
        If String.IsNullOrWhiteSpace(txtNumero.Text) Then
            MessageBox.Show("El campo no puede estar vacío. Por favor, ingresa un número.")
            Return
        End If

        ' Verifica si se ingresó un número válido
        If Not Integer.TryParse(txtNumero.Text, numero) Then
            MessageBox.Show("Por favor, ingresa un número válido.")
            Return
        End If

        ' Verifica si el número es positivo
        If numero <= 0 Then
            MessageBox.Show("Por favor, ingresa un número mayor a cero.")
            Return
        End If

        ' Limpia el ListBox antes de generar una nueva tabla
        lstResultados.Items.Clear()

        ' Ciclo For para generar la tabla del número ingresado
        For i As Integer = 1 To 10
            resultado = numero * i
            lstResultados.Items.Add(numero & " x " & i & " = " & resultado)
        Next
    End Sub
End Class
