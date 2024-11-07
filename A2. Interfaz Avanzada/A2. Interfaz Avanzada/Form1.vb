Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicialización del ComboBox con las opciones de operación
        ComboBoxMenu.Items.AddRange(New String() {"Seleccione una opción", "Suma", "Resta", "Multiplicación", "División"})
        ComboBoxMenu.SelectedIndex = 0 ' Seleccionar la opción inicial
        TextBoxNum3.Visible = False ' Ocultar el tercer TextBox inicialmente
    End Sub

    Private Sub ComboBoxMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMenu.SelectedIndexChanged
        ' Cambiar el título según la opción seleccionada y gestionar la visibilidad de TextBoxNum3
        LabelOperation2.Visible = False
        TextBoxNum3.Visible = False

        Select Case ComboBoxMenu.SelectedIndex
            Case 1 ' Suma
                LabelTitulo.Text = "Calcule la Suma de 2 Números"
                LabelOperation1.Text = "+"


            Case 2 ' Resta
                LabelTitulo.Text = "Calcule la Resta de 2 Números"
                LabelOperation1.Text = "-"


            Case 3 ' Multiplicación
                LabelTitulo.Text = "La Multiplicación de 3 Números"

                LabelOperation1.Text = "×"

                LabelOperation2.Visible = True
                TextBoxNum3.Visible = True

            Case 4 ' División
                LabelTitulo.Text = "Calcule la División de 2 Números"

                LabelOperation1.Text = "÷"

            Case Else
                LabelTitulo.Text = "Seleccione una operación"
        End Select
    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        Dim num1 As Double, num2 As Double, num3 As Double
        Dim resultado As Double = 0

        ' Validar que los primeros dos campos contengan números
        If Not Double.TryParse(TextBoxNum1.Text, num1) Then
            LabelResultado.Text = "Error: Ingrese un número válido en el primer campo."
            Exit Sub
        End If

        If Not Double.TryParse(TextBoxNum2.Text, num2) Then
            LabelResultado.Text = "Error: Ingrese un número válido en el segundo campo."
            Exit Sub
        End If

        ' Ejecutar la operación seleccionada
        Select Case ComboBoxMenu.SelectedIndex
            Case 1 ' Suma
                resultado = num1 + num2
                LabelResultado.Text = "Resultado: " & resultado.ToString("F4")

            Case 2 ' Resta
                resultado = num1 - num2
                LabelResultado.Text = "Resultado: " & resultado.ToString("F4")

            Case 3 ' Multiplicación
                ' Validar el tercer número solo si es multiplicación
                If Double.TryParse(TextBoxNum3.Text, num3) Then
                    resultado = num1 * num2 * num3
                    LabelResultado.Text = "Resultado: " & resultado.ToString("F4")
                Else
                    LabelResultado.Text = "Error: Ingrese un número válido en el tercer campo."
                End If

            Case 4 ' División
                ' Manejar el caso de división por cero
                If num2 = 0 Then
                    LabelResultado.Text = "Error: No se puede dividir entre cero."
                Else
                    resultado = num1 / num2
                    LabelResultado.Text = "Resultado: " & resultado.ToString("F4")
                End If

            Case Else
                LabelResultado.Text = "Seleccione una operación válida."
        End Select
    End Sub
End Class
