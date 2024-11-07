Public Class Form1
    ' TextBox para cada número
    Private TextBoxNum1 As New TextBox()
    Private TextBoxNum2 As New TextBox()
    Private TextBoxNum3 As New TextBox() ' Solo para multiplicación
    Private ComboBoxMenu As New ComboBox()
    Private ButtonCalcular As New Button()
    Private LabelResultado As New Label()
    Private LabelTitulo As New Label()

    Public Sub New()
        ' Inicialización del formulario
        Me.Text = "Calculadora Básica"
        Me.Size = New Drawing.Size(300, 300)

        ' Configuración del Label de título
        LabelTitulo.Text = "Seleccione una operación"
        LabelTitulo.Location = New Drawing.Point(50, 10)
        LabelTitulo.AutoSize = True

        ' Configuración del ComboBox
        ComboBoxMenu.Items.AddRange(New String() {"Seleccione una opción", "Suma", "Resta", "Multiplicación", "División"})
        ComboBoxMenu.Location = New Drawing.Point(50, 40)
        ComboBoxMenu.DropDownStyle = ComboBoxStyle.DropDownList
        AddHandler ComboBoxMenu.SelectedIndexChanged, AddressOf ComboBoxMenu_SelectedIndexChanged

        ' Configuración de los TextBoxes
        TextBoxNum1.Location = New Drawing.Point(50, 80)
        TextBoxNum2.Location = New Drawing.Point(50, 120)
        TextBoxNum3.Location = New Drawing.Point(50, 160) ' Solo se muestra para multiplicación

        ' Configuración del botón
        ButtonCalcular.Text = "Calcular"
        ButtonCalcular.Location = New Drawing.Point(50, 200)
        AddHandler ButtonCalcular.Click, AddressOf ButtonCalcular_Click

        ' Configuración del label para mostrar el resultado
        LabelResultado.Location = New Drawing.Point(50, 240)
        LabelResultado.AutoSize = True

        ' Agregar controles al formulario
        Me.Controls.Add(LabelTitulo)
        Me.Controls.Add(ComboBoxMenu)
        Me.Controls.Add(TextBoxNum1)
        Me.Controls.Add(TextBoxNum2)
        Me.Controls.Add(TextBoxNum3)
        Me.Controls.Add(ButtonCalcular)
        Me.Controls.Add(LabelResultado)
        TextBoxNum3.Visible = False ' Ocultar TextBox de multiplicación inicialmente
    End Sub

    Private Sub ComboBoxMenu_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' Cambiar el título según la opción seleccionada
        Select Case ComboBoxMenu.SelectedIndex
            Case 1 ' Suma
                LabelTitulo.Text = "Calcule la Suma de 2 Números"
                TextBoxNum3.Visible = False
            Case 2 ' Resta
                LabelTitulo.Text = "Calcule la Resta de 2 Números"
                TextBoxNum3.Visible = False
            Case 3 ' Multiplicación
                LabelTitulo.Text = "Calcule la Multiplicación de 3 Números"
                TextBoxNum3.Visible = True
            Case 4 ' División
                LabelTitulo.Text = "Calcule la División de 2 Números"
                TextBoxNum3.Visible = False
            Case Else
                LabelTitulo.Text = "Seleccione una operación"
                TextBoxNum3.Visible = False
        End Select
    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs)
        Dim num1 As Double, num2 As Double, num3 As Double
        Dim resultado As Double = 0

        If Double.TryParse(TextBoxNum1.Text, num1) AndAlso Double.TryParse(TextBoxNum2.Text, num2) Then
            Select Case ComboBoxMenu.SelectedIndex
                Case 1 ' Suma
                    resultado = num1 + num2
                    LabelResultado.Text = "Resultado (Suma): " & resultado.ToString()
                Case 2 ' Resta
                    resultado = num1 - num2
                    LabelResultado.Text = "Resultado (Resta): " & resultado.ToString()
                Case 3 ' Multiplicación
                    If Double.TryParse(TextBoxNum3.Text, num3) Then
                        resultado = num1 * num2 * num3
                        LabelResultado.Text = "Resultado (Multiplicación): " & resultado.ToString()
                    Else
                        LabelResultado.Text = "Ingrese un número válido para el tercer valor."
                    End If
                Case 4 ' División
                    If num2 <> 0 Then
                        resultado = num1 / num2
                        LabelResultado.Text = "Resultado (División): " & resultado.ToString()
                    Else
                        LabelResultado.Text = "No se puede dividir entre cero."
                    End If
                Case Else
                    LabelResultado.Text = "Seleccione una operación válida."
            End Select
        Else
            LabelResultado.Text = "Ingrese valores numéricos válidos en los primeros campos."
        End If
    End Sub
End Class
